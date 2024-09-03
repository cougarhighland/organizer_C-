namespace Event_Organizer
{
    public partial class Form1 : Form
    {
        EventManager eventManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedItem = "Sverige";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string zipCode = txtZipCode.Text;
            
            Address address = new Address(street,zipCode,city);

            EventManager eventManager = new EventManager();
            eventManager.Participants.AddParticipant(firstName, lastName, address);
        }
    }
}
