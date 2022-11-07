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
    public sealed partial class Visualiser : Page
    {
        int index = 8;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            index = (int)e.Parameter;

        }

        public Visualiser()
        {
            this.InitializeComponent();
            nom.Text = MainPage.liste[index].Nom;
            prenom.Text = MainPage.liste[index].Prenom;
            dateNaissance.Text = MainPage.liste[index].DateNaissance;
            numeroMaillot.Text = MainPage.liste[index].Numero;
            
            equipe.Text = MainPage.liste[index].Equipe;




        }
   

        private void supp(object sender, RoutedEventArgs e)
        {
            MainPage.liste.RemoveAt(index);
        }

    }
}
