using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEsLinqTananyag
{
    internal class Feladatok
    {
        static void Main(string[] args)
        {
            var students = CreateStudents();
            static List<Student> CreateStudents()
            {
                return new List<Student>
            {
                new Student { Id = 1, Name = "Anna", Age = 18, AverageGrade = 4.7, ClassName = "13.A" },
                new Student { Id = 2, Name = "Bence", Age = 17, AverageGrade = 3.9, ClassName = "13.A" },
                new Student { Id = 3, Name = "Csilla", Age = 19, AverageGrade = 4.9, ClassName = "13.B" },
                new Student { Id = 4, Name = "Dávid", Age = 18, AverageGrade = 2.8, ClassName = "13.B" },
                new Student { Id = 5, Name = "Eszter", Age = 20, AverageGrade = 4.4, ClassName = "13.C" },
                new Student { Id = 6, Name = "Ferenc", Age = 17, AverageGrade = 3.1, ClassName = "13.C" },
                new Student { Id = 7, Name = "Gréta", Age = 19, AverageGrade = 4.6, ClassName = "13.A" },
                new Student { Id = 8, Name = "Hunor", Age = 18, AverageGrade = 3.5, ClassName = "13.B" }
            };
            }
            var numbers = CreateNumbers();
            static List<int> CreateNumbers()
            {
                return new List<int> { 7, 3, 7, 10, 2, 8, 10, 1, 5 };
            }

            var studentsWithTags = CreateStudentsWithTags();
            static List<StudentWithTags> CreateStudentsWithTags()
            {
                return new List<StudentWithTags>
            {
                new StudentWithTags { Name = "Anna", Tags = new List<string> { "C#", "SQL", "Git" } },
                new StudentWithTags { Name = "Bence", Tags = new List<string> { "HTML", "CSS", "Git" } },
                new StudentWithTags { Name = "Csilla", Tags = new List<string> { "C#", "LINQ", "SQL" } }
            };
            }

            //1. feladat
            Console.WriteLine("1. feladat");
            Func<int, bool> parosE = x =>
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            var parosak = numbers.Where(parosE).ToList();
            foreach (var x in parosak)
            {
                Console.WriteLine(x);
            }

            //2. feladat
            Console.WriteLine("2. feladat");
            Func<Student, bool> felnottE = x =>
            {
                return x.Age >= 18;
            };
            var felnott = students.Where(felnottE).ToList();
            foreach(var x in felnott)
            {
                Console.WriteLine(x.Name); 
            }

            //3. feladat
            Console.WriteLine("3. feladat");
            var felnottNevek = students.Where(x => x.Age >= 18).Select(x => x.Name).ToList();
            foreach( var x in felnottNevek)
            {
                Console.WriteLine(x);
            }

            //4. feladat
            Console.WriteLine("4. feladat");

            var tizenharom = students.Where(s => s.ClassName == "13.B").Select(x => x.Name).ToList();
            foreach(var student  in tizenharom)
            {
                Console.WriteLine(student);
            }

            //5. feladat
            Console.WriteLine("5.feladat");

            var studentName = students.Select(x => x.Name).ToList();
            foreach(var x in studentName)
            {
                Console.WriteLine(x);
            }

            //6. feladat
            Console.WriteLine("6. feladat");
            List<string> nevOsztaly = students.Select(s => s.Name + " - " + s.ClassName).ToList();
            foreach(string x in nevOsztaly) { Console.WriteLine(x); }

            //7. feladat
            Console.WriteLine("7. feladat");
            var eletkorNovekvo = students.OrderBy(s => s.Age);
            foreach(var x in eletkorNovekvo)
            {
                Console.WriteLine($"{x.Age}");
            }

            //8. feladat
            Console.WriteLine("8. feladat");
            var rendezett = students.OrderBy(s => s.AverageGrade).ThenBy(s => s.Name);
            foreach (var x in rendezett) { Console.WriteLine(x.Name); }

            //9.feladat
            Console.WriteLine("9. feladat");
            var nagykoruDarab = students.Where(s => s.Age >= 18).Count();
            Console.WriteLine(nagykoruDarab);


            //10. feladat
            Console.WriteLine("10. feladat");

            var isAdult = students.Any(s => s.Age >= 18);
            if (isAdult)
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }

            //11. feladat
            Console.WriteLine("11. feladat");

            var atlagok = students.Where(s => s.AverageGrade < 3.00).ToList();
            if(atlagok.Count > 0)
            {
                Console.WriteLine("Nem mindenkinek van meg a legalább 3.00 átlag");
            }
            else
            {
                Console.WriteLine("Mindenkinek megvan");
            }

            //12. feladat
            Console.WriteLine("12. feladat");
            var Kinga = students.FirstOrDefault(s => s.Name == "Kinga");
            if(Kinga != null)
            {
                Console.WriteLine(Kinga.Name);
            }
            else
            {
                Console.WriteLine("nincs benne kinga");
            }

            //13. feladat
            Console.WriteLine("13. feladat");
            var osztalynevek = students.Select(s => s.ClassName).Distinct().OrderBy(s => s).ToList();
            foreach(var o in osztalynevek)
            {
                Console.WriteLine(o);
            }

            //14. feladat
            Console.WriteLine("14. feladat");

            var numberLista = numbers.OrderBy(x => x).Distinct();
            foreach (var number in numberLista)
            {
                Console.WriteLine(number);
            }

            //15.feladat
            Console.WriteLine("15. feladat");

            var vanetiz = numbers.Any(x => x > 9 && x < 11);
            if(vanetiz)
            {
                Console.WriteLine("van tiz");
            }
            else
            {
                Console.WriteLine("Nincs tiz");
            }

            //16. feladat
            Console.WriteLine("16. feladat");

            var vaneAnna = students.Any(x => x.Name == "Anna");
            if(vaneAnna)
            {
                Console.WriteLine("Van Anna");
            }
            else
            {
                Console.WriteLine("nincs Anna");
            }

            //17. feladat
            Console.WriteLine("17. feladat");
            List<int> numbernegyeleme = new List<int>();
            for(var i = 0; i < numbers.Count; i++)
            {
                numbernegyeleme.Add(numbers[i]);
                if(numbernegyeleme.Count == 4)
                {
                    foreach(var n in numbernegyeleme)
                    {
                        Console.WriteLine(n);
                    }
                }
            }

            //18. feladat
            Console.WriteLine("18. feladat");

            var szamok = numbers.Skip(3).Take(4).ToList();
            foreach(var n in szamok)
            {
                Console.WriteLine(n);
            }

            //19.feladat
            Console.WriteLine("19. feladat");

            Console.WriteLine($"Összeg: {numbers.Sum()}, Átlag: {numbers.Average().ToString("0.00")}, Minimum: {numbers.Min()}, Maximum: {numbers.Max()}");


            //20. feladat
            Console.WriteLine("20. feladat");
            var tizenharomAtlag = students.Where(s => s.ClassName == "13.A").Average(a => a.AverageGrade);
            Console.WriteLine(tizenharomAtlag.ToString("0.00"));

            //21. feladat
            Console.WriteLine("21. feladat");
            
            var joAtlag = students.Where(s => s.AverageGrade >= 4.5).OrderBy(s => s.AverageGrade).Select(a => a.Name).ToList();
            foreach (var jo in joAtlag) {  Console.WriteLine(jo); }

            //22. feladat
            Console.WriteLine("22. feladat");

            var legjobbak = students.OrderByDescending(s => s.AverageGrade).Take(3).ToList();
            foreach( var legjo in legjobbak) { Console.WriteLine(legjo.Name); }

            //23. feladat
            Console.WriteLine("23. feladat");

            var a = students.Where(s => s.ClassName == "13.A").Select(a => a.Name).Count();
            var b = students.Where(s => s.ClassName == "13.B").Select(a => a.Name).Count();
            var c = students.Where(s => s.ClassName == "13.C").Select(a => a.Name).Count();

            Console.WriteLine($"A db: {a}, B db: {b}, C db: {c}");

            //24. feladat
            Console.WriteLine("24. feladat");
            var A = students.Where(s => s.ClassName == "13.A").Average(a => a.AverageGrade);
            var B = students.Where(s => s.ClassName == "13.B").Average(a => a.AverageGrade);
            var C = students.Where(s => s.ClassName == "13.C").Average(a => a.AverageGrade);

            Console.WriteLine($"A atlag: {A.ToString("0.00")}, B atlag: {B.ToString("0.00")}, C atlag: {C.ToString("0.00")}");

            //25.feladat
            Console.WriteLine("25. feladat");

            var legjobb = students.MaxBy(s => s.AverageGrade);
            Console.WriteLine(legjobb.Name);


            //26. feladat
            Console.WriteLine("26. feladat");

            var cimkek = studentsWithTags.SelectMany(s => s.Tags).Distinct().OrderBy(s => s).ToList();
            foreach (var t in cimkek) Console.WriteLine(t);

            //27. feladat
            Console.WriteLine("27. feladat");

            var nagykoruak = students.Where(s => s.Age >= 18).ToList();
            foreach(var t in nagykoruak) Console.WriteLine($"{t.Name} - {t.Age}");
        }

       
    }
}
