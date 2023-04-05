<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Faleconosco.aspx.cs" Inherits="Projeto3.Faleconosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin-top-60 row">
        <div class="col-6">
            <div class="box border margin-right-20">
                <h2>Fale Conosco</h2>
                <br />
                <asp:Label ID="MensagemErro" ForeColor="Red" Font-Size="16px" runat="server"></asp:Label>
                <br />
                <label>SEU NOME</label>
                <asp:TextBox ID="SeuNome" MaxLength="60" runat="server"></asp:TextBox>
                <label>SEU E-MAIL</label>
                <asp:TextBox ID="SeuEmail" runat="server"></asp:TextBox>
                <label>MENSAGEM</label>
                <asp:TextBox ID="Conteudo" runat="server"></asp:TextBox>
                <br />
                <asp:Button OnClick="Enviar_Click" ID="Enviar" runat="server" Text="Enviar" />



            </div>



        </div>
        <div class="col-6">
        </div>
    </div>
</asp:Content>
