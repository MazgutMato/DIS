namespace DIS_1
{
    partial class Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRepCount = new Label();
            buttonStop = new Button();
            labelSett = new Label();
            labelResults = new Label();
            textBoxActualRep = new TextBox();
            buttonPause = new Button();
            buttonRun = new Button();
            label2 = new Label();
            buttonTurbo = new Button();
            buttonNormal = new Button();
            dataGridViewGlobal = new DataGridView();
            Name1 = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            Units = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            dataGridViewLocal = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Units2 = new DataGridViewTextBoxColumn();
            textBoxActualTime = new TextBox();
            label6 = new Label();
            dataGridViewArrivalQueue = new DataGridView();
            VehicleID = new DataGridViewTextBoxColumn();
            VehicleType = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            dataGridViewWorkersIns = new DataGridView();
            WorkerID = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Working = new DataGridViewTextBoxColumn();
            Vehicle = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dataGridViewInspectionParking = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            dataGridViewPaymentParking = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            dataGridViewWorkersTech = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            label13 = new Label();
            label14 = new Label();
            technicalWorkers = new NumericUpDown();
            inspectionWorkers = new NumericUpDown();
            label15 = new Label();
            UpDownSpeed = new NumericUpDown();
            label3 = new Label();
            UpDownRefresh = new NumericUpDown();
            UpDownRepRefresh = new NumericUpDown();
            UpDownRepCount = new NumericUpDown();
            textBoxArrival = new TextBox();
            textBoxTechnical = new TextBox();
            textBoxInsP = new TextBox();
            textBoxPayment = new TextBox();
            textBoxIns = new TextBox();
            tabControl1 = new TabControl();
            tabPageSimulation = new TabPage();
            tabPageChart1 = new TabPage();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            buttonStopChart1 = new Button();
            buttonRunChart1 = new Button();
            label16 = new Label();
            UpDownRepCountCH1 = new NumericUpDown();
            UpDownInspCH1 = new NumericUpDown();
            label17 = new Label();
            tabPageChart2 = new TabPage();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            buttonStopChart2 = new Button();
            buttonRunChart2 = new Button();
            label18 = new Label();
            UpDownRepCountCH2 = new NumericUpDown();
            UpDownTechCH2 = new NumericUpDown();
            label19 = new Label();
            textBoxEnding = new TextBox();
            label20 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArrivalQueue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersIns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInspectionParking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentParking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersTech).BeginInit();
            ((System.ComponentModel.ISupportInitialize)technicalWorkers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inspectionWorkers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRepRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRepCount).BeginInit();
            tabControl1.SuspendLayout();
            tabPageSimulation.SuspendLayout();
            tabPageChart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownRepCountCH1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownInspCH1).BeginInit();
            tabPageChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownRepCountCH2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownTechCH2).BeginInit();
            SuspendLayout();
            // 
            // labelRepCount
            // 
            labelRepCount.AutoSize = true;
            labelRepCount.Location = new Point(42, 55);
            labelRepCount.Name = "labelRepCount";
            labelRepCount.Size = new Size(74, 20);
            labelRepCount.TabIndex = 4;
            labelRepCount.Text = "RepCount";
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(433, 113);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(123, 35);
            buttonStop.TabIndex = 7;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelSett
            // 
            labelSett.AutoSize = true;
            labelSett.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSett.Location = new Point(5, 4);
            labelSett.Margin = new Padding(1, 0, 1, 0);
            labelSett.Name = "labelSett";
            labelSett.Size = new Size(200, 28);
            labelSett.TabIndex = 8;
            labelSett.Text = "Simulation settings:";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelResults.Location = new Point(17, 153);
            labelResults.Margin = new Padding(1, 0, 1, 0);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(164, 28);
            labelResults.TabIndex = 9;
            labelResults.Text = "Global statistics";
            // 
            // textBoxActualRep
            // 
            textBoxActualRep.Location = new Point(696, 41);
            textBoxActualRep.Name = "textBoxActualRep";
            textBoxActualRep.ReadOnly = true;
            textBoxActualRep.Size = new Size(92, 27);
            textBoxActualRep.TabIndex = 14;
            // 
            // buttonPause
            // 
            buttonPause.Location = new Point(433, 73);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(123, 35);
            buttonPause.TabIndex = 17;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(433, 31);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(123, 35);
            buttonRun.TabIndex = 18;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(824, 47);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 20;
            label2.Text = "Speed";
            // 
            // buttonTurbo
            // 
            buttonTurbo.Location = new Point(1014, 37);
            buttonTurbo.Name = "buttonTurbo";
            buttonTurbo.Size = new Size(123, 35);
            buttonTurbo.TabIndex = 23;
            buttonTurbo.Text = "Turbo";
            buttonTurbo.UseVisualStyleBackColor = true;
            buttonTurbo.Click += buttonTurbo_Click;
            // 
            // buttonNormal
            // 
            buttonNormal.Location = new Point(1014, 80);
            buttonNormal.Name = "buttonNormal";
            buttonNormal.Size = new Size(123, 35);
            buttonNormal.TabIndex = 24;
            buttonNormal.Text = "Normal";
            buttonNormal.UseVisualStyleBackColor = true;
            buttonNormal.Click += buttonNormal_Click;
            // 
            // dataGridViewGlobal
            // 
            dataGridViewGlobal.AllowUserToAddRows = false;
            dataGridViewGlobal.AllowUserToDeleteRows = false;
            dataGridViewGlobal.BackgroundColor = Color.White;
            dataGridViewGlobal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGlobal.Columns.AddRange(new DataGridViewColumn[] { Name1, Value, Units });
            dataGridViewGlobal.Location = new Point(42, 185);
            dataGridViewGlobal.Margin = new Padding(3, 4, 3, 4);
            dataGridViewGlobal.Name = "dataGridViewGlobal";
            dataGridViewGlobal.ReadOnly = true;
            dataGridViewGlobal.RowHeadersWidth = 62;
            dataGridViewGlobal.RowTemplate.Height = 25;
            dataGridViewGlobal.Size = new Size(531, 311);
            dataGridViewGlobal.TabIndex = 26;
            // 
            // Name1
            // 
            Name1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Name1.HeaderText = "Name";
            Name1.MinimumWidth = 8;
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            Name1.Width = 150;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Value.HeaderText = "Value";
            Value.MinimumWidth = 8;
            Value.Name = "Value";
            Value.ReadOnly = true;
            Value.Width = 150;
            // 
            // Units
            // 
            Units.HeaderText = "Units";
            Units.MinimumWidth = 8;
            Units.Name = "Units";
            Units.ReadOnly = true;
            Units.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 45);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 27;
            label4.Text = "Actual Replication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 84);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 31;
            label5.Text = "Actual Time";
            // 
            // dataGridViewLocal
            // 
            dataGridViewLocal.AllowUserToAddRows = false;
            dataGridViewLocal.AllowUserToDeleteRows = false;
            dataGridViewLocal.BackgroundColor = Color.White;
            dataGridViewLocal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocal.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Units2 });
            dataGridViewLocal.Location = new Point(42, 540);
            dataGridViewLocal.Margin = new Padding(3, 4, 3, 4);
            dataGridViewLocal.Name = "dataGridViewLocal";
            dataGridViewLocal.ReadOnly = true;
            dataGridViewLocal.RowHeadersWidth = 62;
            dataGridViewLocal.RowTemplate.Height = 25;
            dataGridViewLocal.Size = new Size(531, 308);
            dataGridViewLocal.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.HeaderText = "Value";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Units2
            // 
            Units2.HeaderText = "Units";
            Units2.MinimumWidth = 8;
            Units2.Name = "Units2";
            Units2.ReadOnly = true;
            Units2.Width = 125;
            // 
            // textBoxActualTime
            // 
            textBoxActualTime.Location = new Point(696, 79);
            textBoxActualTime.Name = "textBoxActualTime";
            textBoxActualTime.ReadOnly = true;
            textBoxActualTime.Size = new Size(92, 27);
            textBoxActualTime.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(17, 508);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 28);
            label6.TabIndex = 28;
            label6.Text = "Local statistics";
            // 
            // dataGridViewArrivalQueue
            // 
            dataGridViewArrivalQueue.AllowUserToAddRows = false;
            dataGridViewArrivalQueue.AllowUserToDeleteRows = false;
            dataGridViewArrivalQueue.BackgroundColor = Color.White;
            dataGridViewArrivalQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArrivalQueue.Columns.AddRange(new DataGridViewColumn[] { VehicleID, VehicleType, ArrivalTime });
            dataGridViewArrivalQueue.Location = new Point(602, 185);
            dataGridViewArrivalQueue.Margin = new Padding(3, 4, 3, 4);
            dataGridViewArrivalQueue.Name = "dataGridViewArrivalQueue";
            dataGridViewArrivalQueue.ReadOnly = true;
            dataGridViewArrivalQueue.RowHeadersWidth = 62;
            dataGridViewArrivalQueue.RowTemplate.Height = 25;
            dataGridViewArrivalQueue.Size = new Size(406, 311);
            dataGridViewArrivalQueue.TabIndex = 33;
            // 
            // VehicleID
            // 
            VehicleID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            VehicleID.HeaderText = "ID";
            VehicleID.MinimumWidth = 8;
            VehicleID.Name = "VehicleID";
            VehicleID.ReadOnly = true;
            VehicleID.Width = 60;
            // 
            // VehicleType
            // 
            VehicleType.HeaderText = "VehicleType";
            VehicleType.MinimumWidth = 8;
            VehicleType.Name = "VehicleType";
            VehicleType.ReadOnly = true;
            VehicleType.Width = 80;
            // 
            // ArrivalTime
            // 
            ArrivalTime.HeaderText = "ArrivalTime";
            ArrivalTime.MinimumWidth = 8;
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.ReadOnly = true;
            ArrivalTime.Width = 150;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(602, 153);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 34;
            label7.Text = "Arrival queue";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(1173, 508);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(192, 28);
            label8.TabIndex = 36;
            label8.Text = "Inspection Workers";
            // 
            // dataGridViewWorkersIns
            // 
            dataGridViewWorkersIns.AllowUserToAddRows = false;
            dataGridViewWorkersIns.AllowUserToDeleteRows = false;
            dataGridViewWorkersIns.BackgroundColor = Color.White;
            dataGridViewWorkersIns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkersIns.Columns.AddRange(new DataGridViewColumn[] { WorkerID, Type, Working, Vehicle });
            dataGridViewWorkersIns.Location = new Point(1173, 540);
            dataGridViewWorkersIns.Margin = new Padding(3, 4, 3, 4);
            dataGridViewWorkersIns.Name = "dataGridViewWorkersIns";
            dataGridViewWorkersIns.ReadOnly = true;
            dataGridViewWorkersIns.RowHeadersWidth = 62;
            dataGridViewWorkersIns.RowTemplate.Height = 25;
            dataGridViewWorkersIns.Size = new Size(535, 308);
            dataGridViewWorkersIns.TabIndex = 35;
            // 
            // WorkerID
            // 
            WorkerID.HeaderText = "ID";
            WorkerID.MinimumWidth = 8;
            WorkerID.Name = "WorkerID";
            WorkerID.ReadOnly = true;
            WorkerID.Width = 60;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 125;
            // 
            // Working
            // 
            Working.HeaderText = "Working";
            Working.MinimumWidth = 8;
            Working.Name = "Working";
            Working.ReadOnly = true;
            Working.Width = 125;
            // 
            // Vehicle
            // 
            Vehicle.HeaderText = "Vehicle";
            Vehicle.MinimumWidth = 8;
            Vehicle.Name = "Vehicle";
            Vehicle.ReadOnly = true;
            Vehicle.Width = 140;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(1048, 153);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 40;
            label1.Text = "Inspection parking";
            // 
            // dataGridViewInspectionParking
            // 
            dataGridViewInspectionParking.AllowUserToAddRows = false;
            dataGridViewInspectionParking.AllowUserToDeleteRows = false;
            dataGridViewInspectionParking.BackgroundColor = Color.White;
            dataGridViewInspectionParking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInspectionParking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewInspectionParking.Location = new Point(1048, 185);
            dataGridViewInspectionParking.Margin = new Padding(3, 4, 3, 4);
            dataGridViewInspectionParking.Name = "dataGridViewInspectionParking";
            dataGridViewInspectionParking.ReadOnly = true;
            dataGridViewInspectionParking.RowHeadersWidth = 62;
            dataGridViewInspectionParking.RowTemplate.Height = 25;
            dataGridViewInspectionParking.Size = new Size(234, 311);
            dataGridViewInspectionParking.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Type";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(1326, 148);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(175, 28);
            label10.TabIndex = 43;
            label10.Text = "Payment parking";
            // 
            // dataGridViewPaymentParking
            // 
            dataGridViewPaymentParking.AllowUserToAddRows = false;
            dataGridViewPaymentParking.AllowUserToDeleteRows = false;
            dataGridViewPaymentParking.BackgroundColor = Color.White;
            dataGridViewPaymentParking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaymentParking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewPaymentParking.Location = new Point(1326, 185);
            dataGridViewPaymentParking.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPaymentParking.Name = "dataGridViewPaymentParking";
            dataGridViewPaymentParking.ReadOnly = true;
            dataGridViewPaymentParking.RowHeadersWidth = 62;
            dataGridViewPaymentParking.RowTemplate.Height = 25;
            dataGridViewPaymentParking.Size = new Size(233, 311);
            dataGridViewPaymentParking.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "ID";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Type";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn3.HeaderText = "Vehicle ID";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn4.HeaderText = "Vehicle Type";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(941, 83);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 46;
            label9.Text = "second";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(816, 84);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 45;
            label11.Text = "Refresh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(602, 508);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(184, 28);
            label12.TabIndex = 49;
            label12.Text = "Technical Workers";
            // 
            // dataGridViewWorkersTech
            // 
            dataGridViewWorkersTech.AllowUserToAddRows = false;
            dataGridViewWorkersTech.AllowUserToDeleteRows = false;
            dataGridViewWorkersTech.BackgroundColor = Color.White;
            dataGridViewWorkersTech.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkersTech.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewWorkersTech.Location = new Point(606, 540);
            dataGridViewWorkersTech.Margin = new Padding(3, 4, 3, 4);
            dataGridViewWorkersTech.Name = "dataGridViewWorkersTech";
            dataGridViewWorkersTech.ReadOnly = true;
            dataGridViewWorkersTech.RowHeadersWidth = 62;
            dataGridViewWorkersTech.RowTemplate.Height = 25;
            dataGridViewWorkersTech.Size = new Size(531, 308);
            dataGridViewWorkersTech.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "ID";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Type";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Working";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Vehicle";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 140;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(241, 57);
            label13.Name = "label13";
            label13.Size = new Size(125, 20);
            label13.TabIndex = 51;
            label13.Text = "Technical workers";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(241, 95);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 52;
            label14.Text = "Inspect workers";
            // 
            // technicalWorkers
            // 
            technicalWorkers.Location = new Point(362, 52);
            technicalWorkers.Margin = new Padding(3, 4, 3, 4);
            technicalWorkers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            technicalWorkers.Name = "technicalWorkers";
            technicalWorkers.Size = new Size(49, 27);
            technicalWorkers.TabIndex = 53;
            technicalWorkers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // inspectionWorkers
            // 
            inspectionWorkers.Location = new Point(362, 92);
            inspectionWorkers.Margin = new Padding(3, 4, 3, 4);
            inspectionWorkers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inspectionWorkers.Name = "inspectionWorkers";
            inspectionWorkers.Size = new Size(49, 27);
            inspectionWorkers.TabIndex = 54;
            inspectionWorkers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(42, 95);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 56;
            label15.Text = "RepRefresh";
            // 
            // UpDownSpeed
            // 
            UpDownSpeed.DecimalPlaces = 1;
            UpDownSpeed.Increment = new decimal(new int[] { 2, 0, 0, 65536 });
            UpDownSpeed.Location = new Point(875, 43);
            UpDownSpeed.Margin = new Padding(3, 4, 3, 4);
            UpDownSpeed.Minimum = new decimal(new int[] { 2, 0, 0, 65536 });
            UpDownSpeed.Name = "UpDownSpeed";
            UpDownSpeed.Size = new Size(58, 27);
            UpDownSpeed.TabIndex = 57;
            UpDownSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownSpeed.ValueChanged += UpDownSpeed_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(941, 47);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 58;
            label3.Text = "second";
            // 
            // UpDownRefresh
            // 
            UpDownRefresh.Location = new Point(875, 80);
            UpDownRefresh.Margin = new Padding(3, 4, 3, 4);
            UpDownRefresh.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownRefresh.Name = "UpDownRefresh";
            UpDownRefresh.Size = new Size(58, 27);
            UpDownRefresh.TabIndex = 59;
            UpDownRefresh.Value = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownRefresh.ValueChanged += UpDownRefresh_ValueChanged;
            // 
            // UpDownRepRefresh
            // 
            UpDownRepRefresh.Location = new Point(125, 92);
            UpDownRepRefresh.Margin = new Padding(3, 4, 3, 4);
            UpDownRepRefresh.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            UpDownRepRefresh.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownRepRefresh.Name = "UpDownRepRefresh";
            UpDownRepRefresh.Size = new Size(96, 27);
            UpDownRepRefresh.TabIndex = 60;
            UpDownRepRefresh.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // UpDownRepCount
            // 
            UpDownRepCount.Location = new Point(125, 51);
            UpDownRepCount.Margin = new Padding(3, 4, 3, 4);
            UpDownRepCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            UpDownRepCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownRepCount.Name = "UpDownRepCount";
            UpDownRepCount.Size = new Size(96, 27);
            UpDownRepCount.TabIndex = 61;
            UpDownRepCount.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // textBoxArrival
            // 
            textBoxArrival.Location = new Point(745, 154);
            textBoxArrival.Name = "textBoxArrival";
            textBoxArrival.ReadOnly = true;
            textBoxArrival.Size = new Size(55, 27);
            textBoxArrival.TabIndex = 62;
            // 
            // textBoxTechnical
            // 
            textBoxTechnical.Location = new Point(790, 509);
            textBoxTechnical.Name = "textBoxTechnical";
            textBoxTechnical.ReadOnly = true;
            textBoxTechnical.Size = new Size(55, 27);
            textBoxTechnical.TabIndex = 63;
            // 
            // textBoxInsP
            // 
            textBoxInsP.Location = new Point(1239, 153);
            textBoxInsP.Name = "textBoxInsP";
            textBoxInsP.ReadOnly = true;
            textBoxInsP.Size = new Size(55, 27);
            textBoxInsP.TabIndex = 64;
            // 
            // textBoxPayment
            // 
            textBoxPayment.Location = new Point(1504, 153);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.ReadOnly = true;
            textBoxPayment.Size = new Size(55, 27);
            textBoxPayment.TabIndex = 65;
            // 
            // textBoxIns
            // 
            textBoxIns.Location = new Point(1369, 512);
            textBoxIns.Name = "textBoxIns";
            textBoxIns.ReadOnly = true;
            textBoxIns.Size = new Size(55, 27);
            textBoxIns.TabIndex = 66;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSimulation);
            tabControl1.Controls.Add(tabPageChart1);
            tabControl1.Controls.Add(tabPageChart2);
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1737, 896);
            tabControl1.TabIndex = 67;
            // 
            // tabPageSimulation
            // 
            tabPageSimulation.Controls.Add(label20);
            tabPageSimulation.Controls.Add(textBoxEnding);
            tabPageSimulation.Controls.Add(buttonTurbo);
            tabPageSimulation.Controls.Add(textBoxPayment);
            tabPageSimulation.Controls.Add(textBoxIns);
            tabPageSimulation.Controls.Add(textBoxInsP);
            tabPageSimulation.Controls.Add(labelRepCount);
            tabPageSimulation.Controls.Add(label10);
            tabPageSimulation.Controls.Add(dataGridViewPaymentParking);
            tabPageSimulation.Controls.Add(buttonStop);
            tabPageSimulation.Controls.Add(labelSett);
            tabPageSimulation.Controls.Add(textBoxTechnical);
            tabPageSimulation.Controls.Add(labelResults);
            tabPageSimulation.Controls.Add(label8);
            tabPageSimulation.Controls.Add(dataGridViewWorkersIns);
            tabPageSimulation.Controls.Add(textBoxArrival);
            tabPageSimulation.Controls.Add(textBoxActualRep);
            tabPageSimulation.Controls.Add(UpDownRepCount);
            tabPageSimulation.Controls.Add(buttonPause);
            tabPageSimulation.Controls.Add(UpDownRepRefresh);
            tabPageSimulation.Controls.Add(buttonRun);
            tabPageSimulation.Controls.Add(UpDownRefresh);
            tabPageSimulation.Controls.Add(label2);
            tabPageSimulation.Controls.Add(label3);
            tabPageSimulation.Controls.Add(buttonNormal);
            tabPageSimulation.Controls.Add(UpDownSpeed);
            tabPageSimulation.Controls.Add(dataGridViewGlobal);
            tabPageSimulation.Controls.Add(label15);
            tabPageSimulation.Controls.Add(label4);
            tabPageSimulation.Controls.Add(inspectionWorkers);
            tabPageSimulation.Controls.Add(label6);
            tabPageSimulation.Controls.Add(technicalWorkers);
            tabPageSimulation.Controls.Add(textBoxActualTime);
            tabPageSimulation.Controls.Add(label14);
            tabPageSimulation.Controls.Add(dataGridViewLocal);
            tabPageSimulation.Controls.Add(label13);
            tabPageSimulation.Controls.Add(label5);
            tabPageSimulation.Controls.Add(label12);
            tabPageSimulation.Controls.Add(dataGridViewArrivalQueue);
            tabPageSimulation.Controls.Add(dataGridViewWorkersTech);
            tabPageSimulation.Controls.Add(label7);
            tabPageSimulation.Controls.Add(label9);
            tabPageSimulation.Controls.Add(dataGridViewInspectionParking);
            tabPageSimulation.Controls.Add(label11);
            tabPageSimulation.Controls.Add(label1);
            tabPageSimulation.Location = new Point(4, 29);
            tabPageSimulation.Margin = new Padding(3, 4, 3, 4);
            tabPageSimulation.Name = "tabPageSimulation";
            tabPageSimulation.Padding = new Padding(3, 4, 3, 4);
            tabPageSimulation.Size = new Size(1729, 863);
            tabPageSimulation.TabIndex = 0;
            tabPageSimulation.Text = "Simulation";
            tabPageSimulation.UseVisualStyleBackColor = true;
            // 
            // tabPageChart1
            // 
            tabPageChart1.Controls.Add(cartesianChart1);
            tabPageChart1.Controls.Add(buttonStopChart1);
            tabPageChart1.Controls.Add(buttonRunChart1);
            tabPageChart1.Controls.Add(label16);
            tabPageChart1.Controls.Add(UpDownRepCountCH1);
            tabPageChart1.Controls.Add(UpDownInspCH1);
            tabPageChart1.Controls.Add(label17);
            tabPageChart1.Location = new Point(4, 29);
            tabPageChart1.Margin = new Padding(3, 4, 3, 4);
            tabPageChart1.Name = "tabPageChart1";
            tabPageChart1.Padding = new Padding(3, 4, 3, 4);
            tabPageChart1.Size = new Size(1729, 863);
            tabPageChart1.TabIndex = 1;
            tabPageChart1.Text = "AverageLineChart";
            tabPageChart1.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(27, 145);
            cartesianChart1.Margin = new Padding(3, 4, 3, 4);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1677, 687);
            cartesianChart1.TabIndex = 69;
            // 
            // buttonStopChart1
            // 
            buttonStopChart1.Location = new Point(225, 69);
            buttonStopChart1.Name = "buttonStopChart1";
            buttonStopChart1.Size = new Size(123, 35);
            buttonStopChart1.TabIndex = 66;
            buttonStopChart1.Text = "Stop";
            buttonStopChart1.UseVisualStyleBackColor = true;
            buttonStopChart1.Click += buttonStopChart1_Click;
            // 
            // buttonRunChart1
            // 
            buttonRunChart1.Location = new Point(225, 20);
            buttonRunChart1.Name = "buttonRunChart1";
            buttonRunChart1.Size = new Size(123, 35);
            buttonRunChart1.TabIndex = 68;
            buttonRunChart1.Text = "Run";
            buttonRunChart1.UseVisualStyleBackColor = true;
            buttonRunChart1.Click += buttonRunChart1_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 28);
            label16.Name = "label16";
            label16.Size = new Size(74, 20);
            label16.TabIndex = 62;
            label16.Text = "RepCount";
            // 
            // UpDownRepCountCH1
            // 
            UpDownRepCountCH1.Location = new Point(110, 24);
            UpDownRepCountCH1.Margin = new Padding(3, 4, 3, 4);
            UpDownRepCountCH1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            UpDownRepCountCH1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownRepCountCH1.Name = "UpDownRepCountCH1";
            UpDownRepCountCH1.Size = new Size(96, 27);
            UpDownRepCountCH1.TabIndex = 65;
            UpDownRepCountCH1.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // UpDownInspCH1
            // 
            UpDownInspCH1.Location = new Point(157, 69);
            UpDownInspCH1.Margin = new Padding(3, 4, 3, 4);
            UpDownInspCH1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownInspCH1.Name = "UpDownInspCH1";
            UpDownInspCH1.Size = new Size(49, 27);
            UpDownInspCH1.TabIndex = 64;
            UpDownInspCH1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(27, 72);
            label17.Name = "label17";
            label17.Size = new Size(132, 20);
            label17.TabIndex = 63;
            label17.Text = "Inspection workers";
            // 
            // tabPageChart2
            // 
            tabPageChart2.Controls.Add(cartesianChart2);
            tabPageChart2.Controls.Add(buttonStopChart2);
            tabPageChart2.Controls.Add(buttonRunChart2);
            tabPageChart2.Controls.Add(label18);
            tabPageChart2.Controls.Add(UpDownRepCountCH2);
            tabPageChart2.Controls.Add(UpDownTechCH2);
            tabPageChart2.Controls.Add(label19);
            tabPageChart2.Location = new Point(4, 29);
            tabPageChart2.Margin = new Padding(3, 4, 3, 4);
            tabPageChart2.Name = "tabPageChart2";
            tabPageChart2.Size = new Size(1729, 863);
            tabPageChart2.TabIndex = 2;
            tabPageChart2.Text = "TimeInSystemChart";
            tabPageChart2.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(26, 152);
            cartesianChart2.Margin = new Padding(3, 4, 3, 4);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(1677, 687);
            cartesianChart2.TabIndex = 77;
            // 
            // buttonStopChart2
            // 
            buttonStopChart2.Location = new Point(224, 79);
            buttonStopChart2.Name = "buttonStopChart2";
            buttonStopChart2.Size = new Size(123, 35);
            buttonStopChart2.TabIndex = 74;
            buttonStopChart2.Text = "Stop";
            buttonStopChart2.UseVisualStyleBackColor = true;
            buttonStopChart2.Click += buttonStopChart2_Click;
            // 
            // buttonRunChart2
            // 
            buttonRunChart2.Location = new Point(224, 31);
            buttonRunChart2.Name = "buttonRunChart2";
            buttonRunChart2.Size = new Size(123, 35);
            buttonRunChart2.TabIndex = 76;
            buttonRunChart2.Text = "Run";
            buttonRunChart2.UseVisualStyleBackColor = true;
            buttonRunChart2.Click += buttonRunChart2_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(26, 35);
            label18.Name = "label18";
            label18.Size = new Size(74, 20);
            label18.TabIndex = 70;
            label18.Text = "RepCount";
            // 
            // UpDownRepCountCH2
            // 
            UpDownRepCountCH2.Location = new Point(109, 31);
            UpDownRepCountCH2.Margin = new Padding(3, 4, 3, 4);
            UpDownRepCountCH2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            UpDownRepCountCH2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownRepCountCH2.Name = "UpDownRepCountCH2";
            UpDownRepCountCH2.Size = new Size(96, 27);
            UpDownRepCountCH2.TabIndex = 73;
            UpDownRepCountCH2.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // UpDownTechCH2
            // 
            UpDownTechCH2.Location = new Point(155, 76);
            UpDownTechCH2.Margin = new Padding(3, 4, 3, 4);
            UpDownTechCH2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownTechCH2.Name = "UpDownTechCH2";
            UpDownTechCH2.Size = new Size(49, 27);
            UpDownTechCH2.TabIndex = 72;
            UpDownTechCH2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(26, 79);
            label19.Name = "label19";
            label19.Size = new Size(125, 20);
            label19.TabIndex = 71;
            label19.Text = "Technical workers";
            // 
            // textBoxEnding
            // 
            textBoxEnding.Location = new Point(1369, 57);
            textBoxEnding.Name = "textBoxEnding";
            textBoxEnding.ReadOnly = true;
            textBoxEnding.Size = new Size(55, 27);
            textBoxEnding.TabIndex = 67;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(1252, 64);
            label20.Name = "label20";
            label20.Size = new Size(111, 20);
            label20.TabIndex = 68;
            label20.Text = "Ending vehicles";
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1761, 928);
            Controls.Add(tabControl1);
            Name = "Application";
            Text = "Application";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArrivalQueue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersIns).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInspectionParking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentParking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersTech).EndInit();
            ((System.ComponentModel.ISupportInitialize)technicalWorkers).EndInit();
            ((System.ComponentModel.ISupportInitialize)inspectionWorkers).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRepRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRepCount).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageSimulation.ResumeLayout(false);
            tabPageSimulation.PerformLayout();
            tabPageChart1.ResumeLayout(false);
            tabPageChart1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownRepCountCH1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownInspCH1).EndInit();
            tabPageChart2.ResumeLayout(false);
            tabPageChart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownRepCountCH2).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownTechCH2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelRepCount;
        private Button buttonStop;
        private Label labelSett;
        private Label labelResults;
        private TextBox textBoxActualRep;
        private Button buttonPause;
        private Button buttonRun;
        private Label label2;
        private Button buttonTurbo;
        private Button buttonNormal;
        private DataGridView dataGridViewGlobal;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewLocal;
        private TextBox textBoxActualTime;
        private Label label6;
        private DataGridView dataGridViewArrivalQueue;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewWorkersIns;
        private Label label1;
        private DataGridView dataGridViewInspectionParking;
        private Label label10;
        private DataGridView dataGridViewPaymentParking;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label9;
        private Label label11;
        private Label label12;
        private DataGridView dataGridViewWorkersTech;
        private Label label13;
        private Label label14;
        private NumericUpDown technicalWorkers;
        private NumericUpDown inspectionWorkers;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn Units;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Units2;
        private DataGridViewTextBoxColumn VehicleID;
        private DataGridViewTextBoxColumn VehicleType;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn WorkerID;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Working;
        private DataGridViewTextBoxColumn Vehicle;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label label15;
        private NumericUpDown UpDownSpeed;
        private Label label3;
        private NumericUpDown UpDownRefresh;
        private NumericUpDown UpDownRepRefresh;
        private NumericUpDown UpDownRepCount;
        private TextBox textBoxArrival;
        private TextBox textBoxTechnical;
        private TextBox textBoxInsP;
        private TextBox textBoxPayment;
        private TextBox textBoxIns;
        private TabControl tabControl1;
        private TabPage tabPageSimulation;
        private TabPage tabPageChart1;
        private TabPage tabPageChart2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Button buttonStopChart1;
        private Button buttonRunChart1;
        private Label label16;
        private NumericUpDown UpDownRepCountCH1;
        private NumericUpDown UpDownInspCH1;
        private Label label17;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private Button buttonStopChart2;
        private Button buttonRunChart2;
        private Label label18;
        private NumericUpDown UpDownRepCountCH2;
        private NumericUpDown UpDownTechCH2;
        private Label label19;
        private Label label20;
        private TextBox textBoxEnding;
    }
}