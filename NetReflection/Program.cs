using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NetReflection
{   
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(double);
            
            MethodInfo[] method1=t.GetMethods();
            foreach (MethodInfo info in method1)
            {
                Console.WriteLine(info.Name);
                ParameterInfo []parInfo = info.GetParameters();
                parInfo[0].GetType();
            }

            MemberInfo []memInfo = t.GetMembers();
            foreach (MemberInfo info in memInfo)
            {
                Console.WriteLine(info.Name);
            }
            
            

            Assembly a = Assembly.GetAssembly(t);
            Module[] modules = a.GetModules();
            Attribute[]k = Attribute.GetCustomAttributes(t);
            foreach (Module m in modules)
            {
                MethodInfo[] methods = m.GetMethods();
                foreach (MethodInfo info in methods)
                {
                    Console.WriteLine(info.Name);
                }
                
            }
            Console.ReadKey();
        }
    }
}
