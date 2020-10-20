using System;
using System.Windows.Forms;
using Domain.Classe;

namespace PdfCripto
{
    public partial class frmCripto : Form
    {
        Cripto cripto;
        private string filePath,hash,textoNormal,textoCriptografado,textoLimpo;
        public frmCripto()
        {
            InitializeComponent();
            filePath = hash = textoNormal = textoCriptografado = textoLimpo = string.Empty;
            cripto = new Cripto();
            StatusBar(0);
        }

        private void frmCripto_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo\n\n" +
                "Este programa permite criptografar e descriptografar arquivos simples .pdf\n\n" +
                "Para criptografar apenas abra um arquivo e clique no botão \"criptografar\", o programa ter fornecera uma hash para ser utilizada na descriptografia desse mesmo arquivo posteriormente\n\n" +
                "Para descriptografa é preciso uma hash, é necessario abrir o arquivo criptografado, inserir a hash no campo de texto inferior e clicar descriptografar\n\n" +
                "Para salvar arquivos criptografados/descriptografados basta apenas selecionar qual texto deseja salvar e clicar em \"Salvar arquivo\"", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }


        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHash.TextLength != 0)
                {
                    textoLimpo = cripto.DescriptografarTexto(retornarTextoAtual(), txtHash.Text);
                    rdbDesriptografado.Enabled = true;
                    rdbDesriptografado.Checked = true;
                }
                else
                {
                    MessageBox.Show("Por favor para descriptografar algum arquivo insira um hash", "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void rdbCriptografado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCriptografado.Checked)
            {
                txbPrevia.Text = textoCriptografado;
            }
        }

        private void rdbTexto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTexto.Checked)
            {
                txbPrevia.Text = textoNormal;
            }
        }

        private void rdbDesriptografado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDesriptografado.Checked)
            {
                txbPrevia.Text = textoLimpo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StatusBar(0);
                StatusLabel("Selecionando arquivo");
                sfdSalvar.Filter = "Pdf files (*.pdf)|*.pdf";
                sfdSalvar.FilterIndex = 2;
                sfdSalvar.RestoreDirectory = true;
                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {
                    StatusBar(50).PerformStep();
                    StatusLabel("Abrindo arquivo");
                    Cursor.Current = Cursors.WaitCursor;
                    StatusBar(80).PerformStep();
                    PdfHelper.SalvarPdf(sfdSalvar.FileName, retornarTextoAtual());
                    StatusBar(100).PerformStep();
                    StatusLabel("Pronto");
                    Cursor.Current = Cursors.Default;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                StatusBar(0).PerformStep();
                Cursor.Current = Cursors.Default;
                StatusLabel("Pronto");
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if(txtHash.Text != string.Empty && txtHash.Text != null)
            {
                Clipboard.SetText(txtHash.Text);
                MessageBox.Show("Hash copiado \nCuidado com ele ;)", "Copiado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            };
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creditos aos alunos do 4º semestre de 2020 da Anhembi Morumbi\n" +
                "Gabriel Marcilio - 21307373\n" +
                "Leonardo Moretti - N\n" +
                "Noelen Giovanna - N\n\n" +
                "Segurança e auditoria de sistemas\n" +
                "Sistemas de informação\n", "Ajuda",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                StatusBar(0);
                StatusLabel("Abrindo arquivo");
                if (opdAbrir.ShowDialog() == DialogResult.OK)
                {
                    resetar();
                    opdAbrir.InitialDirectory = "c:\\";
                    opdAbrir.Filter = "pdf files (*.pdf)|*.pdf";
                    opdAbrir.FilterIndex = 2;
                    opdAbrir.RestoreDirectory = true;
                    filePath = opdAbrir.FileName;
                    StatusBar(50).PerformStep();
                    Cursor.Current = Cursors.WaitCursor;
                    textoNormal = PdfHelper.PdfToText(filePath);
                    txbPrevia.Text = textoNormal;
                    txtHash.Enabled = true;
                    rdbTexto.Enabled = true;
                    rdbTexto.Checked = true;
                    btnCriptografar.Enabled = true;
                    btnDescriptografar.Enabled = true;
                    btnSalvar.Enabled = true;
                    StatusBar(100).PerformStep();
                    StatusLabel("Pronto");
                    Cursor.Current = Cursors.Default;
                }
            }catch(System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o arquivo selecionado", "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }catch(Exception ex)
            {   
                MessageBox.Show(ex.Message, "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            StatusBar(0);
            StatusLabel("Gerando hash");
            hash = cripto.GerarHash();
            StatusBar(25).PerformStep();
            StatusLabel("Criptografando arquivo");
            txtHash.Text = hash;
            textoCriptografado = cripto.CriptografarTexto(retornarTextoAtual(), hash);

            rdbCriptografado.Enabled = true;
            rdbCriptografado.Checked = true;

            StatusBar(100).PerformStep();
            StatusLabel("Pronto");

            var result = MessageBox.Show("Seu hash foi gerado, não esqueça de salva-lo", "Hash gerado",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            if (rdbCriptografado.Checked)
            {
                txbPrevia.Text = textoCriptografado;
            }
            else
            {
                txbPrevia.Text = textoLimpo;
            }
            Cursor.Current = Cursors.Default;
        }

        private void StatusLabel(string texto)
        {
            tpbStatusLabel.Text = texto;
        }

        private ToolStripProgressBar StatusBar(int qtn)
        {
            tpbStatusBar.Visible = true;
            tpbStatusBar.Step = qtn;
            return tpbStatusBar;
        }

        private string retornarTextoAtual()
        {
            if (rdbTexto.Checked)
            {
                return textoNormal;
            }
            if (rdbCriptografado.Checked)
            {
                return textoCriptografado;
            }
            if (rdbDesriptografado.Checked)
            {
                return textoLimpo;
            }
            return textoNormal;
        }
        
        private void resetar()
        {
            txtHash.Text = filePath = hash = textoNormal = textoCriptografado = textoLimpo = string.Empty;
            rdbCriptografado.Enabled = false;
            rdbDesriptografado.Enabled = false;
            rdbTexto.Enabled = false;
            rdbCriptografado.Checked = false;
            rdbDesriptografado.Checked = false;
            rdbTexto.Checked = false;
        }


    }
}
