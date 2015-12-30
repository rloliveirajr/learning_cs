using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace BeginningCS
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 50;
            string computation = "BeginningCS.Fibonacci";
            var methodEnumerable = RetrieveMethods(computation);

            foreach (MethodInfo methodInfo in methodEnumerable)
            {
                run(methodInfo, n);
            }

        }

        private static IEnumerable<MethodInfo> RetrieveMethods(string computation)
        {
            Type a = Type.GetType(computation);
            MethodInfo[] methods = a.GetMethods(BindingFlags.Public | BindingFlags.Static);
            IEnumerable<MethodInfo> methodEnumarable = methods.OrderBy(method => method.Name);
            
            return methodEnumarable;
        }

        static void run(MethodInfo methodInfo, long n)
        {
            Func<long, long>  method = (Func<long, long>)Delegate.
                CreateDelegate(typeof(Func<long, long>), methodInfo);
                
            string output_format = "Fibonacci of " + n + " is {0} ({1})";
            
            Stopwatch watch = Stopwatch.StartNew();
            
            long result = method(n); watch.Stop();

            string text = String.Format(output_format, result, methodInfo.Name);
            Console.WriteLine(text + ": Took " + watch.ElapsedMilliseconds + "ms");
        }
    }
}
