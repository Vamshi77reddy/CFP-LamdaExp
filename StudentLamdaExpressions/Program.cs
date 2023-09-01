using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLamdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
        {
            new Student { Id = 1, Name = "Vamshi", PhoneNumber = "7730006563", Address = "Hydreabad", Age = 20, TotalMarks = 85 },
            new Student { Id = 2, Name = "Sai", PhoneNumber = "9848535242", Address = "Tirupathi", Age = 15, TotalMarks = 92 },
            new Student { Id = 3, Name = "Teja", PhoneNumber = "8955555555", Address = "Chennai", Age = 18, TotalMarks = 78 },
            new Student { Id = 4, Name = "Rahul", PhoneNumber = "8762223333", Address = "Banglore", Age = 17, TotalMarks = 88 },
        };

            //var sortedStudents = studentList.OrderByDescending(student => student.TotalMarks);
            //  var studentsBetween12And18 = studentList.Where(student => student.Age >= 12 && student.Age <= 18);
            //var studentsGroupedByAddress = studentList.GroupBy(student => student.Address);
            // var firstThreeStudents = studentList.Take(3);

            //Console.WriteLine("Students sorted by Total Marks (descending order):");
            //  foreach (var student in sortedStudents)
            // foreach (var student in studentsBetween12And18)
            //  foreach (var student in studentsGroupedByAddress)
            //foreach (var student in firstThreeStudents)
            string searchName = "Rahul"; // The name to search for

            var student = studentList.FirstOrDefault(student => student.Name == searchName);

            if (student != null)

            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Total Marks: {student.TotalMarks}");
                Console.WriteLine();
            }
            else { Console.WriteLine("Student not found"); }
        }
    }
}
