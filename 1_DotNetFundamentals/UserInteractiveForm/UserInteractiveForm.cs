using ConcatetionLogicLibrary;
namespace WinFormsApp1
{
    public partial class UserInteractiveForm : Form
    {
        private ConcatetionLogic library;
        public UserInteractiveForm()
        {
            InitializeComponent();
            library = new();
        }

        private void button_enter_username_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            if (!string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(library.Output(username));
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Enter valid username.", "Invalid input",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    textBox_username.Focus();
                }
            }
        }
    }
}