namespace SalesRentals
{
    partial class Rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmRent = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(38, 78);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(965, 464);
            this.dataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Rent_ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rent_Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit_Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.btnBack.Location = new System.Drawing.Point(732, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(196, 58);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = " BACK";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirmRent
            // 
            this.btnConfirmRent.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmRent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmRent.BackgroundImage")));
            this.btnConfirmRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmRent.FlatAppearance.BorderSize = 0;
            this.btnConfirmRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmRent.ForeColor = System.Drawing.Color.White;
            this.btnConfirmRent.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmRent.Image")));
            this.btnConfirmRent.Location = new System.Drawing.Point(114, 579);
            this.btnConfirmRent.Name = "btnConfirmRent";
            this.btnConfirmRent.Size = new System.Drawing.Size(203, 58);
            this.btnConfirmRent.TabIndex = 58;
            this.btnConfirmRent.Text = " CONFIRM RENT";
            this.btnConfirmRent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmRent.UseVisualStyleBackColor = false;
            this.btnConfirmRent.Click += new System.EventHandler(this.btnConfirmRent_Click);
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMail.BackgroundImage")));
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.ForeColor = System.Drawing.Color.White;
            this.btnMail.Image = ((System.Drawing.Image)(resources.GetObject("btnMail.Image")));
            this.btnMail.Location = new System.Drawing.Point(417, 579);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(203, 58);
            this.btnMail.TabIndex = 60;
            this.btnMail.Text = " SEND MAIL";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirmRent);
            this.Controls.Add(this.dataGridView);
            this.Name = "Rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmRent;
        private System.Windows.Forms.Button btnMail;
    }
}