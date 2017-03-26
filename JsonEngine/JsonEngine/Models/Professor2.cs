﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonEngine.Models
{
    public class Professor2
    {
        private string departmentsAsString;

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public IList<Department> Departments { get; set; }

        public string DepartmentsString { get { return this.departmentsAsString; } set { departmentsAsString = DepartmentsAsString(); } }

        public string DepartmentsAsString()
        {
            return String.Join(", ", Departments.Select(x => x.Name).ToArray());
        }
    }
}
