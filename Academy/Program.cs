using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Vercetty", "Tommy", 30);
            human.Info();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 95, 98);
            student.Info();
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 20);
            teacher.Info();
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 70, 40, "How to catch Haizenberg");
            graduate.Info();
            Console.WriteLine(graduate);

            Student tommy = new Student(human, "Theft", "Vice", 98, 99);
            Console.WriteLine(tommy);

            Graduate tommy_grad = new Graduate(tommy, "How to make money");
            Console.WriteLine(tommy_grad);
            
            Human[] group= new Human[] 
            { 
                student, teacher, graduate, tommy,
                new Graduate("Rosenberg","Ken", 30, "Lower","Vice",45,22,"How to get money back"),
                new Teacher("Diaz","Ricardo",50,"Weapons distribution",25)
            };
            Console.WriteLine("\n----------------------------\n");
            for (int i=0;i<group.Length;i++)
            {
              Console.WriteLine(group[i]);
            }
            StreamWriter sw = new StreamWriter("group.txt");
            foreach(Human i in group) sw.WriteLine(i);
            sw.Close();
            System.Diagnostics.Process.Start("notepad",$"{Directory.GetCurrentDirectory()}\\group.txt");
            Console.WriteLine("\n----------------------------\n");


        }
    }
}
