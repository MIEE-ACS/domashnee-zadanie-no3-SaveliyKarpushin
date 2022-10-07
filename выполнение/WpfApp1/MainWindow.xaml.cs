using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
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

        private void GL_Click(object sender, RoutedEventArgs e)
        {
            string A = TX.Text;
            int n = Regex.Matches(A, @"[УуЕеыАаОоЭэЯяИиЁёЮю]", RegexOptions.IgnoreCase).Count;
            VV.Text = n.ToString();
        }

        private void SG_Click(object sender, RoutedEventArgs e)
        {
            string A = TX.Text;
            int n = Regex.Matches(A, @"[ЦцКкНнГгШшЩщЗзХхФфВвПпРрЛлДдЖжЧчСсМмТтБб]", RegexOptions.IgnoreCase).Count;
            VV.Text = n.ToString();
        }

        private void TX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
