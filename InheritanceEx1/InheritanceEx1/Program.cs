using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx1
{
    class Program
    {
        static int choice = 0;
        static bool check = true;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1) Student");
                Console.WriteLine("2) Teacher");
                Console.WriteLine("3) Exit");
                Console.WriteLine();
                Console.WriteLine("Please enter your choice");
                check = int.TryParse(Console.ReadLine(), out choice);
                if (check == false)
                {
                    Console.WriteLine("Invalid entry, please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (choice > 3)
                {
                    Console.WriteLine("Please enter a number between 1 and 3");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {

                    switch (choice)
                    {
                        case 1:
                            StudentEntry();
                            break;
                        case 2:
                            TeacherEntry();
                            break;
                        case 3:
                            break;
                        default:
                            break;


                    }
                }
            } while (choice != 3);
        }
        static void StudentEntry()
        {
            Console.Clear();
            Console.WriteLine("Please enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Please enter your student ID");
            int studentid = int.Parse(Console.ReadLine());
            Student Person1 = new Student(firstname, lastname, studentid);
            Console.WriteLine();
            Console.WriteLine("Your details are");
            Console.WriteLine(Person1.GetStdtDeets());
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void TeacherEntry()
        {
            Console.Clear();
            Console.WriteLine("Please enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Please enter your employee ID");
            string empid = (Console.ReadLine());
            Console.WriteLine("Please  enter your office number");
            string office = Console.ReadLine();
            Teacher Person1 = new Teacher(firstname, lastname, empid, office);
            Console.WriteLine();
            Console.WriteLine("Your details are");
            Console.WriteLine(Person1.GetTeechDeets());
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
