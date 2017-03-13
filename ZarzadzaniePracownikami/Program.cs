using Finanse.Pracownicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePracownikami
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pracownik();
            p1.imie = "Antoni";
            p1.nazwisko = "Misiewicz";
            //p1.ustawTypUmowy(UmowaTyp.Zlecenie);
            p1.Typ = UmowaTyp.Zlecenie;


            //p1.ustawDateZatrudnienia(new DateTime(2015, 10, 10));
            p1.DataZatrudnienia = new DateTime(2015, 10, 10);

            //struc testc nie trzeba inicjalizowac
            p1.wynagrodzenie.zasadnicza = 12000;
            p1.wynagrodzenie.premia = 2000;

            var o1 = new Operacja();
            o1.dataOperacji = new DateTime(2011, 02, 02);
            o1.tytul = "Tajna akcja w Białymstoku ";
            o1.kwotaOperacji = 3000;
            o1.rozliczenie = false;

            var o2 = new Operacja();
            o2.dataOperacji = new DateTime(2017, 02, 02);
            o2.tytul = "Zaliczka na studia ";
            o2.kwotaOperacji = 2000;
            o2.rozliczenie = true;

            p1.operacje.Add(o1);
            p1.operacje.Add(o2);

            Console.WriteLine(p1.lacznaKwotaNierozliczonychZaliczek());
            Console.ReadKey();

            //typowa notacja
            //p1.dataZatrudnienia
            //p1.dataZatrudnienia = new DateTime(2015,10,10);

        }
    }
}
