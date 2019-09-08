namespace ProxyPattern.Concrete
{
    public class Client
    {
        public void Execute()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
