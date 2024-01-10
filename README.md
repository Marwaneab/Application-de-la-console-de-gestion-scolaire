# Application-de-la-console-de-gestion-scolaire
INTRODUCTION

  Le Système de Gestion Scolaire est une application console développée en langage C# qui offre une plateforme centralisée pour administrer divers aspects d'une institution éducative. Cette application modulaire permet aux utilisateurs d'interagir avec différentes fonctionnalités, couvrant la gestion des étudiants, des enseignants, des modules, du calendrier et des cours. L'objectif principal de ce système est d'automatiser et de simplifier les processus administratifs, offrant ainsi une solution efficace pour les établissements éducatifs

  
  1 - Student Class (Student.cs):
         
         1.1 Properties:
              StudentID (int): Identifiant unique de l'étudiant.
              Name (string): Nom de l'étudiant.
              Special (string): Spécialisation de l'étudiant.
         
         1.2 Methods:
              Add(): Ajoute un nouvel étudiant.
              Edit(int studentID): Modifie les informations d'un étudiant existant.
              Delete(int studentID): Supprime un étudiant en fonction de son identifiant.
              ViewDetails(int studentID): Affiche les détails d'un étudiant.
              
  2 - Teacher Class (Teacher.cs):
        
        2.1 Properties:
              TeacherID (int): Identifiant unique de l'enseignant.
              Name (string): Nom de l'enseignant.
              Subject (string): Matière enseignée par l'enseignant.
        
        2.2Methods:
              Add(): Ajoute un nouvel enseignant.
              Edit(int teacherID): Modifie les informations d'un enseignant existant.
              Delete(int teacherID): Supprime un enseignant en fonction de son identifiant.
              ViewDetails(int teacherID): Affiche les détails d'un enseignant.

  3 - Module Class (Module.cs):
        
        3.1 Properties:
              ModuleID (int): Identifiant unique du module.
              ModuleName (string): Nom du module.
       
        3.2 Methods:
              Add(): Ajoute un nouveau module.
              Edit(int moduleID): Modifie les informations d'un module existant.
              Delete(int moduleID): Supprime un module en fonction de son identifiant.
              ViewDetails(int moduleID): Affiche les détails d'un module.
              
  4 - Calendar Class (Calendar.cs):
        
        4.1 Methods:
              DisplayWeeklySchedules(string name): Affiche les horaires hebdomadaires pour un étudiant, enseignant ou module spécifié.
              AddExamDate(string examName, DateTime examDate): Ajoute une date d'examen à l'agenda.
              AddDeadline(string taskName, DateTime deadline): Ajoute une date limite à l'agenda.
              ViewUpcomingModules(string studentName): Affiche les modules à venir pour un étudiant spécifié.
              
  5 - CourseManager Class (CourseManager.cs):
        
        5.1 Properties:
              Courses (List<Course>): Liste des cours gérés par le gestionnaire de cours.
        
        5.2 Methods:
              AddCourse(string courseName, string courseDetails): Ajoute un nouveau cours à la liste.
              UpdateCourse(string courseName, string newCourseDetails): Met à jour les détails d'un cours existant.
              DeleteCourse(string courseName): Supprime un cours de la liste.
              ViewCourseContent(string courseName): Affiche le contenu d'un cours spécifié.
