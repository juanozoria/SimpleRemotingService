using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemotingServiceIntro;

namespace HelloRemotingService
{
    public class HelloRemotingService : MarshalByRefObject, 
        IHelloRemotingService
    {


        public string GetMessage(string mensaje)
        {
            return "Hello " + mensaje;
        }
    }
}
