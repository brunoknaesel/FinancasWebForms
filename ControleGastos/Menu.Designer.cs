
namespace ControleGastos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblCartao = new System.Windows.Forms.Label();
            this.lblFinancas = new System.Windows.Forms.Label();
            this.lblInvestimento = new System.Windows.Forms.Label();
            this.btnInvestimento = new System.Windows.Forms.Button();
            this.btnFinancas = new System.Windows.Forms.Button();
            this.btnCartao = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(167, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(28, 7);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(80, 13);
            this.lblCadastro.TabIndex = 6;
            this.lblCadastro.Text = "Controle gastos";
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Location = new System.Drawing.Point(179, 7);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(100, 13);
            this.lblCartao.TabIndex = 7;
            this.lblCartao.Text = "Acompanhar cartão";
            // 
            // lblFinancas
            // 
            this.lblFinancas.AutoSize = true;
            this.lblFinancas.Location = new System.Drawing.Point(365, 7);
            this.lblFinancas.Name = "lblFinancas";
            this.lblFinancas.Size = new System.Drawing.Size(50, 13);
            this.lblFinancas.TabIndex = 8;
            this.lblFinancas.Text = "Finanças";
            // 
            // lblInvestimento
            // 
            this.lblInvestimento.AutoSize = true;
            this.lblInvestimento.Location = new System.Drawing.Point(28, 76);
            this.lblInvestimento.Name = "lblInvestimento";
            this.lblInvestimento.Size = new System.Drawing.Size(72, 13);
            this.lblInvestimento.TabIndex = 9;
            this.lblInvestimento.Text = "Investimentos";
            // 
            // btnInvestimento
            // 
            this.btnInvestimento.BackgroundImage = global::ControleGastos.Properties.Resources.investimento;
            this.btnInvestimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvestimento.Location = new System.Drawing.Point(12, 92);
            this.btnInvestimento.Name = "btnInvestimento";
            this.btnInvestimento.Size = new System.Drawing.Size(121, 46);
            this.btnInvestimento.TabIndex = 3;
            this.btnInvestimento.UseVisualStyleBackColor = true;
            // 
            // btnFinancas
            // 
            this.btnFinancas.BackgroundImage = global::ControleGastos.Properties.Resources.salary;
            this.btnFinancas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinancas.Location = new System.Drawing.Point(331, 23);
            this.btnFinancas.Name = "btnFinancas";
            this.btnFinancas.Size = new System.Drawing.Size(121, 46);
            this.btnFinancas.TabIndex = 2;
            this.btnFinancas.UseVisualStyleBackColor = true;
            // 
            // btnCartao
            // 
            this.btnCartao.BackgroundImage = global::ControleGastos.Properties.Resources.debit_card;
            this.btnCartao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCartao.Location = new System.Drawing.Point(167, 23);
            this.btnCartao.Name = "btnCartao";
            this.btnCartao.Size = new System.Drawing.Size(121, 46);
            this.btnCartao.TabIndex = 1;
            this.btnCartao.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackgroundImage = global::ControleGastos.Properties.Resources.payment_method_ico;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastro.Location = new System.Drawing.Point(12, 23);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(121, 46);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(464, 160);
            this.Controls.Add(this.lblInvestimento);
            this.Controls.Add(this.lblFinancas);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnInvestimento);
            this.Controls.Add(this.btnFinancas);
            this.Controls.Add(this.btnCartao);
            this.Controls.Add(this.btnCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCartao;
        private System.Windows.Forms.Button btnFinancas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnInvestimento;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblFinancas;
        private System.Windows.Forms.Label lblInvestimento;
    }
}

