using DevExpress.Mvvm;

namespace ТА.Пароли.Models
{
    public class Account: BindableBase
    {
        private string _login;
        public string Login { get => _login; set => SetProperty(ref _login, value, nameof(Login)); }

        private string _password;
        public string Password { get => _password; set => SetProperty(ref _password, value, nameof(Password)); }

        private string _comment;
        public string Comment { get => _comment; set => SetProperty(ref _comment, value, nameof(Comment)); }
    }
}
