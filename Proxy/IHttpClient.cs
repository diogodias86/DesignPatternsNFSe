namespace DesignPatternsDiogoDias.Proxy
{
    public interface IHttpClient
    {
        Response Exec(Request request);
    }
}
