
namespace praktikum1soal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsuhudari = new System.Windows.Forms.TextBox();
            this.cbsuhudari = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbcelcius = new System.Windows.Forms.RadioButton();
            this.rbfahrenheit = new System.Windows.Forms.RadioButton();
            this.rbreamur = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONVERSI SUHU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUHU";
            // 
            // txtsuhudari
            // 
            this.txtsuhudari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuhudari.Location = new System.Drawing.Point(105, 92);
            this.txtsuhudari.Multiline = true;
            this.txtsuhudari.Name = "txtsuhudari";
            this.txtsuhudari.Size = new System.Drawing.Size(147, 26);
            this.txtsuhudari.TabIndex = 2;
            // 
            // cbsuhudari
            // 
            this.cbsuhudari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsuhudari.FormattingEnabled = true;
            this.cbsuhudari.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur"});
            this.cbsuhudari.Location = new System.Drawing.Point(288, 93);
            this.cbsuhudari.Name = "cbsuhudari";
            this.cbsuhudari.Size = new System.Drawing.Size(121, 28);
            this.cbsuhudari.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "KE";
            // 
            // rbcelcius
            // 
            this.rbcelcius.AutoSize = true;
            this.rbcelcius.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcelcius.Location = new System.Drawing.Point(104, 136);
            this.rbcelcius.Name = "rbcelcius";
            this.rbcelcius.Size = new System.Drawing.Size(90, 32);
            this.rbcelcius.TabIndex = 5;
            this.rbcelcius.TabStop = true;
            this.rbcelcius.Text = "Celcius";
            this.rbcelcius.UseVisualStyleBackColor = true;
            // 
            // rbfahrenheit
            // 
            this.rbfahrenheit.AutoSize = true;
            this.rbfahrenheit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfahrenheit.Location = new System.Drawing.Point(104, 171);
            this.rbfahrenheit.Name = "rbfahrenheit";
            this.rbfahrenheit.Size = new System.Drawing.Size(121, 32);
            this.rbfahrenheit.TabIndex = 6;
            this.rbfahrenheit.TabStop = true;
            this.rbfahrenheit.Text = "Fahrenheit";
            this.rbfahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbreamur
            // 
            this.rbreamur.AutoSize = true;
            this.rbreamur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbreamur.Location = new System.Drawing.Point(104, 206);
            this.rbreamur.Name = "rbreamur";
            this.rbreamur.Size = new System.Drawing.Size(96, 32);
            this.rbreamur.TabIndex = 7;
            this.rbreamur.TabStop = true;
            this.rbreamur.Text = "Reamur";
            this.rbreamur.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "KONVERSI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "HASIL";
            // 
            // txthasil
            // 
            this.txthasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthasil.Location = new System.Drawing.Point(174, 351);
            this.txthasil.Multiline = true;
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(181, 31);
            this.txthasil.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbreamur);
            this.Controls.Add(this.rbfahrenheit);
            this.Controls.Add(this.rbcelcius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbsuhudari);
            this.Controls.Add(this.txtsuhudari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TUGAS PRAKTIKUM (19SA1138)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsuhudari;
        private System.Windows.Forms.ComboBox cbsuhudari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbcelcius;
        private System.Windows.Forms.RadioButton rbfahrenheit;
        private System.Windows.Forms.RadioButton rbreamur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthasil;
    }
}

