using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFor
{
  public  class Boat
    {
        public string Registration { get; set; }

        [MyAttr("名称", "kw")]
        public int EnginePower { get; set; }


        [MyAttr("名称", "knot per hour")]
        public int MaxSpeed { get; set; }


        [MyAttr("名称", "kg")]
        public int GrossTonnage { get; set; }


       
    }
}
