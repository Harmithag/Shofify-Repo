<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminPage1.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ShoppingSite.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="card mb-3">
        <div class="card-body bg-white" >
            <%# GetImage(Eval("imageurl")) %>

        </div>
    </div>


    <div class="card mb-3" runat="server" id="div2">
        <div class="card-header">
            <i class="fa fa-table"></i> <%# Eval("productDetails") %>
     
        </div>
        <div class="card-body" style="background-color: white !important">
        <table class="table table-bordered table-striped">

           <tbody>
                 <tr>
                          <td>Price </td>
                          <td><asp:Label runat="server" ID="lblPrice"></asp:Label></td>

                          <td>Quantity :</td>
                           <td>
                          <asp:Button CssClass="btn btn-dark" ID="incButtton" runat="server" Text="Back" />
                            <asp:Label runat="server" ID="lblQuantity">1</asp:Label>
                          <asp:Button CssClass="btn btn-dark" ID="decButton" runat="server" Text="Back" />
                          </td>
                 </tr>
            </tbody>
            </table>    
        </div>

         </div>
               
</asp:Content>