<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="todo.aspx.cs" Inherits="todo_cdan8.Todo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nom d'Utilisateur"></asp:Label>
            <asp:TextBox ID="nomUtilisateur" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Mot de passe"></asp:Label>
            <asp:TextBox ID="password" runat="server" OnTextChanged="password_TextChanged"></asp:TextBox>
            <asp:Button ID="soumettre" runat="server" Text="Soumettre" CssClass="classebouton" OnClick="soumettre_Click" />
        </div>
    </form>
</body>
</html>
