
namespace Ticketing_System
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            //
            ApplicationConfiguration.Initialize();

            // create a new form for Ticketing system
            Ticketing_System TS = new Ticketing_System();

            // initialise TicketStats
            TicketStats.Init(TS);
            TS.ShowDialog();
        }
}
}