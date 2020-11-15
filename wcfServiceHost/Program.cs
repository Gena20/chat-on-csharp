﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcfServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(wcfService.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Host started");
                Console.ReadKey();
            }
        }
    }
}
