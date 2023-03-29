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
            DataCount = new Label();
            textBoxDataCount = new TextBox();
            buttonStop = new Button();
            labelSett = new Label();
            labelResults = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            labelIgnore = new Label();
            textBoxIgnore = new TextBox();
            labelPercentage = new Label();
            textBoxActualRep = new TextBox();
            comboBoxProject = new ComboBox();
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // textBoxRepCount
            // 
            textBoxRepCount.Location = new Point(469, 46);
            textBoxRepCount.Margin = new Padding(3, 2, 3, 2);
            textBoxRepCount.Name = "textBoxRepCount";
            textBoxRepCount.Size = new Size(125, 27);
            textBoxRepCount.TabIndex = 3;
            // 
            // labelRepCount
            // 
            labelRepCount.AutoSize = true;
            labelRepCount.Location = new Point(389, 50);
            labelRepCount.Name = "labelRepCount";
            labelRepCount.Size = new Size(74, 20);
            labelRepCount.TabIndex = 4;
            labelRepCount.Text = "RepCount";
            // 
            // DataCount
            // 
            DataCount.AutoSize = true;
            DataCount.Location = new Point(389, 82);
            DataCount.Name = "DataCount";
            DataCount.Size = new Size(80, 20);
            DataCount.TabIndex = 6;
            DataCount.Text = "DataCount";
            // 
            // textBoxDataCount
            // 
            textBoxDataCount.Location = new Point(469, 80);
            textBoxDataCount.Margin = new Padding(3, 2, 3, 2);
            textBoxDataCount.Name = "textBoxDataCount";
            textBoxDataCount.Size = new Size(125, 27);
            textBoxDataCount.TabIndex = 5;
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
            labelSett.Location = new Point(384, 10);
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
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(609, 176);
            cartesianChart1.Margin = new Padding(3, 2, 3, 2);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(718, 614);
            cartesianChart1.TabIndex = 10;
            // 
            // labelIgnore
            // 
            labelIgnore.AutoSize = true;
            labelIgnore.Location = new Point(654, 50);
            labelIgnore.Name = "labelIgnore";
            labelIgnore.Size = new Size(52, 20);
            labelIgnore.TabIndex = 12;
            labelIgnore.Text = "Ignore";
            // 
            // textBoxIgnore
            // 
            textBoxIgnore.Location = new Point(712, 46);
            textBoxIgnore.Margin = new Padding(3, 2, 3, 2);
            textBoxIgnore.Name = "textBoxIgnore";
            textBoxIgnore.Size = new Size(33, 27);
            textBoxIgnore.TabIndex = 11;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.Location = new Point(751, 50);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(21, 20);
            labelPercentage.TabIndex = 13;
            labelPercentage.Text = "%";
            // 
            // textBoxActualRep
            // 
            textBoxActualRep.Location = new Point(295, 142);
            textBoxActualRep.Margin = new Padding(3, 2, 3, 2);
            textBoxActualRep.Name = "textBoxActualRep";
            textBoxActualRep.ReadOnly = true;
            textBoxActualRep.Size = new Size(92, 27);
            textBoxActualRep.TabIndex = 14;
            // 
            // comboBoxProject
            // 
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Items.AddRange(new object[] { "RouteA", "NewsStand" });
            comboBoxProject.Location = new Point(37, 36);
            comboBoxProject.Margin = new Padding(2, 2, 2, 2);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(147, 28);
            comboBoxProject.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(9, 6);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 16;
            label1.Text = "Project";
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
            label2.Location = new Point(349, 540);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 20;
            label2.Text = "Speed";
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(402, 538);
            textBoxSpeed.Margin = new Padding(3, 2, 3, 2);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.ReadOnly = true;
            textBoxSpeed.Size = new Size(34, 27);
            textBoxSpeed.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 542);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 21;
            label3.Text = "X";
            // 
            // buttonTurbo
            // 
            buttonTurbo.Location = new Point(349, 626);
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
            buttonNormal.Location = new Point(349, 666);
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
            label4.Location = new Point(159, 146);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 27;
            label4.Text = "Actual Replication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 496);
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
            textBoxActualTime.Location = new Point(283, 492);
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
            trackBarSpeed.Location = new Point(349, 566);
            trackBarSpeed.Margin = new Padding(2, 2, 2, 2);
            trackBarSpeed.Minimum = 1;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(125, 56);
            trackBarSpeed.TabIndex = 32;
            trackBarSpeed.Value = 1;
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 850);
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
            Controls.Add(label1);
            Controls.Add(comboBoxProject);
            Controls.Add(textBoxActualRep);
            Controls.Add(labelPercentage);
            Controls.Add(labelIgnore);
            Controls.Add(textBoxIgnore);
            Controls.Add(cartesianChart1);
            Controls.Add(labelResults);
            Controls.Add(labelSett);
            Controls.Add(buttonStop);
            Controls.Add(DataCount);
            Controls.Add(textBoxDataCount);
            Controls.Add(labelRepCount);
            Controls.Add(textBoxRepCount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Application";
            Text = "Application";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxRepCount;
        private Label labelRepCount;
        private Label DataCount;
        private TextBox textBoxDataCount;
        private Button buttonStop;
        private Label labelSett;
        private Label labelResults;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label labelIgnore;
        private TextBox textBoxIgnore;
        private Label labelPercentage;
        private TextBox textBoxActualRep;
        private ComboBox comboBoxProject;
        private Label label1;
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
    }
}