namespace ProiectFinalPOO
{
    partial class FacturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaForm));
            this.pictureBoxFactura = new System.Windows.Forms.PictureBox();
            this.buttonGenFactura = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFactura
            // 
            this.pictureBoxFactura.BackColor = System.Drawing.Color.White;
            this.pictureBoxFactura.Location = new System.Drawing.Point(30, 32);
            this.pictureBoxFactura.Name = "pictureBoxFactura";
            this.pictureBoxFactura.Size = new System.Drawing.Size(1430, 1198);
            this.pictureBoxFactura.TabIndex = 0;
            this.pictureBoxFactura.TabStop = false;
            // 
            // buttonGenFactura
            // 
            this.buttonGenFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.buttonGenFactura.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenFactura.Location = new System.Drawing.Point(371, 1269);
            this.buttonGenFactura.Name = "buttonGenFactura";
            this.buttonGenFactura.Size = new System.Drawing.Size(211, 64);
            this.buttonGenFactura.TabIndex = 16;
            this.buttonGenFactura.Text = "Printeaza factura";
            this.buttonGenFactura.UseVisualStyleBackColor = false;
            this.buttonGenFactura.Click += new System.EventHandler(this.buttonGenFactura_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(898, 1269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 64);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salveaza ca .png";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1505, 1349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGenFactura);
            this.Controls.Add(this.pictureBoxFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturaForm";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFactura;
        private System.Windows.Forms.Button buttonGenFactura;
        private System.Windows.Forms.Button button1;
    }
}