using System;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string _conn = "HostName=ec-win-iothub.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=3zsfBvJy2yTIaBEoTQpnnbD1jX4Z1Juz3g8jhLSjX8M=";



        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);


        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceService.RecieveMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }
    }
}
