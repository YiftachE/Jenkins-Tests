using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GetMeData
{
    public class HttpData
    {
        public HttpData()
        {

        }

        public string GetStringJsonData()
        {
            using (HttpClient client = new HttpClient())
            {
                return client.GetStringAsync(@"http://www.thomas-bayer.com/sqlrest/CUSTOMER/").Result;
            }
        }        

    }
}
