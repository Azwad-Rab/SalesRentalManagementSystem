namespace SalesRentals
{
    partial class form_productVsPrice
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_productVsPrice));
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoadPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product vs Price";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(78, 136);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Price";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(983, 402);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(789, 585);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(196, 58);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = " BACK";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoadPrice
            // 
            this.btnLoadPrice.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadPrice.BackgroundImage")));
            this.btnLoadPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPrice.FlatAppearance.BorderSize = 0;
            this.btnLoadPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPrice.ForeColor = System.Drawing.Color.White;
            this.btnLoadPrice.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPrice.Image")));
            this.btnLoadPrice.Location = new System.Drawing.Point(137, 585);
            this.btnLoadPrice.Name = "btnLoadPrice";
            this.btnLoadPrice.Size = new System.Drawing.Size(208, 58);
            this.btnLoadPrice.TabIndex = 64;
            this.btnLoadPrice.Text = " LOAD CHART";
            this.btnLoadPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPrice.UseVisualStyleBackColor = false;
            this.btnLoadPrice.Click += new System.EventHandler(this.btnLoadPrice_Click);
            // 
            // form_productVsPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1125, 690);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoadPrice);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Name = "form_productVsPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Vs Price";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoadPrice;
    }
}