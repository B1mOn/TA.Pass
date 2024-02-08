using DevExpress.Mvvm;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ТА.Пароли.Models.JSON;


namespace ТА.Пароли.Models
{
    public class User : BindableBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value, nameof(Name));
        }

        private ObservableCollection<Account> _accounts = new ObservableCollection<Account>();
        public ObservableCollection<Account> Accounts
        {
            get => _accounts;
            set => SetProperty(ref _accounts, value, nameof(Accounts));
        } 

        private Account _selected_Account;
        public Account Selected_Account
        {
            get => _selected_Account;
            set
            {
                SetProperty(ref _selected_Account, value, nameof(Selected_Account));
                Console.WriteLine(value.Comment);
            }
        }

        public ICommand Account_Add => new RelayCommand(() =>
        {
            Accounts.Add(new Account());
            Console.WriteLine(Accounts.Count);
            Console.WriteLine(Accounts.Last());
        });

        public ICommand Account_Remove => new RelayCommand(() =>
        {
            try
            {
                //Console.WriteLine(Selected_Account.Comment);
                Accounts.Remove(Selected_Account);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });

        private UserJSON _userJSON = new UserJSON();
        public UserJSON UserJSON 
        {
            get
            {
                _userJSON.Name = Name;
                _userJSON.Accounts = Accounts.ToArray();
                return _userJSON;
            }
        }

        public void Accounts_Load() 
        {
            //JSON Load
        }

    }
}

