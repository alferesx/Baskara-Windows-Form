namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox = new System.Windows.Forms.TextBox();
            this.bbox = new System.Windows.Forms.TextBox();
            this.abox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deltabox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(118, 593);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(104, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calcular Delta";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "c";
            // 
            // cbox
            // 
            this.cbox.Location = new System.Drawing.Point(118, 330);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(100, 22);
            this.cbox.TabIndex = 7;
            this.cbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bbox
            // 
            this.bbox.Location = new System.Drawing.Point(118, 285);
            this.bbox.Name = "bbox";
            this.bbox.Size = new System.Drawing.Size(100, 22);
            this.bbox.TabIndex = 8;
            this.bbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // abox
            // 
            this.abox.Location = new System.Drawing.Point(118, 240);
            this.abox.Name = "abox";
            this.abox.Size = new System.Drawing.Size(100, 22);
            this.abox.TabIndex = 9;
            this.abox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Baskara";
            // 
            // deltabox
            // 
            this.deltabox.Location = new System.Drawing.Point(118, 393);
            this.deltabox.Name = "deltabox";
            this.deltabox.Size = new System.Drawing.Size(100, 22);
            this.deltabox.TabIndex = 11;
            this.deltabox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Delta";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(118, 468);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 22);
            this.x1.TabIndex = 13;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(119, 448);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(22, 17);
            this.label.TabIndex = 14;
            this.label.Text = "x1";
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(118, 544);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 22);
            this.x2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "x2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deltabox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abox);
            this.Controls.Add(this.bbox);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cbox;
        private System.Windows.Forms.TextBox bbox;
        private System.Windows.Forms.TextBox abox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deltabox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label label6;
    }
}

