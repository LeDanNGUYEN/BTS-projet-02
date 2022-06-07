using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_conservatoire_musique.Modele
{
    public abstract class Person
    {

/*ATTRIBUTS*/
        protected int id;
        protected string nom;
        protected string prenom;
        protected string tel;
        protected string adresse;
        protected string mail;


/*CONSTRUCTOR*/
        public Person() { }
        public Person(int id, string nom, string prenom, string tel, string adresse, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.adresse = adresse;
            this.mail = mail;
        }


/*GETTER - SETTER*/
        public int Id { get => (int)id; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; set => tel = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Mail { get => mail; set => mail = value; }


/*METHODES*/
        public override string ToString()
        {
            return Nom + " " + Prenom;
        }


        public abstract void crediter(int sommeCredit); /*Non fonctionnelle*/

    }
}
