namespace ParkingManagement
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewParking = new DataGridView();
            PlateNumber = new DataGridViewTextBoxColumn();
            VehicleBrand = new DataGridViewTextBoxColumn();
            VehicleType = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            EntryTime = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            cmbVehicleType = new ComboBox();
            cmbVehicleBrand = new ComboBox();
            txtPlateNumber = new TextBox();
            txtColor = new TextBox();
            lblPlateNumber = new Label();
            lblVehicleBrand = new Label();
            lblVehicleType = new Label();
            lblColor = new Label();
            btnCalculateFee = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParking).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewParking
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewParking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewParking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParking.Columns.AddRange(new DataGridViewColumn[] { PlateNumber, VehicleBrand, VehicleType, Color, EntryTime });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewParking.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewParking.Location = new Point(144, 244);
            dataGridViewParking.Margin = new Padding(4, 3, 4, 3);
            dataGridViewParking.MultiSelect = false;
            dataGridViewParking.Name = "dataGridViewParking";
            dataGridViewParking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParking.Size = new System.Drawing.Size(630, 173);
            dataGridViewParking.TabIndex = 0;
            dataGridViewParking.SelectionChanged += dataGridViewParking_SelectionChanged;
            // 
            // PlateNumber
            // 
            PlateNumber.HeaderText = "Plate Number";
            PlateNumber.Name = "PlateNumber";
            PlateNumber.Width = 150;
            // 
            // VehicleBrand
            // 
            VehicleBrand.HeaderText = "VehicleBrand";
            VehicleBrand.Name = "VehicleBrand";
            VehicleBrand.Resizable = DataGridViewTriState.True;
            VehicleBrand.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // VehicleType
            // 
            VehicleType.HeaderText = "VehicleType";
            VehicleType.Name = "VehicleType";
            VehicleType.Resizable = DataGridViewTriState.True;
            VehicleType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Color
            // 
            Color.HeaderText = "Color";
            Color.Name = "Color";
            // 
            // EntryTime
            // 
            EntryTime.HeaderText = "EntryTime";
            EntryTime.Name = "EntryTime";
            EntryTime.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 9.75F);
            btnAdd.Location = new Point(243, 165);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 27);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Khaki;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new Font("Verdana", 9.75F);
            btnEdit.Location = new Point(339, 165);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 27);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Verdana", 9.75F);
            btnDelete.Location = new Point(435, 165);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 27);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "MOTORCYCLE", "SEDAN", "TRUCK" });
            cmbVehicleType.Location = new Point(547, 66);
            cmbVehicleType.Margin = new Padding(4, 3, 4, 3);
            cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(140, 23);
            cmbVehicleType.TabIndex = 4;
            // 
            // cmbVehicleBrand
            // 
            cmbVehicleBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleBrand.FormattingEnabled = true;
            cmbVehicleBrand.Location = new Point(317, 66);
            cmbVehicleBrand.Margin = new Padding(4, 3, 4, 3);
            cmbVehicleBrand.Name = "cmbVehicleBrand";
            this.cmbVehicleBrand.Size = new System.Drawing.Size(140, 23);
            cmbVehicleBrand.TabIndex = 5;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(104, 66);
            txtPlateNumber.Margin = new Padding(4, 3, 4, 3);
            txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(116, 23);
            txtPlateNumber.TabIndex = 6;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(742, 66);
            txtColor.Margin = new Padding(4, 3, 4, 3);
            txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(116, 23);
            txtColor.TabIndex = 7;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(13, 74);
            lblPlateNumber.Margin = new Padding(4, 0, 4, 0);
            lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(83, 15);
            lblPlateNumber.TabIndex = 8;
            lblPlateNumber.Text = "Plate Number:";
            // 
            // lblVehicleBrand
            // 
            lblVehicleBrand.AutoSize = true;
            lblVehicleBrand.Location = new Point(228, 74);
            lblVehicleBrand.Margin = new Padding(4, 0, 4, 0);
            lblVehicleBrand.Name = "lblVehicleBrand";
            this.lblVehicleBrand.Size = new System.Drawing.Size(81, 15);
            lblVehicleBrand.TabIndex = 9;
            lblVehicleBrand.Text = "Vehicle Brand:";
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(465, 74);
            lblVehicleType.Margin = new Padding(4, 0, 4, 0);
            lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(74, 15);
            lblVehicleType.TabIndex = 10;
            lblVehicleType.Text = "Vehicle Type:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(695, 74);
            lblColor.Margin = new Padding(4, 0, 4, 0);
            lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 15);
            lblColor.TabIndex = 11;
            lblColor.Text = "Color:";
            // 
            // btnCalculateFee
            // 
            this.btnCalculateFee.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalculateFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateFee.Location = new System.Drawing.Point(531, 165);
            this.btnCalculateFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCalculateFee.Name = "btnCalculateFee";
            this.btnCalculateFee.Size = new System.Drawing.Size(130, 27);
            btnCalculateFee.TabIndex = 12;
            btnCalculateFee.Text = "Calculate Fee";
            btnCalculateFee.UseVisualStyleBackColor = false;
            btnCalculateFee.Click += btnCalculateFee_Click;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 40);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(407, 9);
            label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            label1.TabIndex = 0;
            label1.Text = "Parking Details";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            ClientSize = new Size(933, 519);
            Controls.Add(panel1);
            Controls.Add(btnCalculateFee);
            Controls.Add(lblColor);
            Controls.Add(lblVehicleType);
            Controls.Add(lblVehicleBrand);
            Controls.Add(lblPlateNumber);
            Controls.Add(txtColor);
            Controls.Add(txtPlateNumber);
            Controls.Add(cmbVehicleBrand);
            Controls.Add(cmbVehicleType);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewParking);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking Management System";
            ((System.ComponentModel.ISupportInitialize)dataGridViewParking).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewParking;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.ComboBox cmbVehicleBrand;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblVehicleBrand;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnCalculateFee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryTime;
        private Label label1;
    }
}
