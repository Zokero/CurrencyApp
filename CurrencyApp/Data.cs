using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp
{
    public class Data : INotifyPropertyChanged

    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Data()
        {
            this.Name = "PLN";
            this.Date = new DateTime(2002, 1, 2);
            this.Value = 3.12;
        }
        public string Summary
        {
            get
            {
                return $"{this.Name} cost {this.Value} on" + this.Date.ToString("d");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class CurrencyViewModel
    {
        private ObservableCollection<Data> currency = new ObservableCollection<Data>();
        public CurrencyViewModel()
        {
            this.currency.Add(new Data() { Name = "EUR", Value = 5.33, Date = new DateTime(2005, 5, 2) });
            this.currency.Add(new Data() { Name = "DDD", Value = 8.23, Date = new DateTime(2065, 4, 2) });
            this.currency.Add(new Data() { Name = "EGG", Value = 7.83, Date = new DateTime(2025, 2, 2) });
            this.currency.Add(new Data() { Name = "EBB", Value = 4.43, Date = new DateTime(2015, 7, 2) });
        }
       
        public ObservableCollection<Data> Currency { get { return this.currency;} }
        private Data defaultCurrency = new Data();
        public Data DefaultCurrency
        {
            get
            {
                return this.defaultCurrency;
            }
        }
    }
}
