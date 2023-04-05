<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="flexslider">
        <ul class="slides">
            <li>
                <img src="Images/banner0.png" />
            </li>
            <li>
                <img src="Images/banner1.png" />
            </li>
            <li>
                <img src="Images/banner2.png" />
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


</asp:Content>
