using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAddressing
{
    class HashTable
    {
        private StudentRecord[] array;
        private int m; //size of the array
        int n;         //number of records

        public HashTable() : this(11)
        {

        }

        public HashTable(int tableSize)
        {
            m = tableSize;
            array = new StudentRecord[m];
            n = 0;
        }

        int hash(int key)
        {
            return (key % m);
        }

        public void Insert(StudentRecord newRecord)
        {
            int key = newRecord.getstudentId();
            int h = hash(key);

            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null || array[location].getstudentId() == -1)
                {
                    array[location] = newRecord;
                    n++;
                    return;
                }

                if (array[location].getstudentId() == key)
                    throw new System.InvalidOperationException("Duplicate key");

                location = (h + i) % m;
            }
            Console.WriteLine("Table is full : Record can't be inserted ");
        }

        public StudentRecord Search(int key)
        {
            int h = hash(key);
            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null)
                {
                    return null;
                }
                if (array[location].getstudentId() == key)
                    return array[location];
                location = (h + i) % m;
            }
            return null;
        }

       /* internal void Insert(StudentRecord aRecord)
        {
            throw new NotImplementedException();
        }*/ 

        public void DisplayTable()
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write("[" + i + "]  -->  ");

                if (array[i] != null && array[i].getstudentId() != -1)
                    Console.WriteLine(array[i].toString());
                else
                    Console.WriteLine("___");
            }
        }

        public StudentRecord Delete(int key)
        {
            int h = hash(key);
            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].getstudentId() == key)
                {
                    StudentRecord temp = array[location];
                    array[location].setstudentId(-1);
                    n--;
                    return temp;
                }
                location = (h + i) % m;
            }
            return null;
        }
    }
}

