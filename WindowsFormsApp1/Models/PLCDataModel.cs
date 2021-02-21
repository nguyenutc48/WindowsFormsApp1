using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PLCDataModel//: INotifyPropertyChanged
    {
        public PLCDataModel()
        {

        }
        private string _spd_dongco1;
        public string Spd_dongco1 
        { 
            get => _spd_dongco1; 
            set {
                _spd_dongco1 = value;
                //OnPropertyChanged("Spd_dongco1");
            } 
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged(string newName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(newName));
        //    }
        //}
    }
}
