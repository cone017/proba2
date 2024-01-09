namespace PrimerKolokvijumaVert
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxSpeciality = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonVise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(26, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 224);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speciality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Years of Experience";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(120, 277);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(162, 26);
            this.textBoxFullName.TabIndex = 4;
            // 
            // textBoxSpeciality
            // 
            this.textBoxSpeciality.Location = new System.Drawing.Point(120, 316);
            this.textBoxSpeciality.Name = "textBoxSpeciality";
            this.textBoxSpeciality.Size = new System.Drawing.Size(162, 26);
            this.textBoxSpeciality.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(182, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(332, 279);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(107, 85);
            this.btnUnesi.TabIndex = 7;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vise od";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 394);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 9;
            // 
            // buttonVise
            // 
            this.buttonVise.Location = new System.Drawing.Point(26, 426);
            this.buttonVise.Name = "buttonVise";
            this.buttonVise.Size = new System.Drawing.Size(75, 45);
            this.buttonVise.TabIndex = 10;
            this.buttonVise.Text = "Vise";
            this.buttonVise.UseVisualStyleBackColor = true;
            this.buttonVise.Click += new System.EventHandler(this.buttonVise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.Controls.Add(this.buttonVise);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSpeciality);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxSpeciality;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonVise;
    }
}

