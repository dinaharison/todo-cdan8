<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accueil.aspx.cs" Inherits="todo_cdan8.Accueil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page d'accueil</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><%= WelcomeWorld + " " + Username %></h1>
            <asp:Label Text="Description de la tache" runat="server" />
            <asp:TextBox runat="server" ID="tachenom"/>
            <asp:Button ID="AjouterTache" Text="Ajouter une Tache" runat="server" OnClick="AjouterTache_Click"/>
        </div>
    </form>
</body>
</html>
