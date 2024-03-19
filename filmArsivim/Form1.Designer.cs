namespace filmArsivim
{
    partial class Form1
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
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.btnElestiriler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AllowUserToAddRows = false;
            this.dgvFilmler.AllowUserToDeleteRows = false;
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(3, 189);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.ReadOnly = true;
            this.dgvFilmler.Size = new System.Drawing.Size(795, 265);
            this.dgvFilmler.TabIndex = 0;
            // 
            // btnElestiriler
            // 
            this.btnElestiriler.Location = new System.Drawing.Point(619, 157);
            this.btnElestiriler.Name = "btnElestiriler";
            this.btnElestiriler.Size = new System.Drawing.Size(116, 23);
            this.btnElestiriler.TabIndex = 1;
            this.btnElestiriler.Text = "Elestiriler";
            this.btnElestiriler.UseVisualStyleBackColor = true;
            this.btnElestiriler.Click += new System.EventHandler(this.btnElestiriler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElestiriler);
            this.Controls.Add(this.dgvFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.Button btnElestiriler;
    }
}

