using M365_HelpDesk_Administration_Simulator.Models;
using M365_HelpDesk_Administration_Simulator.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace M365_HelpDesk_Administration_Simulator.Forms_Folder
{
    // Dialog used to create a new simulated user account.
    public partial class AddUserForm : Form
    {

        // Shared fake data store used to check for duplicate email addresses.
        private readonly FakeDataStore _store;

        // The user account created by this dialog when Save is clicked.
        public UserAccount CreatedUser { get; private set; }

        // Builds the dialog and loads available user roles into the role dropdown.
        public AddUserForm(FakeDataStore store)
        {
            InitializeComponent();

            _store = store;

            roleComboBox.DataSource = Enum.GetValues(typeof(UserRole));
            roleComboBox.SelectedItem = UserRole.User;
        }

        // Reserved WinForms load event. Currently unused.
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            //left blank for now
        }


        // Validates user input, prevents duplicate email addresses, creates the new UserAccount object, and closes with OK.
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string department = departmentTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Email address must contain @.");
                return;
            }

            bool emailAlreadyExists = _store.Users.Any(user =>
                user.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (emailAlreadyExists)
            {
                MessageBox.Show("A user with that email already exists.");
                return;
            }

            var selectedRole = (UserRole)roleComboBox.SelectedItem;

            CreatedUser = new UserAccount
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Department = department,
                Role = selectedRole,
                Status = UserStatus.Active
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        // Cancels user creation and closes the dialog.
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
