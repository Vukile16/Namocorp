using Microsoft.AspNetCore.Mvc;
using NamoWEBAPP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NamoWEBAPP.Controllers
{
    public class BaseController : Controller
    {
        public readonly NamoApi namoApi = new NamoApi();
        public HttpClient httpClient;
        public HttpResponseMessage responseMessage;
    }
}
