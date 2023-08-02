using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebTemplate
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Template.Create(args[0], args[1]);
        }
    }
}