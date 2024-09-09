namespace Event_Organizer
{
    public partial class Form1 : Form
    {
        private EventManager eventManager = new EventManager();
        private Address address;
        public Form1()
        {
            InitializeComponent();
            // Hide the group box at the start
            lstParticipants.Visible = false;
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

        private void validateParticipantInfo()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string zipCode = txtZipCode.Text;


            address = new Address(street, zipCode, city);
            bool validateAddress = address.Validate();

            if (validateAddress)
            {
                city_err.SetError(txtCity, string.Empty);
                btnAdd.Enabled = true;
            }
            else
            {
                city_err.SetError(txtCity, "City is required");
                btnAdd.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            validateParticipantInfo();

            if (btnAdd.Enabled)
            {
                eventManager.Participants.AddParticipant(firstName, lastName, address);

                // Retrieve participant information array
                string[] participantInfoArray = eventManager.Participants.GetParticipantsInfo();
                //clear the old list
                lstParticipants.Items.Clear();
                foreach (string participantInfo in participantInfoArray)
                {
                    // Split the participant info string using the delimiter
                    string[] columns = participantInfo.Split('|');

                    // Create a new ListViewItem for the first column (First Name)
                    var listViewItem = new ListViewItem(columns[0]);

                    listViewItem.SubItems.Add(columns[1]); // Street
                    listViewItem.SubItems.Add(columns[2]); // zip code
                    listViewItem.SubItems.Add(columns[3]); // City

                    // Add the ListViewItem to the ListView
                    lstParticipants.Items.Add(listViewItem);
                }
                txtLastName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtStreet.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtZipCode.Text = string.Empty;

                if (lstParticipants.Visible)
                {
                    UpdateEventEconomy();
                }
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {

            UpdateEventEconomy();
            lstParticipants.Visible = true;
        }

        private void UpdateEventEconomy()
        {
            string eventCost = txtCost.Text;
            string eventFee = txtFee.Text;
            float cost = 0.0f;
            float fee = 0.0f;

            try
            {
                cost = float.Parse(eventCost);
                fee = float.Parse(eventFee);
            }
            catch (FormatException)
            {
                MessageBox.Show("invalid input, please enter number");
            }

            int totalParticipants = eventManager.Participants.Count;
            eventManager.CostPerPerson = cost;
            eventManager.FeePerPerson = fee;
            float totalCost = eventManager.CalcTotalCost();
            float totalFees = eventManager.CalcTotalFees();
            float surplusDeficit = totalFees - totalCost;

            txtNumParticipant.Text = totalParticipants.ToString();
            txtTotalCost.Text = totalCost.ToString();
            txtTotalFees.Text = totalFees.ToString();
            txtSurplusOrDeficit.Text = surplusDeficit.ToString();

        }


        private void lstParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lstParticipants.SelectedItems[0].SubItems[0].Text = "changed Name";
            lstParticipants.SelectedItems[0].SubItems[1].Text = "changed street";
            lstParticipants.SelectedItems[0].SubItems[2].Text = "changed zip code";
            lstParticipants.SelectedItems[0].SubItems[3].Text = "changed city";


        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if(!btnAdd.Enabled) validateParticipantInfo();
        }
    }
}
