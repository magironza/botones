using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Botones.Resources;
using System.Windows.Media;



namespace Botones
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

     


        private void Metodo1(object sender, RoutedEventArgs e)
        {

           
            brocha.Fill = new SolidColorBrush(Colors.Yellow);
            
            
            
            
        }

        private void Metodo2(object sender, RoutedEventArgs e)
        {
            brocha.Fill = new SolidColorBrush(Colors.Blue);
    

        }

        private void Metodo3(object sender, RoutedEventArgs e)
        {
            brocha.Fill = new SolidColorBrush(Colors.Red);
            

        }


        private void metodo(object sender, RoutedEventArgs e)
        {
            int A=0, B=0, C=0, D=0;

            if (txt1.IsChecked == true)
            {
                A = 1;

            }
            else
            {
                A = 0;
            }

            if (txt2.IsChecked == true)
            {
                B = 3;

            }
            else
            {
                B = 0; 
            }

            if (txt3.IsChecked == true)
            {
                C = 5;

            }
            else {
                C = 0;

            }
           

             D = A + B + C;

            if(D==0){
            check.Fill=new SolidColorBrush(Colors.Gray);
            
            }

            else if(D==1){
            check.Fill=new SolidColorBrush(Colors.Yellow);
            }
            else if(D==3){
            check.Fill=new SolidColorBrush(Colors.Blue);
            }
            else if(D==5){
            check.Fill=new SolidColorBrush(Colors.Red);

            }
            else  if(D==4){
            check.Fill=new SolidColorBrush(Colors.Green);
            }
            else if(D==6){
                check.Fill = new SolidColorBrush(Colors.Orange);
            }
            else if (D == 8)
            {
                check.Fill = new SolidColorBrush(Colors.Purple);
            }
            else if (D ==9)
            {
                check.Fill = new SolidColorBrush(Colors.Black);
            }
            



        }

       

      
        
        
        
        
       




       

       

        

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}



       
    }
}