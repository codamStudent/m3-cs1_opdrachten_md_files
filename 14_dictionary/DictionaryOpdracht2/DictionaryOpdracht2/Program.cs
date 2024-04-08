using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace DictionaryOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //maak een dictionary aan van EvoMonsters op naam;
            Dictionary<string, EvoMonster> monsters = new Dictionary<string, EvoMonster>();


            EvoMonster pickelChu = new EvoMonster() { Name = "pickleChu", EvolvesTo = "most popular" };
            EvoMonster boosDraakje = new EvoMonster() { Name = "boosDraakje", EvolvesTo = "nog koppiger" };




            //voeg de bovenstaande monsters toe
			monsters.Add(pickelChu.Name, pickelChu);
            monsters.Add(boosDraakje.Name, boosDraakje);




            //kies een monster uit de dictionary
            EvoMonster ikKiesJouw = monsters["pickleChu"];

            Console.WriteLine(ikKiesJouw.Name + " wants to evolve may it? (y/n)");
            if (Console.ReadLine() == "y")
            {
                //als deze crashed wat ben je vergeten? wat moet er in monsters zitten?
                ikKiesJouw = ikKiesJouw.Evolve(monsters);//maak deze method af in EvoMonster.cs

                Console.WriteLine("you now have a " + ikKiesJouw.Name);
            }
        }
    }
}