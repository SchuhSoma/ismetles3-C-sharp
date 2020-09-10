using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Console.ReadKey();
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat számok 100 és 300 között");
            int Valtozo =  100;
            do
            {
                Valtozo++;
                if(Valtozo%3==0 && Valtozo%7==0)
                {
                    Console.Write("{0} ", Valtozo);
                }
            } while (Valtozo < 300 );
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: dolgozat ponthatára jegyek");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            int Pontok;
            int OsszesPont = 0;
            for (int i = 1; i <= 5; i++)
            {
                Pontok = rnd.Next(0,21);
                Console.WriteLine("{0} feladat pontja: {1} pont", i, Pontok);
                OsszesPont += Pontok;//ez is egy összegzási tétel
            }
            if(0<=OsszesPont && OsszesPont<43)
            { Console.WriteLine("\t{0} dolgozata elégtelen (1) pontjanak összege: {1}", Nev, OsszesPont); }
            if (43 <= OsszesPont && OsszesPont < 58)
            { Console.WriteLine("\t{0} dolgozata elégséges (2) pontjanak összege: {1}", Nev, OsszesPont); }
            if (58 <= OsszesPont && OsszesPont < 73)
            { Console.WriteLine("\t{0} dolgozata közepes (3) pontjanak összege: {1}", Nev, OsszesPont); }
            if (73 <= OsszesPont && OsszesPont < 88)
            { Console.WriteLine("\t{0} dolgozata jó (4) pontjanak összege: {1}", Nev, OsszesPont); }
            if (88 <= OsszesPont && OsszesPont < 101)
            { Console.WriteLine("\t{0} dolgozata jeles (5) pontjanak összege: {1}", Nev, OsszesPont); }
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: kúpot leíró adatok");
            Console.Write("Kérem adja meg a kúp sugarát: ");//bekérés első fele, a felhasználó ennek a sornak a végére ír be egy számot
            double Sugar = double.Parse(Console.ReadLine()); //az előtte lévő sort beolvassa és átalakítja, letárolja szám formában
            Console.Write("Kérem adja meg a kúp magasságát: ");//bekérés első fele, a felhasználó ennek a sornak a végére ír be egy számot
            double Magassag = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a kúp alkotó: ");//bekérés első fele, a felhasználó ennek a sornak a végére ír be egy számot
            double Alkoto = double.Parse(Console.ReadLine());
            double A = 3.14 * Sugar * (Sugar + Alkoto);
            //double A = Math.Pi * Sugar * (Sugar + Alkoto);
            Console.WriteLine("A forgáskúp felszíne: {0:0.00}", A);
            double V = 3.14 * Sugar * Sugar * Magassag / 3;
            //doule V=Math.Pi*Math.Pow(Sugar,2)*Magassag/3;
            Console.WriteLine("A forgáskúp térgogat: {0:0.00}", V);
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: Rulett kerék");
            int Porgetes;
            int Osszeg = 0;//összegzési tétel változója
            double Atlag = 0;//átlagolás tételének változója
            int db = 0;//leszámolás tételének változója
            for (int i = 1; i <= 12; i++)
            {
                Porgetes = rnd.Next(1, 36);
                Console.WriteLine("\t{0:00}. pörgetés : {1}",i,Porgetes);
                Osszeg += Porgetes; //összegés tétele
                if(Porgetes==11)//leszámolási tétel
                {
                    db++;//Leszámolási tétel +1-el nő ha a feltétel igaz
                }
            }
            Atlag = (double)Osszeg /12;//átlagolás tétel
            Console.WriteLine("\tA pörgetés összege: {0}", Osszeg);
            Console.WriteLine("\tA pörgetések átlaga: {0}", Atlag);
            Console.WriteLine("\tA pörgetések között ennyiszer volt 11-es: {0}", db);
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: számok kiiratása");
            int Szam;
            for (int i = 0; i < 30; i++)
            {
                Szam = 5 * 12 * i;
                if (Szam % 24 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }                
                Console.Write("{0} , ", Szam);
                Console.ResetColor();
            }
        }
    }
}
