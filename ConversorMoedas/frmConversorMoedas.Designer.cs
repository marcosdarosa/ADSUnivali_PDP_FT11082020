namespace ConversorMoedas
{
    partial class frmConversorMoedas
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
            this.cmbMoedaOrigem = new System.Windows.Forms.ComboBox();
            this.cmbMoedaDestino = new System.Windows.Forms.ComboBox();
            this.lblMoedaOrigem = new System.Windows.Forms.Label();
            this.lblMoedaDestino = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblVlrOrigem = new System.Windows.Forms.Label();
            this.lblFatorConversao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.mtxtVlrOrigem = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFatorDestino = new System.Windows.Forms.MaskedTextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMoedaOrigem
            // 
            this.cmbMoedaOrigem.FormattingEnabled = true;
            this.cmbMoedaOrigem.Location = new System.Drawing.Point(17, 31);
            this.cmbMoedaOrigem.Name = "cmbMoedaOrigem";
            this.cmbMoedaOrigem.Size = new System.Drawing.Size(102, 21);
            this.cmbMoedaOrigem.TabIndex = 0;
            // 
            // cmbMoedaDestino
            // 
            this.cmbMoedaDestino.FormattingEnabled = true;
            this.cmbMoedaDestino.Location = new System.Drawing.Point(129, 31);
            this.cmbMoedaDestino.Name = "cmbMoedaDestino";
            this.cmbMoedaDestino.Size = new System.Drawing.Size(102, 21);
            this.cmbMoedaDestino.TabIndex = 1;
            // 
            // lblMoedaOrigem
            // 
            this.lblMoedaOrigem.AutoSize = true;
            this.lblMoedaOrigem.Location = new System.Drawing.Point(14, 15);
            this.lblMoedaOrigem.Name = "lblMoedaOrigem";
            this.lblMoedaOrigem.Size = new System.Drawing.Size(76, 13);
            this.lblMoedaOrigem.TabIndex = 2;
            this.lblMoedaOrigem.Text = "Moeda Origem";
            // 
            // lblMoedaDestino
            // 
            this.lblMoedaDestino.AutoSize = true;
            this.lblMoedaDestino.Location = new System.Drawing.Point(126, 15);
            this.lblMoedaDestino.Name = "lblMoedaDestino";
            this.lblMoedaDestino.Size = new System.Drawing.Size(79, 13);
            this.lblMoedaDestino.TabIndex = 3;
            this.lblMoedaDestino.Text = "Moeda Destino";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(161, 89);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(131, 29);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // lblVlrOrigem
            // 
            this.lblVlrOrigem.AutoSize = true;
            this.lblVlrOrigem.Location = new System.Drawing.Point(247, 15);
            this.lblVlrOrigem.Name = "lblVlrOrigem";
            this.lblVlrOrigem.Size = new System.Drawing.Size(82, 13);
            this.lblVlrOrigem.TabIndex = 9;
            this.lblVlrOrigem.Text = "Valor na Origem";
            // 
            // lblFatorConversao
            // 
            this.lblFatorConversao.AutoSize = true;
            this.lblFatorConversao.Location = new System.Drawing.Point(370, 15);
            this.lblFatorConversao.Name = "lblFatorConversao";
            this.lblFatorConversao.Size = new System.Drawing.Size(100, 13);
            this.lblFatorConversao.TabIndex = 10;
            this.lblFatorConversao.Text = "Fator de Conversão";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(481, 74);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 35);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(481, 31);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 35);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(481, 115);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mtxtVlrOrigem
            // 
            this.mtxtVlrOrigem.Location = new System.Drawing.Point(247, 32);
            this.mtxtVlrOrigem.Name = "mtxtVlrOrigem";
            this.mtxtVlrOrigem.Size = new System.Drawing.Size(100, 20);
            this.mtxtVlrOrigem.TabIndex = 2;
            this.mtxtVlrOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtxtFatorDestino
            // 
            this.mtxtFatorDestino.Location = new System.Drawing.Point(370, 32);
            this.mtxtFatorDestino.Name = "mtxtFatorDestino";
            this.mtxtFatorDestino.Size = new System.Drawing.Size(100, 20);
            this.mtxtFatorDestino.TabIndex = 3;
            this.mtxtFatorDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(353, 34);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 17;
            this.lblX.Text = "X";
            // 
            // frmConversorMoedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 158);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.mtxtFatorDestino);
            this.Controls.Add(this.mtxtVlrOrigem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblFatorConversao);
            this.Controls.Add(this.lblVlrOrigem);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMoedaDestino);
            this.Controls.Add(this.lblMoedaOrigem);
            this.Controls.Add(this.cmbMoedaDestino);
            this.Controls.Add(this.cmbMoedaOrigem);
            this.Name = "frmConversorMoedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Moedas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMoedaOrigem;
        private System.Windows.Forms.ComboBox cmbMoedaDestino;
        private System.Windows.Forms.Label lblMoedaOrigem;
        private System.Windows.Forms.Label lblMoedaDestino;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblVlrOrigem;
        private System.Windows.Forms.Label lblFatorConversao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mtxtVlrOrigem;
        private System.Windows.Forms.MaskedTextBox mtxtFatorDestino;
        private System.Windows.Forms.Label lblX;
    }
}

