
namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtResultado = new System.Windows.Forms.Label();
            this.TxtTitulo2 = new System.Windows.Forms.Label();
            this.TxtTitulo1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResultado
            // 
            this.TxtResultado.AutoSize = true;
            this.TxtResultado.Location = new System.Drawing.Point(429, 177);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(38, 15);
            this.TxtResultado.TabIndex = 15;
            this.TxtResultado.Text = "label3";
            // 
            // TxtTitulo2
            // 
            this.TxtTitulo2.AutoSize = true;
            this.TxtTitulo2.Location = new System.Drawing.Point(429, 100);
            this.TxtTitulo2.Name = "TxtTitulo2";
            this.TxtTitulo2.Size = new System.Drawing.Size(59, 15);
            this.TxtTitulo2.TabIndex = 14;
            this.TxtTitulo2.Text = "Resultado";
            // 
            // TxtTitulo1
            // 
            this.TxtTitulo1.AutoSize = true;
            this.TxtTitulo1.Location = new System.Drawing.Point(106, 80);
            this.TxtTitulo1.Name = "TxtTitulo1";
            this.TxtTitulo1.Size = new System.Drawing.Size(94, 15);
            this.TxtTitulo1.TabIndex = 13;
            this.TxtTitulo1.Text = "Digitar Números";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 23);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 23);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 23);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 23);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 357);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtTitulo2);
            this.Controls.Add(this.TxtTitulo1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtResultado;
        private System.Windows.Forms.Label TxtTitulo2;
        private System.Windows.Forms.Label TxtTitulo1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

