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

namespace Pizzeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pizza pizza = new Pizza();
        bool kontrolki = false;
        bool kontrolki2 = false;
        public MainWindow()
        {
            
            InitializeComponent();
            BDodajSkladnik.Visibility = Visibility.Hidden;
            BDodajSkladniki.Visibility = Visibility.Visible;
            BDodajSos.Visibility = Visibility.Hidden;
            BDostawa.Visibility = Visibility.Visible;
            BWyjscie.Visibility = Visibility.Visible;
            BDodajPizze.Visibility = Visibility.Hidden;
            CRodzajDostawy.Visibility = Visibility.Hidden;
            LGodzina.Visibility = Visibility.Hidden;
            TGodzina.Visibility = Visibility.Hidden;

            LNazawaPizzy.Visibility = Visibility.Hidden;
            LSkladnik.Visibility = Visibility.Hidden;
            LSos.Visibility = Visibility.Hidden;
            LCena.Visibility = Visibility.Hidden;

            TNazwaPizzy.Visibility = Visibility.Hidden;
            TNazwaSkladnika.Visibility = Visibility.Hidden;
            TNazwaSosu.Visibility = Visibility.Hidden;
            TCena.Visibility = Visibility.Hidden;
        }

        private void BNowaPizza_Click(object sender, RoutedEventArgs e)
        {
            BDodajSkladnik.Visibility = Visibility.Hidden;
            BDodajSkladniki.Visibility = Visibility.Visible;
            BDodajSos.Visibility = Visibility.Hidden;
            BDostawa.Visibility = Visibility.Visible;
            BWyjscie.Visibility = Visibility.Visible;
            BDodajPizze.Visibility = Visibility.Visible;

            LNazawaPizzy.Visibility = Visibility.Visible;
            LSkladnik.Visibility = Visibility.Hidden;
            LSos.Visibility = Visibility.Hidden;
            LCena.Visibility = Visibility.Hidden;

            TNazwaPizzy.Visibility = Visibility.Visible;
            TNazwaSkladnika.Visibility = Visibility.Hidden;
            TNazwaSosu.Visibility = Visibility.Hidden;
            TCena.Visibility = Visibility.Hidden;
            CRodzajDostawy.Visibility = Visibility.Hidden;
            LGodzina.Visibility = Visibility.Hidden;
            TGodzina.Visibility = Visibility.Hidden;
        }

        private void BDodajPizze_Click(object sender, RoutedEventArgs e)
        {
            bool czy_nazwa = true;
            string nazwa = TNazwaPizzy.Text;
            try
            {
                if (nazwa == "") throw new ArgumentOutOfRangeException();

            }
            catch
            {
                MessageBox.Show("Podaj nazwe");
                czy_nazwa = false;
            }

            if (czy_nazwa == true)
            {
                pizza.UstawNazwe(nazwa);
                kontrolki = true;
            }
            TInformacje.Text = "Dodano Pizze"+Environment.NewLine;


        }

        private void BDodajSkladniki_Click(object sender, RoutedEventArgs e)
        {
            if (kontrolki)
            {
                BDodajSkladnik.Visibility = Visibility.Visible;
                BDodajSkladniki.Visibility = Visibility.Visible;
                BDodajSos.Visibility = Visibility.Visible;
                BDostawa.Visibility = Visibility.Visible;
                BWyjscie.Visibility = Visibility.Visible;
                BDodajPizze.Visibility = Visibility.Hidden;

                LNazawaPizzy.Visibility = Visibility.Hidden;
                LSkladnik.Visibility = Visibility.Visible;
                LSos.Visibility = Visibility.Visible;
                LCena.Visibility = Visibility.Visible;

                TNazwaPizzy.Visibility = Visibility.Hidden;
                TNazwaSkladnika.Visibility = Visibility.Visible;
                TNazwaSosu.Visibility = Visibility.Visible;
                TCena.Visibility = Visibility.Visible;
                CRodzajDostawy.Visibility = Visibility.Hidden;
                LGodzina.Visibility = Visibility.Hidden;
                TGodzina.Visibility = Visibility.Hidden;
            }
        }

        private void BDodajSkladnik_Click(object sender, RoutedEventArgs e)
        {
            string nazwa="";
            double cena=0;
            bool mozna_dodac = true;

            try
            {
                cena = System.Convert.ToDouble(TCena.Text);
                nazwa = TNazwaSkladnika.Text;

                if (nazwa == "") throw new ArgumentOutOfRangeException();
                if (cena < 0) throw new ArgumentOutOfRangeException();
            }
            catch
            {
                mozna_dodac = false;
                MessageBox.Show("Podaj nazwe i cene w double");
            }

            if (mozna_dodac == true)
            {
                pizza.DodajSkladnik(nazwa, cena);
                TInformacje.Text +="Dodano skladnik" + Environment.NewLine;
            }
            if (pizza.CzyPizza())
            {
                TInformacje.Text = pizza.ToString();
                kontrolki2 = true;
            }
        }

        private void BDodajSos_Click(object sender, RoutedEventArgs e)
        {
            bool mozna_dodac = true;
            string sos = TNazwaSosu.Text;
            try
            {
                if (sos == "") throw new ArgumentOutOfRangeException();
            }
            catch
            {
                MessageBox.Show("Podaj nazwe sosu");
                mozna_dodac=false;
            }

            if (mozna_dodac)
            {
                pizza.DodajSos(sos);
                TInformacje.Text += "Dodano sos" + Environment.NewLine;
            }
            if (pizza.CzyPizza())
            {
                TInformacje.Text = pizza.ToString();
                kontrolki2 = true;
            }
        }

        private void BDostawa_Click(object sender, RoutedEventArgs e)
        {
            if (kontrolki2)
            {
                InitializeComponent();
                BDodajSkladnik.Visibility = Visibility.Hidden;
                BDodajSkladniki.Visibility = Visibility.Visible;
                BDodajSos.Visibility = Visibility.Hidden;
                BDostawa.Visibility = Visibility.Visible;
                BWyjscie.Visibility = Visibility.Visible;
                BDodajPizze.Visibility = Visibility.Hidden;

                LNazawaPizzy.Visibility = Visibility.Hidden;
                LSkladnik.Visibility = Visibility.Hidden;
                LSos.Visibility = Visibility.Hidden;
                LCena.Visibility = Visibility.Hidden;

                TNazwaPizzy.Visibility = Visibility.Hidden;
                TNazwaSkladnika.Visibility = Visibility.Hidden;
                TNazwaSosu.Visibility = Visibility.Hidden;
                TCena.Visibility = Visibility.Hidden;
                CRodzajDostawy.Visibility = Visibility.Visible;
                

                
                LGodzina.Visibility = Visibility.Visible;
                TGodzina.Visibility = Visibility.Visible;
                
            }
        }

        private void BSprawdz_Click(object sender, RoutedEventArgs e)
        {
            NaWynos wynos = new NaWynos();
            string dostawa = CRodzajDostawy.Text;
            bool dos = true;
            bool poprawna_godzina =true;
            DateTime data;
            try
            {
                if (dostawa == "") throw new ArgumentOutOfRangeException();
            }

            catch
            {
                MessageBox.Show("Wybierz rodzaj dostawy i podaj godzine");
                dos = false;
            }

            if (dos)
            {
                if (dostawa == "Na miejscu") TDostawa.Text = "Na miejscu";
                else
                {
                    string godzina = TGodzina.Text;
                    
                    double g=00;
                    double m=00;

                    try
                    {
                        g = System.Convert.ToDouble(godzina[0]);
                        g += System.Convert.ToDouble(godzina[1]);
                        m = System.Convert.ToDouble(godzina[3]);
                        m += System.Convert.ToDouble(godzina[4]);

                    }
                    catch
                    {
                        MessageBox.Show("Podaj poprawna godzine");
                        poprawna_godzina = false;
                    }
                    if (poprawna_godzina)
                    {
                        data = DateTime.Now;
                        data.AddHours(g);
                        data.AddMinutes(m);
                        if (wynos.PoprawnyCzas())
                        {

                        }
                        
                    }



                }
            }
        }

        


    }
}
