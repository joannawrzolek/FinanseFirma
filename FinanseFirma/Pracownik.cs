using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Finanse.Pracownicy
{
    public class Pracownik    /*Internal - jest domyslny*/
    {
        ////dyrektywa  region
        #region Pola
        int nrPracownika;
        public string imie;   //""
        public string nazwisko;  //""
        UmowaTyp typUmowy = UmowaTyp.Zlecenie;

        DateTime dataUrodzenia;
        DateTime dataZatrudnienia; //private

        public List<Operacja> operacje = new List<Operacja>();     //lista generyczna// pusta lista domyslnie
        public Wynagrodzenie wynagrodzenie;
        #endregion

        #region Własciwosci
        //wlasciwosc wywoluje sama siebie

        public DateTime DataZatrudnienia
        {
            get //"p1".dataZatrudnienia
            {
                return dataZatrudnienia;
            }
            set  //   "p1".dataZatrudnienia  = new dateTime(...);
            {
                //value czyli to co się ustawia
                ustawDateZatrudnienia(value); 
            }
        }


        public UmowaTyp Typ
        {
            get
            {
                return UmowaTyp.Zlecenie;
            }
            set
            {
                ustawTypUmowy(value);
            }
        }


        #endregion

        #region  Metody akcesorow
        //accerory     //get set
        // zwracamy jawnie this.dataZatrudnienia    //kiedy zwracamy jawnie???
        public DateTime pobierzDataZatrudnienia()   //GET
        {
            return this.dataZatrudnienia;
        }

        public void ustawDateZatrudnienia(DateTime nowaData)
        {
            if (this.dataZatrudnienia > nowaData)
            {
                throw new Exception("Nowa data zatrudnienia nie moze byc wczesniejsza niz aktualna data");
            }
            else
            {
                this.dataZatrudnienia = nowaData;
            }
        }

        //1. metoda ustawTypUmowy 
        //-- umowa o pracę może być ustawiona dla osób ktore pracują min 3 lata
        //DateTime.Now -- aktualna data


        //accesor
        /// <summary>
        /// Metoda ustawiajaca date zatrudnienia
        /// </summary>
        /// <param name="typ">Nowa data zatrudnienia</param>
        /// <exception cref="Exception" >Umowa o prace tylko w przypadku stazu powyzej 3 lat</exception>
        public void  ustawTypUmowy (UmowaTyp typ)
        {
            var aktualna = DateTime.Today;
            var zatrudnienia = this.dataZatrudnienia;

            //(aktualna - zatrudnienia).TotalDays > 3 * 365;
            if (this.typUmowy == UmowaTyp.Praca && (aktualna.AddYears(-3) < dataZatrudnienia))
                throw new Exception("Umowa o prace tylko w przypadku stazu powyzej 3 lat");
            else this.typUmowy = typ;         
        }
        #endregion

        //METODY
        #region Metody
        public float lacznaKwotaNierozliczonychZaliczek()
        {
            //jezyk link  - lista, tab, baza danych  - link to object  //jezyk do przetwarzania bazy danych w sposob stabilny
            return operacje.Where(o => o.rozliczenie == false).Sum(o => o.kwotaOperacji);

            //var suma = 0.0f;
            //foreach (var operacja in operacje)
            //{
            //    if (!operacja.rozliczenie)   // lub operacja rozliczenie == false
            //    {
            //        suma += operacja.kwotaOperacji;
            //    }
            //}
            //return suma;
        }


        #endregion


    }
}
