using ConsoleApp3;
using System.Collections;

namespace ConsoleApp5
{
    public class Program
    {
        internal class Group
        {
            static int countStudents = 12;
            ArrayList students = new ArrayList();
            string nameGroup = "bu111";
            string nameSpecalizationGroup = "designer";
            int numberSemester = 2;

            string[] names = { "alex", "andrey", "katya", "vitalik", "alyona", "vlad", "kirill", "vladimir", "egor", "sonya", "ira", "sergey" };
            string[] surnames = { "Shevchenko", "Vasilenko", "Ovcharenko", "Borisenko", "Tkachenko", "Fedorenko", "Jakovenko", "Pavlenko", "Ivashenko", "Sklyarenko", "Kravchenko", "Ponomarenko" };

            Random random = new Random();
            //Student raitingStudents = new Student();

            //------------CONSTRUCTORS------------
            public Group()
            {

                for (int i = 0; i < countStudents; i++)
                {
                    students.Add(new Student());
                    (students[i] as Student).SetName(names[random.Next(0, 12)]);
                    (students[i] as Student).SetSurname(surnames[random.Next(0, 12)]);
                    (students[i] as Student).SetAge(random.Next(16, 50));
                    (students[i] as Student).SetExam();
                }
            }
            public Group(int x)
            {
                countStudents = x;
            }
            public Group(ArrayList copyStudent)
            {
                this.students = copyStudent;
            }
            public Group(Group g)
            {
                countStudents = g.GetCountStudents();
                this.students = g.students;
                this.nameGroup = g.nameGroup;
                this.nameSpecalizationGroup = g.nameSpecalizationGroup;
                this.numberSemester = g.numberSemester;
            }
            //------------SETTERS------------
            public void SetCountStudents(int x)
            {
                countStudents = x;
            }
            public void SetNameGroup(string nameGroup)
            {
                this.nameGroup = nameGroup;
            }
            public void SetNameSpecalizationGroup(string nameSpecalizationGroup)
            {
                this.nameSpecalizationGroup = nameSpecalizationGroup;
            }
            public void SetNumberSemester(int numberSemester)
            {
                this.numberSemester = numberSemester;
            }
            //------------GETTERS------------
            public int GetCountStudents()
            {
                return countStudents;
            }
            public string SetNameGroup()
            {
                return nameGroup;
            }
            public string SetNameSpecalizationGroup()
            {
                return nameSpecalizationGroup;
            }
            public int SetNumberSemester()
            {
                return numberSemester;
            }

            //------------METHODS------------
            public void AddSudent(string surname, string name, int age)
            {
                students.Add(new Student());
                (students[students.Count] as Student).SetName(names[random.Next(0, 12)]);
                (students[students.Count] as Student).SetSurname(surnames[random.Next(0, 12)]);
                (students[students.Count] as Student).SetAge(random.Next(16, 50));
                (students[students.Count] as Student).SetExam();
            }
            public void EditStudent(int x, string surname, string name, int age)
            {
                (students[x - 1] as Student).SetName(name);
                (students[x - 1] as Student).SetSurname(surname);
                (students[x - 1] as Student).SetAge(age);
            }
            public void EditGroup(string nameGroup, string nameSpecalizationGroup)
            {
                this.nameGroup = nameGroup;
                this.nameSpecalizationGroup = nameSpecalizationGroup;
            }
            public void TransferenceStudent(int x, Group first, Group second)
            {
                second.students[x - 1] = first.students[x - 1];
            }
            //public void EliminationStudent()
            //{
            //    for (int i = 0; i < students.Count; i++)
            //    {
            //        ArrayList stud = new ArrayList();
            //        stud.Add(new Student());
            //        if (!(students[i] as Student).GetExam() == false)
            //        {
            //            students.RemoveAt(i);
            //        }
            //    }
            //}
            public void UnsuccessfulStudent()
            {
                int x = 12;
                int y = 0;
                int[] arrStud = new int[countStudents];
                for (int i = 0; i < arrStud.Length; i++)
                {
                    for (int j = 0; j < (students[0] as Student).dzArr.Length; j++)
                    {
                        arrStud[i] += (students[0] as Student).dzArr[j];
                    }
                    arrStud[i] /= (students[0] as Student).dzArr.Length;
                }
                for (int i = 0; i < arrStud.Length; i++)
                {
                    if (arrStud[i] < x)
                    {
                        x = arrStud[i];
                        y = i;
                    }
                }
                students.RemoveAt(y);
            }
            //------------PRINT------------
            public void PrintGroup()
            {
                Console.WriteLine("Nazvanie group: " + nameGroup);
                Console.WriteLine("Specialization group: " + nameSpecalizationGroup);
                for (int i = 0; i < countStudents; i++)
                {
                    Console.WriteLine((i + 1) + ")  " + (students[i] as Student).GetSurname() + "  " + (students[i] as Student).GetName() + "  " + (students[i] as Student).GetAge() + " years");
                }
                Console.Write("\n");
            }
            public void PrintRaitings()
            {
                for (int i = 0; i < students.Count; i++)
                {
                    Console.Write((i + 1) + ")  ");
                    for (int j = 0; j < (students[0] as Student).dzArr.Length; j++)
                    {
                        Console.Write(" " + (students[i] as Student).dzArr[j]);
                    }
                    Console.Write("\n");
                }
            }
            public void PrintExams()
            {
                for (int i = 0; i < countStudents; i++)
                {
                    Console.Write((i + 1) + ")  ");
                    if ((students[i] as Student).GetExam() == false)
                        Console.Write("NE SDAL" + (students[i] as Student).GetExam());
                    else
                        Console.Write("SDAL" + (students[i] as Student).GetExam());
                    Console.Write("\n");
                }
            }
        }

        static void Main()
        {
            Group g = new Group();
            //Group g1 = new Group();
            g.PrintGroup();
            g.PrintExams();
            //g1.PrintGroup();
            //g.EditStudent(3, "Shapovalov", "Artem", 23);
            //g.PrintGroup();
            //g.PrintRaitings();
            //g1.TransferenceStudent(3, g, g1);
            //g1.PrintGroup();
            g.EliminationStudent();
            //g.UnsuccessfulStudent();
            g.PrintGroup();
        }
    }
}
