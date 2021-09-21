namespace Fordonsregister
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
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.tbxMärke = new System.Windows.Forms.TextBox();
            this.tbxModell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTyp = new System.Windows.Forms.ComboBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.lbxRegister = new System.Windows.Forms.ListBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.rbnMC = new System.Windows.Forms.RadioButton();
            this.rbnBilar = new System.Windows.Forms.RadioButton();
            this.rbnFilter = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Location = new System.Drawing.Point(92, 182);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(121, 26);
            this.tbxRegNr.TabIndex = 0;
            // 
            // tbxMärke
            // 
            this.tbxMärke.Location = new System.Drawing.Point(92, 225);
            this.tbxMärke.Name = "tbxMärke";
            this.tbxMärke.Size = new System.Drawing.Size(121, 26);
            this.tbxMärke.TabIndex = 1;
            // 
            // tbxModell
            // 
            this.tbxModell.Location = new System.Drawing.Point(92, 266);
            this.tbxModell.Name = "tbxModell";
            this.tbxModell.Size = new System.Drawing.Size(121, 26);
            this.tbxModell.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reg-nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Register";
            // 
            // cbxTyp
            // 
            this.cbxTyp.FormattingEnabled = true;
            this.cbxTyp.Items.AddRange(new object[] {
            "Bil",
            "MC"});
            this.cbxTyp.Location = new System.Drawing.Point(92, 306);
            this.cbxTyp.Name = "cbxTyp";
            this.cbxTyp.Size = new System.Drawing.Size(121, 28);
            this.cbxTyp.TabIndex = 8;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(92, 362);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(121, 42);
            this.btnRegistrera.TabIndex = 9;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            // 
            // lbxRegister
            // 
            this.lbxRegister.FormattingEnabled = true;
            this.lbxRegister.ItemHeight = 20;
            this.lbxRegister.Location = new System.Drawing.Point(246, 62);
            this.lbxRegister.Name = "lbxRegister";
            this.lbxRegister.Size = new System.Drawing.Size(234, 264);
            this.lbxRegister.TabIndex = 10;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.rbnMC);
            this.gbxFilter.Controls.Add(this.rbnBilar);
            this.gbxFilter.Controls.Add(this.rbnFilter);
            this.gbxFilter.Location = new System.Drawing.Point(246, 342);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(234, 72);
            this.gbxFilter.TabIndex = 11;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Visa";
            // 
            // rbnMC
            // 
            this.rbnMC.AutoSize = true;
            this.rbnMC.Location = new System.Drawing.Point(161, 24);
            this.rbnMC.Name = "rbnMC";
            this.rbnMC.Size = new System.Drawing.Size(58, 24);
            this.rbnMC.TabIndex = 2;
            this.rbnMC.TabStop = true;
            this.rbnMC.Text = "MC";
            this.rbnMC.UseVisualStyleBackColor = true;
            // 
            // rbnBilar
            // 
            this.rbnBilar.AutoSize = true;
            this.rbnBilar.Location = new System.Drawing.Point(81, 25);
            this.rbnBilar.Name = "rbnBilar";
            this.rbnBilar.Size = new System.Drawing.Size(65, 24);
            this.rbnBilar.TabIndex = 1;
            this.rbnBilar.TabStop = true;
            this.rbnBilar.Text = "Bilar";
            this.rbnBilar.UseVisualStyleBackColor = true;
            // 
            // rbnFilter
            // 
            this.rbnFilter.AutoSize = true;
            this.rbnFilter.Location = new System.Drawing.Point(15, 25);
            this.rbnFilter.Name = "rbnFilter";
            this.rbnFilter.Size = new System.Drawing.Size(60, 24);
            this.rbnFilter.TabIndex = 0;
            this.rbnFilter.TabStop = true;
            this.rbnFilter.Text = "Alla";
            this.rbnFilter.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fordonsregister.Properties.Resources.bil;
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.lbxRegister);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.cbxTyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxModell);
            this.Controls.Add(this.tbxMärke);
            this.Controls.Add(this.tbxRegNr);
            this.Name = "Form1";
            this.Text = "Bilregistret";
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRegNr;
        private System.Windows.Forms.TextBox tbxMärke;
        private System.Windows.Forms.TextBox tbxModell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTyp;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.ListBox lbxRegister;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.RadioButton rbnMC;
        private System.Windows.Forms.RadioButton rbnBilar;
        private System.Windows.Forms.RadioButton rbnFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

