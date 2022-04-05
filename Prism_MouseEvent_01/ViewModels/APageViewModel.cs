using System;
using Prism.Mvvm;

namespace Prism_MouseEvent_01.ViewModels
{
    public class APageViewModel : BindableBase
    {
        private string _aText;
        public string AText
        {
            get { return _aText; }
            set
            {
                if(_aText != value)
                {
                    _aText = value;
                    RaisePropertyChanged("AText");
                }
            }
        }
    }
}
