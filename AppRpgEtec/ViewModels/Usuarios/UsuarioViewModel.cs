using AppRpgEtec.Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppRpgEtec.ViewModels.Usuarios
{
    public class UsuarioViewModel : BaseViewModel
    {
        private UsuarioService uService;
        public ICommand RegistrarCommand { get; set; }
        public ICommand AutenticarCommand { get; set; }

        #region AtributosPropriedades
        private string login = string.Empty;
        private string senha = string.Empty;

        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropetyChanged(Login);
            }
        }

        public string Senha
        {
            get => senha;
            set
            {
                senha = value;
                OnPropetyChanged(Senha);
            }
        }
        #endregion


    }
}
