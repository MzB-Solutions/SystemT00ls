using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SManager.Core.Logger
{
    public class Logger
    {
        public static void DoLog(string message)
        {
            Console.WriteLine($"The following message was logged: {message}");
        }
    }
}