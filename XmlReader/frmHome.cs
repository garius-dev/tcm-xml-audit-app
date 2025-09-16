using System.ComponentModel;
using System.Text;
using System.Windows.Forms.Design;
using System.Xml.Serialization;
using XmlReader.Extensions;
using XmlReader.Models.NfeXml;

namespace XmlReader
{
    public partial class frmHome : Form
    {
        private List<NotaFiscalItem> listaAgregada;

        public frmHome()
        {
            InitializeComponent();
            this.listaAgregada = new List<NotaFiscalItem>();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResults.RowHeadersWidth = 35;
            dgvResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvResults.ReadOnly = true;
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NumeroNota", HeaderText = "Nº Nota" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdNota", HeaderText = "Chave" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NomeCliente", HeaderText = "Cliente" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CnpjCliente", HeaderText = "CNPJ" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DescricaoProduto", HeaderText = "Produto" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NcmProduto", HeaderText = "NCM" });
            dgvResults.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "IsQuimico", HeaderText = "É Químico?" });
        }

        public class NotaFiscalItem
        {
            public string FileName { get; set; }
            public string IdNota { get; set; }
            public int NumeroNota { get; set; }
            public string CnpjCliente { get; set; }
            public string NomeCliente { get; set; }
            public string DescricaoProduto { get; set; }
            public int NcmProduto { get; set; }
            public bool IsQuimico { get; set; }
        }

        public static bool IsProdutoQuimico(int ncm)
        {
            string ncmStr = ncm.ToString();

            List<string> capitulosQuimicos = new List<string>
            {
                "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38"
            };

            if (ncmStr.Length >= 2)
            {
                string capitulo = ncmStr.Substring(0, 2);
                if (capitulosQuimicos.Contains(capitulo))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtFolderPath.Text = fbd.SelectedPath;
                    ProcessarPasta(fbd.SelectedPath);
                }
            }
        }

        private void ProcessarPasta(string caminhoDaPasta)
        {
            listaAgregada.Clear();
            dgvResults.DataSource = null;

            lblStatus.Text = "Processando... aguarde.";
            this.Update();

            string pastaErros = Path.Combine(caminhoDaPasta, "Erros", DateTime.Now.ToString("yyyy-MM-dd"));
            string pastaSucesso = Path.Combine(caminhoDaPasta, "Sucessos", DateTime.Now.ToString("yyyy-MM-dd"));
            string pastaQuimicos = Path.Combine(caminhoDaPasta, "Quimicos", DateTime.Now.ToString("yyyy-MM-dd"));

            Directory.CreateDirectory(pastaErros);
            Directory.CreateDirectory(pastaSucesso);
            Directory.CreateDirectory(pastaQuimicos);

            string[] arquivosXml = Directory.GetFiles(caminhoDaPasta, "*.xml");
            int arquivosProcessados = 0;
            int arquivosMovidos = 0;
            int contador = 0;

            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arquivosXml.Length;
            progressBar1.Value = 0;
            Application.DoEvents();

            foreach (var arquivoPath in arquivosXml)
            {
                progressBar1.Value = contador;
                Application.DoEvents();

                try
                {
                    string xmlContent = File.ReadAllText(arquivoPath);
                    XmlSerializer serializer = new XmlSerializer(typeof(NfeProc));

                    using (StringReader reader = new StringReader(xmlContent))
                    {
                        if (reader == null)
                            throw new Exception("Erro ao ler o conteúdo do XML.");

                        var nfeObject = serializer.Deserialize(reader) as NfeProc;

                        var infNFe = nfeObject?.NFe?.InfNFe;

                        if (infNFe != null)
                        {
                            foreach (var det in infNFe.Det)
                            {
                                var notaItem = new NotaFiscalItem
                                {
                                    FileName = arquivoPath,
                                    IdNota = infNFe.Id,
                                    NumeroNota = infNFe.Ide.NNF,
                                    CnpjCliente = infNFe.Dest.CNPJ,
                                    NomeCliente = infNFe.Dest.XNome,
                                    DescricaoProduto = det.Prod.XProd,
                                    NcmProduto = det.Prod.NCM,
                                    IsQuimico = IsProdutoQuimico(det.Prod.NCM)
                                };
                                listaAgregada.Add(notaItem);
                            }
                        }
                    }
                    arquivosProcessados++;
                }
                catch (Exception)
                {
                    try
                    {
                        string nomeArquivo = Path.GetFileName(arquivoPath);
                        string destinoArquivo = Path.Combine(pastaErros, nomeArquivo);

                        if (File.Exists(destinoArquivo))
                        {
                            destinoArquivo = Path.Combine(pastaErros, Path.GetFileNameWithoutExtension(nomeArquivo) + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml");
                        }

                        File.Move(arquivoPath, destinoArquivo);
                        arquivosMovidos++;
                    }
                    catch (Exception exMove)
                    {
                        // Se falhar ao mover, apenas informa no status (pode ser problema de permissão)
                        MessageBox.Show($"Falha ao mover o arquivo {Path.GetFileName(arquivoPath)}.\nErro: {exMove.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    contador++;
                }
            }

            var grupoDeNotas = listaAgregada
                .GroupBy(g => new { g.IdNota, g.FileName, g.NumeroNota })
                .Select(s => new
                {
                    Chave = s.Key.IdNota,
                    FileName = s.Key.FileName,
                    Arquivos = s.ToList(),
                    IsQuimico = s.Any(i => i.IsQuimico),
                    NumeroNota = s.Key.NumeroNota
                })
                .ToList();

            if(grupoDeNotas != null && grupoDeNotas.Any())
            {
                foreach(var nota in grupoDeNotas)
                {
                    var arquivoDeNotas = FileExtensions.GetFiles(Path.GetDirectoryName(nota.FileName) ?? "", "*.xml|*.pdf", nota.Chave.Replace("NFe", ""));

                    if (nota.IsQuimico)
                    {
                        FileExtensions.CopyFilesToFolder(arquivoDeNotas, pastaQuimicos, nota.NumeroNota.ToString());
                    }
                    else
                    {
                        FileExtensions.CopyFilesToFolder(arquivoDeNotas, pastaSucesso, nota.NumeroNota.ToString());
                    }
                }
            }


            if (listaAgregada.Count > 0)
            {
                var bindingList = new BindingList<NotaFiscalItem>(listaAgregada);
                var source = new BindingSource(bindingList, null);
                dgvResults.DataSource = source;

                btnSave.Enabled = true;
            }
            else
            {
                listaAgregada.Clear();
                dgvResults.DataSource = null;
                btnSave.Enabled = false;
            }

            this.Update();

            lblStatus.Text = $"Processamento concluído. {arquivosProcessados} arquivos lidos com sucesso e {arquivosMovidos} com erro.";
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        public static string FormatarCnpj(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14)
            {
                return cnpj; // Retorna o original se for inválido
            }
            try
            {
                // Converte para um número de 64 bits e aplica a máscara de formatação
                return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
            }
            catch (Exception)
            {
                // Se a conversão falhar, retorna o original
                return cnpj;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Arquivo CSV (*.csv)|*.csv";
                sfd.FileName = $"Relatorio_NFe_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                sfd.Title = "Salvar resultados como CSV";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine("NumeroNota;Chave;NomeCliente;CnpjCliente;DescricaoProduto;NcmProduto;IsQuimico");

                        foreach (var item in listaAgregada)
                        {
                            string nomeCliente = item.NomeCliente.Replace("\"", "\"\"");
                            string descricaoProduto = item.DescricaoProduto.Replace("\"", "\"\"");
                            string cnpjFormatado = FormatarCnpj(item.CnpjCliente);
                            sb.AppendLine($"{item.NumeroNota};\"{item.IdNota}\";\"{nomeCliente}\";\"{cnpjFormatado}\";\"{descricaoProduto}\";{item.NcmProduto};{item.IsQuimico}");
                        }



                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show($"Arquivo CSV salvo com sucesso em:\n{sfd.FileName}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao salvar o arquivo CSV.\nErro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}