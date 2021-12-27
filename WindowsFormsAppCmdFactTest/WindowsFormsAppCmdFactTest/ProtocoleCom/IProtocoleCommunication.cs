using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCmdFactTest.ProtocoleCom
{
    public interface IProtocoleCommunication
    {
        /// <summary>
        /// CommandA
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        string CommandA(string param);

        /// <summary>
        /// CanExecuteCommandA
        /// </summary>
        /// <returns></returns>
        bool CanExecuteCommandA();

        /// <summary>
        /// CommandB
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        string CommandB(string param);
        /// <summary>
        /// CanExecuteCommandB
        /// </summary>
        /// <returns></returns>
        bool CanExecuteCommandB();


        /// <summary>
        /// CommandC
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        string CommandC(string param);
        /// <summary>
        /// CanExecuteCommandC
        /// </summary>
        /// <returns></returns>
        bool CanExecuteCommandC();


        /// <summary>
        /// CommandD
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        string CommandD(string param);
        /// <summary>
        /// CanExecuteCommandD
        /// </summary>
        /// <returns></returns>
        bool CanExecuteCommandD();


        /// <summary>
        /// CommandE
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        string CommandE(string param);
        /// <summary>
        /// CanExecuteCommandE
        /// </summary>
        /// <returns></returns>
        bool CanExecuteCommandE();
    }


}
