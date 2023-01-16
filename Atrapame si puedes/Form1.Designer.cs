namespace Atrapame_si_puedes
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
            this.Kilometros = new System.Windows.Forms.Label();
            this.Litros = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.rch_texto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Kilometros
            // 
            this.Kilometros.AutoSize = true;
            this.Kilometros.Location = new System.Drawing.Point(29, 47);
            this.Kilometros.Name = "Kilometros";
            this.Kilometros.Size = new System.Drawing.Size(64, 15);
            this.Kilometros.TabIndex = 0;
            this.Kilometros.Text = "Kilometros";
            // 
            // Litros
            // 
            this.Litros.AutoSize = true;
            this.Litros.Location = new System.Drawing.Point(29, 107);
            this.Litros.Name = "Litros";
            this.Litros.Size = new System.Drawing.Size(36, 15);
            this.Litros.TabIndex = 1;
            this.Litros.Text = "Litros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Calcular
            // 
            this.Calcular.AllowDrop = true;
            this.Calcular.Location = new System.Drawing.Point(29, 190);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(98, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // rch_texto
            // 
            this.rch_texto.Location = new System.Drawing.Point(206, 54);
            this.rch_texto.Name = "rch_texto";
            this.rch_texto.Size = new System.Drawing.Size(176, 159);
            this.rch_texto.TabIndex = 5;
            this.rch_texto.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 242);
            this.Controls.Add(this.rch_texto);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Litros);
            this.Controls.Add(this.Kilometros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Kilometros;
        private Label Litros;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Calcular;
        private RichTextBox rch_texto;
    }
}