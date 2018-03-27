using System.Collections.Generic;

namespace DesignPatternsDiogoDias.Proxy
{
    public class Request
    {
        public string Method { get; set; }
        public string URI { get; set; }
        public List<string> Headers { get; set; }
        public string Body { get; set; }
    }
}