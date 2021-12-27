using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCmdFactTest.ProtocoleCom
{
    public class ProtocoleCommunicationE : IProtocoleCommunication
    {
        public bool CanExecuteCommandA()
        {
            return true;
        }

        public bool CanExecuteCommandB()
        {
            return true;
        }

        public bool CanExecuteCommandC()
        {
            return true;
        }

        public bool CanExecuteCommandD()
        {
            return true;
        }

        public bool CanExecuteCommandE()
        {
            return true;
        }

        public string CommandA(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})"; 
        }

        public string CommandB(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})";
        }

        public string CommandC(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})";
        }

        public string CommandD(string param)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            string fullMethodName = className + "." + methodName;
            return $"{fullMethodName}({param})";
        }

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
