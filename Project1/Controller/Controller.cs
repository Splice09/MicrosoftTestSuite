using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.HelloWorld;
using Project1.NumbersPractice;

namespace Project1.Controller
{
    class Controller
    {
        public static void Main(String[] args)
        {
            HelloClass hello = new HelloClass();
            hello.toString(args);
            PiToTheNth pi = new PiToTheNth();
            pi.getUserInput();
        }

    }
}
