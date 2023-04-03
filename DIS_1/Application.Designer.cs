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
            textBoxRepCount = new TextBox();
            labelRepCount = new Label();
            buttonStop = new Button();
            labelSett = new Label();
            labelResults = new Label();
            textBoxActualRep = new TextBox();
            buttonPause = new Button();
            buttonRun = new Button();
            label2 = new Label();
            textBoxSpeed = new TextBox();
            label3 = new Label();
            buttonTurbo = new Button();
            buttonNormal = new Button();
            dataGridViewGlobal = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            dataGridViewLocal = new DataGridView();
            textBoxActualTime = new TextBox();
            label6 = new Label();
            trackBarSpeed = new TrackBar();
            dataGridViewArrivalQueue = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            dataGridViewWorkersIns = new DataGridView();
            label1 = new Label();
            dataGridViewInspectionParking = new DataGridView();
            label10 = new Label();
            dataGridViewPaymentParking = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            trackBarRefresh = new TrackBar();
            label9 = new Label();
            label11 = new Label();
            textBoxRefresh = new TextBox();
            label12 = new Label();
            dataGridViewWorkersTech = new DataGridView();
            label13 = new Label();
            label14 = new Label();
            technicalWorkers = new NumericUpDown();
            inspectionWorkers = new NumericUpDown();
            Name1 = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            Units = new DataGridViewTextBoxColumn();
            VehicleID = new DataGridViewTextBoxColumn();
            VehicleType = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Units2 = new DataGridViewTextBoxColumn();
            WorkerID = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Working = new DataGridViewTextBoxColumn();
            Vehicle = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label15 = new Label();
            textBoxRepRefresh = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArrivalQueue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersIns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInspectionParking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentParking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersTech).BeginInit();
            ((System.ComponentModel.ISupportInitialize)technicalWorkers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inspectionWorkers).BeginInit();
            SuspendLayout();
            // 
            // textBoxRepCount
            // 
            textBoxRepCount.Location = new Point(93, 22);
            textBoxRepCount.Margin = new Padding(3, 2, 3, 2);
            textBoxRepCount.Name = "textBoxRepCount";
            textBoxRepCount.Size = new Size(125, 27);
            textBoxRepCount.TabIndex = 3;
            // 
            // labelRepCount
            // 
            labelRepCount.AutoSize = true;
            labelRepCount.Location = new Point(17, 28);
            labelRepCount.Name = "labelRepCount";
            labelRepCount.Size = new Size(74, 20);
            labelRepCount.TabIndex = 4;
            labelRepCount.Text = "RepCount";
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(427, 104);
            buttonStop.Margin = new Padding(3, 2, 3, 2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(123, 34);
            buttonStop.TabIndex = 7;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelSett
            // 
            labelSett.AutoSize = true;
            labelSett.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSett.Location = new Point(-1, -6);
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
            labelResults.Location = new Point(9, 138);
            labelResults.Margin = new Padding(1, 0, 1, 0);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(164, 28);
            labelResults.TabIndex = 9;
            labelResults.Text = "Global statistics";
            // 
            // textBoxActualRep
            // 
            textBoxActualRep.Location = new Point(690, 32);
            textBoxActualRep.Margin = new Padding(3, 2, 3, 2);
            textBoxActualRep.Name = "textBoxActualRep";
            textBoxActualRep.ReadOnly = true;
            textBoxActualRep.Size = new Size(92, 27);
            textBoxActualRep.TabIndex = 14;
            // 
            // buttonPause
            // 
            buttonPause.Location = new Point(427, 64);
            buttonPause.Margin = new Padding(3, 2, 3, 2);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(123, 34);
            buttonPause.TabIndex = 17;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(427, 21);
            buttonRun.Margin = new Padding(3, 2, 3, 2);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(123, 34);
            buttonRun.TabIndex = 18;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(818, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 20;
            label2.Text = "Speed";
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(871, 36);
            textBoxSpeed.Margin = new Padding(3, 2, 3, 2);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.ReadOnly = true;
            textBoxSpeed.Size = new Size(34, 27);
            textBoxSpeed.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(910, 40);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 21;
            label3.Text = "X";
            // 
            // buttonTurbo
            // 
            buttonTurbo.Location = new Point(1205, 32);
            buttonTurbo.Margin = new Padding(3, 2, 3, 2);
            buttonTurbo.Name = "buttonTurbo";
            buttonTurbo.Size = new Size(123, 34);
            buttonTurbo.TabIndex = 23;
            buttonTurbo.Text = "Turbo";
            buttonTurbo.UseVisualStyleBackColor = true;
            buttonTurbo.Click += buttonTurbo_Click;
            // 
            // buttonNormal
            // 
            buttonNormal.Location = new Point(1205, 74);
            buttonNormal.Margin = new Padding(3, 2, 3, 2);
            buttonNormal.Name = "buttonNormal";
            buttonNormal.Size = new Size(123, 34);
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
            dataGridViewGlobal.Location = new Point(37, 176);
            dataGridViewGlobal.Margin = new Padding(3, 4, 3, 4);
            dataGridViewGlobal.Name = "dataGridViewGlobal";
            dataGridViewGlobal.ReadOnly = true;
            dataGridViewGlobal.RowHeadersWidth = 62;
            dataGridViewGlobal.RowTemplate.Height = 25;
            dataGridViewGlobal.Size = new Size(469, 317);
            dataGridViewGlobal.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 36);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 27;
            label4.Text = "Actual Replication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 74);
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
            dataGridViewLocal.Location = new Point(37, 530);
            dataGridViewLocal.Margin = new Padding(3, 4, 3, 4);
            dataGridViewLocal.Name = "dataGridViewLocal";
            dataGridViewLocal.ReadOnly = true;
            dataGridViewLocal.RowHeadersWidth = 62;
            dataGridViewLocal.RowTemplate.Height = 25;
            dataGridViewLocal.Size = new Size(469, 309);
            dataGridViewLocal.TabIndex = 30;
            // 
            // textBoxActualTime
            // 
            textBoxActualTime.Location = new Point(690, 70);
            textBoxActualTime.Margin = new Padding(3, 2, 3, 2);
            textBoxActualTime.Name = "textBoxActualTime";
            textBoxActualTime.ReadOnly = true;
            textBoxActualTime.Size = new Size(92, 27);
            textBoxActualTime.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(9, 490);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 28);
            label6.TabIndex = 28;
            label6.Text = "Local statistics";
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.Location = new Point(818, 64);
            trackBarSpeed.Margin = new Padding(2);
            trackBarSpeed.Maximum = 20;
            trackBarSpeed.Minimum = 1;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(125, 56);
            trackBarSpeed.TabIndex = 32;
            trackBarSpeed.Value = 1;
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // dataGridViewArrivalQueue
            // 
            dataGridViewArrivalQueue.AllowUserToAddRows = false;
            dataGridViewArrivalQueue.AllowUserToDeleteRows = false;
            dataGridViewArrivalQueue.BackgroundColor = Color.White;
            dataGridViewArrivalQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArrivalQueue.Columns.AddRange(new DataGridViewColumn[] { VehicleID, VehicleType, ArrivalTime });
            dataGridViewArrivalQueue.Location = new Point(556, 176);
            dataGridViewArrivalQueue.Margin = new Padding(3, 4, 3, 4);
            dataGridViewArrivalQueue.Name = "dataGridViewArrivalQueue";
            dataGridViewArrivalQueue.ReadOnly = true;
            dataGridViewArrivalQueue.RowHeadersWidth = 62;
            dataGridViewArrivalQueue.RowTemplate.Height = 25;
            dataGridViewArrivalQueue.Size = new Size(356, 317);
            dataGridViewArrivalQueue.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(539, 138);
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
            label8.Location = new Point(1067, 505);
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
            dataGridViewWorkersIns.Location = new Point(582, 537);
            dataGridViewWorkersIns.Margin = new Padding(3, 4, 3, 4);
            dataGridViewWorkersIns.Name = "dataGridViewWorkersIns";
            dataGridViewWorkersIns.ReadOnly = true;
            dataGridViewWorkersIns.RowHeadersWidth = 62;
            dataGridViewWorkersIns.RowTemplate.Height = 25;
            dataGridViewWorkersIns.Size = new Size(466, 302);
            dataGridViewWorkersIns.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(949, 146);
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
            dataGridViewInspectionParking.Location = new Point(998, 183);
            dataGridViewInspectionParking.Margin = new Padding(3, 4, 3, 4);
            dataGridViewInspectionParking.Name = "dataGridViewInspectionParking";
            dataGridViewInspectionParking.ReadOnly = true;
            dataGridViewInspectionParking.RowHeadersWidth = 62;
            dataGridViewInspectionParking.RowTemplate.Height = 25;
            dataGridViewInspectionParking.Size = new Size(206, 310);
            dataGridViewInspectionParking.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(1220, 146);
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
            dataGridViewPaymentParking.Location = new Point(1259, 183);
            dataGridViewPaymentParking.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPaymentParking.Name = "dataGridViewPaymentParking";
            dataGridViewPaymentParking.ReadOnly = true;
            dataGridViewPaymentParking.RowHeadersWidth = 62;
            dataGridViewPaymentParking.RowTemplate.Height = 25;
            dataGridViewPaymentParking.Size = new Size(207, 310);
            dataGridViewPaymentParking.TabIndex = 42;
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
            // trackBarRefresh
            // 
            trackBarRefresh.Location = new Point(973, 60);
            trackBarRefresh.Margin = new Padding(2);
            trackBarRefresh.Maximum = 30;
            trackBarRefresh.Minimum = 1;
            trackBarRefresh.Name = "trackBarRefresh";
            trackBarRefresh.Size = new Size(179, 56);
            trackBarRefresh.TabIndex = 47;
            trackBarRefresh.Value = 1;
            trackBarRefresh.Scroll += trackBarRefresh_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1080, 36);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 46;
            label9.Text = "second";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(977, 35);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 45;
            label11.Text = "Refresh";
            // 
            // textBoxRefresh
            // 
            textBoxRefresh.Location = new Point(1041, 32);
            textBoxRefresh.Margin = new Padding(3, 2, 3, 2);
            textBoxRefresh.Name = "textBoxRefresh";
            textBoxRefresh.ReadOnly = true;
            textBoxRefresh.Size = new Size(34, 27);
            textBoxRefresh.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(537, 505);
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
            dataGridViewWorkersTech.Location = new Point(1106, 537);
            dataGridViewWorkersTech.Margin = new Padding(3, 4, 3, 4);
            dataGridViewWorkersTech.Name = "dataGridViewWorkersTech";
            dataGridViewWorkersTech.ReadOnly = true;
            dataGridViewWorkersTech.RowHeadersWidth = 62;
            dataGridViewWorkersTech.RowTemplate.Height = 25;
            dataGridViewWorkersTech.Size = new Size(465, 302);
            dataGridViewWorkersTech.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 66);
            label13.Name = "label13";
            label13.Size = new Size(125, 20);
            label13.TabIndex = 51;
            label13.Text = "Technical workers";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 104);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 52;
            label14.Text = "Inspect workers";
            // 
            // technicalWorkers
            // 
            technicalWorkers.Location = new Point(138, 62);
            technicalWorkers.Margin = new Padding(3, 4, 3, 4);
            technicalWorkers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            technicalWorkers.Name = "technicalWorkers";
            technicalWorkers.Size = new Size(80, 27);
            technicalWorkers.TabIndex = 53;
            technicalWorkers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // inspectionWorkers
            // 
            inspectionWorkers.Location = new Point(138, 102);
            inspectionWorkers.Margin = new Padding(3, 4, 3, 4);
            inspectionWorkers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inspectionWorkers.Name = "inspectionWorkers";
            inspectionWorkers.Size = new Size(80, 27);
            inspectionWorkers.TabIndex = 54;
            inspectionWorkers.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // 
            // Working
            // 
            Working.HeaderText = "Working";
            Working.MinimumWidth = 8;
            Working.Name = "Working";
            Working.ReadOnly = true;
            // 
            // Vehicle
            // 
            Vehicle.HeaderText = "Vehicle";
            Vehicle.MinimumWidth = 8;
            Vehicle.Name = "Vehicle";
            Vehicle.ReadOnly = true;
            Vehicle.Width = 140;
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
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Working";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Vehicle";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 140;
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(224, 28);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 56;
            label15.Text = "RepRefresh";
            // 
            // textBoxRepRefresh
            // 
            textBoxRepRefresh.Location = new Point(314, 21);
            textBoxRepRefresh.Margin = new Padding(3, 2, 3, 2);
            textBoxRepRefresh.Name = "textBoxRepRefresh";
            textBoxRepRefresh.Size = new Size(99, 27);
            textBoxRepRefresh.TabIndex = 55;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 879);
            Controls.Add(label15);
            Controls.Add(textBoxRepRefresh);
            Controls.Add(inspectionWorkers);
            Controls.Add(technicalWorkers);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dataGridViewWorkersTech);
            Controls.Add(trackBarRefresh);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(textBoxRefresh);
            Controls.Add(label10);
            Controls.Add(dataGridViewPaymentParking);
            Controls.Add(label1);
            Controls.Add(dataGridViewInspectionParking);
            Controls.Add(label8);
            Controls.Add(dataGridViewWorkersIns);
            Controls.Add(label7);
            Controls.Add(dataGridViewArrivalQueue);
            Controls.Add(trackBarSpeed);
            Controls.Add(label5);
            Controls.Add(dataGridViewLocal);
            Controls.Add(textBoxActualTime);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dataGridViewGlobal);
            Controls.Add(buttonNormal);
            Controls.Add(buttonTurbo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxSpeed);
            Controls.Add(buttonRun);
            Controls.Add(buttonPause);
            Controls.Add(textBoxActualRep);
            Controls.Add(labelResults);
            Controls.Add(labelSett);
            Controls.Add(buttonStop);
            Controls.Add(labelRepCount);
            Controls.Add(textBoxRepCount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Application";
            Text = "Application";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArrivalQueue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersIns).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInspectionParking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentParking).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkersTech).EndInit();
            ((System.ComponentModel.ISupportInitialize)technicalWorkers).EndInit();
            ((System.ComponentModel.ISupportInitialize)inspectionWorkers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxRepCount;
        private Label labelRepCount;
        private Button buttonStop;
        private Label labelSett;
        private Label labelResults;
        private TextBox textBoxActualRep;
        private Button buttonPause;
        private Button buttonRun;
        private Label label2;
        private TextBox textBoxSpeed;
        private Label label3;
        private Button buttonTurbo;
        private Button buttonNormal;
        private DataGridView dataGridViewGlobal;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewLocal;
        private TextBox textBoxActualTime;
        private Label label6;
        private TrackBar trackBarSpeed;
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
        private TrackBar trackBarRefresh;
        private Label label9;
        private Label label11;
        private TextBox textBoxRefresh;
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
        private TextBox textBoxRepRefresh;
    }
}