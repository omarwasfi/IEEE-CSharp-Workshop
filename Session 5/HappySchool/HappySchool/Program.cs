using HappySchool.DataModels;
using System;
using System.Collections.Generic;

namespace HappySchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the happy school !");
            Console.WriteLine("Choose a number: ");

            List<Student> students = new List<Student>();


            while (true)
            {
                Console.WriteLine("1- Add Student.");
                Console.WriteLine("2- Readd all Students.");
                Console.WriteLine("3- Print students.");

                int input = 0;

                input = int.Parse(Console.ReadLine());

                if(input == 1)
                {

                    int x = 0;


                    while(x == 0)
                    {
                        Console.WriteLine("Enter the student info: ");

                        Console.WriteLine("Enter the student Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the student Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the student Age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the list of subs: ");

                        List<string> subs = new List<string>();

                        int u = 0;
                        while (u == 0)
                        {
                            Console.WriteLine("Enter subject name: ");

                            string newSub = Console.ReadLine();

                            subs.Add(newSub);

                            
                            Console.WriteLine("Enter y if you want to add a new subject: ");
                           
                            char userInput2 = char.Parse(Console.ReadLine());

                            if (userInput2 == 'y')
                            {

                            }
                            else
                            {
                                u = 1;
                            }

                        }

                        Student newStudent = new Student();
                        newStudent.Id = id;
                        newStudent.Name = name;
                        newStudent.Age = age;
                        newStudent.Subs = subs;

                        students.Add(newStudent);

                        Console.WriteLine("Enter y if you want to add a new student: ");

                        char userInput = char.Parse(Console.ReadLine());

                        if(userInput == 'y')
                        {

                        }
                        else
                        {
                            x = 1;
                        }


                    }

                    Console.WriteLine("U have added all the students.");



                    Console.WriteLine("------------------------------------------------------------------------------");
                }
                else if (input == 2)
                {
                   

                    Console.WriteLine("U have added all the students.");


                    Console.WriteLine("------------------------------------------------------------------------------");
                }
                else if( input == 3)
                {
                    for(int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine("Student number: " + (i+1) );
                        Console.WriteLine();
                        Console.WriteLine("Id" + students[i].Id);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Age: " + students[i].Age);
                        Console.WriteLine("Subjects: ");

                        for(int y = 0; y < students[i].Subs.Count; y++)
                        {
                            Console.WriteLine(" - " + students[i].Subs[y]);
                        }


                        Console.WriteLine();
                        Console.WriteLine();

                    }

                    Console.WriteLine("------------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Wrong choice");
                    Console.WriteLine("Please rechoose again.");
                    Console.WriteLine("------------------------------------------------------------------------------");
                }

            }

        }
    }
}
