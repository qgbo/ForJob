using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFor
{
    
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class MyAttr : Attribute
    {
        public MyAttr(string FiledName, string unit)
        {
            this.FiledName = FiledName;
            this.Unit = unit;
        }
        
        public string FiledName { get; set; }
        public string Unit { get; set; }
    }
}
