using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_ve_nha_2
{
    class Student
    {
        private int id;
        private string name;
        private int age;

       

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Student()
        {
        }
    }

   

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student { Id = 1, Name = "Nguyen Van A", Age = 19 });
            list.Add(new Student { Id = 2, Name = "Nguyen Van B", Age = 18 });
            list.Add(new Student { Id = 3, Name = "Nguyen Van C", Age = 17 });
            list.Add(new Student { Id = 4, Name = "Nguyen Van D", Age = 16});
            list.Add(new Student { Id = 5, Name = "Nguyen Van E", Age = 15 });
            
            ShowList(list); 
            StudenFrom15to18(list);
            StudentHaveAName(list);
            StudentSumAge(list);
            OldestStudent(list);   
            SortStudentAge(list);
            Console.ReadLine();

        }
        static void ShowList(List<Student> list)
        {

            foreach (var student in list)
            {
                Console.WriteLine($"Id: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }

        }
        static void StudenFrom15to18(List<Student> list)
        {
            Console.WriteLine("- Danh sach sinh vien co tuoi tu 15 den 18: ");
            var students = list.Where(s => s.Age >= 15 && s.Age <= 18);
            ShowList(list);
           
        }
        static void StudentHaveAName(List<Student> list)
        {

            var students = list.Where(s =>
            {
                var name = s.Name.Split(' ').Last();
                return name.StartsWith("A", StringComparison.OrdinalIgnoreCase);


            }).ToList();
            if (students.Count() > 0)
            {
                Console.WriteLine("- Danh sach sinh vien co ten bat dau bang chu A");
                ShowList(students);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien co ten bat dau bang chu A");
            }
              
        }

        static void StudentSumAge(List<Student> list)
        {
            Console.Write("- Tong tuoi cua sinh vien trong danh sach: ");
            var studentAge = list.Sum(s => s.Age);
            Console.WriteLine(studentAge);
            
        }

        static void OldestStudent(List<Student> list)
        {
            Console.WriteLine("- Sinh vien co tuoi cao nhat la: ");
            int maxAge = list.Max(s => s.Age);
            var oldestStudent = list.Where(s => s.Age == maxAge).ToList();
            ShowList(oldestStudent);
        }

        static void SortStudentAge(List<Student> list)
        {
            Console.WriteLine(" Danh sach sinh vien co tuoi tang dan: ");
            var sortAge = list.OrderBy(s => s.Age).ToList();
            ShowList(sortAge);

        }

    }
}
