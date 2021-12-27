using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCmdFactTest.ProtocoleCom
{
    public enum ProtocoleCommunicationInfo
    {
        /// <summary>
        /// COMA ==> ProtocoleCommunicationA
        /// </summary>
        COMA = 0,
        /// <summary>
        /// COMB ==> ProtocoleCommunicationB
        /// </summary>
        COMB = 1,
        /// <summary>
        /// COMC ==> ProtocoleCommunicationC
        /// </summary>
        COMC = 2,
        /// <summary>
        /// COMD ==> ProtocoleCommunicationD
        /// </summary>
        COMD = 3,
        /// <summary>
        /// COME ==> ProtocoleCommunicationE
        /// </summary>
        COME = 4
    }

    /// <summary>
    /// ProtocoleCommunicationExtensions
    /// </summary>
    public static class ProtocoleCommunicationExtensions
    {
        public static ProtocoleCommunicationInfo GetProtocoleCommunicationValue(string comCode)
        {
            return (ProtocoleCommunicationInfo)Enum.Parse(typeof(ProtocoleCommunicationInfo), comCode);
        }
    }
}
