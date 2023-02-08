using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace crst.nol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int vibor;
        public MainWindow()
        {
          
            InitializeComponent();
            vibor = 1;
            start.IsEnabled = true;

        }

        private void bat1_Click(object sender, RoutedEventArgs e)
        {
            
            switch (vibor)
            {
                case 1:
                    (sender as Button).Content = "x";
                    vibor = 0;

                    break;
                case 0:
                    (sender as Button).Content = "o";
                    vibor = 1;

                    break;
            }
            (sender as Button).IsEnabled = false;
            
            Proverka(sender, e);
        }
        private void Proverka(object sender, RoutedEventArgs e)
        {
            if (bat1.Content == bat2.Content&&bat2.Content==bat3.Content)
            {
                if (bat1.Content != "")
                {

                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat4.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";
                        bat4.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    
                }
            }
            if (bat4.Content == bat5.Content && bat5.Content == bat6.Content)
            {
                if (bat4.Content != "")
                {
                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";

                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    
                }
            }
            if (bat7.Content == bat8.Content && bat8.Content == bat9.Content)
            {
                if (bat7.Content != "")
                {
                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat6.IsEnabled = false;

                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";
                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat6.IsEnabled = false;
                    }
                   
                }
            }
            if (bat1.Content == bat4.Content && bat4.Content == bat7.Content)
            {
                if (bat1.Content != "")
                {
                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat2.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat8.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";
                        bat2.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat8.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    
                }
            }
            if (bat2.Content == bat5.Content && bat5.Content == bat8.Content)
            {
                if (bat2.Content != "")
                {
                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat4.IsEnabled = false;
                        bat1.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";
                        bat4.IsEnabled = false;
                        bat1.IsEnabled = false;
                        bat3.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat9.IsEnabled = false;
                    }
                    
                }
            }
            if (bat3.Content == bat6.Content && bat6.Content == bat9.Content)
            {
                if (bat7.Content != "")
                {
                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";
                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat5.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                    }
                    
                }
            }
           
            if (bat1.Content == bat5.Content && bat5.Content == bat9.Content)
            {
                if (bat1.Content != "")
                {
                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat3.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";
                        bat3.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat7.IsEnabled = false;
                        bat8.IsEnabled = false;
                    }
                    
                }
            }
            if (bat3.Content == bat5.Content && bat5.Content == bat7.Content)
            {
                if (bat3.Content != "")
                {
                    if (vibor == 1)
                    {
                        rezult.Content = "победили нолики";
                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat9.IsEnabled = false;
                        bat8.IsEnabled = false;
                    }
                    else if (vibor == 0)
                    {
                        rezult.Content = "победили крестики";
                        bat1.IsEnabled = false;
                        bat2.IsEnabled = false;
                        bat4.IsEnabled = false;
                        bat6.IsEnabled = false;
                        bat9.IsEnabled = false;
                        bat8.IsEnabled = false;

                    }

                }

            }
            if (bat1.Content != ""&& bat2.Content != "" && bat3.Content != "" && bat4.Content != "" && bat5.Content != "" && bat6.Content != "" && bat7.Content != "" && bat8.Content != "" && bat9.Content != "")
            {
                rezult.Content = "ничья";
            }
            
            
            
        }

       

        private void start_Click(object sender, RoutedEventArgs e)
        {
            rezult.Content = "";
            bat1.IsEnabled = true;
            bat1.Content = "";
            bat2.IsEnabled = true;
            bat2.Content = "";
            bat3.IsEnabled = true;
            bat3.Content = "";
            bat4.IsEnabled = true;
            bat4.Content = "";
            bat5.IsEnabled = true;
            bat5.Content = "";
            bat6.IsEnabled = true;
            bat6.Content = "";
            bat7.IsEnabled = true;
            bat7.Content = "";
            bat8.IsEnabled = true;
            bat8.Content = "";
            bat9.IsEnabled = true;
            bat9.Content = "";
        }
    }
}



//b1.IsEnabled = false;
//b1.IsEnabled = true;
