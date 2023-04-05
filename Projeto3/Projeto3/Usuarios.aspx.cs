using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataServices.DataBase;

namespace Projeto3
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LerUsuarios();
        }

        // LÊ OS USUÁRIOS DA TABELA USUARIOS PARA EXIBIR NO GRID
        protected void LerUsuarios()
        {
            string comandoSQL = "SELECT UsuarioID,NomeCompleto,Email,NomeAcesso FROM Usuarios WHERE Status=1 ORDER BY NomeCompleto ASC;";
            DAO db = new DAO();
            // Atribui a string de conexâo à classe de acesso ao banco de dados.
            db.ConnectionString = App_Code.AppSettings.ConexaoDB;
            // Define o banco de dados que será acessado.
            db.DataProviderName = DAO.ProviderName.OleDb;

            System.Data.DataTable tb = (System.Data.DataTable)db.Query(comandoSQL);

            ExibirUsuarios.DataSource = tb;
            ExibirUsuarios.DataBind();

            tb.Dispose();
        }



        protected void InserirEditar_Click(object sender, EventArgs e)
        {
            // 1. VALIDAÇÃ DOS DADOS
            if(NomeCompleto.Text.Trim() == "")
            {
                Mensagem.Text = "Digite o nome";
            } else if (Email.Text.Trim() == "")
            {
                Mensagem.Text = "Digite o email";
            } else if (NomeAcesso.Text.Trim() == "")
            {
                Mensagem.Text = "Digite o nome de acesso";
            }else if (Senha.Text.Trim() == "")
            {
                Mensagem.Text = "Digite a senha";
            } else
            {
                 // 2. Instancia do model da tabela usuarios
                 Model.Usuarios usuario = new Model.Usuarios();
                // Classe de transação com o banco de dados (INSERT, UPDATE, DELETE, SELECT)
                 DAO db = new DAO();
                // Atribui a string de conexâo à classe de acesso ao banco de dados.
                 db.ConnectionString = App_Code.AppSettings.ConexaoDB;
                // Define o banco de dados que será acessado.
                 db.DataProviderName = DAO.ProviderName.OleDb;

                if (UsuarioID.Text == "")
                {
                    usuario.NomeCompleto = NomeCompleto.Text;
                    usuario.Email = Email.Text;
                    usuario.NomeAcesso = NomeAcesso.Text;
                    usuario.Senha = Senha.Text;
                    usuario.Status = 1;
                    db.Insert(usuario, "UsuarioID");
                } 
                else
                {
                    usuario.NomeCompleto = NomeCompleto.Text;
                    usuario.Email = Email.Text;
                    usuario.NomeAcesso = NomeAcesso.Text;
                    usuario.Senha = Senha.Text;
                    usuario.Status = 1;
                    db.Update(usuario, "UsuarioID", UsuarioID.Text);
                }
                LimparControles();
                LerUsuarios();
            }
        }

        // LIMPA OS CONTROLES DO FORMULÁRIO
        protected void LimparControles()
        {
            UsuarioID.Text = "";
            NomeAcesso.Text = "";
            NomeCompleto.Text = "";
            Senha.Text = "";
            Email.Text = "";
            InserirEditar.Text = "Inserir";
            Excluir.Visible = false;

        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            Model.Usuarios usuario = new Model.Usuarios();
            DAO db = new DAO();
            // Atribui a string de conexâo à classe de acesso ao banco de dados.
            db.ConnectionString = App_Code.AppSettings.ConexaoDB;
            // Define o banco de dados que será acessado.
            db.DataProviderName = DAO.ProviderName.OleDb;

            usuario.Status = 0;
            db.Update(usuario, "UsuarioID", UsuarioID.Text);
            LimparControles();
            LerUsuarios(); 
        }

        protected void ExibirUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // recupera a chave primária da linha clicada

            UsuarioID.Text = ExibirUsuarios.SelectedRow.Cells[1].Text;

            DAO db = new DAO();

            string comadoSQL = "SELECT * FROM Usuarios WHERE UsuarioID=" + UsuarioID.Text;

            // Atribui a string de conexâo à classe de acesso ao banco de dados.
            db.ConnectionString = App_Code.AppSettings.ConexaoDB;
            // Define o banco de dados que será acessado.
            db.DataProviderName = DAO.ProviderName.OleDb;

            System.Data.DataTable tb = (System.Data.DataTable)db.Query(comadoSQL);

            NomeCompleto.Text = tb.Rows[1]["NomeCompleto"].ToString();
            NomeAcesso.Text = tb.Rows[1]["NomeCompleto"].ToString();
            Email.Text = tb.Rows[1]["NomeCompleto"].ToString();
            Senha.Text = tb.Rows[1]["NomeCompleto"].ToString();

            Excluir.Visible = true;
            InserirEditar.Text = "Editar";
            tb.Dispose();


        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            string comandoSQL = "SELECT UsuarioID,NomeCompleto FROM Usuarios WHERE Status=1 AND NomeCompleto LIKE'%" + BuscarUsuario.Text + "%'";
            DAO db = new DAO();
            // Atribui a string de conexâo à classe de acesso ao banco de dados.
            db.ConnectionString = App_Code.AppSettings.ConexaoDB;
            // Define o banco de dados que será acessado.
            db.DataProviderName = DAO.ProviderName.OleDb;
            ExibirUsuarios.DataSource = (System.Data.DataTable)db.Query(comandoSQL);
            ExibirUsuarios.DataBind();
            Cancelar.Visible = true;
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar.Visible = false;
            BuscarUsuario.Text = "";
            LerUsuarios();
        }
    }
}