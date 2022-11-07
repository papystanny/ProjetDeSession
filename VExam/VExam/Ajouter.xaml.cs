using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace VExam
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Ajouter : Page
    {
        public Ajouter()
        {
            this.InitializeComponent();
        }



        private void pageAjouter_buttonAjouter(object sender, RoutedEventArgs e)
        {
            Boolean validite = true;
            ////////////////////////////////////////////////////////////////TITRE///////////////////////////////////////
            if (nom.Text == null || nom.Text == "")
            {
                nomErreur.Visibility = Visibility.Visible;
                validite = false;
            }
            else
            {

                nomErreur.Visibility = Visibility.Collapsed;
            }

            //////////////////////////////////////////////////////////////EDITEUR///////////////////////////////////////////
            if (prenom.Text == null || prenom.Text == "")
            {
                prenomErreur.Visibility = Visibility.Visible;
                validite = false;
            }
            else
            {
                prenomErreur.Visibility = Visibility.Collapsed;
            }

            /////////////////////////////////////////////////////////////////AUTEUR///////////////////////////////////////////////
            if (dateNaissance.Text == null || dateNaissance.Text == "")
            {
                dateNaissanceErreur.Visibility = Visibility.Visible;
                validite = false;
            }
            else
            {
                dateNaissanceErreur.Visibility = Visibility.Collapsed;
            }

            //////////////////////////////////////////////////////////////////////CouVETURE///////////////////////////////////////////////
            if (numero.Text == null || numero.Text == "" )
            {
                numeroErreur.Visibility = Visibility.Visible;
                validite = false;
            }
            else
            {
                numeroErreur.Visibility = Visibility.Collapsed;
            }

            //////////////////////////////////////////////////////////////////////CouVETURE///////////////////////////////////////////////
            if (equipe.SelectedIndex ==-1)
            {
                equipeErreur.Visibility = Visibility.Visible;
                validite = false;
            }
            else
            {
                equipeErreur.Visibility = Visibility.Collapsed;
            }
            ////////////////////////////////////////////////////////////////////ajouter dans la base de données//////////////////////////
            if (validite)
            {
                MainPage.liste.Add(new Joueur(nom.Text, prenom.Text, dateNaissance.Text, numero.Text,  equipe.SelectedIndex.ToString()));
                nom.Text = "";
                prenom.Text = "";
                dateNaissance.Text = "";
                numero.Text = "";
                equipe.Text = "";



            }



        }


    }
}
