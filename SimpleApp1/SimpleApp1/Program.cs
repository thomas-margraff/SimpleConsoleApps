using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // comment
            SomeShit.Log("a message");
        }
    }

    static class SomeShit
    {
        // should show up in branch1
        public static void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }


}
