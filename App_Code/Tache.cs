using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todo_cdan8.App_Code
{
    
    public class Tache
    {
        private int _tacheid;
        private string _username;
        private string _tachenom;
        private bool _state;

        public int Tacheid { get => _tacheid; set => _tacheid = value; }
        public string Username { get => _username; set => _username = value; }
        public string Tachenom { get => _tachenom; set => _tachenom = value; }
        public bool State { get => _state; set => _state = value; }

        public Tache(string username, string tachenom, bool state)
        {
            _username = username;
            _tachenom = tachenom;
            _state = state;
        }

        public Tache(int tacheid, string username, string tachenom, bool state)
        {
            _tacheid = tacheid;
            _username = username;
            _tachenom = tachenom;
            _state = state;
        }
    }
}