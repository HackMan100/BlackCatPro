using System;

using Xamarin.Forms;
using BlackCat.Views;

namespace BlackCat
{
    public class MainPage : MasterDetailPage
    {
        SideDrawer sidedrawer;
        public MainPage()
        {
            sidedrawer = new SideDrawer();              Master = sidedrawer;              Detail = new NavigationPage(new DashBoardPage());
            sidedrawer.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Modal.MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                sidedrawer.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}

