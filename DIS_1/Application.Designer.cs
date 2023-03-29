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
            this.textBoxRepCount = new System.Windows.Forms.TextBox();
            this.labelRepCount = new System.Windows.Forms.Label();
            this.DataCount = new System.Windows.Forms.Label();
            this.textBoxDataCount = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelSett = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.labelIgnore = new System.Windows.Forms.Label();
            this.textBoxIgnore = new System.Windows.Forms.TextBox();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.textBoxActualRep = new System.Windows.Forms.TextBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTurbo = new System.Windows.Forms.Button();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.dataGridViewGlobal = new System.Windows.Forms.DataGridView();
            this.StatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewLocal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxActualTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRepCount
            // 
            this.textBoxRepCount.Location = new System.Drawing.Point(586, 58);
            this.textBoxRepCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRepCount.Name = "textBoxRepCount";
            this.textBoxRepCount.Size = new System.Drawing.Size(155, 31);
            this.textBoxRepCount.TabIndex = 3;
            // 
            // labelRepCount
            // 
            this.labelRepCount.AutoSize = true;
            this.labelRepCount.Location = new System.Drawing.Point(486, 62);
            this.labelRepCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepCount.Name = "labelRepCount";
            this.labelRepCount.Size = new System.Drawing.Size(90, 25);
            this.labelRepCount.TabIndex = 4;
            this.labelRepCount.Text = "RepCount";
            // 
            // DataCount
            // 
            this.DataCount.AutoSize = true;
            this.DataCount.Location = new System.Drawing.Point(486, 103);
            this.DataCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataCount.Name = "DataCount";
            this.DataCount.Size = new System.Drawing.Size(97, 25);
            this.DataCount.TabIndex = 6;
            this.DataCount.Text = "DataCount";
            // 
            // textBoxDataCount
            // 
            this.textBoxDataCount.Location = new System.Drawing.Point(586, 100);
            this.textBoxDataCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDataCount.Name = "textBoxDataCount";
            this.textBoxDataCount.Size = new System.Drawing.Size(155, 31);
            this.textBoxDataCount.TabIndex = 5;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(291, 108);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(154, 42);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelSett
            // 
            this.labelSett.AutoSize = true;
            this.labelSett.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelSett.Location = new System.Drawing.Point(480, 12);
            this.labelSett.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSett.Name = "labelSett";
            this.labelSett.Size = new System.Drawing.Size(240, 32);
            this.labelSett.TabIndex = 8;
            this.labelSett.Text = "Simulation settings:";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelResults.Location = new System.Drawing.Point(11, 173);
            this.labelResults.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(197, 32);
            this.labelResults.TabIndex = 9;
            this.labelResults.Text = "Global statistics";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(663, 220);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(897, 768);
            this.cartesianChart1.TabIndex = 10;
            // 
            // labelIgnore
            // 
            this.labelIgnore.AutoSize = true;
            this.labelIgnore.Location = new System.Drawing.Point(817, 62);
            this.labelIgnore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIgnore.Name = "labelIgnore";
            this.labelIgnore.Size = new System.Drawing.Size(64, 25);
            this.labelIgnore.TabIndex = 12;
            this.labelIgnore.Text = "Ignore";
            // 
            // textBoxIgnore
            // 
            this.textBoxIgnore.Location = new System.Drawing.Point(890, 58);
            this.textBoxIgnore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIgnore.Name = "textBoxIgnore";
            this.textBoxIgnore.Size = new System.Drawing.Size(40, 31);
            this.textBoxIgnore.TabIndex = 11;
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(939, 62);
            this.labelPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(27, 25);
            this.labelPercentage.TabIndex = 13;
            this.labelPercentage.Text = "%";
            // 
            // textBoxActualRep
            // 
            this.textBoxActualRep.Location = new System.Drawing.Point(354, 177);
            this.textBoxActualRep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxActualRep.Name = "textBoxActualRep";
            this.textBoxActualRep.ReadOnly = true;
            this.textBoxActualRep.Size = new System.Drawing.Size(114, 31);
            this.textBoxActualRep.TabIndex = 14;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Items.AddRange(new object[] {
            "RouteA",
            "NewsStand"});
            this.comboBoxProject.Location = new System.Drawing.Point(46, 43);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(183, 33);
            this.comboBoxProject.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Project";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(291, 58);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(154, 42);
            this.buttonPause.TabIndex = 17;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(291, 8);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(154, 42);
            this.buttonRun.TabIndex = 18;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 675);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Speed";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(503, 672);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.ReadOnly = true;
            this.textBoxSpeed.Size = new System.Drawing.Size(41, 31);
            this.textBoxSpeed.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 677);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "X";
            // 
            // buttonTurbo
            // 
            this.buttonTurbo.Location = new System.Drawing.Point(436, 782);
            this.buttonTurbo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTurbo.Name = "buttonTurbo";
            this.buttonTurbo.Size = new System.Drawing.Size(154, 42);
            this.buttonTurbo.TabIndex = 23;
            this.buttonTurbo.Text = "Turbo";
            this.buttonTurbo.UseVisualStyleBackColor = true;
            this.buttonTurbo.Click += new System.EventHandler(this.buttonTurbo_Click);
            // 
            // buttonNormal
            // 
            this.buttonNormal.Location = new System.Drawing.Point(436, 832);
            this.buttonNormal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(154, 42);
            this.buttonNormal.TabIndex = 24;
            this.buttonNormal.Text = "Normal";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // dataGridViewGlobal
            // 
            this.dataGridViewGlobal.AllowUserToAddRows = false;
            this.dataGridViewGlobal.AllowUserToDeleteRows = false;
            this.dataGridViewGlobal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewGlobal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewGlobal.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGlobal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatName,
            this.Value});
            this.dataGridViewGlobal.Location = new System.Drawing.Point(46, 220);
            this.dataGridViewGlobal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewGlobal.Name = "dataGridViewGlobal";
            this.dataGridViewGlobal.ReadOnly = true;
            this.dataGridViewGlobal.RowHeadersWidth = 62;
            this.dataGridViewGlobal.RowTemplate.Height = 25;
            this.dataGridViewGlobal.Size = new System.Drawing.Size(367, 385);
            this.dataGridViewGlobal.TabIndex = 26;
            // 
            // StatName
            // 
            this.StatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.StatName.HeaderText = "StatName";
            this.StatName.MinimumWidth = 8;
            this.StatName.Name = "StatName";
            this.StatName.ReadOnly = true;
            this.StatName.Width = 8;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 8;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Actual Replication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 620);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Actual Time";
            // 
            // dataGridViewLocal
            // 
            this.dataGridViewLocal.AllowUserToAddRows = false;
            this.dataGridViewLocal.AllowUserToDeleteRows = false;
            this.dataGridViewLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewLocal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewLocal.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewLocal.Location = new System.Drawing.Point(46, 658);
            this.dataGridViewLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewLocal.Name = "dataGridViewLocal";
            this.dataGridViewLocal.ReadOnly = true;
            this.dataGridViewLocal.RowHeadersWidth = 62;
            this.dataGridViewLocal.RowTemplate.Height = 25;
            this.dataGridViewLocal.Size = new System.Drawing.Size(367, 385);
            this.dataGridViewLocal.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "StatName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 8;
            // 
            // textBoxActualTime
            // 
            this.textBoxActualTime.Location = new System.Drawing.Point(354, 615);
            this.textBoxActualTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxActualTime.Name = "textBoxActualTime";
            this.textBoxActualTime.ReadOnly = true;
            this.textBoxActualTime.Size = new System.Drawing.Size(114, 31);
            this.textBoxActualTime.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 612);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Local statistics";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(436, 707);
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(156, 69);
            this.trackBarSpeed.TabIndex = 32;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2044, 1063);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewLocal);
            this.Controls.Add(this.textBoxActualTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewGlobal);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.buttonTurbo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.textBoxActualRep);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelIgnore);
            this.Controls.Add(this.textBoxIgnore);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelSett);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.DataCount);
            this.Controls.Add(this.textBoxDataCount);
            this.Controls.Add(this.labelRepCount);
            this.Controls.Add(this.textBoxRepCount);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Application";
            this.Text = "Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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