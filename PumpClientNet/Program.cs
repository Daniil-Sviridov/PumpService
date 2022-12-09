using PumpClientNet.PumpClientServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PumpClientNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PumpServiceClient client = new PumpServiceClient(new InstanceContext(new CallBackHandler()));

            client.UpdateAndCompileScript("C:\\My_Study_Csh\\Quarter4\\SOAP.REST.gRPC\\Lesson2\\PumpService\\PumpService\\Script\\script1.txt");
            client.RunScript();
            client.Close();

            Console.ReadLine();
        }
    }
}
