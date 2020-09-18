using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace IB120045_Mobile.ViewModel
{
  
      public class VrstaAktivnosti
    {
        public int VrstaAktivnostiID { get; set; }
        public string Naziv { get; set; }
    }

    public class RootModel1 : INotifyPropertyChanged
    {

        List<VrstaAktivnosti> vrsteList;
        public List<VrstaAktivnosti> VrsteList
        {
            get { return vrsteList; }
            set
            {
                if (vrsteList != value)
                {
                    vrsteList = value;
                    OnPropertyChanged1();
                }
            }
        }

        VrstaAktivnosti selectedvrste;
        public VrstaAktivnosti SelectedVrste
        {
            get { return selectedvrste; }
            set
            {
                if (selectedvrste != value)
                {
                    selectedvrste = value;
                    OnPropertyChanged1();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged1([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

   
    }
}
