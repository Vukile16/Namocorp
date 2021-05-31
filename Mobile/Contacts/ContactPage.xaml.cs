using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Models;
using Contacts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        
        public ContactPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();


            listView.ItemsSource = new ContactPageViewModel().Contacts;
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactEntry
            {
                BindingContext = new Contact()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ContactEntry
                {
                    BindingContext = e.SelectedItem as Contact
                });
            }
        }
    }
}