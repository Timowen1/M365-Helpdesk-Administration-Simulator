using M365_HelpDesk_Administration_Simulator.Models;
using M365_HelpDesk_Administration_Simulator.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace M365_HelpDesk_Administration_Simulator.Forms_Folder
{
    // Dialog used to create a new simulated device and return it to Form1.
    public partial class AddDeviceForm : Form
    {

        // Shared fake data store used to check for duplicate device names.
        private readonly FakeDataStore _store;

        // The device created by this dialog when Save is clicked.
        public Device CreatedDevice { get; private set; }
        // Builds the dialog and loads default device type/status choices.
        public AddDeviceForm(FakeDataStore store)
        {
            InitializeComponent();

            _store = store;

            deviceTypeComboBox.Items.Add("Laptop");
            deviceTypeComboBox.Items.Add("Desktop");
            deviceTypeComboBox.Items.Add("Tablet");
            deviceTypeComboBox.Items.Add("Phone");

            deviceTypeComboBox.SelectedIndex = 0;

            statusComboBox.DataSource = Enum.GetValues(typeof(DeviceStatus));
            statusComboBox.SelectedItem = DeviceStatus.Active;

            operatingSystemTextBox.Text = "Windows 11";

        }

        // Reserved WinForms load event. Currently unused.
        private void AddDeviceForm_Load(object sender, EventArgs e)
        {
            // Left blank for now
        }

        // Validates device input, prevents duplicate device names, creates the new Device object, and closes with OK.
        private void saveButton_Click(object sender, EventArgs e)
        {
            string deviceName = deviceNameTextBox.Text.Trim();
            string deviceType = deviceTypeComboBox.Text.Trim();
            string operatingSystem = operatingSystemTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(deviceName))
            {
                MessageBox.Show("Device name is required.");
                return;
            }

            bool deviceAlreadyExists = _store.Devices.Any(device =>
                device.DeviceName.Equals(deviceName, StringComparison.OrdinalIgnoreCase));

            if (deviceAlreadyExists)
            {
                MessageBox.Show("A device with that name already exists.");
                return;
            }

            var selectedStatus = (DeviceStatus)statusComboBox.SelectedItem;

            CreatedDevice = new Device
            {
                DeviceName = deviceName,
                DeviceType = deviceType,
                OperatingSystem = operatingSystem,
                Status = selectedStatus,
                AssignedUserId = null
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        // Cancels device creation and closes the dialog.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
