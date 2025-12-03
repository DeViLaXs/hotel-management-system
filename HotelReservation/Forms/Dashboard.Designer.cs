namespace HotelReservation
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panalSlide = new System.Windows.Forms.Panel();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new HotelReservation.CustomersDataSet();
            this.customersTableAdapter = new HotelReservation.CustomersDataSetTableAdapters.CustomersTableAdapter();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dashboardControl1 = new HotelReservation.DashboardControl.DashboardControl();
            this.clientControl1 = new HotelReservation.Forms.ClientControl.ClientControl();
            this.paymentControl1 = new HotelReservation.PaymentControl.PaymentControl();
            this.roomControl1 = new HotelReservation.RoomControl();
            this.reservationControl1 = new HotelReservation.roomControl.ReservationControl();
            this.userControlDashboard2 = new HotelReservation.RoomControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.panalSlide);
            this.panel1.Controls.Add(this.buttonPayment);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 497);
            this.panel1.TabIndex = 0;
            // 
            // panalSlide
            // 
            this.panalSlide.BackColor = System.Drawing.Color.White;
            this.panalSlide.Location = new System.Drawing.Point(0, 2);
            this.panalSlide.Name = "panalSlide";
            this.panalSlide.Size = new System.Drawing.Size(12, 54);
            this.panalSlide.TabIndex = 3;
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.ForeColor = System.Drawing.Color.White;
            this.buttonPayment.Image = global::HotelReservation.Properties.Resources.pay;
            this.buttonPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayment.Location = new System.Drawing.Point(0, 216);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPayment.Size = new System.Drawing.Size(221, 54);
            this.buttonPayment.TabIndex = 2;
            this.buttonPayment.Text = "Payments";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRoom.Image = global::HotelReservation.Properties.Resources.bed;
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(0, 162);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonRoom.Size = new System.Drawing.Size(221, 54);
            this.buttonRoom.TabIndex = 1;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.UseVisualStyleBackColor = false;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Image = global::HotelReservation.Properties.Resources.booking;
            this.buttonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.Location = new System.Drawing.Point(0, 108);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonReservation.Size = new System.Drawing.Size(221, 54);
            this.buttonReservation.TabIndex = 1;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Image = global::HotelReservation.Properties.Resources.people;
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(0, 54);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonClient.Size = new System.Drawing.Size(221, 54);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDash
            // 
            this.buttonDash.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDash.FlatAppearance.BorderSize = 0;
            this.buttonDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDash.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDash.ForeColor = System.Drawing.Color.White;
            this.buttonDash.Image = global::HotelReservation.Properties.Resources.dashboard;
            this.buttonDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDash.Location = new System.Drawing.Point(0, 0);
            this.buttonDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDash.Name = "buttonDash";
            this.buttonDash.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDash.Size = new System.Drawing.Size(221, 54);
            this.buttonDash.TabIndex = 1;
            this.buttonDash.Text = "Dashboard";
            this.buttonDash.UseVisualStyleBackColor = false;
            this.buttonDash.Click += new System.EventHandler(this.buttonDash_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "AOSA Hotel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 100);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1107, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(340, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Omar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(230, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelReservation.Properties.Resources.five_stars__1_;
            this.pictureBox1.Location = new System.Drawing.Point(77, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customersDataSet;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardControl1.Location = new System.Drawing.Point(221, 100);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(983, 497);
            this.dashboardControl1.TabIndex = 6;
            this.dashboardControl1.Load += new System.EventHandler(this.dashboardControl1_Load);
            // 
            // clientControl1
            // 
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            this.clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl1.Location = new System.Drawing.Point(221, 100);
            this.clientControl1.Margin = new System.Windows.Forms.Padding(4);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(983, 497);
            this.clientControl1.TabIndex = 5;
            // 
            // paymentControl1
            // 
            this.paymentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentControl1.Location = new System.Drawing.Point(221, 100);
            this.paymentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.paymentControl1.Name = "paymentControl1";
            this.paymentControl1.Size = new System.Drawing.Size(983, 497);
            this.paymentControl1.TabIndex = 4;
            // 
            // roomControl1
            // 
            this.roomControl1.BackColor = System.Drawing.SystemColors.Control;
            this.roomControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomControl1.Location = new System.Drawing.Point(221, 100);
            this.roomControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomControl1.Name = "roomControl1";
            this.roomControl1.Size = new System.Drawing.Size(983, 497);
            this.roomControl1.TabIndex = 3;
            // 
            // reservationControl1
            // 
            this.reservationControl1.BackColor = System.Drawing.SystemColors.Control;
            this.reservationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationControl1.Location = new System.Drawing.Point(221, 100);
            this.reservationControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationControl1.Name = "reservationControl1";
            this.reservationControl1.Size = new System.Drawing.Size(983, 497);
            this.reservationControl1.TabIndex = 2;
            // 
            // userControlDashboard2
            // 
            this.userControlDashboard2.BackColor = System.Drawing.Color.White;
            this.userControlDashboard2.Location = new System.Drawing.Point(760, 292);
            this.userControlDashboard2.Margin = new System.Windows.Forms.Padding(2);
            this.userControlDashboard2.Name = "userControlDashboard2";
            this.userControlDashboard2.Size = new System.Drawing.Size(951, 483);
            this.userControlDashboard2.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 597);
            this.Controls.Add(this.dashboardControl1);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.paymentControl1);
            this.Controls.Add(this.roomControl1);
            this.Controls.Add(this.reservationControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOSA System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonPayment;
        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CustomersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        //private UserControlDashboard userControlDashboard1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoomControl userControlDashboard2;
        private roomControl.ReservationControl reservationControl1;
        private RoomControl roomControl1;
        private PaymentControl.PaymentControl paymentControl1;
        private Forms.ClientControl.ClientControl clientControl1;
        private System.Windows.Forms.Panel panalSlide;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonDash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DashboardControl.DashboardControl dashboardControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}