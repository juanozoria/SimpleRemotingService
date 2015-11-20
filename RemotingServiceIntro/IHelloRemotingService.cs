using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemotingServiceIntro
{
    public interface IHelloRemotingService
    {
        string GetMessage(string mensaje);
    }
}
