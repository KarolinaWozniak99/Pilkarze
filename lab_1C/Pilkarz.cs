using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1C
{
    internal class Pilkarz
    {
        //private string _imie;

        //public string Imie {

        //    get { return _imie; }
        //    set { _imie = value; }
        //}
        #region Prop
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public uint Wiek { get; set; }
        public uint Waga { get; set; }
        #endregion

        #region constr
        public Pilkarz(string imie, string nazwisko, uint wiek, uint waga)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Waga = waga;
        }

        public Pilkarz(string imie, string nazwisko) : this(imie, nazwisko, 30, 75) { }
        #endregion

        #region methods

        public override string ToString()
        {
            return $"{Nazwisko} {Imie} lat: {Wiek} waga: {Waga} kg";
        }

        #endregion
    }
}
