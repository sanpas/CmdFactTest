using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppCmdFactTest.ProtocoleCom;

namespace WindowsFormsAppCmdFactTest.FactoryCom
{
    public class FactoryProtocoleCom : IFactoryProtocoleCom
    {
        public IProtocoleCommunication ProtocoleCommunication(ProtocoleCommunicationInfo protocoleCommunicationInfo)
        {
            //Permet de construire la bonne DAL en fonction de l'ERP
            switch (protocoleCommunicationInfo)
            {
                case ProtocoleCommunicationInfo.COMA:
                    return new ProtocoleCommunicationA();
                case ProtocoleCommunicationInfo.COMB:
                    return new ProtocoleCommunicationB();
                case ProtocoleCommunicationInfo.COMC:
                    return new ProtocoleCommunicationC();
                case ProtocoleCommunicationInfo.COMD:
                    return new ProtocoleCommunicationD();
                case ProtocoleCommunicationInfo.COME:
                    return new ProtocoleCommunicationE();
            }
            throw new Exception("Err protocole");
        }
    }
}
