using System;
using System.Collections.Generic;

namespace bingo
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Special { get; set; }
        public List<Student> StudentsList { get; set; } = new List<Student>();

        public void Add()
        {
            Console.WriteLine("Enter Student ID:");
            if (int.TryParse(Console.ReadLine(), out int studentID))
            {
                StudentID = studentID;
            }
            else
            {
                Console.WriteLine("Invalid Student ID. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter Student Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Special:");
            Special = Console.ReadLine();

            StudentsList.Add(this);

            Console.WriteLine("Student successfully added.");
        }

        public void Edit(int studentID)
        {
            var studentToEdit = StudentsList.Find(student => student.StudentID == studentID);

            if (studentToEdit != null)
            {
                Console.WriteLine("Enter new Student Name:");
                studentToEdit.Name = Console.ReadLine();

                Console.WriteLine("Enter new Special:");
                studentToEdit.Special = Console.ReadLine();

                Console.WriteLine("Student successfully edited.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void Delete(int studentID)
        {
            var studentToDelete = StudentsList.Find(student => student.StudentID == studentID);

            if (studentToDelete != null)
            {
                StudentsList.Remove(studentToDelete);
                Console.WriteLine("Student successfully deleted.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void ViewDetails(int studentID)
        {
            var studentDetails = StudentsList.Find(student => student.StudentID == studentID);

            if (studentDetails != null)
            {
                Console.WriteLine($"Student ID: {studentDetails.StudentID}");
                Console.WriteLine($"Student Name: {studentDetails.Name}");
                Console.WriteLine($"Special: {studentDetails.Special}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
