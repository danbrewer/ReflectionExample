using System;
using Microsoft.Extensions.Configuration;

namespace ReflectionExample
{
     public class ConsoleApp
     {
          public static void Main()
          {
               var configuration =  new ConfigurationBuilder()
                     .AddJsonFile($"appsettings.json");
                var config = configuration.Build();

                var whichAssemblyConfiguration = config["WhichAssemblyConfiguration"];
                var assemblyName = config[$"{whichAssemblyConfiguration}:Assembly"];
                var className = config[$"{whichAssemblyConfiguration}:Class"];

                var assembly = System.Reflection.Assembly.LoadFile(assemblyName);
                var type = assembly.GetType(className);
                var instance = Activator.CreateInstance(type);
                ISayHello hello = (ISayHello)instance;
                Console.WriteLine(hello.Hello());

          }
     }
}

