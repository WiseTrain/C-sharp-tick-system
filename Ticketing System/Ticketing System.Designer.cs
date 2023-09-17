namespace Ticketing_System
{
    partial class Ticketing_System
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
            this.pStatistics = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pTicketTable = new System.Windows.Forms.Panel();
            this.dgTicketsStats = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.TicketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lClosed = new System.Windows.Forms.Label();
            this.lOpen = new System.Windows.Forms.Label();
            this.lSubmitted = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pStatistics.SuspendLayout();
            this.pTicketTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTicketsStats)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStatistics
            // 
            this.pStatistics.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pStatistics.Controls.Add(this.label2);
            this.pStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatistics.Location = new System.Drawing.Point(0, 0);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Size = new System.Drawing.Size(880, 50);
            this.pStatistics.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(310, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TICKETING SYSTEM";
            // 
            // pTicketTable
            // 
            this.pTicketTable.Controls.Add(this.dgTicketsStats);
            this.pTicketTable.Controls.Add(this.panel1);
            this.pTicketTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTicketTable.Location = new System.Drawing.Point(0, 50);
            this.pTicketTable.Name = "pTicketTable";
            this.pTicketTable.Size = new System.Drawing.Size(880, 643);
            this.pTicketTable.TabIndex = 1;
            // 
            // dgTicketsStats
            // 
            this.dgTicketsStats.AllowUserToAddRows = false;
            this.dgTicketsStats.AllowUserToDeleteRows = false;
            this.dgTicketsStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTicketsStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.TicketID,
            this.DateStamp,
            this.StaffID,
            this.StaffName,
            this.ContactEmail,
            this.DescriptionOfIssue,
            this.Response});
            this.dgTicketsStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTicketsStats.Location = new System.Drawing.Point(0, 115);
            this.dgTicketsStats.Name = "dgTicketsStats";
            this.dgTicketsStats.ReadOnly = true;
            this.dgTicketsStats.RowTemplate.Height = 25;
            this.dgTicketsStats.Size = new System.Drawing.Size(880, 528);
            this.dgTicketsStats.TabIndex = 1;
            this.dgTicketsStats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTicketsStats_CellClick);
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Status.HeaderText = "            ";
            this.Status.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 28;
            // 
            // TicketID
            // 
            this.TicketID.HeaderText = "ID";
            this.TicketID.Name = "TicketID";
            this.TicketID.ReadOnly = true;
            this.TicketID.Width = 50;
            // 
            // DateStamp
            // 
            this.DateStamp.HeaderText = "Date/time";
            this.DateStamp.Name = "DateStamp";
            this.DateStamp.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Width = 75;
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "Staff Name";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // ContactEmail
            // 
            this.ContactEmail.HeaderText = "Email";
            this.ContactEmail.Name = "ContactEmail";
            this.ContactEmail.ReadOnly = true;
            // 
            // DescriptionOfIssue
            // 
            this.DescriptionOfIssue.HeaderText = "Description of Issue";
            this.DescriptionOfIssue.Name = "DescriptionOfIssue";
            this.DescriptionOfIssue.ReadOnly = true;
            this.DescriptionOfIssue.Width = 200;
            // 
            // Response
            // 
            this.Response.HeaderText = "Response";
            this.Response.Name = "Response";
            this.Response.ReadOnly = true;
            this.Response.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lClosed);
            this.panel1.Controls.Add(this.lOpen);
            this.panel1.Controls.Add(this.lSubmitted);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 115);
            this.panel1.TabIndex = 0;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lTotal.Location = new System.Drawing.Point(301, 46);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(23, 26);
            this.lTotal.TabIndex = 9;
            this.lTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total number of tickets:";
            // 
            // lClosed
            // 
            this.lClosed.AutoSize = true;
            this.lClosed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lClosed.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lClosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lClosed.Location = new System.Drawing.Point(637, 70);
            this.lClosed.Name = "lClosed";
            this.lClosed.Size = new System.Drawing.Size(23, 26);
            this.lClosed.TabIndex = 7;
            this.lClosed.Text = "0";
            // 
            // lOpen
            // 
            this.lOpen.AutoSize = true;
            this.lOpen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lOpen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lOpen.ForeColor = System.Drawing.Color.Gold;
            this.lOpen.Location = new System.Drawing.Point(637, 44);
            this.lOpen.Name = "lOpen";
            this.lOpen.Size = new System.Drawing.Size(23, 26);
            this.lOpen.TabIndex = 7;
            this.lOpen.Text = "0";
            // 
            // lSubmitted
            // 
            this.lSubmitted.AutoSize = true;
            this.lSubmitted.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lSubmitted.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSubmitted.ForeColor = System.Drawing.Color.Red;
            this.lSubmitted.Location = new System.Drawing.Point(637, 19);
            this.lSubmitted.Name = "lSubmitted";
            this.lSubmitted.Size = new System.Drawing.Size(23, 26);
            this.lSubmitted.TabIndex = 6;
            this.lSubmitted.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(448, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of closed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(448, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of open:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(448, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of submitted:";
            // 
            // Ticketing_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(880, 693);
            this.Controls.Add(this.pTicketTable);
            this.Controls.Add(this.pStatistics);
            this.Name = "Ticketing_System";
            this.Text = "Ticketing_System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ticketing_System_FormClosing);
            this.pStatistics.ResumeLayout(false);
            this.pStatistics.PerformLayout();
            this.pTicketTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTicketsStats)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pStatistics;
        private Label label2;
        private Panel pTicketTable;
        private DataGridView dgTicketsStats;
        private Panel panel1;
        private Label lClosed;
        private Label lOpen;
        private Label lSubmitted;
        private Label label4;
        private Label label1;
        private Label label3;
        private DataGridViewImageColumn Status;
        private DataGridViewTextBoxColumn TicketID;
        private DataGridViewTextBoxColumn DateStamp;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn ContactEmail;
        private DataGridViewTextBoxColumn DescriptionOfIssue;
        private DataGridViewTextBoxColumn Response;
        private Label lTotal;
        private Label label6;
    }
}