using System;

namespace DesignPatternsDiogoDias.Proxy.Impl
{
    public class HttpClient : IHttpClient
    {
        public Response Exec(Request request)
        {
            Console.WriteLine("Executando o request...");

            return new Response();
        }
    }
}
