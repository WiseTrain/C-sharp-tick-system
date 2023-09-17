using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace Ticketing_System
{ 
    // Ticketing_System is a visual representation of the TicketStats class
    // it displays statistics and the list of tickets
    // editTicket() function can be called by clicking on the grid
    public partial class Ticketing_System : Form
    {
        // current row number selected in the grid
        public int gridIndex;

        // varibles for UDP communication
        UdpClient server;
        IPEndPoint endPoint;
        Thread thr;

        public Ticketing_System()
        // constructor
        {
            InitializeComponent();

            // start the UDP server in new thread
            int serverPort = 5678;

            //
            server = new UdpClient(serverPort);
            endPoint = new IPEndPoint(IPAddress.Any, 0);

            //thr = new Thread(new ThreadStart(serverStart));
            thr = new System.Threading.Thread(serverStart);
            thr.Start();
        }

        
        private void serverStart()
        // start the UDP server 
        // endless loop is checking the port and receiving the message
        {
            while (true)
            {
                // Receive
                byte[] buffer = server.Receive(ref endPoint);

                // extract data from the message
                string[] msg = Encoding.Unicode.GetString(buffer).Split('|');

                // add new ticket into the system
                this.Invoke(new MethodInvoker(delegate
                {
                    // Console.Beep();
                    TicketStats.addNewTicket(msg[0], msg[1], msg[2], msg[3]);
                }
                ));
            }

        }

        public void displayStatistics()
        // display statistics in corresponiding label elements
        {
            lSubmitted.Text = TicketStats.GetSubmitted().ToString();
            lOpen.Text = TicketStats.GetOpen().ToString();
            lClosed.Text = TicketStats.GetClosed().ToString();

            // total number of tickets
            int total = TicketStats.GetSubmitted()
                        + TicketStats.GetOpen()
                        + TicketStats.GetClosed();
            lTotal.Text = total.ToString();
        }

        private void dgTicketsStats_CellClick(object sender, DataGridViewCellEventArgs e)
        // when user click on any Ticket in the grid
        // the selected ticket must be displayed in the TicketForm
        // (for beeing edited)
        {
            int _ticketID = -1;
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgTicketsStats.Rows[e.RowIndex];
                _ticketID = int.Parse(row.Cells["TicketID"].Value.ToString());

                // find the ticket object with id=_ticketID in the list
                Ticket t = TicketStats.findTicket(_ticketID);
                gridIndex = e.RowIndex;
                // call form to dispaly the ticket
                TicketForm TF = new TicketForm(t,"edit");
                TF.ShowDialog(this);
            }
            
        }
        public void DisplayTicketRaw(Ticket _t)
        // display the existing ticket _t in a Data Grid
        // rowNumber = _t.gridRowNumber
        {
            switch (_t.Status)
            {
                case (TicketStats.SUBMITTED_TICKET_STATUS):
                    dgTicketsStats.Rows[_t.gridRowNumber].Cells[0].Value = Properties.Resources.RedCircle; break;
                case (TicketStats.OPEN_TICKET_STATUS):
                    dgTicketsStats.Rows[_t.gridRowNumber].Cells[0].Value = Properties.Resources.YelloCircle; break;
                case (TicketStats.CLOSED_TICKET_STATUS):
                    dgTicketsStats.Rows[_t.gridRowNumber].Cells[0].Value = Properties.Resources.GreenCircle; break;
            }

            dgTicketsStats.Rows[_t.gridRowNumber].Cells[1].Value = _t.TicketID;
            dgTicketsStats.Rows[_t.gridRowNumber].Cells[2].Value = _t.TimeStamp;
            dgTicketsStats.Rows[_t.gridRowNumber].Cells[3].Value = _t.StaffID;
            dgTicketsStats.Rows[_t.gridRowNumber].Cells[4].Value = _t.StaffName;
            dgTicketsStats.Rows[_t.gridRowNumber].Cells[5].Value = _t.StaffContactEmail;
            dgTicketsStats.Rows[_t.gridRowNumber].Cells[6].Value = _t.DescriptionOfIssue;
            dgTicketsStats.Rows[_t.gridRowNumber].Cells[7].Value = _t.Response;
            // set index to current row
            dgTicketsStats.CurrentCell = dgTicketsStats.Rows[_t.gridRowNumber].Cells[1];
        }
        //                  
        public void DisplayTicketRaw(Ticket _t, string _mode)
        // displays the new ticket _t, in a DataGrid
        // creates a new row in the grid first
        // then dispalys the ticket
        {
            if (_mode == "new")
            {
                _t.gridRowNumber = dgTicketsStats.Rows.Add();
                DisplayTicketRaw(_t);
            }
        }

        private void Ticketing_System_FormClosing(object sender, FormClosingEventArgs e)
        // trying to close the UDP thread
        {
            //if (thr.IsAlive) thr.Abort();
        }

    }
}
