using System;
using Jogo_RPG.src.Entities;

namespace dotne__poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior guerreiro1 = new Warrior("Brutus", 56, "Machado Mítico"); //instanciando a classe, atalho ctrl + .
            Wizard mago1 = new Wizard("Esplendica", 26, "Poder Arcano");

            Console.WriteLine(guerreiro1); //por padrão se chamado o objeto ele vai buscar o método "ToString"
            Console.WriteLine(guerreiro1.Attack());
            Console.WriteLine(mago1.Attack(3));
            Console.WriteLine(mago1.Attack(7));
            Console.WriteLine(mago1.Attack());
        }
    }
}
