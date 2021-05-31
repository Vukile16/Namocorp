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
    public class ContactDetailController : BaseController
    {
        // GET: ContactDetailController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: ContactDetailController/AddContactDetail
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> AddContactDetail(ContactDetail contactDetail, int? contactId)
        {
            try
            {
                httpClient = namoApi.Initial();
                contactDetail.ContactId = contactId;
                var postTask = await httpClient.PostAsJsonAsync("api/ContactDetails", contactDetail);

                if (postTask.IsSuccessStatusCode)
                {
                    return "added";
                }
                return "failed";
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }


        //// PUT: ContactDetailController/UpdateDetails
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> UpdateContactDetail(ContactDetail contactDetail, int? id)
        {
            try
            {
                httpClient = namoApi.Initial();
                var postTask = await httpClient.PutAsJsonAsync("api/ContactDetails/" + id, contactDetail);

                if (postTask.IsSuccessStatusCode)
                {
                    return "updated";
                }
                return "failed";
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        /// PUT: ContactDetailController/DeleteContactDetail
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> DeleteContactDetail(int? id)
        {
            try
            {
                httpClient = namoApi.Initial();
                var postTask = await httpClient.DeleteAsync($"api/ContactDetails/{id}");

                if (postTask.IsSuccessStatusCode)
                {
                    return "updated";
                }
                return "failed";
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }



        // GET: ContactDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactDetailController/Delete/5
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

        // POST: ContactDetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
