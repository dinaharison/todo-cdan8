using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using todo_cdan8.App_Code;

namespace todo_cdan8
{
    public partial class Accueil : System.Web.UI.Page
    {
        public string WelcomeWorld
        {
            get
            {
                return "Welcome";
            }
        }
        public string Username
        {
            get {
                if(Session["username"] != null)
                {
                    return Session["username"].ToString();
                }
                return "";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] == null)
            {
                Response.Redirect("todo.aspx");
            }
            listeTache.DataSource = DBConnection.retrouverTaches(Session["username"].ToString());
            listeTache.DataBind();
        }

        protected void AjouterTache_Click(object sender, EventArgs e)
        {
            if (tachenom.Text != "")
            {
                var tache = new Tache(Session["username"].ToString(), tachenom.Text, false);
                DBConnection.InsertionTache(tache);
            }
        }
    }
}