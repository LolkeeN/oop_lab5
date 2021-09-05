using System;

namespace Veselov_V_O_oop_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature humanCreature = new Human("human creature", 12);
            HomoSapiens humanSapiens = new Human("human homo sapinens", 24);
            humanCreature.eat();
            humanSapiens.eat();

            Creature horseCreature = new Horse("horse creature", 12);
            ClovenHoofed clovenHoofedHorse = new Horse("cloven-hoofed horse", 12);
            horseCreature.eat();
            clovenHoofedHorse.eat();
        }
    }
}
