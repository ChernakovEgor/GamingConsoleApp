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
using System.IO;


namespace GamingConsoleApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class GamingConsolesWindow : Window
    {
        const string FileName = "developers.txt";
        List<Developer> _developers = new List<Developer>();
        public GamingConsolesWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new NewConsoleWindow(_developers);
        }

        

        private void LoadData()
        {
            try
            {
                _developers = new List<Developer>();

                using (var sr = new StreamReader(FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var parts = line.Split(':');
                        if (parts.Length == 3)
                        {

                            int i = 0;
                            while (i < _developers.Count && _developers[i].Name != parts[0])
                                i++;
                            Developer d;
                            if (i < _developers.Count)
                                d = _developers[i];
                            else
                            {
                                d = new Developer(parts[0], parts[1], parts[2]);
                                _developers.Add(d);
                            }                            
                        }
                    }


                }
            }
            catch (FileNotFoundException)
            {
                _developers.Add(new Developer("Sony", "Japan", "10 6 2016"));
            }
            catch
            {
                MessageBox.Show("Ошибка чтения из файла");
            }
           
        }
    
    }
}
