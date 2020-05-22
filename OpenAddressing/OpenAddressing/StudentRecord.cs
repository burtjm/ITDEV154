using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAddressing
{
    class StudentRecord
    {
        private int studentId;
        private String studentName;

        public StudentRecord(int i, String name)
        {
            studentId = i;
            studentName = name;
        }

        public int getstudentId()
        {
            return studentId;
        }

        public void setstudentId(int i)
        {
            studentId = i;
        }

        public String toString()
        {
            return studentId + " " + studentName + " ";
        }
    }
}
