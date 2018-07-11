using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Class
{
    class Class_Employee:Object
    {
       public  string EmpName { get; set; }
       public  DateTime HireDate { get; set; }
       public string EmpImage { get; set; }

        public override string ToString()
        {
            return EmpName+"-" +HireDate;
        }
    }
    
}
