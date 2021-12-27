using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCmdFactTest.ProtocoleCom
{
    public class ProtocoleCommunicationD : IProtocoleCommunication
    {
        public bool CanExecuteCommandA()
        {
            return false;
        }

        public bool CanExecuteCommandB()
        {
            return false;
        }

        public bool CanExecuteCommandC()
        {
            return false;
        }

        public bool CanExecuteCommandD()
        {
            return true;
        }

        public bool CanExecuteCommandE()
        {
            return false;
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
