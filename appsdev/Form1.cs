using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class MainForm : Form
    {
        private class ParkingEntry
        {
            public string PlateNumber { get; set; }
            public string VehicleType { get; set; }
            public string VehicleBrand { get; set; }
            public string Color { get; set; }
            public DateTime EntryTime { get; set; }
        }

        private List<ParkingEntry> parkingEntries = new List<ParkingEntry>();

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeVehicleTypeComboBox();
            cmbVehicleType.SelectedIndexChanged += cmbVehicleType_SelectedIndexChanged;
        }

        private void InitializeVehicleTypeComboBox()
        {
            cmbVehicleType.Items.Clear();
            cmbVehicleType.Items.AddRange(new string[] { "MOTORCYCLE", "SEDAN", "TRUCK" });
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbVehicleType.SelectedItem.ToString();
            cmbVehicleBrand.Items.Clear();

            switch (selectedType)
            {
                case "MOTORCYCLE":
                    cmbVehicleBrand.Items.AddRange(new string[] { "Honda", "Yamaha", "Suzuki" });
                    break;
                case "SEDAN":
                    cmbVehicleBrand.Items.AddRange(new string[] { "Toyota", "Honda", "Ford" });
                    break;
                case "TRUCK":
                    cmbVehicleBrand.Items.AddRange(new string[] { "Ford", "Chevrolet", "Toyota" });
                    break;
            }
        }

        private void InitializeDataGridView()
        {
            dataGridViewParking.ColumnCount = 5;
            dataGridViewParking.Columns[0].Name = "PlateNumber";
            dataGridViewParking.Columns[1].Name = "VehicleType";
            dataGridViewParking.Columns[2].Name = "VehicleBrand";
            dataGridViewParking.Columns[3].Name = "Color";
            dataGridViewParking.Columns[4].Name = "EntryTime";
        }

        private void UpdateParkingDetails()
        {
            dataGridViewParking.Rows.Clear();

            foreach (var entry in parkingEntries)
            {
                dataGridViewParking.Rows.Add(entry.PlateNumber, entry.VehicleType, entry.VehicleBrand, entry.Color, entry.EntryTime);
            }
        }

        private double CalculateParkingFee(DateTime entryTime)
        {
            TimeSpan duration = DateTime.Now - entryTime;
            double feePerHour = 5.0;
            double totalFee = feePerHour * duration.TotalHours;

            // Adjust fee based on vehicle type
            switch (cmbVehicleType.Text.Trim().ToUpper())
            {
                case "MOTORCYCLE":
                    feePerHour = 20.0;
                    break;
                case "SEDAN":
                    feePerHour = 30.0;
                    break;
                case "TRUCK":
                    feePerHour = 50.0;
                    break;
            }

            totalFee = feePerHour * duration.TotalHours;
            return totalFee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string plateNumber = txtPlateNumber.Text.Trim();
            string vehicleType = cmbVehicleType.Text.Trim();
            string vehicleBrand = cmbVehicleBrand.Text.Trim();
            string color = txtColor.Text.Trim();
            DateTime entryTime = DateTime.Now;

            parkingEntries.Add(new ParkingEntry { PlateNumber = plateNumber, VehicleType = vehicleType, VehicleBrand = vehicleBrand, Color = color, EntryTime = entryTime });

            UpdateParkingDetails();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewParking.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewParking.SelectedRows[0].Index;

                parkingEntries[selectedIndex].PlateNumber = txtPlateNumber.Text.Trim();
                parkingEntries[selectedIndex].VehicleType = cmbVehicleType.Text.Trim();
                parkingEntries[selectedIndex].VehicleBrand = cmbVehicleBrand.Text.Trim();
                parkingEntries[selectedIndex].Color = txtColor.Text.Trim();

                UpdateParkingDetails();
            }
            else
            {
                MessageBox.Show("Please select a parking entry to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewParking.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewParking.SelectedRows[0].Index;
                parkingEntries.RemoveAt(selectedIndex);
                UpdateParkingDetails();
            }
            else
            {
                MessageBox.Show("Please select a parking entry to delete.");
            }
        }

        private void dataGridViewParking_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewParking.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewParking.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < parkingEntries.Count)
                {
                    // Update text boxes
                    txtPlateNumber.Text = parkingEntries[selectedIndex].PlateNumber;
                    txtColor.Text = parkingEntries[selectedIndex].Color;

                    // Update combo boxes
                    cmbVehicleType.Text = parkingEntries[selectedIndex].VehicleType;
                    cmbVehicleBrand.Text = parkingEntries[selectedIndex].VehicleBrand;
                }
                else
                {
                    // Deselect the row to prevent further processing
                    dataGridViewParking.ClearSelection();
                }
            }
        }


        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            if (dataGridViewParking.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewParking.SelectedRows[0].Index;
                DateTime entryTime = parkingEntries[selectedIndex].EntryTime;
                double totalFee = CalculateParkingFee(entryTime);
                MessageBox.Show($"Total Parking Fee: {totalFee:C}");
            }
            else
            {
                MessageBox.Show("Please select a parking entry to calculate fee.");
            }
        }
    }
}
