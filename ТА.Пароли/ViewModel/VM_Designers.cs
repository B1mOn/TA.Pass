using DevExpress.Mvvm;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;
using ТА.Пароли.Models;
using ТА.Пароли.Models.JSON;

namespace ТА.Пароли.ViewModel
{
    public class VM_Designers: BindableBase
    {
        private readonly string _jsonName = "Designers";
        private JSON_Manager _jsonManager = new JSON_Manager();

        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set => SetProperty(ref _selectedUser, value, nameof(SelectedUser));
        }


        private Users _users = new Users();
        public Users Users 
        {
            get => _users;
            set => SetProperty(ref _users, value, nameof(Users)); 
        }

        private bool _readOnly = false;
        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value, nameof(ReadOnly));
        }



        public ICommand Add_User => new RelayCommand(() => Users.Users_Add());
        public ICommand Remove_User => new RelayCommand(() => Users.Users_Remove(SelectedUser));
        public ICommand Edit_Mode => new RelayCommand(() => ReadOnly = !ReadOnly);
        public ICommand Save_Configuration => new RelayCommand(() => _jsonManager.Save(Users, _jsonName));

        public VM_Designers()
        {
            try
            {
                SelectedUser = Users._Users[0];
            }
            catch
            {
                SelectedUser = null;
            }
        }
    }
}
