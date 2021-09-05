using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab2
{
    class Horse : Creature, ClovenHoofed
    {
        private String name;
        private int age;

        public Horse(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Horse()
        {
        } 

        public int getAge() {
            return age;
        }
        
        public String getName() {
            return name;
        }
        
        public void setName(String name) {
            this.name = name;
        }
         
        public void setAge(int age) {
            this.age = age;
        }

        public void clatter()
        {
            Console.WriteLine(name + " makes clip-clop clip-clop");
        }

        void ClovenHoofed.eat()
        {
            Console.WriteLine(name + " eats as cloven-hoofed");
        }

        void Creature.eat()
        {
            Console.WriteLine(name + " eats as a creature");
        }

        public void run()
        {
            Console.WriteLine(name + " runs with 4 hoofs");
        }

        public void makeASound()
        {
            Console.WriteLine(name + " says neigh-neigh");

        }
    }
}
