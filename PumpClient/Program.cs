using PumpClient;
using PumpServiceServiceReference;
using System.ServiceModel;

PumpServiceClient client = new PumpServiceClient(new InstanceContext( new CallBackHandler()));

client.UpdateAndCompileScriptAsync("C:\\My_Study_Csh\\Quarter4\\OAP.REST.gRPC\\Lesson2\\PumpService\\PumpService\\Script\\script1.txt");
client.RunScriptAsync();
client.Close();

Console.ReadLine();