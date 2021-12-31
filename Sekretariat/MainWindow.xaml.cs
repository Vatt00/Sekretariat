using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input; 
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sekretariat
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submit_Click_Uczen(object sender, RoutedEventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
                
            if (theDialog.ShowDialog() == true)
            {
                File.AppendAllText(theDialog.FileName, "Imię: " + imieUczen1.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Drugie Imię: " + imieUczen2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Nazwisko: " + nazwiskoUczen1.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Nazwisko panieńskie: " + nazwiskoUczen2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Imiona rodziców: " + imionaUczen1.Text + ", ");
                File.AppendAllText(theDialog.FileName, imionaUczen2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Data urodzenia: " + dataUUczen.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Pesel: " + peselUczen.Text);
            }
        }
        private void input_Click_Uczen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == true)
            {
                string[] allLines = File.ReadAllLines(theDialog.FileName);
                imieUczen1.Text = "";
                imieUczen2.Text = "";
                nazwiskoUczen1.Text = "";
                nazwiskoUczen2.Text = "";
                imionaUczen1.Text = "";
                imionaUczen2.Text = "";
                dataUUczen.Text = "";
                peselUczen.Text = "";
                for (int i = 0; i < allLines.Length; i++)
                {
                    string currentLine = allLines[i];
                    imieUczen1.AppendText(currentLine + Environment.NewLine);
                    imieUczen2.AppendText(currentLine + Environment.NewLine);
                    nazwiskoUczen1.AppendText(currentLine + Environment.NewLine);
                    nazwiskoUczen2.AppendText(currentLine + Environment.NewLine);
                    imionaUczen1.AppendText(currentLine + Environment.NewLine);
                    imionaUczen2.AppendText(currentLine + Environment.NewLine);
                    peselUczen.AppendText(currentLine + Environment.NewLine);
                }
            }
        }
        private void zdjecieNauczyciel_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                string photoPath = System.IO.Path.GetFileName(op.FileName);
                zdjecieNauczyciel.Content = photoPath;
            }
        }
        private void submit_Click_Nauczyciel(object sender, RoutedEventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";

            if (theDialog.ShowDialog() == true)
            {
                File.AppendAllText(theDialog.FileName, "Imię: " + imieNauczyciel1.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Drugie Imię: " + imieNauczyciel2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Nazwisko: " + nazwiskoNauczyciel1.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Nazwisko panieńskie: " + nazwiskoNauczyciel2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Imiona rodziców: " + imionaNauczyciel1.Text + ", ");
                File.AppendAllText(theDialog.FileName, imionaNauczyciel2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Data urodzenia: " + dataUNauczyciel.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Pesel: " + peselNauczyciel.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Płeć: " + plecNauczyciel.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Wychowastwo: ");
                if (wychowastwoNauczyciel.IsChecked == true) { File.AppendAllText(theDialog.FileName, "TAK"); }
                else{ File.AppendAllText(theDialog.FileName, "NIE"); }
                File.AppendAllText(theDialog.FileName, Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Przedmioty nauczane: " + przedmiotyNauczyciel.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Klasy: " + klasyNauczyciel.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Data zatrudnienia: " + dataZNauczyciel.Text);
            }
        }
        private void input_Click_Nauczyciel(object sender, RoutedEventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == true)
            {
                string[] allLines = File.ReadAllLines(theDialog.FileName);
                imieNauczyciel1.Text = "";
                imieNauczyciel2.Text = "";
                nazwiskoNauczyciel1.Text = "";
                nazwiskoNauczyciel2.Text = "";
                imionaNauczyciel1.Text = "";
                imionaNauczyciel2.Text = "";
                dataUNauczyciel.Text = "";
                peselNauczyciel.Text = "";
                plecNauczyciel.Text = "";
                przedmiotyNauczyciel.Text = "";
                klasyNauczyciel.Text = "";
                for (int i = 0; i < allLines.Length; i++)
                {
                    string currentLine = allLines[i];
                    imieUczen1.AppendText(currentLine + Environment.NewLine);
                    imieNauczyciel1.AppendText(currentLine + Environment.NewLine);
                    imieNauczyciel2.AppendText(currentLine + Environment.NewLine);
                    nazwiskoNauczyciel1.AppendText(currentLine + Environment.NewLine);
                    nazwiskoNauczyciel2.AppendText(currentLine + Environment.NewLine);
                    imionaNauczyciel1.AppendText(currentLine + Environment.NewLine);
                    imionaNauczyciel2.AppendText(currentLine + Environment.NewLine);
                    peselNauczyciel.AppendText(currentLine + Environment.NewLine);
                    przedmiotyNauczyciel.AppendText(currentLine + Environment.NewLine);
                    klasyNauczyciel.AppendText(currentLine + Environment.NewLine);
                }
            }
        }
        private void zdjeciePracownik_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                string photoPath = System.IO.Path.GetFileName(op.FileName);
                zdjeciePracownik.Content = photoPath;
            }
        }
        private void submit_Click_Pracownik(object sender, RoutedEventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";

            if (theDialog.ShowDialog() == true)
            {
                File.AppendAllText(theDialog.FileName, "Imię: " + imiePracownik1.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Drugie Imię: " + imiePracownik2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Nazwisko: " + nazwiskoPracownik1.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Nazwisko panieńskie: " + nazwiskoPracownik2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Imiona rodziców: " + imionaPracownik1.Text + ", " + imionaPracownik2.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Data urodzenia: " + dataUPracownik.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Pesel: " + peselPracownik.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Płeć: " + plecPracownik.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Etat: " + etatPracownik.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Opis stanowiska: " + opisPracownik.Text + Environment.NewLine);
                File.AppendAllText(theDialog.FileName, "Data zatrudnienia: " + dataZPracownik.Text);
            }
        }
        private void input_Click_Pracownik(object sender, RoutedEventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == true)
            {
                string[] allLines = File.ReadAllLines(theDialog.FileName);
                imiePracownik1.Text = "";
                imiePracownik2.Text = "";
                nazwiskoPracownik1.Text = "";
                nazwiskoPracownik2.Text = "";
                imionaPracownik1.Text = "";
                imionaPracownik2.Text = "";
                dataUPracownik.Text = "";
                peselPracownik.Text = "";
                plecPracownik.Text = "";
                etatPracownik.Text = "";
                opisPracownik.Text = "";
                dataZPracownik.Text = "";
                for (int i = 0; i < allLines.Length; i++)
                {
                    string currentLine = allLines[i];
                    imieUczen1.AppendText(currentLine + Environment.NewLine);
                    imiePracownik1.AppendText(currentLine + Environment.NewLine);
                    imiePracownik2.AppendText(currentLine + Environment.NewLine);
                    nazwiskoPracownik1.AppendText(currentLine + Environment.NewLine);
                    nazwiskoPracownik2.AppendText(currentLine + Environment.NewLine);
                    imionaPracownik1.AppendText(currentLine + Environment.NewLine);
                    imionaPracownik2.AppendText(currentLine + Environment.NewLine);
                    peselPracownik.AppendText(currentLine + Environment.NewLine);
                    opisPracownik.AppendText(currentLine + Environment.NewLine);
                }
            }
        }
    }
}
