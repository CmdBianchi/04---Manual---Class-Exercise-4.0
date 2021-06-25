using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Student {
        public string Name { get; set; }
        public double Grade { get; set; }
        public Student(string name, double grade) {
            Name = name;
            Grade = grade;
        }
        public Student() {
        }

        public bool Check1() {
            if(Grade >= 60) {
                return true;
            }
            else {
                return false;
            }
        }
        public double Check2() {
            return (Grade - 60) * (-1);
        }

        public override string ToString() {
            if (Check1() == true) {
                return "Nome do aluno: " + Name + " | Situação do aluno: Aprovado" + " | Média global: " + Grade;
            }
            else {
                return "Nome do aluno: " + Name + "\nSituação do aluno: Reprovado" + "\nMédia global: " + Grade + "\nFaltam " + Check2() + " pontos para aprovação."; 
            }
        }
    }
}
