using System;

namespace bingo
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            Teacher teacher = new Teacher(1, "Teacher Name", "Subject");
            Module module = new Module();
            Calendar calendar = new Calendar();
            CourseManager courseManager = new CourseManager();

            while (true)
            {
                Console.WriteLine("===== School Management System =====");
                Console.WriteLine("1. Student Management");
                Console.WriteLine("2. Teacher Management");
                Console.WriteLine("3. Module Management");
                Console.WriteLine("4. Calendar and Schedule");
                Console.WriteLine("5. Administration Access");
                Console.WriteLine("6. Course Management");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StudentManagement(student);
                        break;
                    case "2":
                        TeacherManagement(teacher);
                        break;
                    case "3":
                        ModuleManagement(module);
                        break;
                    case "4":
                        CalendarManagement(calendar);
                        break;
                    case "5":
                        AdminAccess(courseManager);
                        break;
                    case "6":
                        CourseManagement(courseManager);
                        break;
                    case "7":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void StudentManagement(Student student)
        {
            while (true)
            {
                Console.WriteLine("===== Student Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Edit Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. View Student Details");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        student.Add();
                        break;
                    case "2":
                        Console.Write("Enter Student ID to edit:");
                        if (int.TryParse(Console.ReadLine(), out int editStudentID))
                        {
                            student.Edit(editStudentID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Student ID. Please enter a valid integer.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter Student ID to delete:");
                        if (int.TryParse(Console.ReadLine(), out int deleteStudentID))
                        {
                            student.Delete(deleteStudentID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Student ID. Please enter a valid integer.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter Student ID to view details:");
                        if (int.TryParse(Console.ReadLine(), out int viewStudentID))
                        {
                            student.ViewDetails(viewStudentID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Student ID. Please enter a valid integer.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void TeacherManagement(Teacher teacher)
        {
            while (true)
            {
                Console.WriteLine("===== Teacher Management System =====");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Edit Teacher");
                Console.WriteLine("3. Delete Teacher");
                Console.WriteLine("4. View Teacher Details");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        teacher.Add();
                        break;
                    case "2":
                        Console.Write("Enter Teacher ID to edit:");
                        if (int.TryParse(Console.ReadLine(), out int editTeacherID))
                        {
                            teacher.Edit(editTeacherID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Teacher ID. Please enter a valid integer.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter Teacher ID to delete:");
                        if (int.TryParse(Console.ReadLine(), out int deleteTeacherID))
                        {
                            teacher.Delete(deleteTeacherID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Teacher ID. Please enter a valid integer.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter Teacher ID to view details:");
                        if (int.TryParse(Console.ReadLine(), out int viewTeacherID))
                        {
                            teacher.ViewDetails(viewTeacherID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Teacher ID. Please enter a valid integer.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ModuleManagement(Module module)
        {
            while (true)
            {
                Console.WriteLine("===== Module Management System =====");
                Console.WriteLine("1. Add Module");
                Console.WriteLine("2. Edit Module");
                Console.WriteLine("3. Delete Module");
                Console.WriteLine("4. View Module Details");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        module.Add();
                        break;
                    case "2":
                        Console.WriteLine("Enter Module ID to edit:");
                        int editModuleID;
                        if (int.TryParse(Console.ReadLine(), out editModuleID))
                        {
                            module.Edit(editModuleID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Module ID. Please enter a valid integer.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter Module ID to delete:");
                        int deleteModuleID;
                        if (int.TryParse(Console.ReadLine(), out deleteModuleID))
                        {
                            module.Delete(deleteModuleID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Module ID. Please enter a valid integer.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter Module ID to view details:");
                        int viewModuleID;
                        if (int.TryParse(Console.ReadLine(), out viewModuleID))
                        {
                            module.ViewDetails(viewModuleID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Module ID. Please enter a valid integer.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CourseManagement(CourseManager courseManager)
        {
            while (true)
            {
                Console.WriteLine("===== Course Management System =====");
                Console.WriteLine("1. Add Course");
                Console.WriteLine("2. Update Course");
                Console.WriteLine("3. Delete Course");
                Console.WriteLine("4. View Course Content");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Course Name: ");
                        string addCourseName = Console.ReadLine();
                        Console.Write("Enter Course Details: ");
                        string addCourseDetails = Console.ReadLine();
                        courseManager.AddCourse(addCourseName, addCourseDetails);
                        break;

                    case "2":
                        Console.Write("Enter Course Name: ");
                        string updateCourseName = Console.ReadLine();
                        Console.Write("Enter New Course Details: ");
                        string newCourseDetails = Console.ReadLine();
                        courseManager.UpdateCourse(updateCourseName, newCourseDetails);
                        break;

                    case "3":
                        Console.Write("Enter Course Name: ");
                        string deleteCourseName = Console.ReadLine();
                        courseManager.DeleteCourse(deleteCourseName);
                        break;

                    case "4":
                        Console.Write("Enter Course Name: ");
                        string viewCourseName = Console.ReadLine();
                        courseManager.ViewCourseContent(viewCourseName);
                        break;

                    case "5":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CalendarManagement(Calendar calendar)
        {
            while (true)
            {
                Console.WriteLine("===== Calendar Management =====");
                Console.WriteLine("1. Display Weekly Schedule");
                Console.WriteLine("2. Add Exam Date");
                Console.WriteLine("3. Add Deadline");
                Console.WriteLine("4. View Upcoming Modules");
                Console.WriteLine("5. Back to Main Menu");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student/teacher/module name: ");
                        string name = Console.ReadLine();
                        calendar.DisplayWeeklySchedules(name);
                        break;

                    case "2":
                        Console.Write("Enter exam name: ");
                        string examName = Console.ReadLine();
                        Console.Write("Enter exam date (yyyy-MM-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime examDate))
                        {
                            calendar.AddExamDate(examName, examDate);
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format. Please enter a valid date (yyyy-MM-dd).");
                        }
                        break;

                    case "3":
                        Console.Write("Enter task name: ");
                        string taskName = Console.ReadLine();
                        Console.Write("Enter deadline (yyyy-MM-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime deadline))
                        {
                            calendar.AddDeadline(taskName, deadline);
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format. Please enter a valid date (yyyy-MM-dd).");
                        }
                        break;

                    case "4":
                        Console.Write("Enter student name: ");
                        string studentName = Console.ReadLine();
                        calendar.ViewUpcomingModules(studentName);
                        break;

                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AdminAccess(CourseManager courseManager)
        {
            Console.Write("Enter admin password: ");
            string password = Console.ReadLine();

            if (password == "Azerty123")
            {
                Console.WriteLine("Admin access granted.");
            }
            else
            {
                Console.WriteLine("Admin access denied. Incorrect password.");
            }
        }
    }
}
