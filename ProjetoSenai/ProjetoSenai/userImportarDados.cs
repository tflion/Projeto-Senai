using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Data.SqlClient;

//Material Design
using MaterialSkin;
using MaterialSkin.Controls;

using System.Data.OleDb;


namespace ProjetoSenai
{
    public partial class userImportarDados : UserControl
    {
        public userImportarDados()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            //Cores do form
            materialSkin.ColorScheme = new ColorScheme(
                Primary.Red500, Primary.Red500,
                Primary.Red500, Accent.Red400,
                TextShade.WHITE
            );
        }

        DataSet result;

        private void CboFolha_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel Work Book 97-2003|*.xls|Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {

                    FileStream fs = File.Open(of.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (of.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);



                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true  // set to true to use excel first row as column in datagridview
                        }

                    });

                    cboTipo.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                    {
                        cboTipo.Items.Add(dt.TableName);

                    }
                    reader.Close();


                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvExcel.DataSource = result.Tables[cboTipo.SelectedIndex];
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string strinConn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbProjetoSenai;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conexao = new SqlConnection(strinConn);
            string sql = "INSERT INTO Aluno values (@RegistroAluno,@nomeAluno,@nascimento,@cpf,@email,@identidade,@carteiraTrabalho,@serieCartTrabalho,@dataExpCartTrabalho,@estadoCartTrabalho,@certidaoNumero,@certidaoLivro,@certidaoFolha,@certidaoEstado,@certidaoDistrito,@certidaoData,@certidaoCartorio,@certidaoComarca,@corRaca,@codPai,@idade,@sexo,@grauInstrucao,@nomePai,@nomeMae,@telCelular,@telCelular2,@cartIdentidadeMae,@cartIdentidadePai,@naturalidadeAluno,@nacionalidadeAluno,@nomeInstituicao,@pcd,@auditiva,@fala,@visual,@mental,@valorBolsa,@articuladoSesi,@telCelularPai,@cpfPai,@pisPai,@emailPai,@codMae,@telCelularMae,@cpfMae,@pisMae,@emailMae,@codRespFinanceiro,@nomeRespFinanceiro,@cpfRespFinanceiro,@cepRespFinanceiro,@ruaRespFinanceiro,@numEndRespFinanceiro,@compEndRespFinanceiro,@bairroRespFinanceiro,@celularRespFinanceiro,@telRespFinanceiro,@codRespAcademico,@nomeRespAcademico,@telRespAcademico1,@telRespAcademico2,@cpfRespAcademico,@emailRespAcademico,@cidade,@estado,@bairro,@rua,@complemento,@numeroCasa,@cep,@nomeCurso,@nomeHabilitacao,@codigoTurma,@tipoMatricula,@statusMatricula,@categoria,@articulado,@empresa,@unidade,@irmaoRa,@irmaoNome,@periodoLetivo,@filial,@bolsaParcInicial,@bolsaParcFinal,@nomeServico,@dataMatricula,@codTurma1,@bolsaNome,@bolsaDataInicial,@bolsaDataFinal,@nomeTurma,@nomeReduzidoTurma,@motivoAlteracao,@dataAlteracao,@historicoStatus)";
            try
            {
                conexao.Open();
                for (int i = 0; i < dgvExcel.Rows.Count - 1; i++)
                {
                    SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@RegistroAluno", dgvExcel.Rows[i].Cells[0].Value);
                    comando.Parameters.AddWithValue("@nomeAluno", dgvExcel.Rows[i].Cells[1].Value);
                    comando.Parameters.AddWithValue("@nascimento", dgvExcel.Rows[i].Cells[2].Value);
                    comando.Parameters.AddWithValue("@cpf", dgvExcel.Rows[i].Cells[3].Value);
                    comando.Parameters.AddWithValue("@email", dgvExcel.Rows[i].Cells[4].Value);
                    comando.Parameters.AddWithValue("@identidade", dgvExcel.Rows[i].Cells[5].Value);
                    comando.Parameters.AddWithValue("@carteiraTrabalho", dgvExcel.Rows[i].Cells[6].Value);
                    comando.Parameters.AddWithValue("@serieCartTrabalho", dgvExcel.Rows[i].Cells[7].Value);
                    comando.Parameters.AddWithValue("@dataExpCartTrabalho", dgvExcel.Rows[i].Cells[8].Value);
                    comando.Parameters.AddWithValue("@estadoCartTrabalho", dgvExcel.Rows[i].Cells[9].Value);
                    comando.Parameters.AddWithValue("@certidaoNumero", dgvExcel.Rows[i].Cells[10].Value);
                    comando.Parameters.AddWithValue("@certidaoLivro", dgvExcel.Rows[i].Cells[11].Value);
                    comando.Parameters.AddWithValue("@certidaoFolha", dgvExcel.Rows[i].Cells[12].Value);
                    comando.Parameters.AddWithValue("@certidaoEstado", dgvExcel.Rows[i].Cells[13].Value);
                    comando.Parameters.AddWithValue("@certidaoDistrito", dgvExcel.Rows[i].Cells[14].Value);
                    comando.Parameters.AddWithValue("@certidaoData", dgvExcel.Rows[i].Cells[15].Value);
                    comando.Parameters.AddWithValue("@certidaoCartorio", dgvExcel.Rows[i].Cells[16].Value);
                    comando.Parameters.AddWithValue("@certidaoComarca", dgvExcel.Rows[i].Cells[17].Value);
                    comando.Parameters.AddWithValue("@corRaca", dgvExcel.Rows[i].Cells[18].Value);
                    comando.Parameters.AddWithValue("@codPai", dgvExcel.Rows[i].Cells[19].Value);
                    comando.Parameters.AddWithValue("@idade", dgvExcel.Rows[i].Cells[20].Value);
                    comando.Parameters.AddWithValue("@sexo", dgvExcel.Rows[i].Cells[21].Value);
                    comando.Parameters.AddWithValue("@grauInstrucao", dgvExcel.Rows[i].Cells[22].Value);
                    comando.Parameters.AddWithValue("@nomePai", dgvExcel.Rows[i].Cells[23].Value);
                    comando.Parameters.AddWithValue("@nomeMae", dgvExcel.Rows[i].Cells[24].Value);
                    comando.Parameters.AddWithValue("@telCelular", dgvExcel.Rows[i].Cells[25].Value);
                    comando.Parameters.AddWithValue("@telCelular2", dgvExcel.Rows[i].Cells[26].Value);
                    comando.Parameters.AddWithValue("@cartIdentidadeMae", dgvExcel.Rows[i].Cells[27].Value);
                    comando.Parameters.AddWithValue("@cartIdentidadePai", dgvExcel.Rows[i].Cells[28].Value);
                    comando.Parameters.AddWithValue("@naturalidadeAluno", dgvExcel.Rows[i].Cells[29].Value);
                    comando.Parameters.AddWithValue("@nacionalidadeAluno", dgvExcel.Rows[i].Cells[30].Value);
                    comando.Parameters.AddWithValue("@nomeInstituicao", dgvExcel.Rows[i].Cells[31].Value);
                    comando.Parameters.AddWithValue("@pcd", dgvExcel.Rows[i].Cells[32].Value);
                    comando.Parameters.AddWithValue("@auditiva", dgvExcel.Rows[i].Cells[33].Value);
                    comando.Parameters.AddWithValue("@fala", dgvExcel.Rows[i].Cells[34].Value);
                    comando.Parameters.AddWithValue("@visual", dgvExcel.Rows[i].Cells[35].Value);
                    comando.Parameters.AddWithValue("@mental", dgvExcel.Rows[i].Cells[36].Value);
                    comando.Parameters.AddWithValue("@valorBolsa", dgvExcel.Rows[i].Cells[37].Value);
                    comando.Parameters.AddWithValue("@articuladoSesi", dgvExcel.Rows[i].Cells[38].Value);
                    comando.Parameters.AddWithValue("@telCelularPai", dgvExcel.Rows[i].Cells[39].Value);
                    comando.Parameters.AddWithValue("@cpfPai", dgvExcel.Rows[i].Cells[40].Value);
                    comando.Parameters.AddWithValue("@pisPai", dgvExcel.Rows[i].Cells[41].Value);
                    comando.Parameters.AddWithValue("@emailPai", dgvExcel.Rows[i].Cells[42].Value);
                    comando.Parameters.AddWithValue("@codMae", dgvExcel.Rows[i].Cells[43].Value);
                    comando.Parameters.AddWithValue("@telCelularMae", dgvExcel.Rows[i].Cells[44].Value);
                    comando.Parameters.AddWithValue("@cpfMae", dgvExcel.Rows[i].Cells[45].Value);
                    comando.Parameters.AddWithValue("@pisMae", dgvExcel.Rows[i].Cells[46].Value);
                    comando.Parameters.AddWithValue("@emailMae", dgvExcel.Rows[i].Cells[47].Value);
                    comando.Parameters.AddWithValue("@codRespFinanceiro", dgvExcel.Rows[i].Cells[48].Value);
                    comando.Parameters.AddWithValue("@nomeRespFinanceiro", dgvExcel.Rows[i].Cells[49].Value);
                    comando.Parameters.AddWithValue("@cpfRespFinanceiro", dgvExcel.Rows[i].Cells[50].Value);
                    comando.Parameters.AddWithValue("@cepRespFinanceiro", dgvExcel.Rows[i].Cells[51].Value);
                    comando.Parameters.AddWithValue("@ruaRespFinanceiro", dgvExcel.Rows[i].Cells[52].Value);
                    comando.Parameters.AddWithValue("@numEndRespFinanceiro", dgvExcel.Rows[i].Cells[53].Value);
                    comando.Parameters.AddWithValue("@compEndRespFinanceiro", dgvExcel.Rows[i].Cells[54].Value);
                    comando.Parameters.AddWithValue("@bairroRespFinanceiro", dgvExcel.Rows[i].Cells[55].Value);
                    comando.Parameters.AddWithValue("@celularRespFinanceiro", dgvExcel.Rows[i].Cells[56].Value);
                    comando.Parameters.AddWithValue("@telRespFinanceiro", dgvExcel.Rows[i].Cells[57].Value);
                    comando.Parameters.AddWithValue("@codRespAcademico", dgvExcel.Rows[i].Cells[58].Value);
                    comando.Parameters.AddWithValue("@nomeRespAcademico", dgvExcel.Rows[i].Cells[59].Value);
                    comando.Parameters.AddWithValue("@telRespAcademico1", dgvExcel.Rows[i].Cells[60].Value);
                    comando.Parameters.AddWithValue("@telRespAcademico2", dgvExcel.Rows[i].Cells[61].Value);
                    comando.Parameters.AddWithValue("@cpfRespAcademico", dgvExcel.Rows[i].Cells[62].Value);
                    comando.Parameters.AddWithValue("@emailRespAcademico", dgvExcel.Rows[i].Cells[63].Value);
                    comando.Parameters.AddWithValue("@cidade", dgvExcel.Rows[i].Cells[64].Value);
                    comando.Parameters.AddWithValue("@estado", dgvExcel.Rows[i].Cells[65].Value);
                    comando.Parameters.AddWithValue("@bairro", dgvExcel.Rows[i].Cells[66].Value);
                    comando.Parameters.AddWithValue("@rua", dgvExcel.Rows[i].Cells[67].Value);
                    comando.Parameters.AddWithValue("@complemento", dgvExcel.Rows[i].Cells[68].Value);
                    comando.Parameters.AddWithValue("@numeroCasa", dgvExcel.Rows[i].Cells[69].Value);
                    comando.Parameters.AddWithValue("@cep", dgvExcel.Rows[i].Cells[70].Value);
                    comando.Parameters.AddWithValue("@nomeCurso", dgvExcel.Rows[i].Cells[71].Value);
                    comando.Parameters.AddWithValue("@nomeHabilitacao", dgvExcel.Rows[i].Cells[72].Value);
                    comando.Parameters.AddWithValue("@codigoTurma", dgvExcel.Rows[i].Cells[73].Value);
                    comando.Parameters.AddWithValue("@tipoMatricula", dgvExcel.Rows[i].Cells[74].Value);
                    comando.Parameters.AddWithValue("@statusMatricula", dgvExcel.Rows[i].Cells[75].Value);
                    comando.Parameters.AddWithValue("@categoria", dgvExcel.Rows[i].Cells[76].Value);
                    comando.Parameters.AddWithValue("@articulado", dgvExcel.Rows[i].Cells[77].Value);
                    comando.Parameters.AddWithValue("@empresa", dgvExcel.Rows[i].Cells[78].Value);
                    comando.Parameters.AddWithValue("@unidade", dgvExcel.Rows[i].Cells[79].Value);
                    comando.Parameters.AddWithValue("@irmaoRa", dgvExcel.Rows[i].Cells[80].Value);
                    comando.Parameters.AddWithValue("@irmaoNome", dgvExcel.Rows[i].Cells[81].Value);
                    comando.Parameters.AddWithValue("@periodoLetivo", dgvExcel.Rows[i].Cells[82].Value);
                    comando.Parameters.AddWithValue("@filial", dgvExcel.Rows[i].Cells[83].Value);
                    comando.Parameters.AddWithValue("@bolsaParcInicial", dgvExcel.Rows[i].Cells[84].Value);
                    comando.Parameters.AddWithValue("@bolsaParcFinal", dgvExcel.Rows[i].Cells[85].Value);
                    comando.Parameters.AddWithValue("@nomeServico", dgvExcel.Rows[i].Cells[86].Value);
                    comando.Parameters.AddWithValue("@dataMatricula", dgvExcel.Rows[i].Cells[87].Value);
                    comando.Parameters.AddWithValue("@codTurma1", dgvExcel.Rows[i].Cells[88].Value);
                    comando.Parameters.AddWithValue("@bolsaNome", dgvExcel.Rows[i].Cells[89].Value);
                    comando.Parameters.AddWithValue("@bolsaDataInicial", dgvExcel.Rows[i].Cells[90].Value);
                    comando.Parameters.AddWithValue("@bolsaDataFinal", dgvExcel.Rows[i].Cells[91].Value);
                    comando.Parameters.AddWithValue("@nomeTurma", dgvExcel.Rows[i].Cells[92].Value);
                    comando.Parameters.AddWithValue("@nomeReduzidoTurma", dgvExcel.Rows[i].Cells[93].Value);
                    comando.Parameters.AddWithValue("@motivoAlteracao", dgvExcel.Rows[i].Cells[94].Value);
                    comando.Parameters.AddWithValue("@dataAlteracao", dgvExcel.Rows[i].Cells[95].Value);
                    comando.Parameters.AddWithValue("@historicoStatus", dgvExcel.Rows[i].Cells[96].Value);

                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("dados inseridos no banco de dados com sucesso");
            }

        }
    }
}

