using Contacts.Models;
using Contacts.Services;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.ViewModels
{
    public class ContactPageViewModel : BaseViewModel
    {
        readonly ContactService contactService = new ContactService();
        public ObservableRangeCollection<Contact> Contacts = new ObservableRangeCollection<Contact>();

        public ContactPageViewModel()
        {
            LoadContacts();
        }

        //get all the contacts
        async void LoadContacts()
        {
            Contacts.Clear();

            var contacts = await contactService.GetAllContactsAsync();

            Contacts.AddRange(contacts);
        }

    }
}
