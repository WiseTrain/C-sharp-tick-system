namespace Ticketing_System
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bGeneratePassword = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.lResponse = new System.Windows.Forms.Label();
            this.lDiscriptionOfIssue = new System.Windows.Forms.Label();
            this.lContactEmail = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lStaffID = new System.Windows.Forms.Label();
            this.bEmptyTicket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pSubmitTicket = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.pResponse = new System.Windows.Forms.Panel();
            this.Response = new System.Windows.Forms.TextBox();
            this.pTicketInfo = new System.Windows.Forms.Panel();
            this.DescriptionOfIssue = new System.Windows.Forms.TextBox();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.StaffContactEmail = new System.Windows.Forms.TextBox();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.pStatus = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.pTicketTitle = new System.Windows.Forms.Panel();
            this.lTicketTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pSubmitTicket.SuspendLayout();
            this.pResponse.SuspendLayout();
            this.pTicketInfo.SuspendLayout();
            this.pStatus.SuspendLayout();
            this.pTicketTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.bGeneratePassword);
            this.panel1.Controls.Add(this.lStatus);
            this.panel1.Controls.Add(this.lResponse);
            this.panel1.Controls.Add(this.lDiscriptionOfIssue);
            this.panel1.Controls.Add(this.lContactEmail);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.lStaffID);
            this.panel1.Controls.Add(this.bEmptyTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 737);
            this.panel1.TabIndex = 0;
            // 
            // bGeneratePassword
            // 
            this.bGeneratePassword.BackColor = System.Drawing.Color.White;
            this.bGeneratePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGeneratePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGeneratePassword.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bGeneratePassword.Location = new System.Drawing.Point(12, 462);
            this.bGeneratePassword.Name = "bGeneratePassword";
            this.bGeneratePassword.Size = new System.Drawing.Size(135, 90);
            this.bGeneratePassword.TabIndex = 12;
            this.bGeneratePassword.Text = "Generate password";
            this.bGeneratePassword.UseVisualStyleBackColor = false;
            this.bGeneratePassword.Click += new System.EventHandler(this.bGenerateResponse_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lStatus.Location = new System.Drawing.Point(91, 117);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(56, 19);
            this.lStatus.TabIndex = 7;
            this.lStatus.Text = "Status:";
            // 
            // lResponse
            // 
            this.lResponse.AutoSize = true;
            this.lResponse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lResponse.Location = new System.Drawing.Point(70, 428);
            this.lResponse.Name = "lResponse";
            this.lResponse.Size = new System.Drawing.Size(77, 19);
            this.lResponse.TabIndex = 6;
            this.lResponse.Text = "Response:";
            // 
            // lDiscriptionOfIssue
            // 
            this.lDiscriptionOfIssue.AutoSize = true;
            this.lDiscriptionOfIssue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDiscriptionOfIssue.Location = new System.Drawing.Point(6, 259);
            this.lDiscriptionOfIssue.Name = "lDiscriptionOfIssue";
            this.lDiscriptionOfIssue.Size = new System.Drawing.Size(141, 19);
            this.lDiscriptionOfIssue.TabIndex = 5;
            this.lDiscriptionOfIssue.Text = "Discription of issue:";
            // 
            // lContactEmail
            // 
            this.lContactEmail.AutoSize = true;
            this.lContactEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lContactEmail.Location = new System.Drawing.Point(40, 225);
            this.lContactEmail.Name = "lContactEmail";
            this.lContactEmail.Size = new System.Drawing.Size(107, 19);
            this.lContactEmail.TabIndex = 4;
            this.lContactEmail.Text = "Contact email:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(94, 191);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(53, 19);
            this.lName.TabIndex = 3;
            this.lName.Text = "Name:";
            // 
            // lStaffID
            // 
            this.lStaffID.AutoSize = true;
            this.lStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lStaffID.Location = new System.Drawing.Point(84, 157);
            this.lStaffID.Name = "lStaffID";
            this.lStaffID.Size = new System.Drawing.Size(63, 19);
            this.lStaffID.TabIndex = 2;
            this.lStaffID.Text = "Staff ID:";
            // 
            // bEmptyTicket
            // 
            this.bEmptyTicket.BackColor = System.Drawing.Color.White;
            this.bEmptyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEmptyTicket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEmptyTicket.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bEmptyTicket.Location = new System.Drawing.Point(12, 12);
            this.bEmptyTicket.Name = "bEmptyTicket";
            this.bEmptyTicket.Size = new System.Drawing.Size(135, 90);
            this.bEmptyTicket.TabIndex = 1;
            this.bEmptyTicket.Text = "New ticket";
            this.bEmptyTicket.UseVisualStyleBackColor = false;
            this.bEmptyTicket.Visible = false;
            this.bEmptyTicket.Click += new System.EventHandler(this.bEmptyTicket_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pSubmitTicket);
            this.panel2.Controls.Add(this.pResponse);
            this.panel2.Controls.Add(this.pTicketInfo);
            this.panel2.Controls.Add(this.pStatus);
            this.panel2.Controls.Add(this.pTicketTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 737);
            this.panel2.TabIndex = 1;
            // 
            // pSubmitTicket
            // 
            this.pSubmitTicket.Controls.Add(this.bCancel);
            this.pSubmitTicket.Controls.Add(this.bSubmit);
            this.pSubmitTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmitTicket.Location = new System.Drawing.Point(0, 589);
            this.pSubmitTicket.Name = "pSubmitTicket";
            this.pSubmitTicket.Size = new System.Drawing.Size(349, 144);
            this.pSubmitTicket.TabIndex = 13;
            // 
            // bCancel
            // 
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCancel.Image = global::Ticketing_System.Properties.Resources.Cancel___2;
            this.bCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bCancel.Location = new System.Drawing.Point(13, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(160, 135);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.Color.Transparent;
            this.bSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSubmit.Image = global::Ticketing_System.Properties.Resources.OK___2;
            this.bSubmit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bSubmit.Location = new System.Drawing.Point(179, 0);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bSubmit.Size = new System.Drawing.Size(160, 135);
            this.bSubmit.TabIndex = 2;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // pResponse
            // 
            this.pResponse.Controls.Add(this.Response);
            this.pResponse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pResponse.Location = new System.Drawing.Point(0, 426);
            this.pResponse.Name = "pResponse";
            this.pResponse.Size = new System.Drawing.Size(349, 163);
            this.pResponse.TabIndex = 12;
            // 
            // Response
            // 
            this.Response.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Response.Location = new System.Drawing.Point(13, 0);
            this.Response.Multiline = true;
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(326, 153);
            this.Response.TabIndex = 7;
            // 
            // pTicketInfo
            // 
            this.pTicketInfo.Controls.Add(this.DescriptionOfIssue);
            this.pTicketInfo.Controls.Add(this.StaffID);
            this.pTicketInfo.Controls.Add(this.StaffContactEmail);
            this.pTicketInfo.Controls.Add(this.StaffName);
            this.pTicketInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTicketInfo.Location = new System.Drawing.Point(0, 144);
            this.pTicketInfo.Name = "pTicketInfo";
            this.pTicketInfo.Size = new System.Drawing.Size(349, 282);
            this.pTicketInfo.TabIndex = 10;
            // 
            // DescriptionOfIssue
            // 
            this.DescriptionOfIssue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionOfIssue.Location = new System.Drawing.Point(13, 116);
            this.DescriptionOfIssue.Multiline = true;
            this.DescriptionOfIssue.Name = "DescriptionOfIssue";
            this.DescriptionOfIssue.PlaceholderText = "Please describe the issue...";
            this.DescriptionOfIssue.Size = new System.Drawing.Size(326, 153);
            this.DescriptionOfIssue.TabIndex = 6;
            // 
            // StaffID
            // 
            this.StaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffID.Location = new System.Drawing.Point(13, 3);
            this.StaffID.Name = "StaffID";
            this.StaffID.PlaceholderText = "Staff ID";
            this.StaffID.Size = new System.Drawing.Size(180, 27);
            this.StaffID.TabIndex = 1;
            // 
            // StaffContactEmail
            // 
            this.StaffContactEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffContactEmail.Location = new System.Drawing.Point(13, 79);
            this.StaffContactEmail.Name = "StaffContactEmail";
            this.StaffContactEmail.PlaceholderText = "Your contact email";
            this.StaffContactEmail.Size = new System.Drawing.Size(326, 27);
            this.StaffContactEmail.TabIndex = 5;
            // 
            // StaffName
            // 
            this.StaffName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffName.Location = new System.Drawing.Point(13, 42);
            this.StaffName.Name = "StaffName";
            this.StaffName.PlaceholderText = "Name";
            this.StaffName.Size = new System.Drawing.Size(326, 27);
            this.StaffName.TabIndex = 4;
            // 
            // pStatus
            // 
            this.pStatus.Controls.Add(this.cbStatus);
            this.pStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatus.Location = new System.Drawing.Point(0, 100);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(349, 44);
            this.pStatus.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(13, 10);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(326, 27);
            this.cbStatus.TabIndex = 8;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // pTicketTitle
            // 
            this.pTicketTitle.BackColor = System.Drawing.Color.Red;
            this.pTicketTitle.Controls.Add(this.lTicketTitle);
            this.pTicketTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTicketTitle.Location = new System.Drawing.Point(0, 0);
            this.pTicketTitle.Name = "pTicketTitle";
            this.pTicketTitle.Size = new System.Drawing.Size(349, 100);
            this.pTicketTitle.TabIndex = 3;
            // 
            // lTicketTitle
            // 
            this.lTicketTitle.AutoSize = true;
            this.lTicketTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTicketTitle.Location = new System.Drawing.Point(26, 26);
            this.lTicketTitle.Name = "lTicketTitle";
            this.lTicketTitle.Size = new System.Drawing.Size(70, 23);
            this.lTicketTitle.TabIndex = 0;
            this.lTicketTitle.Text = "Ticket #";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pSubmitTicket.ResumeLayout(false);
            this.pResponse.ResumeLayout(false);
            this.pResponse.PerformLayout();
            this.pTicketInfo.ResumeLayout(false);
            this.pTicketInfo.PerformLayout();
            this.pStatus.ResumeLayout(false);
            this.pTicketTitle.ResumeLayout(false);
            this.pTicketTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lName;
        private Label lStaffID;
        private Button bEmptyTicket;
        private Panel panel2;
        private Button bSubmit;
        private Label lTicketTitle;
        private Label lResponse;
        private Label lDiscriptionOfIssue;
        private Label lContactEmail;
        private Label lStatus;
        private ComboBox cbStatus;
        private TextBox Response;
        private TextBox DescriptionOfIssue;
        private TextBox StaffContactEmail;
        private TextBox StaffName;
        private TextBox StaffID;
        private Panel pTicketTitle;
        private Panel pStatus;
        private Panel pResponse;
        private Button bGeneratePassword;
        private Panel pTicketInfo;
        private Button bCancel;
        private Panel pSubmitTicket;
    }
}