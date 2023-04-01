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
            StatName = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            dataGridViewLocal = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            textBoxActualTime = new TextBox();
            label6 = new Label();
            trackBarSpeed = new TrackBar();
            dataGridViewArrival = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            dataGridViewTechnical = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            dataGridViewInspection = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArrival).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInspection).BeginInit();
            SuspendLayout();
            // 
            // textBoxRepCount
            // 
            textBoxRepCount.Location = new Point(95, 45);
            textBoxRepCount.Margin = new Padding(3, 2, 3, 2);
            textBoxRepCount.Name = "textBoxRepCount";
            textBoxRepCount.Size = new Size(125, 27);
            textBoxRepCount.TabIndex = 3;
            // 
            // labelRepCount
            // 
            labelRepCount.AutoSize = true;
            labelRepCount.Location = new Point(15, 49);
            labelRepCount.Name = "labelRepCount";
            labelRepCount.Size = new Size(74, 20);
            labelRepCount.TabIndex = 4;
            labelRepCount.Text = "RepCount";
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(233, 86);
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
            labelSett.Location = new Point(10, 9);
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
            textBoxActualRep.Location = new Point(524, 32);
            textBoxActualRep.Margin = new Padding(3, 2, 3, 2);
            textBoxActualRep.Name = "textBoxActualRep";
            textBoxActualRep.ReadOnly = true;
            textBoxActualRep.Size = new Size(92, 27);
            textBoxActualRep.TabIndex = 14;
            // 
            // buttonPause
            // 
            buttonPause.Location = new Point(233, 46);
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
            buttonRun.Location = new Point(233, 6);
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
            label2.Location = new Point(651, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 20;
            label2.Text = "Speed";
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(704, 36);
            textBoxSpeed.Margin = new Padding(3, 2, 3, 2);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.ReadOnly = true;
            textBoxSpeed.Size = new Size(34, 27);
            textBoxSpeed.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(743, 40);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 21;
            label3.Text = "X";
            // 
            // buttonTurbo
            // 
            buttonTurbo.Location = new Point(819, 32);
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
            buttonNormal.Location = new Point(819, 73);
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
            dataGridViewGlobal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewGlobal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewGlobal.BackgroundColor = Color.White;
            dataGridViewGlobal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGlobal.Columns.AddRange(new DataGridViewColumn[] { StatName, Value });
            dataGridViewGlobal.Location = new Point(37, 176);
            dataGridViewGlobal.Margin = new Padding(3, 4, 3, 4);
            dataGridViewGlobal.Name = "dataGridViewGlobal";
            dataGridViewGlobal.ReadOnly = true;
            dataGridViewGlobal.RowHeadersWidth = 62;
            dataGridViewGlobal.RowTemplate.Height = 25;
            dataGridViewGlobal.Size = new Size(294, 308);
            dataGridViewGlobal.TabIndex = 26;
            // 
            // StatName
            // 
            StatName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            StatName.HeaderText = "StatName";
            StatName.MinimumWidth = 8;
            StatName.Name = "StatName";
            StatName.ReadOnly = true;
            StatName.Width = 8;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Value.HeaderText = "Value";
            Value.MinimumWidth = 8;
            Value.Name = "Value";
            Value.ReadOnly = true;
            Value.Width = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 36);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 27;
            label4.Text = "Actual Replication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 73);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 31;
            label5.Text = "Actual Time";
            // 
            // dataGridViewLocal
            // 
            dataGridViewLocal.AllowUserToAddRows = false;
            dataGridViewLocal.AllowUserToDeleteRows = false;
            dataGridViewLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewLocal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewLocal.BackgroundColor = Color.White;
            dataGridViewLocal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocal.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewLocal.Location = new Point(37, 526);
            dataGridViewLocal.Margin = new Padding(3, 4, 3, 4);
            dataGridViewLocal.Name = "dataGridViewLocal";
            dataGridViewLocal.ReadOnly = true;
            dataGridViewLocal.RowHeadersWidth = 62;
            dataGridViewLocal.RowTemplate.Height = 25;
            dataGridViewLocal.Size = new Size(294, 308);
            dataGridViewLocal.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn1.HeaderText = "StatName";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn2.HeaderText = "Value";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 8;
            // 
            // textBoxActualTime
            // 
            textBoxActualTime.Location = new Point(524, 70);
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
            trackBarSpeed.Location = new Point(651, 64);
            trackBarSpeed.Margin = new Padding(2);
            trackBarSpeed.Minimum = 1;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(125, 56);
            trackBarSpeed.TabIndex = 32;
            trackBarSpeed.Value = 1;
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // dataGridViewArrival
            // 
            dataGridViewArrival.AllowUserToAddRows = false;
            dataGridViewArrival.AllowUserToDeleteRows = false;
            dataGridViewArrival.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewArrival.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewArrival.BackgroundColor = Color.White;
            dataGridViewArrival.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArrival.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewArrival.Location = new Point(517, 176);
            dataGridViewArrival.Margin = new Padding(3, 4, 3, 4);
            dataGridViewArrival.Name = "dataGridViewArrival";
            dataGridViewArrival.ReadOnly = true;
            dataGridViewArrival.RowHeadersWidth = 62;
            dataGridViewArrival.RowTemplate.Height = 25;
            dataGridViewArrival.Size = new Size(294, 308);
            dataGridViewArrival.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn3.HeaderText = "StatName";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn4.HeaderText = "Value";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(441, 141);
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
            label8.Location = new Point(441, 494);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(180, 28);
            label8.TabIndex = 36;
            label8.Text = "Technical workers";
            // 
            // dataGridViewTechnical
            // 
            dataGridViewTechnical.AllowUserToAddRows = false;
            dataGridViewTechnical.AllowUserToDeleteRows = false;
            dataGridViewTechnical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewTechnical.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewTechnical.BackgroundColor = Color.White;
            dataGridViewTechnical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTechnical.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewTechnical.Location = new Point(517, 529);
            dataGridViewTechnical.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTechnical.Name = "dataGridViewTechnical";
            dataGridViewTechnical.ReadOnly = true;
            dataGridViewTechnical.RowHeadersWidth = 62;
            dataGridViewTechnical.RowTemplate.Height = 25;
            dataGridViewTechnical.Size = new Size(294, 308);
            dataGridViewTechnical.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn5.HeaderText = "StatName";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 8;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn6.HeaderText = "Value";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(830, 491);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(188, 28);
            label9.TabIndex = 38;
            label9.Text = "Inspection workers";
            // 
            // dataGridViewInspection
            // 
            dataGridViewInspection.AllowUserToAddRows = false;
            dataGridViewInspection.AllowUserToDeleteRows = false;
            dataGridViewInspection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewInspection.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewInspection.BackgroundColor = Color.White;
            dataGridViewInspection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInspection.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewInspection.Location = new Point(906, 526);
            dataGridViewInspection.Margin = new Padding(3, 4, 3, 4);
            dataGridViewInspection.Name = "dataGridViewInspection";
            dataGridViewInspection.ReadOnly = true;
            dataGridViewInspection.RowHeadersWidth = 62;
            dataGridViewInspection.RowTemplate.Height = 25;
            dataGridViewInspection.Size = new Size(294, 308);
            dataGridViewInspection.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn7.HeaderText = "StatName";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 8;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn8.HeaderText = "Value";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 8;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 850);
            Controls.Add(label9);
            Controls.Add(dataGridViewInspection);
            Controls.Add(label8);
            Controls.Add(dataGridViewTechnical);
            Controls.Add(label7);
            Controls.Add(dataGridViewArrival);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewArrival).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnical).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInspection).EndInit();
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
        private DataGridViewTextBoxColumn StatName;
        private DataGridViewTextBoxColumn Value;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewLocal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TextBox textBoxActualTime;
        private Label label6;
        private TrackBar trackBarSpeed;
        private DataGridView dataGridViewArrival;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewTechnical;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label9;
        private DataGridView dataGridViewInspection;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}