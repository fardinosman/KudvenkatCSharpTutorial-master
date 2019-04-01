using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssamblyOne
{
    public class AssemblyOneClassO
    {
       protected internal int ID = 101;
    }

    public class AssembltOneClassTwo
    {
        public void SampleMethod()
        {
            AssemblyOneClassO assemblyOneClassO = new AssemblyOneClassO();
            Console.WriteLine(   assemblyOneClassO.ID); 
        }
    }
}
