﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace BeginningCS.MathSequencies
{
    class MathSequenciesMethods
    {
        public static void Run()
        {
            long n = 10;
            string computation = "BeginningCS.MathSequencies.Fibonacci";
            
            char[] delimiters = { '.' };
            string algorithm = computation.Split(delimiters)[2];

            var methodEnumerable = RetrieveMethods(computation);
    
            foreach (MethodInfo methodInfo in methodEnumerable)
            {
                ExecuteAndMeasureMethod(methodInfo, n, algorithm);
            }

        }

        private static IEnumerable<MethodInfo> RetrieveMethods(string computation)
        {
            var a = Type.GetType(computation);
            MethodInfo[] methods = a.GetMethods(BindingFlags.Public | BindingFlags.Static);
            IEnumerable<MethodInfo> methodEnumarable = methods.OrderBy(method => method.Name);
            
            return methodEnumarable;
        }

        private static void ExecuteAndMeasureMethod(MethodInfo methodInfo, long n, string algorithm="")
        {
            Func<long, long>  method = (Func<long, long>)Delegate.
                CreateDelegate(typeof(Func<long, long>), methodInfo);
                
            string output_format = "{0} of {1} is {2} ({3}): Took {4}ms";
            
            var watch = Stopwatch.StartNew();
            
            long result = method(n); watch.Stop();

            Console.WriteLine(output_format, algorithm, n, result, methodInfo.Name, watch.ElapsedMilliseconds);
        }
    }
}
