using System.Collections.Generic;

namespace DesignPatternsDiogoDias.Proxy
{
    public class Response
    {
        public int StatusCode { get; set; }
        public List<string> Headers { get; set; }
        public string Body { get; set; }
    }
}