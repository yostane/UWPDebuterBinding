using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace BindingTutorial.P03
{
    public class P03Classroom : BindableBase
    {
        private int _studentCount;
        //bound property
        public int studentCount {
            get { return this._studentCount; }
            set { this.SetProperty(ref this._studentCount, value); }
        }

        public void addStudent()
        {
            this.studentCount++;
        }
    }
}
