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

namespace Ticketing_System
{
    public partial class TicketForm : Form
    // TicketForm is used to display the Ticket Class object
    // it contains textBoxed for all attributes of the Ticket Class
    {
        Ticket T; // the ticket object which is beeing displayed in the form. 
        private string mode; // = "new", "remote new" or "edit"

        public TicketForm()
        {
            InitializeComponent();

            // filling in the comboBox with Status values
            cbStatus.Items.Add(TicketStats.statusList[0]);
            cbStatus.Items.Add(TicketStats.statusList[1]);
            cbStatus.Items.Add(TicketStats.statusList[2]);
            cbStatus.SelectedIndex = 0;
            //     
        }
        public TicketForm(Ticket _t, string _mode = "edit"):
          this()
        {
            mode = _mode; // "edit", "remote new" or "new"
            //
            // set elements 
            if (_mode == "edit")
            {
                // the administrator or IT
                // can't edit any field but status and Response
                cbStatus.Enabled = true;
                Response.Enabled = true;
                bGeneratePassword.Visible = true;
                //
                StaffID.Enabled = false;
                StaffName.Enabled = false;
                StaffContactEmail.Enabled = false;
                DescriptionOfIssue.Enabled = false;
            }
            else if (_mode == "new" || _mode == "remote new")
            // the user can only enter StaffID, StaffName,
            // StaffContatEmail and Description of Issue
            {
                // the administrator can't edit any field but status and Response
                cbStatus.Enabled = false;
                Response.Enabled = false;
                bGeneratePassword.Visible = false;
                //
                StaffID.Enabled = true;
                StaffName.Enabled = true;
                StaffContactEmail.Enabled = true;
                DescriptionOfIssue.Enabled = true;
            }

            // new ticket -> empty firlds
            if (_t == null || _mode == "new" || _mode == "remote new")
            {
                emptyTicket();     
            }
            else // "edit" mode
            {
                T = _t;
                //
                generateTitle();
                cbStatus.SelectedIndex = T.Status;
                StaffID.Text = T.StaffID;
                StaffName.Text = T.StaffName;
                StaffContactEmail.Text = T.StaffContactEmail;
                DescriptionOfIssue.Text = T.DescriptionOfIssue;
                Response.Text = T.Response;

                // red for submitted tickets,
                // yellow for open tickets
                // green for closed ticket
                ColourTicketTitle(T.Status);
            }
        }

        private void generateTitle()
        // generates and display Ticket Title
        {
            if (mode == "edit")
            {
                string str = "Ticket # ";
                str += T.ticketID;
                str += "\n(" + T.timeStamp.ToString() + ")";
                lTicketTitle.Text = str;
            }
            else if (mode == "new" || mode == "remote new")
            {
                string str = "Ticket # *NEW_TICKET*";
                str += "\n(" + DateTime.Now + ")";
                lTicketTitle.Text = str;
            }
        }

        private void bGenerateResponse_Click(object sender, EventArgs e)
         // generate response button
        {
            if (T != null)
                Response.Text = T.generateResponse();
        }

        private void emptyTicket()
        // set all fields to empty (for new input ticket)
        {
            generateTitle();
            cbStatus.SelectedIndex = TicketStats.SUBMITTED_TICKET_STATUS;
            StaffID.Text = "";
            StaffName.Text = "";
            StaffContactEmail.Text = "";
            DescriptionOfIssue.Text = "";
            Response.Text = "";
        }

        private void bEmptyTicket_Click(object sender, EventArgs e)
        // "empty ticket" button click
        {
            mode = "new";
            emptyTicket();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        // "submit" button click
        {
            // check: staffID and descriptionOfIssue must not be empty
            if (StaffID.Text == "" || DescriptionOfIssue.Text == "")
            {
                MessageBox.Show("StaffID and Description Of Issue must not be empty.");
                return;
            }
            
            if (mode == "new") 
                TicketStats.addNewTicket(
                    StaffID.Text,
                    StaffName.Text,
                    StaffContactEmail.Text,
                    DescriptionOfIssue.Text);
            else if (mode == "edit")
            {
                T.EditTicket(cbStatus.SelectedIndex, Response.Text);
            }
            else if (mode == "remote new")
            {
                sendDataToServerUDP();
            }
            this.Close();    

        }
        private void sendDataToServerUDP()
        // sends data to the server via port# 5678
        {
            UdpClient client;
            //IPEndPoint endPoint;

            // Send message to server
            int serverPort = 5678;
            int clientPort = 1234;
            string hostName = "localhost";

            client = new UdpClient(clientPort);

            // assamble data into one string
            string msg = StaffID.Text + "|"
                + StaffName.Text + "|"
                + StaffContactEmail.Text + "|"
                + DescriptionOfIssue.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            // Send message
            client.Send(buffer, buffer.Length, hostName, serverPort);
            client.Close();
 
        }

        private void bCancel_Click(object sender, EventArgs e)
        // "Cancel" button click
        {
            this.Close();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        // when the status of the ticket is changed  -> the colour is changed 
        {
            ColourTicketTitle(cbStatus.SelectedIndex);
        }
        private void ColourTicketTitle(int _status)
        // sets the color of the TicketTitle pannel according to the Status
        {
            if (_status == TicketStats.SUBMITTED_TICKET_STATUS)
                pTicketTitle.BackColor = Color.Red;
            if (_status == TicketStats.OPEN_TICKET_STATUS)
                pTicketTitle.BackColor = Color.Gold;
            if (_status == TicketStats.CLOSED_TICKET_STATUS)
                pTicketTitle.BackColor = Color.Green;
        }

    }
}
