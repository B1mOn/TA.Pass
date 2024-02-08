using DevExpress.Mvvm;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Controls;
using System.Windows.Input;
using ТА.Пароли.View;

namespace ТА.Пароли.ViewModel
{
    public class VM_MainWindow : BindableBase
    {
        private readonly Page _designers = new Page_Designers();
        private readonly Page _installers = new Page_Installers();
        private readonly Page _managers = new Page_Managers();
        private readonly Page _services = new Page_Services();
        private readonly Page _conta = new Page_Conta();

        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set => SetProperty(ref _currentPage, value, nameof(CurrentPage));
        }

        public VM_MainWindow()
        {
            CurrentPage = _designers;
        }

        private string _pass;
        public string Pass 
        {
            get => _pass;
            set => SetProperty(ref _pass, value, nameof(Pass));
        }

        public ICommand Open_Designers => new RelayCommand(() => CurrentPage = _designers);
        public ICommand Open_Installers => new RelayCommand(() => CurrentPage = _installers);
        public ICommand Open_Managers => new RelayCommand(() => CurrentPage = _managers);
        public ICommand Open_Services => new RelayCommand(() => CurrentPage = _services);
        public ICommand Open_Conta => new RelayCommand(() => CurrentPage = _conta);

    }
}
