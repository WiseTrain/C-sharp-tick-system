using Ticketing_System;

namespace Help_Desk_Client
{
    internal static class Program
    {
        /// <summary>
        ///  this is my "client" application
        ///  it only starts the TicketForm with empty values for user input
        ///  and pass them to the ticketing System
        /// </summary>
        [STAThread]
         
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // calling the TicketForm from Ticketing_System project
            // to input the new ticket
            Ticketing_System.TicketForm TF = new Ticketing_System.TicketForm(null, "remote new");
            TF.ShowDialog();
        }
    }
}