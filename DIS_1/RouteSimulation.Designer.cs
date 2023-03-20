namespace DIS_1
{
    partial class RouteSimulation
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
            button1 = new Button();
            buttonRouteA = new Button();
            buttonRouteB = new Button();
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
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(410, 198);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonRouteA
            // 
            buttonRouteA.Location = new Point(566, 39);
            buttonRouteA.Name = "buttonRouteA";
            buttonRouteA.Size = new Size(124, 34);
            buttonRouteA.TabIndex = 1;
            buttonRouteA.Text = "RouteA";
            buttonRouteA.UseVisualStyleBackColor = true;
            buttonRouteA.Click += buttonRouteA_Click;
            // 
            // buttonRouteB
            // 
            buttonRouteB.Location = new Point(566, 79);
            buttonRouteB.Name = "buttonRouteB";
            buttonRouteB.Size = new Size(124, 34);
            buttonRouteB.TabIndex = 2;
            buttonRouteB.Text = "RouteB";
            buttonRouteB.UseVisualStyleBackColor = true;
            buttonRouteB.Click += buttonRouteB_Click;
            // 
            // textBoxRepCount
            // 
            textBoxRepCount.Location = new Point(96, 46);
            textBoxRepCount.Name = "textBoxRepCount";
            textBoxRepCount.Size = new Size(125, 27);
            textBoxRepCount.TabIndex = 3;
            // 
            // labelRepCount
            // 
            labelRepCount.AutoSize = true;
            labelRepCount.Location = new Point(16, 49);
            labelRepCount.Name = "labelRepCount";
            labelRepCount.Size = new Size(74, 20);
            labelRepCount.TabIndex = 4;
            labelRepCount.Text = "RepCount";
            // 
            // DataCount
            // 
            DataCount.AutoSize = true;
            DataCount.Location = new Point(16, 82);
            DataCount.Name = "DataCount";
            DataCount.Size = new Size(80, 20);
            DataCount.TabIndex = 6;
            DataCount.Text = "DataCount";
            // 
            // textBoxDataCount
            // 
            textBoxDataCount.Location = new Point(96, 79);
            textBoxDataCount.Name = "textBoxDataCount";
            textBoxDataCount.Size = new Size(125, 27);
            textBoxDataCount.TabIndex = 5;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(696, 59);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(124, 34);
            buttonStop.TabIndex = 7;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelSett
            // 
            labelSett.AutoSize = true;
            labelSett.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSett.Location = new Point(11, 9);
            labelSett.Margin = new Padding(2, 0, 2, 0);
            labelSett.Name = "labelSett";
            labelSett.Size = new Size(200, 28);
            labelSett.TabIndex = 8;
            labelSett.Text = "Simulation settings:";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelResults.Location = new Point(11, 121);
            labelResults.Margin = new Padding(2, 0, 2, 0);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(79, 28);
            labelResults.TabIndex = 9;
            labelResults.Text = "Results";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(27, 163);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1343, 608);
            cartesianChart1.TabIndex = 10;
            // 
            // labelIgnore
            // 
            labelIgnore.AutoSize = true;
            labelIgnore.Location = new Point(281, 49);
            labelIgnore.Name = "labelIgnore";
            labelIgnore.Size = new Size(52, 20);
            labelIgnore.TabIndex = 12;
            labelIgnore.Text = "Ignore";
            // 
            // textBoxIgnore
            // 
            textBoxIgnore.Location = new Point(339, 46);
            textBoxIgnore.Name = "textBoxIgnore";
            textBoxIgnore.Size = new Size(33, 27);
            textBoxIgnore.TabIndex = 11;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.Location = new Point(378, 49);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(21, 20);
            labelPercentage.TabIndex = 13;
            labelPercentage.Text = "%";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(95, 122);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(131, 27);
            textBoxResult.TabIndex = 14;
            // 
            // RouteSimulation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 801);
            Controls.Add(textBoxResult);
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
            Controls.Add(buttonRouteB);
            Controls.Add(buttonRouteA);
            Controls.Add(button1);
            Name = "RouteSimulation";
            Text = "RouteSimulation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonRouteA;
        private Button buttonRouteB;
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
        private TextBox textBoxResult;
    }
}