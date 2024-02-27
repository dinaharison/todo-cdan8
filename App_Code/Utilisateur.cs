using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todo_cdan8.App_Code
{
    public class Utilisateur
    {

        private string _nomUtilisateur;

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string NomUtilisateur
        {
            get { return _nomUtilisateur; }
            set { _nomUtilisateur = value; }
        }

        public Utilisateur(string nomUtilisateur, string password)
        {
            _nomUtilisateur = nomUtilisateur;
            _password = password;
        }
    }

}