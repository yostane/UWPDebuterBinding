using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingTutorial.P02
{
    public class P02Classroom
    {
        public int studentCount { get; set; }

        public void addStudent()
        {
            this.studentCount++;
        }
    }
}
