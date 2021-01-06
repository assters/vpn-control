using System;
using System.Collections.Generic;
using System.Text;

namespace desconekt
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c rasdial /d");
        }
    }
}
