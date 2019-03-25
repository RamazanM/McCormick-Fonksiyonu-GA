namespace GenetikAlgoritma
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iterateBtn = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startButton = new System.Windows.Forms.Button();
            this.initPopulation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eliteCountNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.populationSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.mutationRateTxt = new System.Windows.Forms.TextBox();
            this.crossoverRateTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iterateCountNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterateCountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(18, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(668, 330);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // iterateBtn
            // 
            this.iterateBtn.Location = new System.Drawing.Point(29, 600);
            this.iterateBtn.Name = "iterateBtn";
            this.iterateBtn.Size = new System.Drawing.Size(134, 23);
            this.iterateBtn.TabIndex = 1;
            this.iterateBtn.Text = "Iterate";
            this.iterateBtn.UseVisualStyleBackColor = true;
            this.iterateBtn.Click += new System.EventHandler(this.iterateBtn_Click);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(222, 348);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(464, 290);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(29, 571);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(134, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // initPopulation
            // 
            this.initPopulation.Location = new System.Drawing.Point(29, 542);
            this.initPopulation.Name = "initPopulation";
            this.initPopulation.Size = new System.Drawing.Size(134, 23);
            this.initPopulation.TabIndex = 4;
            this.initPopulation.Text = "Initialize Population";
            this.initPopulation.UseVisualStyleBackColor = true;
            this.initPopulation.Click += new System.EventHandler(this.initPopulation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mutation Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Crossover Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Elite Count:";
            // 
            // eliteCountNUD
            // 
            this.eliteCountNUD.Location = new System.Drawing.Point(126, 423);
            this.eliteCountNUD.Name = "eliteCountNUD";
            this.eliteCountNUD.Size = new System.Drawing.Size(63, 20);
            this.eliteCountNUD.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Population Size:";
            // 
            // populationSizeNUD
            // 
            this.populationSizeNUD.Location = new System.Drawing.Point(126, 449);
            this.populationSizeNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.populationSizeNUD.Name = "populationSizeNUD";
            this.populationSizeNUD.Size = new System.Drawing.Size(63, 20);
            this.populationSizeNUD.TabIndex = 13;
            this.populationSizeNUD.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // mutationRateTxt
            // 
            this.mutationRateTxt.Location = new System.Drawing.Point(126, 365);
            this.mutationRateTxt.Name = "mutationRateTxt";
            this.mutationRateTxt.Size = new System.Drawing.Size(63, 20);
            this.mutationRateTxt.TabIndex = 14;
            // 
            // crossoverRateTxt
            // 
            this.crossoverRateTxt.Location = new System.Drawing.Point(126, 397);
            this.crossoverRateTxt.Name = "crossoverRateTxt";
            this.crossoverRateTxt.Size = new System.Drawing.Size(63, 20);
            this.crossoverRateTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Iterate For:";
            // 
            // iterateCountNUD
            // 
            this.iterateCountNUD.Location = new System.Drawing.Point(126, 476);
            this.iterateCountNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.iterateCountNUD.Name = "iterateCountNUD";
            this.iterateCountNUD.Size = new System.Drawing.Size(63, 20);
            this.iterateCountNUD.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 646);
            this.Controls.Add(this.iterateCountNUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crossoverRateTxt);
            this.Controls.Add(this.mutationRateTxt);
            this.Controls.Add(this.populationSizeNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eliteCountNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initPopulation);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.iterateBtn);
            this.Controls.Add(this.chart1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "McCormick Fonksiyonu - Genetik Algoritma Örneği";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterateCountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button iterateBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button initPopulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown eliteCountNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown populationSizeNUD;
        private System.Windows.Forms.TextBox mutationRateTxt;
        private System.Windows.Forms.TextBox crossoverRateTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown iterateCountNUD;
    }
}

