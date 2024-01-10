using System;

namespace bingo
{
    class Administration
    {
        public void ManageStudents(Student student)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Edit Student");
                Console.WriteLine("3. View Student Details");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Back to Administration Menu");
                Console.Write("Enter your choice (1-5): ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            student.Add();
                            break;
                        case 2:
                            Console.Write("Enter Student ID to edit: ");
                            if (int.TryParse(Console.ReadLine(), out int editStudentID))
                            {
                                student.Edit(editStudentID);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Student ID.");
                            }
                            break;
                        case 3:
                            Console.Write("Enter Student ID to view details: ");
                            if (int.TryParse(Console.ReadLine(), out int viewStudentID))
                            {
                                student.ViewDetails(viewStudentID);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Student ID.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter Student ID to delete: ");
                            if (int.TryParse(Console.ReadLine(), out int deleteStudentID))
                            {
                                student.Delete(deleteStudentID);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Student ID.");
                            }
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                }

                Console.WriteLine();
            }
        }

        public void ManageTeachers(Teacher teacher)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Edit Teacher");
                Console.WriteLine("3. View Teacher Details");
                Console.WriteLine("4. Delete Teacher");
                Console.WriteLine("5. Back to Administration Menu");
                Console.Write("Enter your choice (1-5): ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            teacher.Add();
                            break;
                        case 2:
                            Console.Write("Enter Teacher ID to edit: ");
                            if (int.TryParse(Console.ReadLine(), out int editTeacherID))
                            {
                                teacher.Edit(editTeacherID);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Teacher ID.");
                            }
                            break;
                        case 3:
                            Console.Write("Enter Teacher ID to view details: ");
                            if (int.TryParse(Console.ReadLine(), out int viewTeacherID))
                            {
                                teacher.ViewDetails(viewTeacherID);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Teacher ID.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter Teacher ID to delete: ");
                            if (int.TryParse(Console.ReadLine(), out int deleteTeacherID))
                            {
                                teacher.Delete(deleteTeacherID);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Teacher ID.");
                            }
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                }

                Console.WriteLine();
            }
        }
    }
}
