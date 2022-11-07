
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VExam
{
    public sealed partial class MainPage : Page
    {
        internal static ObservableCollection<Joueur> liste = new ObservableCollection<Joueur>()
        {
              new Joueur ("Stv2","Stv2","Stv2","4","Stv2"),
              new Joueur("Stv2","Stv2","Stv2","4","Stv2"),
        };

        public MainPage()
        {
            this.InitializeComponent();
            mainFrame.Navigate(typeof(Affichage));
        }


        private void ajouter(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Ajouter));
        }






    }
}
