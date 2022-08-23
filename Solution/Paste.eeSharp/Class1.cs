using System;

using RestSharp;

namespace Paste.eeSharp
{
    public static class Class1
    {
        public static void Test()
        {
            // dev key aFKs40Pq88vIf4UjaZZ0WGrWmCzNidiJFxqsUnxtZ
            // app key uPmIldHDXAtpWVF3l240O2kuk984uaMMc4tKOIkvU
            string key = "uPmIldHDXAtpWVF3l240O2kuk984uaMMc4tKOIkvU";
            /*RestClient restClient = new RestClient(new RestClientOptions { BaseUrl = new Uri("https://api.paste.ee/v1/") });
            RestRequest request = new RestRequest("pastes", Method.Get);
            request.AddParameter("key", key);*/

            //var r = restClient.Execute(request);
            //Console.WriteLine(r.Content);
            //uPmIldHDXAtpWVF3l240O2kuk984uaMMc4tKOIkvU
            //aFKs40Pq88vIf4UjaZZ0WGrWmCzNidiJFxqsUnxtZ
            string key2 = "aFKs40Pq88vIf4UjaZZ0WGrWmCzNidiJFxqsUnxtZ";
            //RestClient restClient2 = new RestClient(new RestClientOptions { BaseUrl = new Uri($"https://paste.ee/account/api/authorize/") });
            RestClient restClient2 = new RestClient(new RestClientOptions { BaseUrl = new Uri($"https://api.paste.ee/v1/syntaxes") });
            RestRequest request2 = new RestRequest(/*"uPmIldHDXAtpWVF3l240O2kuk984uaMMc4tKOIkvU"*/"", Method.Get);
            request2.AddParameter("key", key2);

            var r2 = restClient2.Execute(request2);
            Console.WriteLine(r2.Content);
        }
    }
}
