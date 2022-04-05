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
            this.valueQuantidade = new System.Windows.Forms.Label();
            this.valuePeso = new System.Windows.Forms.Label();
            this.valueDimensoes = new System.Windows.Forms.Label();
            this.valueModelo = new System.Windows.Forms.Label();
            this.valueFabricante = new System.Windows.Forms.Label();
            this.valuePreco = new System.Windows.Forms.Label();
            this.valueDesconto = new System.Windows.Forms.Label();
            this.txtBoxObservacoes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreço.Location = new System.Drawing.Point(116, 219);
            this.lblPreço.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(45, 29);
            this.lblPreço.TabIndex = 23;
            this.lblPreço.Text = "R$";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(34, 145);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 21;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.ForeColor = System.Drawing.Color.Red;
            this.lblDesconto.Location = new System.Drawing.Point(34, 186);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 22;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(34, 119);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 20;
            this.lblPeso.Text = "Peso:";
            // 
            // lblDimensoes
            // 
            this.lblDimensoes.AutoSize = true;
            this.lblDimensoes.Location = new System.Drawing.Point(34, 93);
            this.lblDimensoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDimensoes.Name = "lblDimensoes";
            this.lblDimensoes.Size = new System.Drawing.Size(59, 13);
            this.lblDimensoes.TabIndex = 17;
            this.lblDimensoes.Text = "Dimensões";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(34, 67);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(34, 41);
            this.lblFabricante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(60, 13);
            this.lblFabricante.TabIndex = 15;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(174, 206);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(106, 63);
            this.btnComprar.TabIndex = 24;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // valueQuantidade
            // 
            this.valueQuantidade.AutoSize = true;
            this.valueQuantidade.Location = new System.Drawing.Point(115, 145);
            this.valueQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueQuantidade.Name = "valueQuantidade";
            this.valueQuantidade.Size = new System.Drawing.Size(65, 13);
            this.valueQuantidade.TabIndex = 29;
            this.valueQuantidade.Text = "Quantidade:";
            // 
            // valuePeso
            // 
            this.valuePeso.AutoSize = true;
            this.valuePeso.Location = new System.Drawing.Point(115, 119);
            this.valuePeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valuePeso.Name = "valuePeso";
            this.valuePeso.Size = new System.Drawing.Size(34, 13);
            this.valuePeso.TabIndex = 28;
            this.valuePeso.Text = "Peso:";
            // 
            // valueDimensoes
            // 
            this.valueDimensoes.AutoSize = true;
            this.valueDimensoes.Location = new System.Drawing.Point(115, 93);
            this.valueDimensoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueDimensoes.Name = "valueDimensoes";
            this.valueDimensoes.Size = new System.Drawing.Size(59, 13);
            this.valueDimensoes.TabIndex = 27;
            this.valueDimensoes.Text = "Dimensões";
            // 
            // valueModelo
            // 
            this.valueModelo.AutoSize = true;
            this.valueModelo.Location = new System.Drawing.Point(116, 67);
            this.valueModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueModelo.Name = "valueModelo";
            this.valueModelo.Size = new System.Drawing.Size(45, 13);
            this.valueModelo.TabIndex = 26;
            this.valueModelo.Text = "Modelo:";
            // 
            // valueFabricante
            // 
            this.valueFabricante.AutoSize = true;
            this.valueFabricante.Location = new System.Drawing.Point(116, 41);
            this.valueFabricante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueFabricante.Name = "valueFabricante";
            this.valueFabricante.Size = new System.Drawing.Size(60, 13);
            this.valueFabricante.TabIndex = 25;
            this.valueFabricante.Text = "Fabricante:";
            // 
            // valuePreco
            // 
            this.valuePreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePreco.Location = new System.Drawing.Point(27, 219);
            this.valuePreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valuePreco.Name = "valuePreco";
            this.valuePreco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.valuePreco.Size = new System.Drawing.Size(94, 29);
            this.valuePreco.TabIndex = 31;
            this.valuePreco.Text = "0,00aaaaaaa";
            // 
            // valueDesconto
            // 
            this.valueDesconto.AutoSize = true;
            this.valueDesconto.ForeColor = System.Drawing.Color.Red;
            this.valueDesconto.Location = new System.Drawing.Point(94, 186);
            this.valueDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueDesconto.Name = "valueDesconto";
            this.valueDesconto.Size = new System.Drawing.Size(56, 13);
            this.valueDesconto.TabIndex = 32;
            this.valueDesconto.Text = "Desconto:";
            // 
            // txtBoxObservacoes
            // 
            this.txtBoxObservacoes.Location = new System.Drawing.Point(36, 261);
            this.txtBoxObservacoes.MaxLength = 80;
            this.txtBoxObservacoes.Multiline = true;
            this.txtBoxObservacoes.Name = "txtBoxObservacoes";
            this.txtBoxObservacoes.Size = new System.Drawing.Size(113, 56);
            this.txtBoxObservacoes.TabIndex = 33;
            // 
            // frmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 366);
            this.Controls.Add(this.txtBoxObservacoes);
            this.Controls.Add(this.valueDesconto);
            this.Controls.Add(this.valuePreco);
            this.Controls.Add(this.valueQuantidade);
            this.Controls.Add(this.valuePeso);
            this.Controls.Add(this.valueDimensoes);
            this.Controls.Add(this.valueModelo);
            this.Controls.Add(this.valueFabricante);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblPreço);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDimensoes);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblFabricante);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label valueQuantidade;
        private System.Windows.Forms.Label valuePeso;
        private System.Windows.Forms.Label valueDimensoes;
        private System.Windows.Forms.Label valueModelo;
        private System.Windows.Forms.Label valueFabricante;
        private System.Windows.Forms.Label valuePreco;
        private System.Windows.Forms.Label valueDesconto;
        private System.Windows.Forms.TextBox txtBoxObservacoes;
    }
}