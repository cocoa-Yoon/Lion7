using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ConsoleApp1
{
    public class Animal
    {
        string animalName;
        int length;
        int hegith;
        int weight;
        
        public Animal(string name)
        {
            animalName = name;
            length = 10;
            hegith = 90;
            weight = 14;
        }

        public void animalInfo()
        {
            Console.WriteLine($"동물 : {animalName}");
            Console.WriteLine($"너비 : {length}");
            Console.WriteLine($"높이 : {hegith}");
            Console.WriteLine($"무게 : {weight}");
        }
    }

    public class Penguin : Animal
    {
        private string specific = "뒤뚱뒤뚱";
        string animalName;
        public Penguin(string name) : base(name)
        {
            animalName = name;
        }        
        public void animalInfo1()
        {
            animalInfo();
            Console.WriteLine("특징 : " + specific);
        }
    }

    public class Lion : Animal
    {
        private string specific = "무서움";
        string animalName; 
        
        public Lion(string name) : base(name)
        {
            animalName = name;
        }
        public void animalInfo2()
        {
            animalInfo();
            Console.WriteLine("특징 : " + specific);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Penguin("팽귄");
            Animal animal2 = new Lion("사자");

            List<Animal> animals = {
                "팽귄", "사자"
            }

        }
    }
}
