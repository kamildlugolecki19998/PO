﻿using System;
using System.Collections.Generic;

namespace Cw_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworzymy instancję klasy Osoba
            Osoba konrad = new Osoba("Konrad", "Malinowski", 1990);
            // korzystając z mechanizmu refleksji pobieramy typ obiektu
            Type type = konrad.GetType();

            //w pętli pobieramy wszystkie pole dla tego typu obiektu i wyświeltamy wybrane właściwości
            foreach (var f in type.GetFields())
            {
                Console.WriteLine(
                    String.Format("Nazwa: {0}, Typ: {2},  Wartość: {1}", f.Name, f.GetValue(konrad), f.FieldType));
            }


            
            konrad.WypiszInfo();
            // studenci
            Student student1 = new Student("Adam", "Maliniak", 1991, 12345678);
            student1.WypiszInfo();

            // konrad na studenta
            //Student sKonrad = (Student)konrad; tak nie można
            // ale można napisać dodatkowy konstruktor
            konrad = new Student(konrad, 1234678);
       
            konrad.WypiszInfo();

            //RPG

            Wojownik zdzich = new Wojownik("Zdzich", Rasa.Człowiek);
            Zlodziej maniek = new Zlodziej("Maniek", Rasa.Niziołek);

            List<Bohater> druzyna = new List<Bohater>();
            druzyna.Add(zdzich);
            druzyna.Add(maniek);

            // albo

            //List<Bohater> druzyna = new List<Bohater>
            //{
            //    zdzich,
            //    maniek
            //};

            foreach (Bohater boh in druzyna)
            {
                Console.WriteLine(boh.PrzedstawSie());
            }

            Console.ReadKey();
        }
    }
}