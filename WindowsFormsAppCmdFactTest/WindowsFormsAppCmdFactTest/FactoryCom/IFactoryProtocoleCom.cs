using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppCmdFactTest.ProtocoleCom;

namespace WindowsFormsAppCmdFactTest.FactoryCom
{
    public interface IFactoryProtocoleCom
    {
        IProtocoleCommunication ProtocoleCommunication(ProtocoleCommunicationInfo protocoleCommunicationInfo);
    }
}
