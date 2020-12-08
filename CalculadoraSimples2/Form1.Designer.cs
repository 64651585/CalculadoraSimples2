
namespace CalculadoraSimples2
{
    partial class FormCalc
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
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicação = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(74, 17);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(111, 20);
            this.txbNumero1.TabIndex = 2;
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(75, 60);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(110, 20);
            this.txbNumero2.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(12, 113);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(58, 13);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.Text = "Resultado:";
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(74, 110);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(111, 20);
            this.txbResultado.TabIndex = 5;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(223, 17);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(87, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(223, 46);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(87, 23);
            this.btnSomar.TabIndex = 7;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(223, 75);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(87, 23);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicação
            // 
            this.btnMultiplicação.Location = new System.Drawing.Point(223, 104);
            this.btnMultiplicação.Name = "btnMultiplicação";
            this.btnMultiplicação.Size = new System.Drawing.Size(87, 23);
            this.btnMultiplicação.TabIndex = 9;
            this.btnMultiplicação.Text = "Multiplicação";
            this.btnMultiplicação.UseVisualStyleBackColor = true;
            this.btnMultiplicação.Click += new System.EventHandler(this.btnMultiplicação_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 168);
            this.Controls.Add(this.btnMultiplicação);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCalc";
            this.Text = "Calculadora simples com teclado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicação;
    }
}

