using System;
using Entities;
namespace _04___Manual___Class_Exercise_4._0 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("-----------------------------------");
            Student student = new Student();
            Console.Write("Digite o nome do aluno: "); student.Name = Console.ReadLine();
            student.Grade = 0;
            for(double i = 1; i <= 3; i++) {
                Console.Write("Digite a nota "+i+ " : ");
                double sumGrade = double.Parse(Console.ReadLine());
                student.Grade += sumGrade;
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(student);
            Console.WriteLine("-----------------------------------");
        }
    }
}
