using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delMeNav
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c rasdial NAMAE_CONN MOE_NAMAE MOE_PASSOWODE");
        }
    }
}
