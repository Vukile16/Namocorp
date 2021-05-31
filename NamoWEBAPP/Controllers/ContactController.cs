using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NamoWEBAPP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NamoWEBAPP.Controllers
{
    public class ContactController : BaseController
    {

        public ContactController()
        {

        }

        readonly ContactDetailController contactDetail = new();


        // GET: ContactController
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Contact> contacts = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.GetAsync("api/Contacts");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var results = responseMessage.Content.ReadAsStringAsync().Result;
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(results);
                }

                return View(contacts);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }

        }  
        
        public async Task<ActionResult> GetContactsOver35()
        {
            try
            {
                List<Contact> contacts = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.GetAsync("api/Get35Contacts");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var results = responseMessage.Content.ReadAsStringAsync().Result;
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(results);
                }

                return View(contacts);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }

        }

        // GET: get all services
        public async Task<List<ContactType>> GetContactTypes()
        {
            try
            {
                List<ContactType> typeList = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.GetAsync("api/ContactTypes");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var results = responseMessage.Content.ReadAsStringAsync()
                        .Result;
                    typeList = JsonConvert.DeserializeObject<List<ContactType>>(results);
                }
                return typeList;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        // GET: get contact type
        [HttpGet]
        public async Task<ContactType> GetContactType(int id)
        {
            try
            {
                ContactType type = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.GetAsync($"api/ContactTypes/{id}");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var results = responseMessage.Content.ReadAsStringAsync()
                        .Result;
                    type = JsonConvert.DeserializeObject<ContactType>(results);
                }
                return type;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }

        }



        // GET: ContactController/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            try
            {
                List<Contact> contacts = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.GetAsync($"api/Contacts/{id}");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var results = responseMessage.Content.ReadAsStringAsync().Result;
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(results);
                }

                return View(contacts);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        // GET: ContactController/Create
        public async Task<ActionResult> Create()
        {
            List<ContactType> typeList = await GetContactTypes();
            ViewBag.TypeList = typeList;
            return View();
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Contact contact, IFormCollection collection)
        {
            try
            {
                List<ContactType> typeList = await GetContactTypes();
                ViewBag.TypeList = typeList;

                httpClient = namoApi.Initial();

                var postTask = await httpClient.PostAsJsonAsync("api/Contacts", contact);

                if (postTask.IsSuccessStatusCode)
                {
                    var results = postTask.Content.ReadAsStringAsync().Result;
                    Contact contact1 = JsonConvert.DeserializeObject<Contact>(results);

                    int contactId = contact1.ContactId;
                    contact.ContactDetail.ContactTypeId = contact.ContactType.ContactTypeId;

                    string output = await contactDetail.AddContactDetail(contact.ContactDetail, contactId);

                    if (output == "added")
                    {
                        return RedirectToAction("Index", "Contact");
                    }

                }

                return RedirectToAction("Index", "Contact");

            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        // GET: ContactController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                List<ContactType> typeList = await GetContactTypes();
                ViewBag.TypeList = typeList;


                List<Contact> contacts = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.GetAsync($"api/Contacts/{id}");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var results = responseMessage.Content.ReadAsStringAsync().Result;
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(results);
                }
                foreach (var item in contacts)
                {
                    ViewBag.ContactType = await GetContactType((int)item.ContactDetail.ContactType.ContactTypeId);
                }
                return View(contacts);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        // POST: ContactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, List<Contact> contacts, IFormCollection collection)
        {
            try
            {
                foreach (var contact in contacts)
                {
                    List<ContactType> typeList = await GetContactTypes();
                    ViewBag.TypeList = typeList;

                    httpClient = namoApi.Initial();

                    var postTask = await httpClient.PutAsJsonAsync("api/Contacts/" + contact.ContactId, contact);


                    if (postTask.IsSuccessStatusCode)
                    {
                        //var results = postTask.Content.ReadAsStringAsync().Result;
                        //Contact contact1 = JsonConvert.DeserializeObject<Contact>(results);

                        //int contactId = contact1.ContactId;
                        contact.ContactDetail.ContactTypeId = contact.ContactType.ContactTypeId;
                        contact.ContactDetail.ContactId = contact.ContactId;

                        string output = await contactDetail.UpdateContactDetail(contact.ContactDetail, contact.ContactDetail.ContactDetailId);

                        if (output == "added")
                        {
                            return RedirectToAction("Index", "Contact");
                        }
                    }
                }
                return RedirectToAction("Index", "Contact");

            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        // GET: ContactController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                List<Contact> contacts = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.GetAsync($"api/Contacts/{id}");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var results = responseMessage.Content.ReadAsStringAsync().Result;
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(results);
                }

                return View(contacts);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        // POST: ContactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                List<Contact> contacts = new();
                httpClient = namoApi.Initial();
                responseMessage = await httpClient.DeleteAsync($"api/Contacts/{id}");

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Contact");

                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }
    }
}
