<%@ Page Title="Home Page" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatalogoWeb_TP3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Lista de productos</h1>
    <asp:TextBox ID="txtFiltrar" CssClass="mt-5" runat="server" placeholder="Presione 'Enter' para filtrar" OnTextChanged="Filtrar_TextChanged" />
    

    <div class="card-columns" style="margin-left: 10px; margin-right: 10px; margin-top:10px;">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="card text-center">
                    <img src="<%#Eval("ImagenURL") %>" class="card-img-top" alt="..." style="min-height:375px; max-height:1000px; ">
                    <div class="card-body">
                        <h1 class="card-text text-left">$<%#Eval("Precio")%></h1>
                        <h5 class="card-text text-left" style="color:lawngreen">Envío gratis</h5>
                        <h4 class="card-title text-left"><%#Eval("Nombre")%></h4>
                        <p class="card-text text-left"><%#Eval("Descripcion")%></p>
                    </div>
                    <%--<a class="btn btn-primary" href="Carrito.aspx?idArt=<%#Eval("Id")%>">Seleccionar</a>--%>
                    <asp:Button ID="btnSeleccionar" Text="Seleccionar" ControlStyle-CssClass="btn btn-success mb-4" CommandArgument='<%#Eval("Id")%>' CommandName="idArt" runat="server" OnClick="btnSeleccionar_Click"  />
                   
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <%--<asp:TextBox runat="server" ID="txtTextbox" />--%>
</asp:Content>
