using System;
using System.IO;

namespace bingo
{
    class CourseManager
    {
        private const string CoursesDirectory = "Courses";

        public void AddCourse(string courseName, string courseDetails)
        {
            if (IsValidFileName(courseName))
            {
                string courseFileName = Path.Combine(CoursesDirectory, $"{courseName}.txt");

                if (!Directory.Exists(CoursesDirectory))
                {
                    Directory.CreateDirectory(CoursesDirectory);
                }

                if (!File.Exists(courseFileName))
                {
                    using (StreamWriter sw = File.CreateText(courseFileName))
                    {
                        sw.Write(courseDetails);
                    }

                    Console.WriteLine($"Course '{courseName}' added successfully.");
                }
                else
                {
                    Console.WriteLine($"Course '{courseName}' already exists.");
                }
            }
            else
            {
                Console.WriteLine("Invalid course name. Please provide a valid name.");
            }
        }

        public void UpdateCourse(string courseName, string newCourseDetails)
        {
            if (IsValidFileName(courseName))
            {
                string courseFileName = Path.Combine(CoursesDirectory, $"{courseName}.txt");

                if (File.Exists(courseFileName))
                {
                    File.WriteAllText(courseFileName, newCourseDetails);
                    Console.WriteLine($"Course '{courseName}' updated successfully.");
                }
                else
                {
                    Console.WriteLine($"Course '{courseName}' does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid course name. Please provide a valid name.");
            }
        }

        public void DeleteCourse(string courseName)
        {
            if (IsValidFileName(courseName))
            {
                string courseFileName = Path.Combine(CoursesDirectory, $"{courseName}.txt");

                if (File.Exists(courseFileName))
                {
                    File.Delete(courseFileName);
                    Console.WriteLine($"Course '{courseName}' deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Course '{courseName}' does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid course name. Please provide a valid name.");
            }
        }

        public void ViewCourseContent(string courseName)
        {
            if (IsValidFileName(courseName))
            {
                string courseFileName = Path.Combine(CoursesDirectory, $"{courseName}.txt");

                if (File.Exists(courseFileName))
                {
                    string content = File.ReadAllText(courseFileName);
                    Console.WriteLine($"Course Content for '{courseName}':");
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine($"Course '{courseName}' does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid course name. Please provide a valid name.");
            }
        }

        private bool IsValidFileName(string fileName)
        {
            // Add your validation logic here
            // For example, check for invalid characters, length constraints, etc.
            return !string.IsNullOrWhiteSpace(fileName);
        }

        public static void CourseManagementMenu(CourseManager courseManager)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Course Management");
                Console.WriteLine("1. Add Course");
                Console.WriteLine("2. Update Course");
                Console.WriteLine("3. Delete Course");
                Console.WriteLine("4. View Course Content");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Enter your choice (1-5): ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Course Name: ");
                            string addCourseName = Console.ReadLine();
                            Console.Write("Enter Course Details: ");
                            string addCourseDetails = Console.ReadLine();
                            courseManager.AddCourse(addCourseName, addCourseDetails);
                            break;

                        case 2:
                            Console.Write("Enter Course Name: ");
                            string updateCourseName = Console.ReadLine();
                            Console.Write("Enter New Course Details: ");
                            string newCourseDetails = Console.ReadLine();
                            courseManager.UpdateCourse(updateCourseName, newCourseDetails);
                            break;

                        case 3:
                            Console.Write("Enter Course Name: ");
                            string deleteCourseName = Console.ReadLine();
                            courseManager.DeleteCourse(deleteCourseName);
                            break;

                        case 4:
                            Console.Write("Enter Course Name: ");
                            string viewCourseName = Console.ReadLine();
                            courseManager.ViewCourseContent(viewCourseName);
                            break;

                        case 5:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                }
            }
        }
    }
}
