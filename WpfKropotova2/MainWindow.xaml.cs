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
using WpfKropotova2.Model;

namespace WpfKropotova2
{
    public partial class MainWindow : Window
    {
        public IEnumerable<Sweet> SweetList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            SweetList = Globals.dataProvider.GetSweets();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}
