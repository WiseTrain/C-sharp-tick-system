using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_System
{
    public class PasswordGenerator
    // this class generating the password by certain rule.
    {
        // variables which are necessary for password generation
        // staffID, ticketNumber and timeStamp
        private string staffID = "";
        private int ticketNumber;
        private DateTime timeStamp;
        //
        public PasswordGenerator(string staffID, int ticketNumber, DateTime timeStamp)
        // constructor
        {
            this.staffID = staffID;
            this.ticketNumber = ticketNumber;   
            this.timeStamp = timeStamp;
        }
        public string generatePassword()
        // generates and returns the password
        {
            string str = "";

            // The first two characters of the staffID
            if (staffID.Length >= 2)
                str += staffID.Substring(0, 2);

            // followed by the hexadecimal representation of the ticket number
            str += ticketNumber.ToString("x");

            // followed by a hexadecimal representation of the
            // first three characters of the timestamp.
            string firstThreeCharacters = timeStamp.ToString();
            string c1 = "";
            string c2 = "";
            string c3 = "";

            // first char
            c1 = firstThreeCharacters.Substring(0, 1);
            str += int.Parse(c1).ToString("x2");

            // second char 
            // check for "/" symbol
            if (firstThreeCharacters.Substring(1, 1) == "/")
               c2 = firstThreeCharacters.Substring(2, 1);
            else
               c2 = firstThreeCharacters.Substring(1, 1);
       
            str += int.Parse(c2).ToString("x2");


            // third char
            // check for "/" symbol
            if (firstThreeCharacters.Substring(3, 1) == "/")
                c3 = firstThreeCharacters.Substring(4, 1);
            else
                c3 = firstThreeCharacters.Substring(3, 1);
            str += int.Parse(c3).ToString("x2");

            // this is old code. I want to keep it for reference 
            // FileTime representation of TimeStamp
            //char c3 = firstThreeCharacters[3];
            //str += Convert.ToByte(c3).ToString("x2");

            return str;
        }

    }
}
