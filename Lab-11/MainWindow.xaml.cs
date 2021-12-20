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
using System.Text.RegularExpressions;

namespace Lab_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rez_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            Regex regex = new Regex("a(b{1,3})a");
            string line = "aa, aba, abba, abbba, abea, abca";
            theLine.Text = line;
            MatchCollection matchCollection = regex.Matches(line);
            object[] array = new object[matchCollection.Count];
            matchCollection.CopyTo(array, 0);
            for (int i = 0; i < matchCollection.Count; i++)
            {
                listBox.Items.Add(matchCollection[i]);
            }
        }

        private void Exite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана строка 'aa aba abba abbba abca abea'. " +
                "Напишите регулярное выражение,которое найдет строки aba, abba, abbba. ");
        }
    }
}
