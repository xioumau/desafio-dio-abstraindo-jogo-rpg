using System;
using Projeto.src.Entities;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer Leon = new Archer("Leon", 5, "Archer");
            Programmer Kortana = new Programmer("Kortana", 15, "Programmer");
            Professor Janjo = new Professor("Janjo", 28, "Professor");
            Skater Klovis = new Skater("Klovis", 27, "Skater");

            Console.WriteLine(Janjo.Attack());
            Console.WriteLine(Klovis.Attack());
            Console.WriteLine(Leon.Attack(5));
            Console.WriteLine(Kortana.Attack(7));
        }
    }
}
