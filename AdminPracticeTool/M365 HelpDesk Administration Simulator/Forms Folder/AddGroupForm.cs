using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using M365_HelpDesk_Administration_Simulator.Models;
using M365_HelpDesk_Administration_Simulator.Storage;

namespace M365_HelpDesk_Administration_Simulator.Forms_Folder
{
    // Dialog used to create a new simulated security/access group.
    public partial class AddGroupForm : Form
    {

        // Shared fake data store used to check for duplicate group names.
        private readonly FakeDataStore _store;

        // The group created by this dialog when Save is clicked.
        public SecurityGroup CreatedGroup { get; private set; }

        // Builds the dialog and keeps a reference to the fake store for validation.
        public AddGroupForm(FakeDataStore store)
        {
            InitializeComponent();

            _store = store;
        }

        // Reserved WinForms load event. Currently unused.
        private void AddGroupForm_Load(object sender, EventArgs e)
        {

        }

        // Validates group input, prevents duplicate group names, creates the new SecurityGroup object, and closes with OK.
        private void saveButton_Click(object sender, EventArgs e)
        {
            string groupName = groupNameTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Group name is required.");
                return;
            }

            bool groupAlreadyExists = _store.Groups.Any(group =>
                group.Name.Equals(groupName, StringComparison.OrdinalIgnoreCase));

            if (groupAlreadyExists)
            {
                MessageBox.Show("A group with that name already exists.");
                return;
            }

            CreatedGroup = new SecurityGroup
            {
                Name = groupName,
                Description = description
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        // Cancels group creation and closes the dialog.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
