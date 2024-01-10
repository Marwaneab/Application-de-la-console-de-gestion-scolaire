using System;
using System.Collections.Generic;

namespace bingo
{
    class Module
    {
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public List<Module> ModulesList { get; set; } = new List<Module>();

        public void Add()
        {
            Console.WriteLine("Enter Module ID:");
            if (int.TryParse(Console.ReadLine(), out int moduleId))
            {
                ModuleID = moduleId;
            }
            else
            {
                Console.WriteLine("Invalid Module ID. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter Module Name:");
            ModuleName = Console.ReadLine();

            ModulesList.Add(this);

            Console.WriteLine("Module successfully added.");
        }

        public void Edit(int moduleId)
        {
            var moduleToEdit = ModulesList.Find(module => module.ModuleID == moduleId);

            if (moduleToEdit != null)
            {
                Console.WriteLine("Enter new Module Name:");
                moduleToEdit.ModuleName = Console.ReadLine();

                Console.WriteLine("Module successfully edited.");
            }
            else
            {
                Console.WriteLine("Module not found.");
            }
        }

        public void Delete(int moduleId)
        {
            var moduleToDelete = ModulesList.Find(module => module.ModuleID == moduleId);

            if (moduleToDelete != null)
            {
                ModulesList.Remove(moduleToDelete);
                Console.WriteLine("Module successfully deleted.");
            }
            else
            {
                Console.WriteLine("Module not found.");
            }
        }

        public void ViewDetails(int moduleId)
        {
            var moduleDetails = ModulesList.Find(module => module.ModuleID == moduleId);

            if (moduleDetails != null)
            {
                Console.WriteLine($"Module ID: {moduleDetails.ModuleID}");
                Console.WriteLine($"Module Name: {moduleDetails.ModuleName}");
            }
            else
            {
                Console.WriteLine("Module not found.");
            }
        }
    }
}
