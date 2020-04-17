namespace GA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numAltSin = new System.Windows.Forms.NumericUpDown();
            this.numUstSin = new System.Windows.Forms.NumericUpDown();
            this.numXn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCaprazlamaOlasilik = new System.Windows.Forms.NumericUpDown();
            this.numMutasyonOrani = new System.Windows.Forms.NumericUpDown();
            this.numIterasyon = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numPopulasyonBoyutu = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltSin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUstSin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaprazlamaOlasilik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutasyonOrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulasyonBoyutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.numXn);
            this.panel2.Controls.Add(this.numUstSin);
            this.panel2.Controls.Add(this.numAltSin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numIterasyon);
            this.panel2.Controls.Add(this.numMutasyonOrani);
            this.panel2.Controls.Add(this.numPopulasyonBoyutu);
            this.panel2.Controls.Add(this.numCaprazlamaOlasilik);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 623);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alt Sınır :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üst Sınır :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "X-> n (>1) :";
            // 
            // numAltSin
            // 
            this.numAltSin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numAltSin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAltSin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numAltSin.Location = new System.Drawing.Point(149, 153);
            this.numAltSin.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numAltSin.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.numAltSin.Name = "numAltSin";
            this.numAltSin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numAltSin.Size = new System.Drawing.Size(78, 20);
            this.numAltSin.TabIndex = 1;
            // 
            // numUstSin
            // 
            this.numUstSin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numUstSin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUstSin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numUstSin.Location = new System.Drawing.Point(149, 189);
            this.numUstSin.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numUstSin.Minimum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            -2147483648});
            this.numUstSin.Name = "numUstSin";
            this.numUstSin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numUstSin.Size = new System.Drawing.Size(78, 20);
            this.numUstSin.TabIndex = 1;
            // 
            // numXn
            // 
            this.numXn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numXn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numXn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numXn.Location = new System.Drawing.Point(149, 225);
            this.numXn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXn.Name = "numXn";
            this.numXn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numXn.Size = new System.Drawing.Size(78, 20);
            this.numXn.TabIndex = 1;
            this.numXn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çaprazlama Oranı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mutasyon Oranı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "İterasyon Sayısı :";
            // 
            // numCaprazlamaOlasilik
            // 
            this.numCaprazlamaOlasilik.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numCaprazlamaOlasilik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCaprazlamaOlasilik.DecimalPlaces = 2;
            this.numCaprazlamaOlasilik.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numCaprazlamaOlasilik.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCaprazlamaOlasilik.Location = new System.Drawing.Point(149, 384);
            this.numCaprazlamaOlasilik.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCaprazlamaOlasilik.Name = "numCaprazlamaOlasilik";
            this.numCaprazlamaOlasilik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numCaprazlamaOlasilik.Size = new System.Drawing.Size(78, 20);
            this.numCaprazlamaOlasilik.TabIndex = 1;
            this.numCaprazlamaOlasilik.ThousandsSeparator = true;
            // 
            // numMutasyonOrani
            // 
            this.numMutasyonOrani.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numMutasyonOrani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMutasyonOrani.DecimalPlaces = 3;
            this.numMutasyonOrani.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numMutasyonOrani.Increment = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            this.numMutasyonOrani.Location = new System.Drawing.Point(149, 422);
            this.numMutasyonOrani.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMutasyonOrani.Name = "numMutasyonOrani";
            this.numMutasyonOrani.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numMutasyonOrani.Size = new System.Drawing.Size(78, 20);
            this.numMutasyonOrani.TabIndex = 1;
            // 
            // numIterasyon
            // 
            this.numIterasyon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numIterasyon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numIterasyon.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numIterasyon.Location = new System.Drawing.Point(149, 460);
            this.numIterasyon.Maximum = new decimal(new int[] {
            9100,
            0,
            0,
            0});
            this.numIterasyon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIterasyon.Name = "numIterasyon";
            this.numIterasyon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numIterasyon.Size = new System.Drawing.Size(78, 20);
            this.numIterasyon.TabIndex = 1;
            this.numIterasyon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Populasyon Boyutu :";
            // 
            // numPopulasyonBoyutu
            // 
            this.numPopulasyonBoyutu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numPopulasyonBoyutu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPopulasyonBoyutu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numPopulasyonBoyutu.Location = new System.Drawing.Point(149, 346);
            this.numPopulasyonBoyutu.Maximum = new decimal(new int[] {
            9100,
            0,
            0,
            0});
            this.numPopulasyonBoyutu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPopulasyonBoyutu.Name = "numPopulasyonBoyutu";
            this.numPopulasyonBoyutu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPopulasyonBoyutu.Size = new System.Drawing.Size(78, 20);
            this.numPopulasyonBoyutu.TabIndex = 1;
            this.numPopulasyonBoyutu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Rubik", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "SPHERE F DEGERLERİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Rubik", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "PARAMETRELER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(13, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "TAMAM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(247, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.EmptyPointStyle.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series1.EmptyPointStyle.BorderWidth = 3;
            series1.LabelForeColor = System.Drawing.Color.Maroon;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 2;
            series1.Name = "Eniyidegerler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(933, 599);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 623);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Genetik Algoritma";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltSin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUstSin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaprazlamaOlasilik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutasyonOrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulasyonBoyutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numXn;
        private System.Windows.Forms.NumericUpDown numUstSin;
        private System.Windows.Forms.NumericUpDown numAltSin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numIterasyon;
        private System.Windows.Forms.NumericUpDown numMutasyonOrani;
        private System.Windows.Forms.NumericUpDown numPopulasyonBoyutu;
        private System.Windows.Forms.NumericUpDown numCaprazlamaOlasilik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

