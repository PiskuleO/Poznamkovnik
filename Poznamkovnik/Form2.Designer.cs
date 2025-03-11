namespace Poznamkovnik
{
    partial class Form2
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
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonZrusit = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(12, 28);
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazev.TabIndex = 0;
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(309, 28);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 1;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // buttonZrusit
            // 
            this.buttonZrusit.Location = new System.Drawing.Point(390, 28);
            this.buttonZrusit.Name = "buttonZrusit";
            this.buttonZrusit.Size = new System.Drawing.Size(75, 23);
            this.buttonZrusit.TabIndex = 2;
            this.buttonZrusit.Text = "Zrušit";
            this.buttonZrusit.UseVisualStyleBackColor = true;
            this.buttonZrusit.Click += new System.EventHandler(this.buttonZrusit_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(118, 28);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(185, 20);
            this.textBoxText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazev poznamky";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Poznamka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 67);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.buttonZrusit);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.textBoxNazev);
            this.Name = "Form2";
            this.Text = "Úprava poznámky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Button buttonZrusit;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}