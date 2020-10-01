using System;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp5
{
    class Program
    {
        private static readonly string _conn = "HostName=william-iothub.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=NSMvREJlr/jxQQa+T/sKS8xGlDvDJsuLkgh1FXmcOeE=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);
        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
            Console.Write("hejsan");
            
        }
    }
}
