using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace POS_CofeeMeet
{
    public partial class LoginForm : Form
    {
        string connectionString = "server=localhost;database=cofeemeet;uid=root;pwd=;";

        private readonly ErrorProvider _errorProvider;

        public LoginForm()
        {
            InitializeComponent();

            // Initialize and configure ErrorProvider
            _errorProvider = new ErrorProvider
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink,
                ContainerControl = this
            };
        }

        private void UserTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Clear user textbox error when the user types
            _errorProvider.SetError(UserTxtBox, string.Empty);
        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Clear password textbox error when the user types
            _errorProvider.SetError(PasswordTxtBox, string.Empty);
        }

        private bool ValidateInputs()
        {
            _errorProvider.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(UserTxtBox.Text))
            {
                _errorProvider.SetError(UserTxtBox, "Username is required");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTxtBox.Text))
            {
                _errorProvider.SetError(PasswordTxtBox, "Password is required");
                valid = false;
            }

            return valid;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Validate inputs and show inline errors + messagebox
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill in the required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Focus first invalid control
                if (!string.IsNullOrWhiteSpace(UserTxtBox.Text))
                    PasswordTxtBox.Focus();
                else
                    UserTxtBox.Focus();

                return;
            }

            var username = UserTxtBox.Text.Trim();
            var password = PasswordTxtBox.Text; // In production, compare hashes, not plaintext.

            try
            {
                using var conn = new MySqlConnection(connectionString);
                using var cmd = new MySqlCommand(
                    "SELECT COUNT(1) FROM adminaccounts WHERE username = @user AND password = @pass;",
                    conn);

                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                var result = cmd.ExecuteScalar();
                var matches = result != null && Convert.ToInt32(result) > 0;

                if (matches)
                {
                    MessageBox.Show("Credentials correct. Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TODO: Open dashboard / main form here, for example:
                    // var dash = new DashboardForm();
                    // dash.Show();
                    // this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException mex)
            {
                MessageBox.Show($"Database error: {mex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
