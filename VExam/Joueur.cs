using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VExam
{

    internal class Joueur : INotifyPropertyChanged
    {
        string nom, prenom, dateNaisance,  equipe;
        String numero;

        public Joueur(string nom, string prenom, string dateNaisance, String numero, string Poste)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaisance = dateNaisance;
            this.numero = numero;
            
            this.equipe = Poste;
        }

        public string Nom { get => nom; set { nom = value; this.OnPropertyChanged(); } }

        public string Prenom { get => prenom; set { prenom = value; this.OnPropertyChanged(); } }

        public string DateNaissance { get => dateNaisance; set { dateNaisance = value; this.OnPropertyChanged(); } }

        public String Numero { get => numero; set { numero = value; this.OnPropertyChanged(); } }

        

        public string Equipe { get => equipe; set { equipe = value; this.OnPropertyChanged(); } }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public override string ToString()
        {
            return nom + " - " + prenom + " - " + dateNaisance + " - " + numero +  " - " + equipe;
        }

    }

}
