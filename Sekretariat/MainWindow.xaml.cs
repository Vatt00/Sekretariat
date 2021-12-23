
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
                File.AppendAllText(theDialog.FileName, imieUczen1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, imieUczen2.Text);
                File.AppendAllText(theDialog.FileName, Environment.NewLine);
                File.AppendAllText(theDialog.FileName, nazwiskoUczen1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, nazwiskoUczen2.Text);
                File.AppendAllText(theDialog.FileName, Environment.NewLine);
                File.AppendAllText(theDialog.FileName, imionaUczen1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, imionaUczen2.Text);
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
                File.AppendAllText(theDialog.FileName, imieNauczyciel1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, imieNauczyciel2.Text);
                File.AppendAllText(theDialog.FileName, Environment.NewLine);
                File.AppendAllText(theDialog.FileName, nazwiskoNauczyciel1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, nazwiskoNauczyciel2.Text);
                File.AppendAllText(theDialog.FileName, Environment.NewLine);
                File.AppendAllText(theDialog.FileName, imionaNauczyciel1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, imionaNauczyciel2.Text);
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
                File.AppendAllText(theDialog.FileName, imiePracownik1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, imiePracownik2.Text);
                File.AppendAllText(theDialog.FileName, Environment.NewLine);
                File.AppendAllText(theDialog.FileName, nazwiskoPracownik1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, nazwiskoPracownik2.Text);
                File.AppendAllText(theDialog.FileName, Environment.NewLine);
                File.AppendAllText(theDialog.FileName, imionaPracownik1.Text);
                File.AppendAllText(theDialog.FileName, " ");
                File.AppendAllText(theDialog.FileName, imionaPracownik2.Text);
            }
        }
    }
}
