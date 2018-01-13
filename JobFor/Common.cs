using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobFor
{
    public class Common
    {
        public static void print<T>(T model)
        {
            Type t = model.GetType();
            PropertyInfo[] PropertyList = t.GetProperties();
            foreach (PropertyInfo item in PropertyList)
            {
                string name = item.Name;
                string unit = "";
                object[] attr=   item.GetCustomAttributes(true);
                if (attr != null && attr.Length > 0)
                {
                    unit = ((MyAttr)attr[0]).Unit;
                }


                object value = item.GetValue(model, null);
                Console.Write(item.Name+":"+ value +unit+", ");
            }
            Console.WriteLine("");


        }
    }
}
