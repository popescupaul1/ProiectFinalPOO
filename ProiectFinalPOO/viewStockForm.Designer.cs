namespace ProiectFinalPOO
{
    partial class viewStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewStockForm));
            this.listProduseV = new System.Windows.Forms.ListBox();
            this.buttonMeniu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProduseV
            // 
            this.listProduseV.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProduseV.FormattingEnabled = true;
            this.listProduseV.ItemHeight = 43;
            this.listProduseV.Location = new System.Drawing.Point(29, 31);
            this.listProduseV.Name = "listProduseV";
            this.listProduseV.Size = new System.Drawing.Size(1061, 692);
            this.listProduseV.TabIndex = 7;
            this.listProduseV.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listProduseV_DrawItem);
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.buttonMeniu.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeniu.Location = new System.Drawing.Point(450, 746);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.Size = new System.Drawing.Size(211, 64);
            this.buttonMeniu.TabIndex = 16;
            this.buttonMeniu.Text = "Meniu";
            this.buttonMeniu.UseVisualStyleBackColor = false;
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // viewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1121, 843);
            this.Controls.Add(this.buttonMeniu);
            this.Controls.Add(this.listProduseV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewStockForm";
            this.Text = "Stoc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProduseV;
        private System.Windows.Forms.Button buttonMeniu;
    }
}