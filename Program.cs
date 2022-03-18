using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decostructor
{
    public class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("object is created");
        }
        ~Destructor()
        {
            Console.WriteLine("obect is destroyed");
        }
        static void Main(String[] args)
        {
            Destructor ob = new Destructor();
            ob = null;
            GC.Collect();   //call destructor explicitly
            Console.ReadLine();
        }
    } 
    }
