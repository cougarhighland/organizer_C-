namespace Event_Organizer
{
    public partial class Form1 : Form
    {
        private EventManager eventManager;
        public Form1()
        {
            InitializeComponent();
            // Hide the group box at the start
            grpParticipants.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] countryNames = Enum.GetNames(typeof(Countries));

            cmbCountry.Items.AddRange(countryNames);

            cmbCountry.SelectedItem = "Sverige";

            txtNumParticipant.Text = "0";
            txtTotalCost.Text = "0.00";
            txtTotalFees.Text = "0.00";
            txtSurplusOrDeficit.Text = "0.00";
            lstParticipants.Items.Clear();
        }

        private void UpdateGUI()
        {
            string[] strInfo = eventManager.Participants.GetParticipantsInfo();
            if (strInfo != null)
            {
                lstParticipants.Items.Clear();
                lstParticipants.Items.AddRange(strInfo);
                txtNumParticipant.Text = lstParticipants.Items.Count.ToString();
            }
            float totalCost = eventManager.CalcTotalCost();
            float totalFees = eventManager.CalcTotalFees();
            float surplusDeficit = totalFees - totalCost;
            txtTotalCost.Text = totalCost.ToString("0.00");
            txtTotalFees.Text = totalFees.ToString("0.00");
            txtSurplusOrDeficit.Text = surplusDeficit.ToString("0.00");
            txtNumParticipant.Text = eventManager.Participants.Count.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if (ReadInput(ref participant))
            {
                UpdateGUI();
            }
        }

        private bool ReadInput(ref Participant participant)
        {
            bool ok = ReadParticipantData(ref participant);
            if (ok)
            {
                eventManager.Participants.AddParticipant(participant);
            }
            else
            {
                string strMsg = "first name, last name and city are required";
                MessageBox.Show(strMsg);
            }
            return ok;
        }

        private bool ReadParticipantData(ref Participant participant)
        {
            participant.FirstName = txtFirstName.Text;
            participant.LastName = txtLastName.Text;
            Address address = ReadAddress();

            participant.Address = address;

            bool ok = address.Validate();
            return ok;
        }

        private Address ReadAddress()
        {
            Address address = new Address();

            address.Street = txtStreet.Text;
            address.City = txtCity.Text;
            address.ZipCode = txtZipCode.Text;
            address.Country = (Countries)cmbCountry.SelectedIndex;

            return address;
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes(grpParticipants);
            lstParticipants.Items.Clear();
            CreateEvent();
        }

        private void EmptyTextBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void CreateEvent()
        {
            eventManager = new EventManager();
            if (string.IsNullOrEmpty(txtTitle.Text)) txtTitle.Text = "Untitled Event";

            eventManager.Title = txtTitle.Text + " By Xuan";
            this.Text = eventManager.Title;

            bool okCostAmount = ReadCostPerPerson();
            bool okFeeAmount = ReadFeePerPerson();
            if(okCostAmount && okFeeAmount)
            {
                MessageBox.Show("Event Created !");
                grpParticipants.Enabled=true;
                UpdateGUI();
            }
        }

        private bool ReadCostPerPerson()
        {
            bool ok = true;
            float amount = 0;
            if(float.TryParse(txtCost.Text, out amount) && amount >= 0)
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost amount, try again!");
                ok = false;
            }
            return ok;
        }
       
        private bool ReadFeePerPerson()
        {
            bool ok = true;
            float amount = 0;
            if (float.TryParse(txtFee.Text, out amount) && amount >= 0)
            {
                eventManager.FeePerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid fee amount, try again!");
                ok = false;
            }
            return ok;
        }
        private void lstParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstParticipants.SelectedIndex;

            if (index >= 0)
            {
                Participant participant = eventManager.Participants.GetParticipantAt(index);

                txtFirstName.Text = participant.FirstName;
                txtLastName.Text = participant.LastName;
                txtStreet.Text = participant.Address.Street;
                txtZipCode.Text = participant.Address.ZipCode;
                txtCity.Text = participant.Address.City;
                cmbCountry.SelectedIndex = (int)participant.Address.Country;
            }
            else
            {
                MessageBox.Show("Select an item");
            }

        }
        private int IsListBoxItemSelected()
        {
            int index = lstParticipants.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select an item in the list");
                return -1;
            }
            else
            {
                return index;
            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = IsListBoxItemSelected();
            if (index < 0) return;

            Participant participant = eventManager.Participants.GetParticipantAt(index);
            if (ReadParticipantData(ref participant))
            {
                eventManager.Participants.ChangeParticipantAt(participant, index);
                UpdateGUI();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstParticipants.SelectedIndex;
            if (index < 0) return;
            eventManager.Participants.DeleteParticipantAt(index);
            UpdateGUI() ;
        }
    }
}
