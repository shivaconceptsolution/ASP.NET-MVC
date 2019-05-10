using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class DeptEmp
    {
        public Dept dep { get; set; }
        public Emp em { get; set; }
    }
}