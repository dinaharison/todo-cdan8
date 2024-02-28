using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using todo_cdan8.App_Code;

namespace todo_cdan8
{
    public partial class Todo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void soumettre_Click(object sender, EventArgs e)
        {
            var user = new Utilisateur(nomUtilisateur.Text.Trim(), password.Text.Trim());
            if (DBConnection.VerifierUtilisateur(user))
            {
                Session["username"] = user.NomUtilisateur;
                Session["zavatrahafa"] = "valeur";
                Response.Redirect("Accueil.aspx");
            }
        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}