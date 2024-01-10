using System;
using System.Collections.Generic;

namespace bingo
{
    class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }

        // Utiliser une liste statique partagée par toutes les instances de la classe
        public static List<Teacher> TeachersList { get; set; } = new List<Teacher>();

        public Teacher(int teacherID, string name, string subject)
        {
            TeacherID = teacherID;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
        }

        public void Add()
        {
            Console.WriteLine("Enter Teacher ID:");
            if (int.TryParse(Console.ReadLine(), out int teacherID))
            {
                TeacherID = teacherID;
            }
            else
            {
                Console.WriteLine("Invalid Teacher ID. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter Teacher Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Subject:");
            Subject = Console.ReadLine();

            TeachersList.Add(new Teacher(TeacherID, Name, Subject));

            Console.WriteLine("Teacher successfully added.");
        }

        public void Edit(int teacherID)
        {
            var teacherToEdit = TeachersList.Find(teacher => teacher.TeacherID == teacherID);

            if (teacherToEdit != null)
            {
                Console.WriteLine("Enter new Teacher Name:");
                teacherToEdit.Name = Console.ReadLine();

                Console.WriteLine("Enter new Subject:");
                teacherToEdit.Subject = Console.ReadLine();

                Console.WriteLine("Teacher successfully edited.");
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }

        public void Delete(int teacherID)
        {
            var teacherToDelete = TeachersList.Find(teacher => teacher.TeacherID == teacherID);

            if (teacherToDelete != null)
            {
                TeachersList.Remove(teacherToDelete);
                Console.WriteLine("Teacher successfully deleted.");
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }

        public void ViewDetails(int teacherID)
        {
            var teacherDetails = TeachersList.Find(teacher => teacher.TeacherID == teacherID);

            if (teacherDetails != null)
            {
                Console.WriteLine($"Teacher ID: {teacherDetails.TeacherID}");
                Console.WriteLine($"Teacher Name: {teacherDetails.Name}");
                Console.WriteLine($"Subject: {teacherDetails.Subject}");
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }
    }
}
