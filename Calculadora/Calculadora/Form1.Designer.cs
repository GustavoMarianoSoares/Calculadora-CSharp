
namespace Calculadora
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(15, 186);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 52);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(15, 244);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 53);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(14, 19);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(349, 45);
            this.txtResultado.TabIndex = 15;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(86, 186);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 52);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(157, 186);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 52);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(15, 128);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 52);
            this.btn4.TabIndex = 18;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(86, 128);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 52);
            this.btn5.TabIndex = 19;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(157, 128);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 52);
            this.btn6.TabIndex = 20;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(15, 70);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 52);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(86, 70);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 52);
            this.btn8.TabIndex = 22;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(157, 70);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 52);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(157, 244);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(65, 52);
            this.btnPonto.TabIndex = 24;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(228, 70);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(65, 52);
            this.btnSoma.TabIndex = 25;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(228, 128);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(65, 52);
            this.btnMenos.TabIndex = 26;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.Location = new System.Drawing.Point(228, 186);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(65, 52);
            this.btnVezes.TabIndex = 27;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(228, 245);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(65, 52);
            this.btnDividir.TabIndex = 28;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(299, 70);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(65, 52);
            this.btnCE.TabIndex = 29;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(299, 128);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(65, 52);
            this.btnC.TabIndex = 30;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(299, 186);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(65, 110);
            this.btnIgual.TabIndex = 31;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click_1);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Location = new System.Drawing.Point(15, 31);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 17);
            this.lblOperacao.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 327);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblOperacao;
    }
}

