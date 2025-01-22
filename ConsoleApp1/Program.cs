using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp5.AtvaltOOP;

/*
 * A megadott bináris számot átváltja tízes alapú számmá és vissza.
 * Metódusok:
 * -Konstruktor
 * - Szám input stringként. Megjegyzés: Mivel lehet olyan decimális szám, amely csak nullából és egyesből áll, ezért
 * 
 */

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atvalt atvalt1 = new Atvalt();
            int atvalt = atvalt1;
            atvalt.SetSzam(1101);  
            atvalt.Atvalto();  
            Console.WriteLine(atvalt.GetEredmeny());
        }
    }
}
