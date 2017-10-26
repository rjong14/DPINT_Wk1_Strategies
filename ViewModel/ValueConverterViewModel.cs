using DPINT_Wk1_Strategies.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DPINT_Wk1_Strategies
{
    public class ValueConverterViewModel : ViewModelBase
    {
        private string fromText;
        public string FromText
        {
            get { return fromText; }
            set
            {
                fromText = value;
                RaisePropertyChanged("FromText");
                this.ConvertNumbers();
            }
        }

        private string toText;
        public string ToText
        {
            get { return toText; }
            set
            {
                toText = value;
                RaisePropertyChanged("ToText");
            }
        }

        private string fromConverterName = "Numerical";
        public string FromConverterName
        {
            get { return fromConverterName; }
            set
            {
                fromConverterName = value;
                RaisePropertyChanged("FromConverterName");
                this.ConvertNumbers();
            }
        }

        private string toConverterName = "Numerical";
        public string ToConverterName
        {
            get { return toConverterName; }
            set
            {
                toConverterName = value;
                RaisePropertyChanged("ToConverterName");
                this.ConvertNumbers();
            }
        }

        public ObservableCollection<string> ConverterNames { get; set; }
        public ICommand ConvertCommand { get; set; }

        private INumberConverter fromConverter;
        private INumberConverter toConverter;
        private NumberConverterFactory converterFactory;

        public ValueConverterViewModel () {
            converterFactory=new NumberConverterFactory ();
            ConverterNames=new ObservableCollection<string> (converterFactory.ConverterNames);
            FromText="0";
            ToText="0";
            ConvertCommand=new RelayCommand (ConvertNumbers);
        }

        private void ConvertNumbers () {
            fromConverter=converterFactory.GetConverter (FromConverterName);
            toConverter=converterFactory.GetConverter (ToConverterName);
            int fromNumber = fromConverter.ToNumerical (FromText);
            ToText=toConverter.ToLocalString (fromNumber);
        }


    }
}
