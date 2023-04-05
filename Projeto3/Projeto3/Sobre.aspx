<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="Projeto3.Sobre" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin-top-60">
        <div class="row">
            <div class="col-4">
                <div class="flexslider">
                    <ul class="slides">
                        <li>
                            <img src="Images/si1.png" />
                        </li>
                        <li>
                            <img src="Images/si2.jpg" />
                        </li>
                        <li>
                            <img src="Images/si3.jpg" />
                        </li>
                    </ul>
                </div>
                <script>
                    $(window).load(function () {
                        $('.flexslider').flexslider({
                            animation: "slide"
                        });
                    });
                </script>
                <div class="margin-top-20">
                    <h3>Curso de ADS na FATEC</h3>
                    <p>Com essa graduação tecnológica você vai manjar muito de gerenciamento de bancos de dados, algoritmos de inteligência artificial, criação de apps para celular, softwares e sistemas inteligentes, ou seja, áreas cheias de oportunidades de trabalho para especialistas.</p>
                </div>
            </div>
            <div class="col-4">
            </div>
            <div class="col-4">
            </div>
        </div>



    </div>
</asp:Content>
