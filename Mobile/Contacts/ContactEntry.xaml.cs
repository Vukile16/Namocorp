using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Contacts.Models;
using Contacts.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactEntry : ContentPage
    {
        readonly ContactService contactService = new ContactService();
        
        public ContactEntry()
        {
            InitializeComponent();
            BindingContext = this;
        }



        async void OnSaveButtonClicked(object sender, EventArgs e)
        {

            if (BindingContext is Contact context)
            {                
                var name = context.Name;
                var contactNumber = context.ContactNumber;
                var email = context.Email;
                var patternCheck = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                bool checkIfEmailValid = Regex.IsMatch(email, patternCheck);

                if (checkIfEmailValid == false)
                {
                    await DisplayAlert("Error", "Please enter a valid email address", "OK");
                }
                else
                {
                    var contact = new Contact
                    {
                        Name = name,
                        ContactNumber = contactNumber.ToString(),
                        Email = email,
                        Date = DateTime.Now
                    };

                    int insertResult = await contactService.SaveContactAsync(contact);

                    if (insertResult != 0)
                    {
                        await DisplayAlert("Success", "Contact added succesffully", "OK");
                        await Navigation.PushAsync(new ContactPage());
                    }
                }

            }

           
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (BindingContext is Contact context)
            {

                var contact = new Contact
                {
                    ID = context.ID,
                    Name = context.Name,
                    ContactNumber = context.ContactNumber,
                    Email = context.Email,
                    Date = context.Date
                };

                int insertResult = await contactService.DeleteContactAsync(contact);

                if (insertResult != 0)
                {
                    await DisplayAlert("Success", "Contact deleted succesffully", "OK");
                    await Navigation.PushAsync(new ContactPage());
                }
            }
           
        }
    }
}