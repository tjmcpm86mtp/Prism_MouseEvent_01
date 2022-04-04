using Prism.Mvvm;
using Prism.Commands;

namespace Prism_MouseEvent_01.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            APage = new APageViewModel();
            BPage = new BPageViewModel();
            CurrentPage = APage;
            //CurrentPage = BPage;
        }

        private BindableBase _CurrentPage;
        public BindableBase CurrentPage
        {
            get { return _CurrentPage; }
            set
            {
                if (_CurrentPage != value)
                {
                    _CurrentPage = value;
                    RaisePropertyChanged("CurrentPage");
                }
            }
        }

        private APageViewModel _APage;
        public APageViewModel APage
        {
            get { return _APage; }
            set
            {
                if (_APage != value)
                {
                    _APage = value;
                    RaisePropertyChanged("APage");
                }
            }
        }

        private BPageViewModel _BPage;
        public BPageViewModel BPage
        {
            get { return _BPage; }
            set
            {
                if (_BPage != value)
                {
                    _BPage = value;
                    RaisePropertyChanged("BPage");
                }
            }
        }

        private DelegateCommand _togglePageCommand;
        public DelegateCommand TogglePageCommand
        {
            get
            {
                if (_togglePageCommand == null)
                {
                    _togglePageCommand = new DelegateCommand(TogglePage);
                }
                return _togglePageCommand;
            }
        }

        private void TogglePage()
        {
            // AページだったらBページに切り替え
            if (CurrentPage == APage)
            {
                CurrentPage = BPage;
            }
            // BページだったらAページに切り替え
            else if (CurrentPage == BPage)
            {
                CurrentPage = APage;
            }
        }
    }
}
