using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {

        //Name,Surname,Street,City,Province,ZIP

        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetProvince()
        {
            return this.province;
        }

        public string GetZip()
        {
            return this.zip;
        }

        public void SetName(string Name)
        {
            if (this.name == "undefined")
            {
                this.name = Name;
            }
        }

        public void SetSurname(string Surname)
        {
            if (this.surname == "undefined")
            {
                this.surname = Surname;
            }
        }

        public void SetStreet(string Street)
        {
            if (this.street == "undefined")
            {
                this.street = Street;
            }
        }

        public void SetCity(string City)
        {
            if (this.city == "undefined")
            {
                this.city = City;
            }
        }

        public void SetProvince(string Province)
        {
            if (this.province == "undefined")
            {
                this.province = Province;
            }
        }

        public void SetZip(string Zip)
        {
            if (this.zip == "undefined")
            {
                this.zip = Zip;
            }
        }

        public override string ToString()
        {
            string stringa = "Nome: " + name + "\n";
            stringa = "Cognome: " + surname + "\n";
            stringa += "Indirizzo: " + street + city + province + zip + "\n";
            stringa += "-------------------";

            return stringa;
        }
    }
}
