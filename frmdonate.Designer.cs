namespace frmbkavhome
{
    partial class frmdonate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdonate));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.picBank = new System.Windows.Forms.PictureBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.pnlMobile = new System.Windows.Forms.Panel();
            this.picMobile = new System.Windows.Forms.PictureBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBank)).BeginInit();
            this.pnlMobile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMobile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Support Us";
            // 
            // pnlBank
            // 
            this.pnlBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBank.Controls.Add(this.picBank);
            this.pnlBank.Controls.Add(this.lblBank);
            this.pnlBank.Location = new System.Drawing.Point(12, 50);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(200, 300);
            this.pnlBank.TabIndex = 1;
            // 
            // picBank
            // 
            this.picBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBank.Image = global::frmbkavhome.Properties.Resources.donate_bank;
            this.picBank.Location = new System.Drawing.Point(10, 10);
            this.picBank.Name = "picBank";
            this.picBank.Size = new System.Drawing.Size(180, 195);
            this.picBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBank.TabIndex = 0;
            this.picBank.TabStop = false;
            // 
            // lblBank
            // 
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(5, 215);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(190, 30);
            this.lblBank.TabIndex = 1;
            this.lblBank.Text = "Support via Bank Transfer";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMobile
            // 
            this.pnlMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMobile.Controls.Add(this.picMobile);
            this.pnlMobile.Controls.Add(this.lblMobile);
            this.pnlMobile.Location = new System.Drawing.Point(223, 50);
            this.pnlMobile.Name = "pnlMobile";
            this.pnlMobile.Size = new System.Drawing.Size(200, 300);
            this.pnlMobile.TabIndex = 2;
            // 
            // picMobile
            // 
            this.picMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMobile.Image = global::frmbkavhome.Properties.Resources.donate_zp;
            this.picMobile.Location = new System.Drawing.Point(10, 10);
            this.picMobile.Name = "picMobile";
            this.picMobile.Size = new System.Drawing.Size(180, 195);
            this.picMobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMobile.TabIndex = 0;
            this.picMobile.TabStop = false;
            // 
            // lblMobile
            // 
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(5, 215);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(190, 30);
            this.lblMobile.TabIndex = 1;
            this.lblMobile.Text = "Support via Mobile Money";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmdonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 370);
            this.Controls.Add(this.pnlMobile);
            this.Controls.Add(this.pnlBank);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(451, 409);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(451, 409);
            this.Name = "frmdonate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donate";
            this.pnlBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBank)).EndInit();
            this.pnlMobile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBank;
        private System.Windows.Forms.PictureBox picBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Panel pnlMobile;
        private System.Windows.Forms.PictureBox picMobile;
        private System.Windows.Forms.Label lblMobile;
    }
}