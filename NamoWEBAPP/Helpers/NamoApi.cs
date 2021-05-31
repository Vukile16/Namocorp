using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NamoWEBAPP.Helpers
{
    public class NamoApi
    {
        public HttpClient Initial()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44375/") //for local (vukile)
            };
            return client;
        }
    }
}
