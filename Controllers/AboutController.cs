using Microsoft.AspNetCore.Mvc;

namespace OdeToFood
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "+55+61+9932556+44";
        }
        
        //[Route("address")]
        public string Address()
        {
            return "New Zealand";
        }
    }
}