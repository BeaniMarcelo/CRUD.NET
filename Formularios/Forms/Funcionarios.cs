using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Data.Repositorios;

namespace Formularios.Forms
{
    public partial class Funcionarios : Form
    {
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CRUD_DAPPER;Data Source=MARCELO-BEANI\BEANI");
        readonly int funcId = 0;

        public Funcionarios()
        {
            InitializeComponent();
        }

        public void Btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@FuncionarioId", funcId);
                param.Add("@Nome", txt_nome.Text.Trim());
                param.Add("@Telefone", txt_telefone.Text.Trim());
                param.Add("@Endereco", txt_endereco.Text.Trim());
                con.Execute("AdicionaOuEditarFuncionario", param, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Cadastro Salvo com Sucesso!");
                txt_endereco.Clear();
                txt_nome.Clear();
                txt_telefone.Clear();
                BuscarFuncionario();
            }
        }

        public void BuscarFuncionario()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", txt_pesquisar.Text.Trim());
            List<FuncionarioDTO> list = new List<FuncionarioDTO>();
            list = con.Query<FuncionarioDTO>("BuscarFuncionario", param, commandType: CommandType.StoredProcedure).ToList<FuncionarioDTO>();
            grid_funcionarios.DataSource = list;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarFuncionario();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }
    }
}
