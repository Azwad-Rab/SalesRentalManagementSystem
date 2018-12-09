namespace SalesRentals
{
    partial class form_graphInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_graphInfo));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadStock = new System.Windows.Forms.Button();
            this.btnPVP = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(58, 110);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Stock";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(737, 327);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product vs Stock";
            // 
            // btnLoadStock
            // 
            this.btnLoadStock.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadStock.BackgroundImage")));
            this.btnLoadStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadStock.FlatAppearance.BorderSize = 0;
            this.btnLoadStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadStock.ForeColor = System.Drawing.Color.White;
            this.btnLoadStock.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadStock.Image")));
            this.btnLoadStock.Location = new System.Drawing.Point(111, 474);
            this.btnLoadStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadStock.Name = "btnLoadStock";
            this.btnLoadStock.Size = new System.Drawing.Size(156, 47);
            this.btnLoadStock.TabIndex = 61;
            this.btnLoadStock.Text = " LOAD CHART";
            this.btnLoadStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadStock.UseVisualStyleBackColor = false;
            this.btnLoadStock.Click += new System.EventHandler(this.btnLoadStock_Click);
            // 
            // btnPVP
            // 
            this.btnPVP.BackColor = System.Drawing.Color.Transparent;
            this.btnPVP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPVP.BackgroundImage")));
            this.btnPVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPVP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPVP.FlatAppearance.BorderSize = 0;
            this.btnPVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPVP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPVP.ForeColor = System.Drawing.Color.White;
            this.btnPVP.Image = ((System.Drawing.Image)(resources.GetObject("btnPVP.Image")));
            this.btnPVP.Location = new System.Drawing.Point(332, 474);
            this.btnPVP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPVP.Name = "btnPVP";
            this.btnPVP.Size = new System.Drawing.Size(194, 47);
            this.btnPVP.TabIndex = 62;
            this.btnPVP.Text = " PRODUCT vs PRICE";
            this.btnPVP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPVP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPVP.UseVisualStyleBackColor = false;
            this.btnPVP.Click += new System.EventHandler(this.btnPVP_Click);
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
            this.btnBack.Location = new System.Drawing.Point(600, 474);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 47);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = " BACK";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // form_graphInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPVP);
            this.Controls.Add(this.btnLoadStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_graphInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Info";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadStock;
        private System.Windows.Forms.Button btnPVP;
        private System.Windows.Forms.Button btnBack;
    }
}