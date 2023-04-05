<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Projeto3.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin-top-60">
        <div class="row">
            <div class="col-6">
                <div class="box border margin-right-20">
                    <h2>Usuários</h2>
                    <br />
                    <asp:Label ID="Mensagem" ForeColor="Red" Font-Size="16px" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="UsuarioID" Font-Size="20px" runat="server"></asp:Label>
                    <label>Seu Nome</label>
                    <asp:TextBox ID="NomeCompleto" MaxLength="255" runat="server"></asp:TextBox>
                    <label>Seu E-MAIL</label>
                    <asp:TextBox ID="Email" MaxLength="255" runat="server"></asp:TextBox>
                    <label>NOME DE ACESSO</label>
                    <asp:TextBox ID="NomeAcesso" MaxLength="255" runat="server"></asp:TextBox>
                    <label>SENHA</label>
                    <asp:TextBox ID="Senha" MaxLength="255" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="InserirEditar" OnClick="InserirEditar_Click" CssClass="botao-inserir" runat="server" Text="Salvar" />
                    <asp:Button ID="Excluir" CssClass="botao-delete" OnClick="Excluir_Click" Visible="false" runat="server" Text="Excluir" />
                    <br />
                </div>
            </div>
            <div class="col-6">
                <div class="box">
                    <div>
                        <asp:TextBox ID="BuscarUsuario" Width="150px" runat="server"></asp:TextBox>
                        <asp:Button ID="Buscar" OnClick="Buscar_Click" runat="server" Text="Buscar" />
                        <asp:Button ID="Cancelar" OnClick="Cancelar_Click" Visible="false" runat="server" Text="X" />
                    </div>
                    <asp:Panel ID="Panel1" Height="500px" Width="100%" ScrollBars="Vertical" runat="server">
                        <asp:GridView OnSelectedIndexChanged="ExibirUsuarios_SelectedIndexChanged" ID="ExibirUsuarios" AutoGenerateColumns="true" Width="100%" CellPadding="4" BorderColor="#c0c0c0" runat="server">
                            <Columns>
                                <asp:ButtonField CommandName="Select" Text="EDT" />
                            </Columns>


                        </asp:GridView>
                    </asp:Panel>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
