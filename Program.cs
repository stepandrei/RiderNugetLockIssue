using System;
using Newtonsoft.Json;

namespace RiderNugetLockIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Message = "Hello, World!" };
            string json = JsonConvert.SerializeObject(obj);
            Console.WriteLine(json);
        }
    }
}

