namespace ProiectFinalPOO
{
    partial class storeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.listProduse = new System.Windows.Forms.ListBox();
            this.buttonDeconecteaza = new System.Windows.Forms.Button();
            this.listCos = new System.Windows.Forms.ListBox();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaProduseleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGenFactura = new System.Windows.Forms.Button();
            this.PBCodBare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCodBare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(22, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(187, 133);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1076, 56);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // buttonCauta
            // 
            this.buttonCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.buttonCauta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCauta.BackgroundImage")));
            this.buttonCauta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCauta.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonCauta.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Image = ((System.Drawing.Image)(resources.GetObject("buttonCauta.Image")));
            this.buttonCauta.Location = new System.Drawing.Point(1292, 124);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(135, 83);
            this.buttonCauta.TabIndex = 4;
            this.buttonCauta.UseVisualStyleBackColor = false;
            // 
            // listProduse
            // 
            this.listProduse.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProduse.FormattingEnabled = true;
            this.listProduse.ItemHeight = 43;
            this.listProduse.Location = new System.Drawing.Point(41, 279);
            this.listProduse.Name = "listProduse";
            this.listProduse.Size = new System.Drawing.Size(707, 606);
            this.listProduse.TabIndex = 6;
            this.listProduse.SelectedIndexChanged += new System.EventHandler(this.listProduse_SelectedIndexChanged);
            // 
            // buttonDeconecteaza
            // 
            this.buttonDeconecteaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.buttonDeconecteaza.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconecteaza.Location = new System.Drawing.Point(1233, 821);
            this.buttonDeconecteaza.Name = "buttonDeconecteaza";
            this.buttonDeconecteaza.Size = new System.Drawing.Size(211, 64);
            this.buttonDeconecteaza.TabIndex = 8;
            this.buttonDeconecteaza.Text = "Deconecteaza-te";
            this.buttonDeconecteaza.UseVisualStyleBackColor = false;
            this.buttonDeconecteaza.Click += new System.EventHandler(this.buttonDeconecteaza_Click);
            // 
            // listCos
            // 
            this.listCos.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCos.FormattingEnabled = true;
            this.listCos.ItemHeight = 43;
            this.listCos.Location = new System.Drawing.Point(801, 290);
            this.listCos.Name = "listCos";
            this.listCos.Size = new System.Drawing.Size(665, 391);
            this.listCos.TabIndex = 13;
            this.listCos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listCos_DrawItem);
            this.listCos.SelectedIndexChanged += new System.EventHandler(this.listCos_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicatieToolStripMenuItem,
            this.contToolStripMenuItem,
            this.incarcaProduseleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 36);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicatieToolStripMenuItem
            // 
            this.aplicatieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.aplicatieToolStripMenuItem.Name = "aplicatieToolStripMenuItem";
            this.aplicatieToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.aplicatieToolStripMenuItem.Text = "Aplicatie";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // contToolStripMenuItem
            // 
            this.contToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconectareToolStripMenuItem});
            this.contToolStripMenuItem.Name = "contToolStripMenuItem";
            this.contToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.contToolStripMenuItem.Text = "Cont";
            // 
            // deconectareToolStripMenuItem
            // 
            this.deconectareToolStripMenuItem.Name = "deconectareToolStripMenuItem";
            this.deconectareToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.deconectareToolStripMenuItem.Text = "Deconectare";
            this.deconectareToolStripMenuItem.Click += new System.EventHandler(this.deconectareToolStripMenuItem_Click);
            // 
            // incarcaProduseleToolStripMenuItem
            // 
            this.incarcaProduseleToolStripMenuItem.Name = "incarcaProduseleToolStripMenuItem";
            this.incarcaProduseleToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.incarcaProduseleToolStripMenuItem.Text = "Incarca Produsele";
            this.incarcaProduseleToolStripMenuItem.Click += new System.EventHandler(this.incarcaProduseleToolStripMenuItem_Click);
            // 
            // buttonGenFactura
            // 
            this.buttonGenFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.buttonGenFactura.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenFactura.Location = new System.Drawing.Point(1233, 723);
            this.buttonGenFactura.Name = "buttonGenFactura";
            this.buttonGenFactura.Size = new System.Drawing.Size(211, 64);
            this.buttonGenFactura.TabIndex = 15;
            this.buttonGenFactura.Text = "Generare Factura";
            this.buttonGenFactura.UseVisualStyleBackColor = false;
            this.buttonGenFactura.Click += new System.EventHandler(this.buttonGenFactura_Click);
            // 
            // PBCodBare
            // 
            this.PBCodBare.BackColor = System.Drawing.Color.White;
            this.PBCodBare.Location = new System.Drawing.Point(812, 723);
            this.PBCodBare.Name = "PBCodBare";
            this.PBCodBare.Size = new System.Drawing.Size(379, 162);
            this.PBCodBare.TabIndex = 16;
            this.PBCodBare.TabStop = false;
            // 
            // storeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(97)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBCodBare);
            this.Controls.Add(this.buttonGenFactura);
            this.Controls.Add(this.listCos);
            this.Controls.Add(this.buttonDeconecteaza);
            this.Controls.Add(this.listProduse);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "storeForm";
            this.Text = "Magazin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCodBare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.ListBox listProduse;
        private System.Windows.Forms.Button buttonDeconecteaza;
        private System.Windows.Forms.ListBox listCos;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconectareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaProduseleToolStripMenuItem;
        private System.Windows.Forms.Button buttonGenFactura;
        private System.Windows.Forms.PictureBox PBCodBare;
    }
}