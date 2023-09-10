using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
using escuelaCampus.Entities;
internal class Program
{
    public static void Main(string[] args)
    {
        int quantityStudents = 0;
        bool loopQuantity = true;
        while (loopQuantity)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("ADD STUDENTS\n");
                Console.Write("Type the quantity of students to add: ");
                quantityStudents = int.Parse(Console.ReadLine());
                if (quantityStudents > 0 && quantityStudents < 5001)
                {
                    loopQuantity = false;
                }
                else
                {
                    Console.Clear();
                    Console.Write("The number must be higher than 0 and lower than 5000. \nPress Enter to continue. . . ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch
            {
                Console.Clear();
                Console.Write("The input is not valid. \nPress Enter to continue. . . ");
                Console.ReadKey();
                Console.Clear();
            }
        }
        Console.Clear();
        List<Student> listStudents = new List<Student>();
        for (int i = 0; i < quantityStudents; i++)
        {
            Student student = new Student();
            bool loopId = true;
            while (loopId)
            {
                loopId = false;
                Console.Clear();
                Console.WriteLine("ADD STUDENTS\n");
                Console.Write("Type the student's id: ");
                student.Id = Console.ReadLine();
                for (int c = 0; c < 1; c++)
                {
                    if (student.Id.Length < 1 || student.Id.Length > 15)
                    {
                        Console.Clear();
                        Console.WriteLine("The student's id must be between 1 and 15 characters long. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                        loopId = true;
                    }
                }
                for (int j = 0; j < listStudents.Count; j++)
                {
                    if (student.Id == listStudents[j].Id)
                    {
                        Console.Clear();
                        Console.WriteLine("The student's id already exists. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                        loopId = true;
                    }
                }
                if (!student.Id.All(char.IsDigit))
                {
                    Console.Clear();
                    Console.WriteLine("The student's id must be numeric. \nPress Enter to continue. . . ");
                    Console.ReadKey();
                    Console.Clear();
                    loopId = true;
                }
            }
            bool loopName = true;
            while (loopName)
            {
                loopName = false;
                Console.Clear();
                Console.WriteLine("ADD STUDENTS\n");
                Console.Write("Type the student's name: ");
                student.Name = Console.ReadLine();
                for (int c = 0; c < 1; c++)
                {
                    if (student.Name.Length < 1 || student.Name.Length > 40)
                    {
                        Console.Clear();
                        Console.WriteLine("The student's name must be between 1 and 40 characters long. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                        loopName = true;
                    }
                    else if (student.Name.All(char.IsDigit))
                    {
                        Console.Clear();
                        Console.WriteLine("The student's name can not have numbers. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                        loopName = true;
                    }
                }
                for (int j = 0; j < listStudents.Count; j++)
                {
                    if (student.Name == listStudents[j].Name)
                    {
                        Console.Clear();
                        Console.WriteLine("The student's name already exists. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                        loopName = true;
                    }
                }
            }
            bool loopEmail = true;
            while (loopEmail)
            {
                loopEmail = false;
                Console.Clear();
                Console.WriteLine("ADD STUDENTS\n");
                Console.Write("Type the student's email: ");
                student.Email = Console.ReadLine();
                for (int c = 0; c < 1; c++)
                {
                    if (student.Email.Length < 1 || student.Email.Length > 40)
                    {
                        Console.Clear();
                        Console.WriteLine("The student's email must be between 1 and 40 characters long. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                        loopEmail = true;
                    }
                }
            }
            bool loopAge = true;
            while (loopAge)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("ADD STUDENTS\n");
                    Console.Write("Type the student's age: ");
                    student.Age = int.Parse(Console.ReadLine());
                    if (student.Age > 0 && student.Age < 100)
                    {
                        loopAge = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("The student's age must be between 1 and 99. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.Write("The student's age is not valid. \nPress Enter to continue. . . ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            bool loopAddress = true;
            while (loopAddress)
            {
                loopAddress = false;
                Console.Clear();
                Console.WriteLine("ADD STUDENTS\n");
                Console.Write("Type the student's address: ");
                student.Address = Console.ReadLine();
                for (int c = 0; c < 1; c++)
                {
                    if (student.Address.Length < 1 || student.Address.Length > 30)
                    {
                        Console.Clear();
                        Console.WriteLine("The student's address must be between 1 and 30 characters long. \nPress Enter to continue. . . ");
                        Console.ReadKey();
                        Console.Clear();
                        loopAddress = true;
                    }
                }
            }
            listStudents.Add(student);
            Console.Clear();
            Console.Write($"The student {student.Name} was added to the list of students with the id {student.Id}. \nPress Enter to continue. . . ");
            Console.ReadKey();
            Console.Clear();
        }
        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("\n1. Select student to add a grade");
            Console.WriteLine("2. Show student's general information");
            Console.WriteLine("3. Show general grades of the group");
            Console.WriteLine("4. Show final grades of the group");
            Console.WriteLine("\n0. Exit");
            Console.Write("\nType the option: ");
            string option = string.Empty;
            option = Console.ReadLine();
            Console.Clear();
            bool loopStudent = true;
            while (loopStudent)
            {
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("+-----------------+------------------------------------------+");
                        Console.WriteLine("| {0,-15} | {1,-40} |", "ID", "NAME");
                        Console.WriteLine("+-----------------+------------------------------------------+");
                        for (int i = 0; i < listStudents.Count; i++)
                        {
                            Console.WriteLine("| {0,-15} | {1,-40} |", listStudents[i].Id, listStudents[i].Name);
                            Console.WriteLine("+-----------------+------------------------------------------+");
                        }
                        Console.Write("\nType the id of the student: ");
                        string optionStudent = Console.ReadLine();
                        int studentFound = 0;
                        int loopTillFound = -1;
                        foreach (Student stu in listStudents)
                        {
                            loopTillFound++;
                            if (optionStudent.Equals(stu.Id))
                            {
                                studentFound++;
                                break;
                            }
                        }
                        if (studentFound == 1)
                        {
                            bool loopOptionGrade = true;
                            while (loopOptionGrade)
                            {
                                Console.Clear();
                                Console.WriteLine("1. Add a quiz grade");
                                Console.WriteLine("2. Add a work grade");
                                Console.WriteLine("3. Add an assessment grade");
                                Console.WriteLine("\n0. Go back to the Main Menu\n");
                                Console.Write("Type the option: ");
                                string optionGrade = string.Empty;
                                optionGrade = Console.ReadLine();
                                Console.Clear();
                                switch (optionGrade)
                                {
                                    case "1":
                                        sbyte optionQuiz = 0;
                                        bool loopQuiz = true;
                                        while (loopQuiz)
                                        {
                                            try
                                            {
                                                Console.WriteLine("1. Quiz 1");
                                                Console.WriteLine("2. Quiz 2");
                                                Console.WriteLine("3. Quiz 3");
                                                Console.WriteLine("4. Quiz 4");
                                                Console.Write("\nType the grade of the quiz: ");
                                                optionQuiz = sbyte.Parse(Console.ReadLine());
                                                if (optionQuiz < 1 || optionQuiz > 4)
                                                {
                                                    Console.Clear();
                                                    Console.Write("The input must be between 1 and 4. \nPress Enter to continue. . . ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    loopQuiz = false;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.Write("The input is not valid. \nPress Enter to continue. . . ");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        Console.Clear();
                                        sbyte newQuizGrade = 0;
                                        bool loopNewQuiz = true;
                                        while (loopNewQuiz)
                                        {
                                            try
                                            {
                                                Console.WriteLine($"Current grade of the quiz {optionQuiz}: {listStudents[loopTillFound].Quiz[optionQuiz - 1]}");
                                                Console.Write($"Type the grade of the quiz {optionQuiz} (1 - 50): ");
                                                newQuizGrade = sbyte.Parse(Console.ReadLine());
                                                if (newQuizGrade > 0 && newQuizGrade < 51)
                                                {
                                                    loopNewQuiz = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.Write("The grade must be between 1 and 50. \nPress Enter to continue. . . ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.Write("The input is not valid. \nPress Enter to continue. . . ");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        listStudents[loopTillFound].Quiz[optionQuiz - 1] = newQuizGrade;
                                        Console.Clear();
                                        Console.Write($"Grade {optionQuiz} added. \nPress Enter to continue. . . ");
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        sbyte optionWork = 0;
                                        bool loopWork = true;
                                        while (loopWork)
                                        {
                                            try
                                            {
                                                Console.WriteLine("1. Work 1");
                                                Console.WriteLine("2. Work 2");
                                                Console.Write("\nType the grade of the work: ");
                                                optionWork = sbyte.Parse(Console.ReadLine());
                                                if (optionWork < 1 || optionWork > 2)
                                                {
                                                    Console.Clear();
                                                    Console.Write("The input must be between 1 and 2. \nPress Enter to continue. . . ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    loopWork = false;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.Write("The input is not valid. \nPress Enter to continue. . . ");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        Console.Clear();
                                        sbyte newWorkGrade = 0;
                                        bool loopNewWork = true;
                                        while (loopNewWork)
                                        {
                                            try
                                            {
                                                Console.WriteLine($"Current grade of the work {optionWork}: {listStudents[loopTillFound].Work[optionWork - 1]}");
                                                Console.Write($"Type the grade of the work {optionWork} (1 - 50): ");
                                                newWorkGrade = sbyte.Parse(Console.ReadLine());
                                                if (newWorkGrade > 0 && newWorkGrade < 51)
                                                {
                                                    loopNewWork = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.Write("The grade must be between 1 and 50. \nPress Enter to continue. . . ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.Write("The input is not valid. \nPress Enter to continue. . . ");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        listStudents[loopTillFound].Work[optionWork - 1] = newWorkGrade;
                                        Console.Clear();
                                        Console.Write($"Grade {optionWork} added. \nPress Enter to continue. . . ");
                                        Console.ReadKey();
                                        break;
                                    case "3":
                                        sbyte optionAssessment = 0;
                                        bool loopAssessment = true;
                                        while (loopAssessment)
                                        {
                                            try
                                            {
                                                Console.WriteLine("1. Assessment 1");
                                                Console.WriteLine("2. Assessment 2");
                                                Console.WriteLine("3. Assessment 3");
                                                Console.Write("\nType the grade of the assessment: ");
                                                optionAssessment = sbyte.Parse(Console.ReadLine());
                                                if (optionAssessment < 1 || optionAssessment > 3)
                                                {
                                                    Console.Clear();
                                                    Console.Write("The input must be between 1 and 3. \nPress Enter to continue. . . ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    loopAssessment = false;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.Write("The input is not valid. \nPress Enter to continue. . . ");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        Console.Clear();
                                        sbyte newAssessmentGrade = 0;
                                        bool loopNewAssessment = true;
                                        while (loopNewAssessment)
                                        {
                                            try
                                            {
                                                Console.WriteLine($"Current grade of the assessment {optionAssessment}: {listStudents[loopTillFound].Assessment[optionAssessment - 1]}");
                                                Console.Write($"Type the grade of the assessment {optionAssessment} (1 - 50): ");
                                                newAssessmentGrade = sbyte.Parse(Console.ReadLine());
                                                if (newAssessmentGrade > 0 && newAssessmentGrade < 51)
                                                {
                                                    loopNewAssessment = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.Write("The grade must be between 1 and 50. \nPress Enter to continue. . . ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.Write("The input is not valid. \nPress Enter to continue. . . ");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        listStudents[loopTillFound].Assessment[optionAssessment - 1] = newAssessmentGrade;
                                        Console.Clear();
                                        Console.Write($"Grade {optionAssessment} added. \nPress Enter to continue. . . ");
                                        Console.ReadKey();
                                        break;
                                    case "0":
                                        Console.Clear();
                                        loopStudent = false;
                                        loopOptionGrade = false;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.Write("Invalid option. . .\nPress Enter to continue. . . ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write("Invalid id. . .\nPress Enter to continue. . . ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        Console.WriteLine("+-----------------+------------------------------------------+------------------------------------------+------+--------------------------------+");
                        Console.WriteLine("| {0,-15} | {1,-40} | {2,-40} | {3,-4} | {4,-30} |", "ID", "NAME", "EMAIL", "AGE", "ADDRESS");
                        Console.WriteLine("+-----------------+------------------------------------------+------------------------------------------+------+--------------------------------+");
                        string x;
                        for (int i = 0; i < listStudents.Count; i++)
                        {
                            Console.WriteLine("| {0,-15} | {1,-40} | {2,-40} | {3,-4} | {4,-30} |", listStudents[i].Id, listStudents[i].Name, listStudents[i].Email, listStudents[i].Age, listStudents[i].Address);
                            Console.WriteLine("+-----------------+------------------------------------------+------------------------------------------+------+--------------------------------+");
                            x = Convert.ToString(i);
                            if (x[x.Length - 1].Equals("9"))
                            {
                                Console.Write("Press Enter to continue. . . ");
                                Console.ReadKey();
                            }
                        }
                        Console.Write("\nPress Enter to continue. . . ");
                        Console.ReadKey();
                        loopStudent = false;
                        break;
                    case "3":
                        Console.WriteLine("+-----------------+------------------------------------------+-------------------------------------------+------------------------------------------------------+");
                        Console.WriteLine("| {0,-15} | {1,-40} | {2,-41} | {3,-19} | {4,-30} |", "ID", "NAME", "QUIZES", "WORKS", "ASSESSMENTS");
                        Console.WriteLine("+-----------------+------------------------------------------+----------+----------+----------+----------+----------+----------+----------+----------+----------+");
                        for (int i = 0; i < listStudents.Count; i++)
                        {
                            Console.WriteLine("| {0,-15} | {1,-40} | {2,-8} | {3,-8} | {4,-8} | {5,-8} | {6,-8} | {7,-8} | {8,-8} | {9,-8} | {10,-8} |", listStudents[i].Id, listStudents[i].Name, listStudents[i].Quiz[0], listStudents[i].Quiz[1], listStudents[i].Quiz[2], listStudents[i].Quiz[3], listStudents[i].Work[0], listStudents[i].Work[1], listStudents[i].Assessment[0], listStudents[i].Assessment[1], listStudents[i].Assessment[2]);
                            Console.WriteLine("+-----------------+------------------------------------------+----------+----------+----------+----------+----------+----------+----------+----------+----------+");
                        }
                        Console.Write("\nPress Enter to continue. . . ");
                        Console.ReadKey();
                        loopStudent = false;
                        break;
                    case "4":
                        for (int j = 0; j < listStudents.Count; j++)
                        {
                            listStudents[j].FinalQuiz = Math.Round((listStudents[j].Quiz[0] + listStudents[j].Quiz[1] + listStudents[j].Quiz[2] + listStudents[j].Quiz[3]) / 4 * 0.25);
                            listStudents[j].FinalWork = Math.Round((listStudents[j].Work[0] + listStudents[j].Work[1]) / 2 * 0.15);
                            listStudents[j].FinalAssessment = Math.Round((listStudents[j].Assessment[0] + listStudents[j].Assessment[1] + listStudents[j].Assessment[2]) / 3 * 0.60);
                            listStudents[j].Final = listStudents[j].FinalQuiz + listStudents[j].FinalWork + listStudents[j].FinalAssessment;
                        }
                        Console.WriteLine("+-----------------+------------------------------------------+--------------------------------------------+-------+");
                        Console.WriteLine("| {0,-15} | {1,-40} | {2,-10} | {3,-10} | {4,-16} | {5,-5} |", "ID", "NAME", "FINAL QUIZ", "FINAL WORK", "FINAL ASSESSMENT", "FINAL");
                        Console.WriteLine("+-----------------+------------------------------------------+------------+------------+------------------+-------+");
                        for (int i = 0; i < listStudents.Count; i++)
                        {
                            Console.WriteLine("| {0,-15} | {1,-40} | {2,-10} | {3,-10} | {4,-16} | {5,-5} |", listStudents[i].Id, listStudents[i].Name, listStudents[i].FinalQuiz, listStudents[i].FinalWork, listStudents[i].FinalAssessment, listStudents[i].Final);
                            Console.WriteLine("+-----------------+------------------------------------------+------------+------------+------------------+-------+");
                        }
                        Console.Write("\nPress Enter to continue. . . ");
                        Console.ReadKey();
                        loopStudent = false;
                        break;
                    case "0":
                        Console.Clear();
                        loop = false;
                        loopStudent = false;
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Invalid option. . .\nPress Enter to continue. . . ");
                        Console.ReadKey();
                        loopStudent = false;
                        break;
                }
            }
        }
    }
}