using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCmdFactTest.ProtocoleCom
{
    public class ProtocoleCommunicationA : IProtocoleCommunication
    {
        /// <summary>
        /// CanExecuteCommandA
        /// </summary>
        /// <returns></returns>
        public bool CanExecuteCommandA()
        {
            return true;
        }
        /// <summary>
        /// CanExecuteCommandB
        /// </summary>
        /// <returns></returns>
        public bool CanExecuteCommandB()
        {
            return true;
        }
        /// <summary>
        /// CanExecuteCommandC
        /// </summary>
        /// <returns></returns>
        public bool CanExecuteCommandC()
        {
            return true;
        }
        /// <summary>
        /// CanExecuteCommandD
        /// </summary>
        /// <returns></returns>
        public bool CanExecuteCommandD()
        {
            return true;
        }
        /// <summary>
        /// CanExecuteCommandE
        /// </summary>
        /// <returns></returns>
        public bool CanExecuteCommandE()
        {
            return false;
        }

        /// <summary>
        /// CommandA
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string CommandA(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})"; 
        }

        /// <summary>
        /// CommandB
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string CommandB(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})";
        }

        /// <summary>
        /// CommandC
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string CommandC(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})";
        }

        /// <summary>
        /// CommandD
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string CommandD(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})";
        }

        /// <summary>
        /// CommandE
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string CommandE(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})";
        }
    }
}
