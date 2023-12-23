using System.Windows;

namespace Gestion_d_une_biblio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            // Add your login logic here
            // For simplicity, let's just display a message for demonstration purposes
            if (IsValidLogin(email, password))
            {
                // Successful login
                MessageBox.Show($"Welcome, {email}!", "Login Successful");
            }
            else
            {
                // Failed login
                txtMessage.Text = "Invalid email or password. Please try again.";
            }
        }

        private bool IsValidLogin(string email, string password)
        {
            // Replace this with your actual authentication logic
            // For example, check against a database of users
            // For now, let's use a simple hardcoded check
            return email == "admin@emsi.com" && password == "admin";
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            // Close the application
            Application.Current.Shutdown();
        }
    }
}
