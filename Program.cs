using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using odilibo.Helpers;
using SharperSharp;

namespace odilibo
{

    // odilibo ionic create page map
    // inside www/app/pages
      // ==> creates folder called map
        // ==> in that folder  2 files map.html & mapCtrl.js
    class Program
    {
        static void Main(string[] args)
        {
            // Ionic.CreatePage("map");
            try
            {
                Type type = Type.GetType("odilibo." + args[0], throwOnError: false, ignoreCase: true);
                MethodInfo method = type?.GetMethod(args[1] + args[2],
                    BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

                if (method == null) ConsoleHelper.WriteError("Wrong Input");

                var a = args.ToList();
                a.RemoveAt(0); a.RemoveAt(0); a.RemoveAt(0);
                method?.Invoke(null, a.ToArray());
            }
            catch (Exception)
            {
                ConsoleHelper.WriteError("Wrong parameters");
            }
            
            //Console.WriteLine(Environment.CurrentDirectory);
        }
        



        public static string[] GetAllTechnologies()
        {
            return ClassesManager.GetAllClassesInNameSpace(Assembly.GetExecutingAssembly(), "odilibo.Technologies");
        }

    }

}
