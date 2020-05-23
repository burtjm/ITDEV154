using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class EmployeeRecord
    {
        private int key;
        // Importance of task (A,B,C ...)
        private String Position;
        // What needs to be done
        private String Salary;
        // What day of the week the task needs to be done by
        private String Location;

        public EmployeeRecord(int Id, String position, String salary, String city)
        {
            key = Id;
            position = Position;
            salary = Salary;
            city = Location;
        }

        public int getkey()
        {
            return key;
        }

        public String getPosition()
        {
            return Position;
        }

        public String getSalary()
        {
            return Salary;
        }

        public String getCity()
        {
            return Location;
        }

        public void setId(int id)
        {
            key = id;
        }

        public void setPosition(String position)
        {
            position = Position;
        }

        public void setLocation(String city)
        {
            city = Location;
        }

        public void setSalary(String salary)
        {
            salary = Salary;
        }

        public String toString()
        {
            return key + " [" + Position + "] " + Salary + " " + Location;
        }
    }
}

