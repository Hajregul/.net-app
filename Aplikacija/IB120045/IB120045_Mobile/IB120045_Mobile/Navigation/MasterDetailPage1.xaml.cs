﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IB120045_Mobile.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1(ContentPage startPage = null)
        {
            InitializeComponent();

            Detail = startPage != null ?
           new NavigationPage(startPage) :
            new NavigationPage(new Login());
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}