using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Finanse.Pracownicy
{
   public struct Wynagrodzenie
    {
        //POLA STATYCZNE
        static float dodatekWakacyjny;

        //POLA
        public float zasadnicza;
        public float nadgodziny;
        public float premia;
        public float dodatekStazowy;
        //struct typ odwolanie do obiektow przez wartosc/ strukture 
        //class odwolanie do obiektow przez referencje
        //structury tez mają pola statyczne


        //Metodystatyczne
        public static float pobierzDodatekWakacyjny()
        {
            return Wynagrodzenie.dodatekWakacyjny;
        }
        public static void ustawDodatekWakacyjny(float nowyDodatek)
        {
            Wynagrodzenie.dodatekWakacyjny = nowyDodatek;
        }
















    }
}
