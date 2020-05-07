namespace Calculadora_Cálculos_Básicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULOS BÁSICOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE O 1° NÚMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIGITE O 2° NÚMERO";
            // 
            // txtNum1
            // 
            this.txtNum1.ForeColor = System.Drawing.Color.Red;
            this.txtNum1.Location = new System.Drawing.Point(332, 184);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(5);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(211, 30);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.ForeColor = System.Drawing.Color.Red;
            this.txtNum2.Location = new System.Drawing.Point(332, 224);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(5);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(211, 30);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 534);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "RESULTADO";
            // 
            // txtResultado
            // 
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(302, 531);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(241, 30);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.HotPink;
            this.btnSomar.FlatAppearance.BorderSize = 0;
            this.btnSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.btnSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Location = new System.Drawing.Point(136, 296);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(176, 89);
            this.btnSomar.TabIndex = 7;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.HotPink;
            this.btnSubtrair.FlatAppearance.BorderSize = 0;
            this.btnSubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.btnSubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Location = new System.Drawing.Point(332, 296);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(174, 89);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.HotPink;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Location = new System.Drawing.Point(136, 404);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(176, 89);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.HotPink;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Location = new System.Drawing.Point(332, 404);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(5);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(174, 89);
            this.btnDividir.TabIndex = 10;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.HotPink;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(151, 617);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 67);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.HotPink;
            this.bntSair.FlatAppearance.BorderSize = 0;
            this.bntSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.bntSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSair.Location = new System.Drawing.Point(369, 617);
            this.bntSair.Margin = new System.Windows.Forms.Padding(5);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(137, 65);
            this.bntSair.TabIndex = 12;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora_Cálculos_Básicos.Properties.Resources.fundo_calculadora3;
            this.ClientSize = new System.Drawing.Size(628, 714);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button bntSair;
    }
}

