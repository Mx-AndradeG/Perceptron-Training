namespace entrenamientoDePerceptrones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbW0 = new System.Windows.Forms.TextBox();
            this.tbW2 = new System.Windows.Forms.TextBox();
            this.tbW1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.upCompuerta = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrenamiento de Perceptrones";
            // 
            // tbW0
            // 
            this.tbW0.Location = new System.Drawing.Point(7, 107);
            this.tbW0.Name = "tbW0";
            this.tbW0.Size = new System.Drawing.Size(69, 20);
            this.tbW0.TabIndex = 1;
            // 
            // tbW2
            // 
            this.tbW2.Location = new System.Drawing.Point(254, 107);
            this.tbW2.Name = "tbW2";
            this.tbW2.Size = new System.Drawing.Size(69, 20);
            this.tbW2.TabIndex = 2;
            // 
            // tbW1
            // 
            this.tbW1.Location = new System.Drawing.Point(129, 107);
            this.tbW1.Name = "tbW1";
            this.tbW1.Size = new System.Drawing.Size(75, 20);
            this.tbW1.TabIndex = 3;
            this.tbW1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "w0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "w1";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.Location = new System.Drawing.Point(276, 81);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(34, 23);
            this.labelx.TabIndex = 6;
            this.labelx.Text = "w2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upCompuerta
            // 
            this.upCompuerta.InterceptArrowKeys = false;
            this.upCompuerta.Items.Add("AND");
            this.upCompuerta.Items.Add("OR");
            this.upCompuerta.Items.Add("NOT");
            this.upCompuerta.Location = new System.Drawing.Point(367, 12);
            this.upCompuerta.Name = "upCompuerta";
            this.upCompuerta.ReadOnly = true;
            this.upCompuerta.Size = new System.Drawing.Size(74, 20);
            this.upCompuerta.TabIndex = 8;
            this.upCompuerta.Text = "seleccione";
            this.upCompuerta.SelectedItemChanged += new System.EventHandler(this.upCompuerta_SelectedItemChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Inserte los pesos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Factor de aprendizaje";
            // 
            // tbFa
            // 
            this.tbFa.Location = new System.Drawing.Point(372, 107);
            this.tbFa.Name = "tbFa";
            this.tbFa.Size = new System.Drawing.Size(69, 20);
            this.tbFa.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 206);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upCompuerta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbW1);
            this.Controls.Add(this.tbW2);
            this.Controls.Add(this.tbW0);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbW0;
        private System.Windows.Forms.TextBox tbW2;
        private System.Windows.Forms.TextBox tbW1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown upCompuerta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFa;
    }
}

