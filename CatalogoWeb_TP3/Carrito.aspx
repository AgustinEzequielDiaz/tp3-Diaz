﻿<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CatalogoWeb_TP3.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Carro</h1>
    <div class="card" style="width: 25%">

        <style>
            .oculto {
                display: none;
            }
        </style>

        <asp:GridView CssClass="table" ID="dgvCarrito" runat="server" AutoGenerateColumns="false" Height="259px" Width="473px" OnSelectedIndexChanged="dgvCarrito_SelectedIndexChanged" OnRowCommand="dgvCarrito_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Caracteristicas" DataField="Descripcion" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />
                <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Select" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>