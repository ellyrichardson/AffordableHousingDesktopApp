using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AffordableHousingDesktopApp
{
    class RestAPIConnection
    {
        private string baseURL = "http://localhost:8000/api/search/";
        //private const string URL = bas;
        //private string urlParameters = "?search=kansas";

        public string getSearchResults(string urlParameters)
        {
            string searchURL = baseURL + urlParameters;
            var apirequest = (HttpWebRequest)System.Net.WebRequest.Create(searchURL);

            var stringJSONResult = "dummy";
            using (var response = apirequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                stringJSONResult = Convert.ToString(result);
                string RESULT = Convert.ToString(result);
                Console.WriteLine(RESULT);
            }

            return stringJSONResult;
        }
    }
}
