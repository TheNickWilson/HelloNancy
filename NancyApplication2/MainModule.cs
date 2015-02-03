using System.Security.Principal;
using Nancy;

namespace NancyApplication2
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}