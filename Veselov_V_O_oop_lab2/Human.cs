using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab2
{
    class Human : Creature, HomoSapiens
    {
        private String name;
        private int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Human()
        {
        }

        public int getAge()
        {
            return age;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void rideAHorse()
        {
            Console.WriteLine(name + " rides a horse");
        }

        public void walkOnTwoFeet()
        {
            Console.WriteLine(name + " walks on two feet");

        }

        void Creature.eat()
        {
            Console.WriteLine(name + " eats like a creature");
            
        }
        void HomoSapiens.eat()
        {
            Console.WriteLine(name + " eats like a homo sapiens");

        }

        public void run()
        {
            Console.WriteLine(name + " runs on two feet");
        }

        public void makeASound()
        {
            Console.WriteLine(name + " says: 'I want an automate'");
        }
    }
}
