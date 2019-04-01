using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssamblyTwo
{
    public class Class1 :AssamblyOne.AssemblyOneClassO
    {
        public void d()
        {
            AssamblyOne.AssemblyOneClassO p = new AssamblyOne.AssemblyOneClassO();
            // p.ID = 22;
            Class1 dsd = new Class1();
            Console.WriteLine(   dsd.ID);
        }        
    }
}
