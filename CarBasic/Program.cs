using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using CarBasic.negosio;

namespace CarBasic
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Game game = new Game(800, 600, "Car Hellow World");
        }
    }
}
