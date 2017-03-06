using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanseFirma
{
    public class Pracownik
    {
        ////dyrektywa  region
        #region POLA
        int nrPracownika;
        string imie;   //""
        string nazwisko;  //""
        UmowaTyp typUmowy = UmowaTyp.Zlecenie;

        DateTime dataUrodzenia;
        DateTime dataZatrudnienia; //privet

        List<Operacje> operacje = new List<Operacje>();     //lista generyczna// pusta lista domyslnie
        public Wynagrodzenie wynagrodzenie;
        #endregion


        #region  METODY  AKCESOROW
        //accerory     //get set
        // zwracamy jawnie this.dataZatrudnienia    //kiedy zwracamy jawnie???
        public DateTime pobierzDataZatrudnienia()   //GET
        {
            return this.dataZatrudnienia;
        }

        public void ustawDateZatrudnienia(DateTime nowaData)
        {
            if (this.dataZatrudnienia < nowaData)
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




        
 

        public UmowaTyp ustawTypUmowy (UmowaTyp typ)
        {
            //typ = new UmowaTyp();
            typ = UmowaTyp.Praca;

            DateTime localDate = DateTime.Today;
            DateTime today = DateTime.Now;
            TimeSpan duration = new TimeSpan(-36, 0, 0, 0);
            DateTime answer = today.Add(duration);
            Console.WriteLine("{0:dddd}", answer);

            //DateTime minZatrudnienia = localDate - ustawDateZatrudnienia;
            if (dataZatrudnienia < answer)
            {
                return typ;
            }
            else 
            {
                throw new Exception("Nie ten typ umowy");
            }
        }
        #endregion

        //METODY



    }
}
