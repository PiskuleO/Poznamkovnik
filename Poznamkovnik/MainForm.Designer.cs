namespace Poznamkovnik
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.buttonUpravit = new System.Windows.Forms.Button();
            this.buttonSmazat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 160);
            this.listBox1.TabIndex = 0;
            // 
            // buttonPridat
            // 
            this.buttonPridat.Location = new System.Drawing.Point(21, 218);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(75, 23);
            this.buttonPridat.TabIndex = 1;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // buttonUpravit
            // 
            this.buttonUpravit.Location = new System.Drawing.Point(102, 218);
            this.buttonUpravit.Name = "buttonUpravit";
            this.buttonUpravit.Size = new System.Drawing.Size(75, 23);
            this.buttonUpravit.TabIndex = 2;
            this.buttonUpravit.Text = "Upravit";
            this.buttonUpravit.UseVisualStyleBackColor = true;
            this.buttonUpravit.Click += new System.EventHandler(this.buttonUpravit_Click);
            // 
            // buttonSmazat
            // 
            this.buttonSmazat.Location = new System.Drawing.Point(183, 218);
            this.buttonSmazat.Name = "buttonSmazat";
            this.buttonSmazat.Size = new System.Drawing.Size(75, 23);
            this.buttonSmazat.TabIndex = 3;
            this.buttonSmazat.Text = "Smazat";
            this.buttonSmazat.UseVisualStyleBackColor = true;
            this.buttonSmazat.Click += new System.EventHandler(this.buttonSmazat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ulozitToolStripMenuItem,
            this.nacistToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // ulozitToolStripMenuItem
            // 
            this.ulozitToolStripMenuItem.Name = "ulozitToolStripMenuItem";
            this.ulozitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ulozitToolStripMenuItem.Text = "Uložit";
            this.ulozitToolStripMenuItem.Click += new System.EventHandler(this.ulozitToolStripMenuItem_Click);
            // 
            // nacistToolStripMenuItem
            // 
            this.nacistToolStripMenuItem.Name = "nacistToolStripMenuItem";
            this.nacistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nacistToolStripMenuItem.Text = "Načíst";
            this.nacistToolStripMenuItem.Click += new System.EventHandler(this.nacistToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seznam poznámek";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSmazat);
            this.Controls.Add(this.buttonUpravit);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Poznámkovník";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonPridat;
        private System.Windows.Forms.Button buttonUpravit;
        private System.Windows.Forms.Button buttonSmazat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulozitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacistToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}