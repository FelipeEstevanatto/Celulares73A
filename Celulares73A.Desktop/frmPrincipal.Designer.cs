namespace Celulares73A.Desktop
{
    partial class frmPrincipal
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
            this.btnSearchModelo = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxCelulares = new System.Windows.Forms.GroupBox();
            this.lstCelulares = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBoxPesquisar = new System.Windows.Forms.GroupBox();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.numericPrecoMax = new System.Windows.Forms.NumericUpDown();
            this.numericPrecoMin = new System.Windows.Forms.NumericUpDown();
            this.lblAbetween = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnSearchPreco = new System.Windows.Forms.Button();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.btnSearchFabricante = new System.Windows.Forms.Button();
            this.groupBoxCelulares.SuspendLayout();
            this.groupBoxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo aparelho:";
            // 
            // btnSearchModelo
            // 
            this.btnSearchModelo.Location = new System.Drawing.Point(385, 49);
            this.btnSearchModelo.Name = "btnSearchModelo";
            this.btnSearchModelo.Size = new System.Drawing.Size(90, 23);
            this.btnSearchModelo.TabIndex = 1;
            this.btnSearchModelo.Text = "Pesquisar";
            this.btnSearchModelo.UseVisualStyleBackColor = true;
            this.btnSearchModelo.Click += new System.EventHandler(this.btnSearchModelo_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(140, 50);
            this.txtBoxSearch.MaxLength = 150;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(239, 22);
            this.txtBoxSearch.TabIndex = 4;
            // 
            // groupBoxCelulares
            // 
            this.groupBoxCelulares.Controls.Add(this.lstCelulares);
            this.groupBoxCelulares.Location = new System.Drawing.Point(50, 136);
            this.groupBoxCelulares.Name = "groupBoxCelulares";
            this.groupBoxCelulares.Size = new System.Drawing.Size(766, 233);
            this.groupBoxCelulares.TabIndex = 5;
            this.groupBoxCelulares.TabStop = false;
            this.groupBoxCelulares.Text = "Celulares";
            // 
            // lstCelulares
            // 
            this.lstCelulares.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCelulares.FormattingEnabled = true;
            this.lstCelulares.ItemHeight = 20;
            this.lstCelulares.Location = new System.Drawing.Point(15, 21);
            this.lstCelulares.Name = "lstCelulares";
            this.lstCelulares.Size = new System.Drawing.Size(731, 184);
            this.lstCelulares.TabIndex = 0;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(56, 400);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(151, 400);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBoxPesquisar
            // 
            this.groupBoxPesquisar.Controls.Add(this.btnLimparFiltro);
            this.groupBoxPesquisar.Controls.Add(this.cmbFabricante);
            this.groupBoxPesquisar.Controls.Add(this.numericPrecoMax);
            this.groupBoxPesquisar.Controls.Add(this.numericPrecoMin);
            this.groupBoxPesquisar.Controls.Add(this.lblAbetween);
            this.groupBoxPesquisar.Controls.Add(this.lblPreco);
            this.groupBoxPesquisar.Controls.Add(this.btnSearchPreco);
            this.groupBoxPesquisar.Controls.Add(this.lblFabricante);
            this.groupBoxPesquisar.Controls.Add(this.btnSearchFabricante);
            this.groupBoxPesquisar.Controls.Add(this.txtBoxSearch);
            this.groupBoxPesquisar.Controls.Add(this.label1);
            this.groupBoxPesquisar.Controls.Add(this.btnSearchModelo);
            this.groupBoxPesquisar.Location = new System.Drawing.Point(56, 12);
            this.groupBoxPesquisar.Name = "groupBoxPesquisar";
            this.groupBoxPesquisar.Size = new System.Drawing.Size(740, 118);
            this.groupBoxPesquisar.TabIndex = 8;
            this.groupBoxPesquisar.TabStop = false;
            this.groupBoxPesquisar.Text = "Pesquisar";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Location = new System.Drawing.Point(594, 58);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(140, 49);
            this.btnLimparFiltro.TabIndex = 14;
            this.btnLimparFiltro.Text = "Limpar Filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = true;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(140, 84);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(239, 24);
            this.cmbFabricante.TabIndex = 13;
            // 
            // numericPrecoMax
            // 
            this.numericPrecoMax.DecimalPlaces = 2;
            this.numericPrecoMax.Location = new System.Drawing.Point(281, 20);
            this.numericPrecoMax.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericPrecoMax.Name = "numericPrecoMax";
            this.numericPrecoMax.Size = new System.Drawing.Size(98, 22);
            this.numericPrecoMax.TabIndex = 12;
            this.numericPrecoMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericPrecoMin
            // 
            this.numericPrecoMin.DecimalPlaces = 2;
            this.numericPrecoMin.Location = new System.Drawing.Point(140, 20);
            this.numericPrecoMin.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericPrecoMin.Name = "numericPrecoMin";
            this.numericPrecoMin.Size = new System.Drawing.Size(114, 22);
            this.numericPrecoMin.TabIndex = 11;
            this.numericPrecoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAbetween
            // 
            this.lblAbetween.AutoSize = true;
            this.lblAbetween.Location = new System.Drawing.Point(260, 22);
            this.lblAbetween.Name = "lblAbetween";
            this.lblAbetween.Size = new System.Drawing.Size(15, 16);
            this.lblAbetween.TabIndex = 10;
            this.lblAbetween.Text = "a";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(6, 23);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 16);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço:";
            // 
            // btnSearchPreco
            // 
            this.btnSearchPreco.Location = new System.Drawing.Point(385, 16);
            this.btnSearchPreco.Name = "btnSearchPreco";
            this.btnSearchPreco.Size = new System.Drawing.Size(90, 23);
            this.btnSearchPreco.TabIndex = 9;
            this.btnSearchPreco.Text = "Pesquisar";
            this.btnSearchPreco.UseVisualStyleBackColor = true;
            this.btnSearchPreco.Click += new System.EventHandler(this.btnSearchPreco_Click);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(6, 84);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(131, 16);
            this.lblFabricante.TabIndex = 5;
            this.lblFabricante.Text = "Fabricante aparelho:";
            // 
            // btnSearchFabricante
            // 
            this.btnSearchFabricante.Location = new System.Drawing.Point(385, 84);
            this.btnSearchFabricante.Name = "btnSearchFabricante";
            this.btnSearchFabricante.Size = new System.Drawing.Size(90, 23);
            this.btnSearchFabricante.TabIndex = 6;
            this.btnSearchFabricante.Text = "Pesquisar";
            this.btnSearchFabricante.UseVisualStyleBackColor = true;
            this.btnSearchFabricante.Click += new System.EventHandler(this.btnSearchFabricante_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.groupBoxPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.groupBoxCelulares);
            this.Name = "frmPrincipal";
            this.Text = "CTI Celulares - Matriz";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBoxCelulares.ResumeLayout(false);
            this.groupBoxPesquisar.ResumeLayout(false);
            this.groupBoxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchModelo;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxCelulares;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBoxPesquisar;
        private System.Windows.Forms.NumericUpDown numericPrecoMax;
        private System.Windows.Forms.NumericUpDown numericPrecoMin;
        private System.Windows.Forms.Label lblAbetween;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnSearchPreco;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Button btnSearchFabricante;
        private System.Windows.Forms.ListBox lstCelulares;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Button btnLimparFiltro;
    }
}

