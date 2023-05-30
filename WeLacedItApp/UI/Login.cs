namespace WeLacedItApp
{
    public partial class Login : Form
    {
        public DatabaseAccess access = null;
        public Login()
        {
            InitializeComponent();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                access = new DatabaseAccess(textBoxUsername.Text,textBoxPassword.Text);
                
                MessageBox.Show(access.ExecutedCode,access.Msg);

                if (access.isConnected) { 
                this.Hide();

                MainDashboardAdmin mainDashboard = new MainDashboardAdmin(access);
                mainDashboard.Show();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;

           

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }


    }
}