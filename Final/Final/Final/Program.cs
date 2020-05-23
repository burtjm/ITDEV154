using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int key, choice;
            String Position, Salary, Location;
            Console.Write("Enter initial list size : ");
            int size = Convert.ToInt32(Console.ReadLine());

            HashTable table = new HashTable(size);

            while (true)
            {
                Console.WriteLine("1. Insert or add a record");
                Console.WriteLine("2. Search a record by Key");
                Console.WriteLine("3. Delete a record");
                Console.WriteLine("4. Display whole table");
                Console.WriteLine("5. Search a record by task");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter action to perform : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter key : ");
                        key = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Position : ");
                        Position = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        Salary = Console.ReadLine();
                        Console.Write("Enter Location (City) : ");
                        Location = Console.ReadLine();

                        EmployeeRecord aRecord = new EmployeeRecord(key, Position, Salary, Location);

                        table.Insert(aRecord);
                        break;
                    case 2:
                        Console.Write("Enter a key to be searched : ");
                        key = Convert.ToInt32(Console.ReadLine());
                        aRecord = table.Search(key);

                        if (aRecord == null)
                            Console.WriteLine("Key not found\n");
                        else
                            Console.WriteLine(aRecord.toString());

                        break;
                    case 3:
                        Console.Write("Enter a key to be deleted : ");
                        key = Convert.ToInt32(Console.ReadLine());
                        table.Delete(key);
                        break;
                    case 4:
                        table.DisplayTable();
                        break;
                    case 5:
                        Console.Write("Enter a task to be searched : ");
                        Position = Console.ReadLine();
                        aRecord = table.Search1(Position);

                        if (aRecord == null)
                            Console.WriteLine("Task not found\n");
                        else
                            Console.WriteLine(aRecord.toString());

                        break;
                }
            }
        }
    }
}
        