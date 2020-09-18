﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IB120045_Mobile.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage1MenuItem> MenuItems { get; set; }
            
            public MasterDetailPage1MasterViewModel()
            {
                if (Global.LogiraniKorisnik.Aktivan)
                {
                    MenuItems = new ObservableCollection<MasterDetailPage1MenuItem>(new[]
                {
                    new MasterDetailPage1MenuItem { Title = "Pregled aktivnosti", ImageSource="list-searching-variant.png",TargetType=typeof(Aktivnosti.PregledAktivnosti)  },
                    new MasterDetailPage1MenuItem { Title = "Korisnički podaci", ImageSource="resume.png",TargetType=typeof(KorisnickiProfil)  },
                          new MasterDetailPage1MenuItem { Title = "Prijava u dom", ImageSource="document.png",TargetType=typeof(Aktivnosti.Prijava)  },
                    new MasterDetailPage1MenuItem { Title = "Odjavi se", ImageSource="arrow.png",TargetType=typeof(Login)  }
                    });
                }
                else
                {
                    MenuItems = new ObservableCollection<MasterDetailPage1MenuItem>(new[]
                 {
                    new MasterDetailPage1MenuItem { Title = "Prijavi se", ImageSource = "log-in (2).png", TargetType = typeof(Login) } ,
                    new MasterDetailPage1MenuItem { Title = "Registruj se", ImageSource = "user.png", TargetType = typeof(Registracija) },
                    });
                }
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}