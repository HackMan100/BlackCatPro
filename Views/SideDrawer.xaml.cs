using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BlackCat.Views
{
    public partial class SideDrawer : ContentPage
    {
        public ListView ListView
        {
            get
            {
                return listView;
            }
        }
        public SideDrawer()
        {
            InitializeComponent();
            Icon = "";
            Title = " ";

            var masterPageItems = new List<Modal.MasterPageItem>();
            masterPageItems.Add(new Modal.MasterPageItem
            {
                Title = "DashBoard",
                IconSource = "",
                TargetType = typeof(DashBoardPage)
            });
            masterPageItems.Add(new Modal.MasterPageItem
            {
                Title = "Contact Us",
                IconSource = "",
                TargetType = typeof(ContactusPage)
            });
            masterPageItems.Add(new Modal.MasterPageItem
            {
                Title = "About us",
                IconSource = "",
                TargetType = typeof(AboutUsPage)
            });
            listView.ItemsSource = masterPageItems;

        }
    }
}
