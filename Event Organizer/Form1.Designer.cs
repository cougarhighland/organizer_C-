namespace Event_Organizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            grpNewEvent = new GroupBox();
            btnCreateEvent = new Button();
            txtFee = new TextBox();
            txtCost = new TextBox();
            txtTitle = new TextBox();
            label3 = new Label();
            lblCostPerParticipant = new Label();
            lblNewEvent = new Label();
            grpParticipants = new GroupBox();
            cmbCountry = new ComboBox();
            txtZipCode = new TextBox();
            txtCity = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            txtStreet = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblFirstName = new Label();
            lstParticipants = new ListView();
            FullName = new ColumnHeader();
            Address = new ColumnHeader();
            zipCode = new ColumnHeader();
            city = new ColumnHeader();
            label10 = new Label();
            label11 = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            groupBox3 = new GroupBox();
            txtSurplusOrDeficit = new TextBox();
            label15 = new Label();
            txtTotalFees = new TextBox();
            txtTotalCost = new TextBox();
            txtNumParticipant = new TextBox();
            lblTotalFees = new Label();
            lblTotalCost = new Label();
            lblNumParticipants = new Label();
            city_err = new ErrorProvider(components);
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            grpNewEvent.SuspendLayout();
            grpParticipants.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)city_err).BeginInit();
            SuspendLayout();
            // 
            // grpNewEvent
            // 
            grpNewEvent.Controls.Add(btnCreateEvent);
            grpNewEvent.Controls.Add(txtFee);
            grpNewEvent.Controls.Add(txtCost);
            grpNewEvent.Controls.Add(txtTitle);
            grpNewEvent.Controls.Add(label3);
            grpNewEvent.Controls.Add(lblCostPerParticipant);
            grpNewEvent.Controls.Add(lblNewEvent);
            grpNewEvent.Location = new Point(12, 12);
            grpNewEvent.Name = "grpNewEvent";
            grpNewEvent.Size = new Size(339, 149);
            grpNewEvent.TabIndex = 0;
            grpNewEvent.TabStop = false;
            grpNewEvent.Text = "New Event";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Location = new Point(97, 120);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(128, 23);
            btnCreateEvent.TabIndex = 6;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(239, 87);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(80, 23);
            txtFee.TabIndex = 5;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(239, 61);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(80, 23);
            txtCost.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(77, 25);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(242, 23);
            txtTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Fee per participant";
            // 
            // lblCostPerParticipant
            // 
            lblCostPerParticipant.AutoSize = true;
            lblCostPerParticipant.Location = new Point(12, 64);
            lblCostPerParticipant.Name = "lblCostPerParticipant";
            lblCostPerParticipant.Size = new Size(111, 15);
            lblCostPerParticipant.TabIndex = 1;
            lblCostPerParticipant.Text = "Cost per participant";
            // 
            // lblNewEvent
            // 
            lblNewEvent.AutoSize = true;
            lblNewEvent.Location = new Point(12, 33);
            lblNewEvent.Name = "lblNewEvent";
            lblNewEvent.Size = new Size(59, 15);
            lblNewEvent.TabIndex = 0;
            lblNewEvent.Text = "Event title";
            // 
            // grpParticipants
            // 
            grpParticipants.Controls.Add(cmbCountry);
            grpParticipants.Controls.Add(txtZipCode);
            grpParticipants.Controls.Add(txtCity);
            grpParticipants.Controls.Add(label9);
            grpParticipants.Controls.Add(label8);
            grpParticipants.Controls.Add(label7);
            grpParticipants.Controls.Add(btnAdd);
            grpParticipants.Controls.Add(txtStreet);
            grpParticipants.Controls.Add(txtLastName);
            grpParticipants.Controls.Add(txtFirstName);
            grpParticipants.Controls.Add(label4);
            grpParticipants.Controls.Add(label5);
            grpParticipants.Controls.Add(lblFirstName);
            grpParticipants.Location = new Point(12, 192);
            grpParticipants.Name = "grpParticipants";
            grpParticipants.Size = new Size(339, 287);
            grpParticipants.TabIndex = 7;
            grpParticipants.TabStop = false;
            grpParticipants.Text = "Add participant";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(97, 179);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(121, 23);
            cmbCountry.TabIndex = 12;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(97, 144);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(222, 23);
            txtZipCode.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(97, 118);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(222, 23);
            txtCity.TabIndex = 10;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 121);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 9;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 147);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 8;
            label8.Text = "Zip Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 182);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 7;
            label7.Text = "Country";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(77, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(97, 87);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(222, 23);
            txtStreet.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(97, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(222, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(97, 25);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(222, 23);
            txtFirstName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 90);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "Street";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 64);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 1;
            label5.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 33);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lstParticipants
            // 
            lstParticipants.Columns.AddRange(new ColumnHeader[] { FullName, Address, zipCode, city });
            lstParticipants.FullRowSelect = true;
            lstParticipants.HeaderStyle = ColumnHeaderStyle.None;
            lstParticipants.Location = new Point(395, 45);
            lstParticipants.Name = "lstParticipants";
            lstParticipants.Size = new Size(552, 97);
            lstParticipants.TabIndex = 8;
            lstParticipants.UseCompatibleStateImageBehavior = false;
            lstParticipants.View = View.Details;
            lstParticipants.SelectedIndexChanged += lstParticipants_SelectedIndexChanged;
            // 
            // FullName
            // 
            FullName.Text = "fullName";
            FullName.Width = 180;
            // 
            // Address
            // 
            Address.Text = "address";
            Address.Width = 180;
            // 
            // zipCode
            // 
            zipCode.Text = "zipcode";
            // 
            // city
            // 
            city.Text = "city";
            city.Width = 100;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(407, 27);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 9;
            label10.Text = "Participant";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(707, 27);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 10;
            label11.Text = "Address";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(428, 148);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(128, 23);
            btnChange.TabIndex = 7;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(727, 148);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSurplusOrDeficit);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtTotalFees);
            groupBox3.Controls.Add(txtTotalCost);
            groupBox3.Controls.Add(txtNumParticipant);
            groupBox3.Controls.Add(lblTotalFees);
            groupBox3.Controls.Add(lblTotalCost);
            groupBox3.Controls.Add(lblNumParticipants);
            groupBox3.Location = new Point(516, 245);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(339, 179);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Event economy";
            // 
            // txtSurplusOrDeficit
            // 
            txtSurplusOrDeficit.Location = new Point(191, 116);
            txtSurplusOrDeficit.Name = "txtSurplusOrDeficit";
            txtSurplusOrDeficit.ReadOnly = true;
            txtSurplusOrDeficit.Size = new Size(128, 23);
            txtSurplusOrDeficit.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 115);
            label15.Name = "label15";
            label15.Size = new Size(84, 15);
            label15.TabIndex = 7;
            label15.Text = "Surplus/deficit";
            // 
            // txtTotalFees
            // 
            txtTotalFees.Location = new Point(191, 87);
            txtTotalFees.Name = "txtTotalFees";
            txtTotalFees.ReadOnly = true;
            txtTotalFees.Size = new Size(128, 23);
            txtTotalFees.TabIndex = 5;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(191, 61);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(128, 23);
            txtTotalCost.TabIndex = 4;
            // 
            // txtNumParticipant
            // 
            txtNumParticipant.Location = new Point(191, 25);
            txtNumParticipant.Name = "txtNumParticipant";
            txtNumParticipant.ReadOnly = true;
            txtNumParticipant.Size = new Size(128, 23);
            txtNumParticipant.TabIndex = 3;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(12, 90);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(56, 15);
            lblTotalFees.TabIndex = 2;
            lblTotalFees.Text = "Total fees";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(12, 64);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(59, 15);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblNumParticipants
            // 
            lblNumParticipants.AutoSize = true;
            lblNumParticipants.Location = new Point(12, 33);
            lblNumParticipants.Name = "lblNumParticipants";
            lblNumParticipants.Size = new Size(130, 15);
            lblNumParticipants.TabIndex = 0;
            lblNumParticipants.Text = "Number of participants";
            // 
            // city_err
            // 
            city_err.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 557);
            Controls.Add(groupBox3);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(lstParticipants);
            Controls.Add(grpParticipants);
            Controls.Add(grpNewEvent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpNewEvent.ResumeLayout(false);
            grpNewEvent.PerformLayout();
            grpParticipants.ResumeLayout(false);
            grpParticipants.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)city_err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox grpNewEvent;
        private Label lblCostPerParticipant;
        private Label lblNewEvent;
        private TextBox txtFee;
        private TextBox txtCost;
        private TextBox txtTitle;
        private Label label3;
        private Button btnCreateEvent;
        private GroupBox grpParticipants;
        private ComboBox cmbCountry;
        private TextBox txtZipCode;
        private TextBox txtCity;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnAdd;
        private TextBox txtStreet;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label5;
        private Label lblFirstName;
        private ListView lstParticipants;
        private Label label10;
        private Label label11;
        private Button btnChange;
        private Button btnDelete;
        private GroupBox groupBox3;
        private Label label15;
        private Label lblTotalFees;
        private Label lblTotalCost;
        private Label lblNumParticipants;
        private TextBox txtSurplusOrDeficit;
        private TextBox txtTotalFees;
        private TextBox txtTotalCost;
        private TextBox txtNumParticipant;
        private ColumnHeader FullName;
        private ColumnHeader Address;
        private ColumnHeader zipCode;
        private ColumnHeader city;
        private ErrorProvider city_err;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}
