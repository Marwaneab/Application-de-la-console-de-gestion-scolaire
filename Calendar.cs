using System;
using System.Collections.Generic;

namespace bingo
{
    class Calendar
    {
        private Dictionary<string, DateTime> examDates;
        private Dictionary<string, DateTime> courseDeadlines;

        public Calendar()
        {
            examDates = new Dictionary<string, DateTime>();
            courseDeadlines = new Dictionary<string, DateTime>();
        }

        public void DisplayExamDates()
        {
            Console.WriteLine("Exam Dates:");
            foreach (var exam in examDates)
            {
                Console.WriteLine($"{exam.Key}: {exam.Value.ToShortDateString()}");
            }
        }

        public void DisplayCourseDeadlines()
        {
            Console.WriteLine("Course Deadlines:");
            foreach (var deadline in courseDeadlines)
            {
                Console.WriteLine($"{deadline.Key}: {deadline.Value.ToShortDateString()}");
            }
        }

        public void ChangeExamDate(string examName, DateTime newDate, Administration admin)
        {
            if (admin != null)
            {
                examDates[examName] = newDate;
                Console.WriteLine($"Exam date for {examName} updated.");
            }
            else
            {
                Console.WriteLine("Access denied. Only admin can change exam dates.");
            }
        }

        public void ChangeCourseDeadline(string courseName, DateTime newDeadline, Administration admin)
        {
            if (admin != null)
            {
                courseDeadlines[courseName] = newDeadline;
                Console.WriteLine($"Course deadline for {courseName} updated.");
            }
            else
            {
                Console.WriteLine("Access denied. Only admin can change course deadlines.");
            }
        }

        public void ViewUpcomingModules(string studentName)
        {
            // Placeholder implementation, adjust as needed
            Console.WriteLine($"Viewing upcoming modules for student: {studentName}");
        }

        public void DisplayWeeklySchedules(string name)
        {
            // Placeholder implementation, adjust as needed
            Console.WriteLine($"Displaying weekly schedule for: {name}");
        }

        public void AddExamDate(string examName, DateTime examDate)
        {
            // Placeholder implementation, adjust as needed
            examDates.Add(examName, examDate);
            Console.WriteLine($"Exam date for {examName} added.");
        }

        public void AddDeadline(string taskName, DateTime deadline)
        {
            // Placeholder implementation, adjust as needed
            courseDeadlines.Add(taskName, deadline);
            Console.WriteLine($"Deadline for {taskName} added.");
        }
    }
}
