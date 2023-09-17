using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ticketing_System
{
    public class Ticket
    // class for the help desk ticket
    {
        // private fields
        public int ticketID;
        public DateTime timeStamp;
        public int status;
        public string staffID;
        public string staffName;
        public string staffContactEmail;
        public string descriptionOfIssue;
        public string response;

        // the number of row in the grid where ticked displayed
        public int gridRowNumber;

        // public properties
        public int TicketID { get { return ticketID; } }
        public DateTime TimeStamp { get { return timeStamp; } }
        public int Status { get { return status; } }
        public string StaffID { get { return staffID; } }
        public string StaffName { get { return staffName; } }
        public string StaffContactEmail { get { return staffContactEmail; } }
        public string DescriptionOfIssue { get { return descriptionOfIssue; } }
        public string Response { get { return response; } }
       
        public Ticket(
            int _ticketID, 
            string _staffID, 
            string _staffName, 
            string _staffContactEmail, 
            string _DescriptionOfIssue)
        {
            // constructor
            this.ticketID = _ticketID;
            this.timeStamp = DateTime.Now;
            this.status = TicketStats.SUBMITTED_TICKET_STATUS;
            this.staffID = _staffID;

            //if the _staffName is empty it must be assigned to "Not Assigned"
            if (_staffName != "")
                this.staffName = _staffName;
            else
                this.staffName = "Not Assigned";

            //if the _staffContactEmail is empty it must be assigned to "Not Assigned"
            if (_staffContactEmail != "") 
                this.staffContactEmail = _staffContactEmail;
            else
                this.staffContactEmail = "Not Assigned";
            //

            this.descriptionOfIssue = _DescriptionOfIssue;
            this.response = "Not Yet Provided";
        }
        virtual public string generateResponse()
        // generates and returns default response string
        // and generates the password if the the Description of 
        // Issue contains words "change" and "password"
        {
            String strResponse = "";
            // class that generates the password
            PasswordGenerator pg = new PasswordGenerator(staffID, ticketID, timeStamp);

            // default value of the response
            strResponse += "Welcome to Help Desk! \r\n";
            //strResponse += "Thanks a lot for your request.\r\n";
            //strResponse += "Your ticket ID: " + this.TicketID.ToString() + "\r\n";
            //strResponse += "Date/time: " + this.TimeStamp.ToString() + "\r\n";
            //strResponse += "Our response: \r\n";
            //
            if (defineTicketType() == TicketStats.PASSWORD_CHANGE_TICKET_TYPE)
            {
                strResponse += "\r\nNew password generated:\r\n";
                strResponse += pg.generatePassword();
            }


            return strResponse;
        }
        public void EditTicket(int _status, string _response)
        // IT specialist edit: only fields responce and status
        {
            // if the ticket is edited and submitted 
            // statistics are recalculated and displayed
            TicketStats.statRecalculation(this.status, _status);
            TicketStats.TLDisplayForm.displayStatistics();
            // new values are assigned
            this.status = _status;
            this.response = _response;
            // the edited ticket is displayed in the grid
            TicketStats.TLDisplayForm.DisplayTicketRaw(this);
        }
        private short defineTicketType()
        // this method analises the "Description of issue" and
        // search for patterns "change" and "password"
        // returnes: the type of the ticket
        {
            // defines if this ticket is "password change" or default type
            string descriptionOfIssueLC = DescriptionOfIssue.ToLower();
            string patternSTR1 = "change";
            string patternSTR2 = "password";
            bool enterPattern1 = Regex.IsMatch(descriptionOfIssueLC, patternSTR1);
            bool enterPattern2 = Regex.IsMatch(descriptionOfIssueLC, patternSTR2);
            //
            if (enterPattern1 && enterPattern2)
                return TicketStats.PASSWORD_CHANGE_TICKET_TYPE;
            else
                return TicketStats.DEFAULT_TICKET_TYPE;
        }
    }
}
