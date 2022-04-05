namespace Celulares73A.Desktop
{
    partial class frmComprar
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
            this.lblPreço = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDimensoes = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtBoxObservacoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreço.Location = new System.Drawing.Point(42, 228);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(56, 36);
            this.lblPreço.TabIndex = 23;
            this.lblPreço.Text = "R$";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(45, 178);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 16);
            this.lblQuantidade.TabIndex = 21;
            this.lblQuantidade.Text = "Qnt. Estoque:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.ForeColor = System.Drawing.Color.Red;
            this.lblDesconto.Location = new System.Drawing.Point(45, 273);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(68, 16);
            this.lblDesconto.TabIndex = 22;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(45, 146);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 16);
            this.lblPeso.TabIndex = 20;
            this.lblPeso.Text = "Peso:";
            // 
            // lblDimensoes
            // 
            this.lblDimensoes.AutoSize = true;
            this.lblDimensoes.Location = new System.Drawing.Point(45, 114);
            this.lblDimensoes.Name = "lblDimensoes";
            this.lblDimensoes.Size = new System.Drawing.Size(76, 16);
            this.lblDimensoes.TabIndex = 17;
            this.lblDimensoes.Text = "Dimensões";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(45, 82);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 16);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(45, 50);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(74, 16);
            this.lblFabricante.TabIndex = 15;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(263, 321);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(141, 78);
            this.btnComprar.TabIndex = 24;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtBoxObservacoes
            // 
            this.txtBoxObservacoes.Location = new System.Drawing.Point(48, 321);
            this.txtBoxObservacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxObservacoes.MaxLength = 80;
            this.txtBoxObservacoes.Multiline = true;
            this.txtBoxObservacoes.Name = "txtBoxObservacoes";
            this.txtBoxObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxObservacoes.Size = new System.Drawing.Size(208, 78);
            this.txtBoxObservacoes.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Observação:";
            // 
            // frmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxObservacoes);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblPreço);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDimensoes);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblFabricante);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmComprar";
            this.Text = "Comprar Aparelho";
            this.Load += new System.EventHandler(this.frmComprar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDimensoes;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtBoxObservacoes;
        private System.Windows.Forms.Label label1;
    }
}