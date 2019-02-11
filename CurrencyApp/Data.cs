using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp
{
    class Data : INotifyPropertyChanged

    {
        private string uname;
        private string usurname;

        public Data()
        {
            uname = "XX";
            usurname = "AA";
        }

        public string Uname
        {
            get => uname;
            set
            {
                usurname = "";
            }
        }

        public string Usurname
        {
            get => usurname;
            set
            {
                usurname = value;
                Summary = "";
            }
        }

        public string Summary
        {
            get { return "Witaj, {this.Uname} {this.Usurname}"; }
            set { }
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
