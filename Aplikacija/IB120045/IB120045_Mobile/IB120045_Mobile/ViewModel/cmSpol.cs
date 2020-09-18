using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace IB120045_Mobile.ViewModel
{
    public class Spol
    {
        public int SpolID { get; set; }
        public string Naziv { get; set; }
    }

    public class RootModel : INotifyPropertyChanged
    {

        List<Spol> spolList;
        public List<Spol> SpolList
        {
            get { return spolList; }
            set
            {
                if (spolList != value)
                {
                    spolList = value;
                    OnPropertyChanged();
                }
            }
        }

        Spol selectedspol;
        public Spol SelectedSpol
        {
            get { return selectedspol; }
            set
            {
                if (selectedspol != value)
                {
                    selectedspol = value;
                    OnPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
