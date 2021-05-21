using Newtonsoft.Json;
using System;
using System.Xml;
using System.Net;
using System.IO;

namespace AuthenticationRequest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            JSONRequest requestTest = new JSONRequest();
            requestTest.TryLogin();
            requestTest.formRequestData();
            requestTest.createNewTestJSONRecord();
            Console.ReadKey();

        }
    }
}
