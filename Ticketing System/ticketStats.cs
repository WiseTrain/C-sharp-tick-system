using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

//using Ticketing_System;

namespace Ticketing_System
{
    public static class TicketStats
    // this class is "database" and "server"
    // it contains the list of tickets and statistic variables
    // as well as public constants
    {
        public const short SUBMITTED_TICKET_STATUS = 0;
        public const short OPEN_TICKET_STATUS = 1;
        public const short CLOSED_TICKET_STATUS = 2;

        // the list of all possible values the ticket status can be assigned with
        public static Dictionary<int, string> statusList = new Dictionary<int, string> {
            { SUBMITTED_TICKET_STATUS, "Not Respond Yet"},
            { OPEN_TICKET_STATUS, "Open"},
            { CLOSED_TICKET_STATUS, "Closed"}
        };
        //
        public const short DEFAULT_TICKET_TYPE = 0;
        public const short PASSWORD_CHANGE_TICKET_TYPE = 1;
        // the list containing all tickets = "database"
        public static List<Ticket> ListOfTickets = new List<Ticket>();
       
        // ticketIDs starts from 2000
        private static int lastTicketID = 2000;

        // variables for statistics:
        private static int numOfSubmitted = 0;
        private static int numOfOpen = 0;
        private static int numOfClosed = 0;

        // the link to the grid where the list displayed
        public static Ticketing_System TLDisplayForm;
        // 
        public static void Init(Ticketing_System _ts)
        {
            // form where the list will be displayed
            TLDisplayForm = _ts;

            // add some records into ListOfTickets
            // and calculates statistics according to the Ticket.status
            // "populating" my system
            //addNewTicket("MarieK", "Maria Khari", "marie@whitecliffe.com", "need to change my password.");
            //addNewTicket("AnnO", "Ann O'khari", "anno@whitecliffe.com", "Printer doesn't work.");
            //addNewTicket("AnnO", "Not Assigned", "Not Assigned", "Password Change");

            // Define the ticketID of the last ticket
            foreach (Ticket t in ListOfTickets)
            {
                if (t.TicketID > lastTicketID) lastTicketID = t.TicketID;
            }
        }
        
        public static int GetSubmitted()
        // public property
        // returnes the Number of Submitted Tickets
        {
            return numOfSubmitted;
        }
        public static int GetOpen()
        // public property
        // returnes the Number of Open Tickets
        {
            return numOfOpen;
        }

        public static int GetClosed()
        // public property
        // returnes the Number of Closed Tickets
        {
            return numOfClosed;
        }
        private static int getTicketID()
        // returnes the smallest available ticketID
        // function is used when a new ticket is created
        {
            lastTicketID += 1;
            return lastTicketID;
        }
        public static void addNewTicket(string _staffID, string _staffName, string _staffContactEmail, string _DescriptionOfIssue)
        // this method creates a new ticket
        // and add it into the List
        {
            // call constructor ticket
            Ticket t = new Ticket(
                getTicketID(),
                _staffID,
                _staffName,
                _staffContactEmail,
                _DescriptionOfIssue);

            // recalculation of statistics
            statRecalculation(-1, SUBMITTED_TICKET_STATUS);
            TLDisplayForm.displayStatistics();

            // add new ticket object into list
            ListOfTickets.Add(t);

            // display ticket in the grid
            TLDisplayForm.DisplayTicketRaw(t, "new");
        }

        public static Ticket findTicket(int _ticketID)
        // search the ticket by TicketID
        // returnes the link to the Ticket oblect
        { 
            foreach (Ticket t in ListOfTickets)
            { 
                if (t.TicketID == _ticketID)
                    return t;
            }
            return null;
        }

        public static void statRecalculation(int _oldStatus, int _newStatus)
        // recalculates the statistics when the status
        // of the ticket has been changed
        { 
            if (_oldStatus == _newStatus) return;
            if (_oldStatus == SUBMITTED_TICKET_STATUS) numOfSubmitted--;
            if (_oldStatus == OPEN_TICKET_STATUS) numOfOpen--;
            if (_oldStatus == CLOSED_TICKET_STATUS) numOfClosed--;
            //
            if (_newStatus == SUBMITTED_TICKET_STATUS) numOfSubmitted++;
            if (_newStatus == OPEN_TICKET_STATUS) numOfOpen++;
            if (_newStatus == CLOSED_TICKET_STATUS) numOfClosed++;
            //
        }

    }
}
