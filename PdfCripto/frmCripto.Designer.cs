namespace PdfCripto
{
    partial class frmCripto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCripto));
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.opdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdSalvar = new System.Windows.Forms.SaveFileDialog();
            this.lblHash = new System.Windows.Forms.Label();
            this.txbPrevia = new System.Windows.Forms.TextBox();
            this.rdbCriptografado = new System.Windows.Forms.RadioButton();
            this.rdbDesriptografado = new System.Windows.Forms.RadioButton();
            this.lblPrevia = new System.Windows.Forms.Label();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rdbTexto = new System.Windows.Forms.RadioButton();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tpbStatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tpbStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(18, 12);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(129, 23);
            this.btnAbrirArquivo.TabIndex = 0;
            this.btnAbrirArquivo.Text = "Abrir arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Enabled = false;
            this.btnDescriptografar.Location = new System.Drawing.Point(153, 40);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(135, 23);
            this.btnDescriptografar.TabIndex = 1;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // txtHash
            // 
            this.txtHash.AcceptsReturn = true;
            this.txtHash.AcceptsTab = true;
            this.txtHash.AllowDrop = true;
            this.txtHash.Enabled = false;
            this.txtHash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHash.Location = new System.Drawing.Point(50, 340);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(228, 20);
            this.txtHash.TabIndex = 2;
            this.txtHash.WordWrap = false;
            // 
            // opdAbrir
            // 
            this.opdAbrir.FileName = "openFileDialog1";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(12, 343);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(32, 13);
            this.lblHash.TabIndex = 3;
            this.lblHash.Text = "Hash";
            // 
            // txbPrevia
            // 
            this.txbPrevia.Location = new System.Drawing.Point(15, 82);
            this.txbPrevia.MaxLength = 5000;
            this.txbPrevia.Multiline = true;
            this.txbPrevia.Name = "txbPrevia";
            this.txbPrevia.ReadOnly = true;
            this.txbPrevia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPrevia.Size = new System.Drawing.Size(317, 222);
            this.txbPrevia.TabIndex = 4;
            // 
            // rdbCriptografado
            // 
            this.rdbCriptografado.AutoSize = true;
            this.rdbCriptografado.Enabled = false;
            this.rdbCriptografado.Location = new System.Drawing.Point(73, 314);
            this.rdbCriptografado.Name = "rdbCriptografado";
            this.rdbCriptografado.Size = new System.Drawing.Size(117, 17);
            this.rdbCriptografado.TabIndex = 5;
            this.rdbCriptografado.Text = "Texto criptografado";
            this.rdbCriptografado.UseVisualStyleBackColor = true;
            this.rdbCriptografado.CheckedChanged += new System.EventHandler(this.rdbCriptografado_CheckedChanged);
            // 
            // rdbDesriptografado
            // 
            this.rdbDesriptografado.AutoSize = true;
            this.rdbDesriptografado.Enabled = false;
            this.rdbDesriptografado.Location = new System.Drawing.Point(198, 314);
            this.rdbDesriptografado.Name = "rdbDesriptografado";
            this.rdbDesriptografado.Size = new System.Drawing.Size(134, 17);
            this.rdbDesriptografado.TabIndex = 6;
            this.rdbDesriptografado.Text = "Texto descriptografado";
            this.rdbDesriptografado.UseVisualStyleBackColor = true;
            this.rdbDesriptografado.CheckedChanged += new System.EventHandler(this.rdbDesriptografado_CheckedChanged);
            // 
            // lblPrevia
            // 
            this.lblPrevia.AutoSize = true;
            this.lblPrevia.Location = new System.Drawing.Point(15, 66);
            this.lblPrevia.Name = "lblPrevia";
            this.lblPrevia.Size = new System.Drawing.Size(63, 13);
            this.lblPrevia.TabIndex = 7;
            this.lblPrevia.Text = "Previa texto";
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Enabled = false;
            this.btnCriptografar.Location = new System.Drawing.Point(18, 40);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(129, 23);
            this.btnCriptografar.TabIndex = 8;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(153, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(135, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar arquivo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rdbTexto
            // 
            this.rdbTexto.AutoSize = true;
            this.rdbTexto.Checked = true;
            this.rdbTexto.Enabled = false;
            this.rdbTexto.Location = new System.Drawing.Point(15, 314);
            this.rdbTexto.Name = "rdbTexto";
            this.rdbTexto.Size = new System.Drawing.Size(52, 17);
            this.rdbTexto.TabIndex = 10;
            this.rdbTexto.TabStop = true;
            this.rdbTexto.Text = "Texto";
            this.rdbTexto.UseVisualStyleBackColor = true;
            this.rdbTexto.CheckedChanged += new System.EventHandler(this.rdbTexto_CheckedChanged);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(284, 339);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(48, 22);
            this.btnCopiar.TabIndex = 11;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(294, 12);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(38, 51);
            this.btnAjuda.TabIndex = 12;
            this.btnAjuda.Text = "?";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpbStatusLabel,
            this.tpbStatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "stsStatus";
            // 
            // tpbStatusBar
            // 
            this.tpbStatusBar.Name = "tpbStatusBar";
            this.tpbStatusBar.Size = new System.Drawing.Size(100, 16);
            this.tpbStatusBar.Visible = false;
            // 
            // tpbStatusLabel
            // 
            this.tpbStatusLabel.Name = "tpbStatusLabel";
            this.tpbStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.tpbStatusLabel.Text = "Pronto";
            // 
            // frmCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 389);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.rdbTexto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.lblPrevia);
            this.Controls.Add(this.rdbDesriptografado);
            this.Controls.Add(this.rdbCriptografado);
            this.Controls.Add(this.txbPrevia);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnAbrirArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCripto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cripto";
            this.Load += new System.EventHandler(this.frmCripto_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.OpenFileDialog opdAbrir;
        private System.Windows.Forms.SaveFileDialog sfdSalvar;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txbPrevia;
        private System.Windows.Forms.RadioButton rdbCriptografado;
        private System.Windows.Forms.RadioButton rdbDesriptografado;
        private System.Windows.Forms.Label lblPrevia;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rdbTexto;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tpbStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tpbStatusLabel;
    }
}

