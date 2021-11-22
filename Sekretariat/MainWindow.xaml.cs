
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.AppendAllText(theDialog.FileName, imie1.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, imie2.Text);
                    File.AppendAllText(theDialog.FileName, Environment.NewLine);
                    File.AppendAllText(theDialog.FileName, nazwisko1.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, nazwisko2.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, imiona1.Text);
                    File.AppendAllText(theDialog.FileName, " ");
                    File.AppendAllText(theDialog.FileName, imiona2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file. Original error: " + ex.Message);
                }
            }
        }
    }
}
