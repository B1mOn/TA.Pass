using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using ТА.Пароли.Models.JSON;

namespace ТА.Пароли.Models
{
    public class Users: BindableBase
    {
        private ObservableCollection<User> _users = new ObservableCollection<User>();
        public ObservableCollection<User> _Users
        {
            get => _users;
            set => SetProperty(ref _users, value, nameof(_Users));
        }

        private UserJSON[] _usersJSON;
        public UserJSON[] UsersJSON
        {
            get
            {
                _usersJSON = new UserJSON[_Users.Count];
                for (int i = 0; i < _Users.Count; i++)
                {
                    _usersJSON[i] = _Users[i].UserJSON;
                }
                return _usersJSON;
            }
        }

        public void Users_Add() => _Users.Add(new User());

        public void Users_Remove(User user) => _Users.Remove(user);

        public Users()
        {
            Users_Load();
        }

        private void Users_Load()
        {
            //JSON load 
        }

    }
}
