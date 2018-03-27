using System;

namespace DesignPatternsDiogoDias.Proxy.Impl
{
    public class HttpClientProxy : IHttpClient
    {
        HttpClient _client = new HttpClient();

        public Response Exec(Request request)
        {
            AssignRequest(request);

            var response = _client.Exec(request);

            Console.WriteLine("Lendo o response via proxy.");

            return response;
        }

        private void AssignRequest(Request request)
        {
            Console.WriteLine("Assinando o request com certificado digital via proxy.");
        }
    }
}
