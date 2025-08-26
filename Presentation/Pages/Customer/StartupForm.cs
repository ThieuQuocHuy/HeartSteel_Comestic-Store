namespace Presentation.Pages.Customer
{
    public partial class StartupForm : Form
    {
        public bool IsAdminMode { get; private set; }

        public StartupForm()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            IsAdminMode = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            IsAdminMode = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}