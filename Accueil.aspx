<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accueil.aspx.cs" Inherits="todo_cdan8.Accueil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page d'accueil</title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="page-header"><%= WelcomeWorld + " " + Username %></h1>
            <div class="form-group">
                <asp:Label Text="Description de la tache" runat="server" />
                <asp:TextBox CssClass="form-control" runat="server" ID="tachenom"/>
            </div>            
            <asp:Button ID="AjouterTache" CssClass="btn btn-primary" Text="Ajouter une Tache" runat="server" OnClick="AjouterTache_Click"/>
        </div>
        <asp:GridView ID="listeTache" runat="server" AutoGenerateSelectButton="True">
        </asp:GridView>
    </form>
</body>
</html>
