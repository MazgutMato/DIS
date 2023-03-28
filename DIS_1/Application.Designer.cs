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
            textBox1 = new TextBox();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            dataGridViewGlobal = new DataGridView();
            StatName = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            dataGridViewLocal = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            textBoxTime = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocal).BeginInit();
            SuspendLayout();
            // 
            // textBoxRepCount
            // 
            textBoxRepCount.Location = new Point(410, 35);
            textBoxRepCount.Margin = new Padding(3, 2, 3, 2);
            textBoxRepCount.Name = "textBoxRepCount";
            textBoxRepCount.Size = new Size(110, 23);
            textBoxRepCount.TabIndex = 3;
            // 
            // labelRepCount
            // 
            labelRepCount.AutoSize = true;
            labelRepCount.Location = new Point(340, 37);
            labelRepCount.Name = "labelRepCount";
            labelRepCount.Size = new Size(60, 15);
            labelRepCount.TabIndex = 4;
            labelRepCount.Text = "RepCount";
            // 
            // DataCount
            // 
            DataCount.AutoSize = true;
            DataCount.Location = new Point(340, 62);
            DataCount.Name = "DataCount";
            DataCount.Size = new Size(64, 15);
            DataCount.TabIndex = 6;
            DataCount.Text = "DataCount";
            // 
            // textBoxDataCount
            // 
            textBoxDataCount.Location = new Point(410, 60);
            textBoxDataCount.Margin = new Padding(3, 2, 3, 2);
            textBoxDataCount.Name = "textBoxDataCount";
            textBoxDataCount.Size = new Size(110, 23);
            textBoxDataCount.TabIndex = 5;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(204, 65);
            buttonStop.Margin = new Padding(3, 2, 3, 2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(108, 25);
            buttonStop.TabIndex = 7;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelSett
            // 
            labelSett.AutoSize = true;
            labelSett.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSett.Location = new Point(336, 7);
            labelSett.Margin = new Padding(1, 0, 1, 0);
            labelSett.Name = "labelSett";
            labelSett.Size = new Size(159, 21);
            labelSett.TabIndex = 8;
            labelSett.Text = "Simulation settings:";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelResults.Location = new Point(8, 104);
            labelResults.Margin = new Padding(1, 0, 1, 0);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(127, 21);
            labelResults.TabIndex = 9;
            labelResults.Text = "Global statistics";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(464, 132);
            cartesianChart1.Margin = new Padding(3, 2, 3, 2);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(628, 461);
            cartesianChart1.TabIndex = 10;
            // 
            // labelIgnore
            // 
            labelIgnore.AutoSize = true;
            labelIgnore.Location = new Point(572, 37);
            labelIgnore.Name = "labelIgnore";
            labelIgnore.Size = new Size(41, 15);
            labelIgnore.TabIndex = 12;
            labelIgnore.Text = "Ignore";
            // 
            // textBoxIgnore
            // 
            textBoxIgnore.Location = new Point(623, 35);
            textBoxIgnore.Margin = new Padding(3, 2, 3, 2);
            textBoxIgnore.Name = "textBoxIgnore";
            textBoxIgnore.Size = new Size(29, 23);
            textBoxIgnore.TabIndex = 11;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.Location = new Point(657, 37);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(17, 15);
            labelPercentage.TabIndex = 13;
            labelPercentage.Text = "%";
            // 
            // textBoxActualRep
            // 
            textBoxActualRep.Location = new Point(248, 106);
            textBoxActualRep.Margin = new Padding(3, 2, 3, 2);
            textBoxActualRep.Name = "textBoxActualRep";
            textBoxActualRep.ReadOnly = true;
            textBoxActualRep.Size = new Size(81, 23);
            textBoxActualRep.TabIndex = 14;
            // 
            // comboBoxProject
            // 
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Items.AddRange(new object[] { "RouteA", "NewsStand" });
            comboBoxProject.Location = new Point(32, 26);
            comboBoxProject.Margin = new Padding(2);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(129, 23);
            comboBoxProject.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 16;
            label1.Text = "Project";
            // 
            // buttonPause
            // 
            buttonPause.Location = new Point(204, 35);
            buttonPause.Margin = new Padding(3, 2, 3, 2);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(108, 25);
            buttonPause.TabIndex = 17;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(204, 5);
            buttonRun.Margin = new Padding(3, 2, 3, 2);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(108, 25);
            buttonRun.TabIndex = 18;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 405);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 20;
            label2.Text = "Speed";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 403);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(30, 23);
            textBox1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 406);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 21;
            label3.Text = "X";
            // 
            // button5
            // 
            button5.Location = new Point(305, 433);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(108, 25);
            button5.TabIndex = 23;
            button5.Text = "Turbo";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(305, 463);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(108, 25);
            button4.TabIndex = 24;
            button4.Text = "Normal";
            button4.UseVisualStyleBackColor = true;
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
            dataGridViewGlobal.Location = new Point(32, 132);
            dataGridViewGlobal.Name = "dataGridViewGlobal";
            dataGridViewGlobal.ReadOnly = true;
            dataGridViewGlobal.RowTemplate.Height = 25;
            dataGridViewGlobal.Size = new Size(257, 231);
            dataGridViewGlobal.TabIndex = 26;
            // 
            // StatName
            // 
            StatName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            StatName.HeaderText = "StatName";
            StatName.Name = "StatName";
            StatName.ReadOnly = true;
            StatName.Width = 5;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Value.HeaderText = "Value";
            Value.Name = "Value";
            Value.ReadOnly = true;
            Value.Width = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 110);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 27;
            label4.Text = "Actual Replication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 372);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
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
            dataGridViewLocal.Location = new Point(32, 395);
            dataGridViewLocal.Name = "dataGridViewLocal";
            dataGridViewLocal.ReadOnly = true;
            dataGridViewLocal.RowTemplate.Height = 25;
            dataGridViewLocal.Size = new Size(257, 231);
            dataGridViewLocal.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn1.HeaderText = "StatName";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn2.HeaderText = "Value";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 5;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(248, 369);
            textBoxTime.Margin = new Padding(3, 2, 3, 2);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.ReadOnly = true;
            textBoxTime.Size = new Size(81, 23);
            textBoxTime.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(8, 367);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 28;
            label6.Text = "Local statistics";
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 638);
            Controls.Add(label5);
            Controls.Add(dataGridViewLocal);
            Controls.Add(textBoxTime);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dataGridViewGlobal);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label3;
        private Button button5;
        private Button button4;
        private DataGridView dataGridViewGlobal;
        private DataGridViewTextBoxColumn StatName;
        private DataGridViewTextBoxColumn Value;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewLocal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TextBox textBoxTime;
        private Label label6;
    }
}