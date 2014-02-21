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

namespace Balls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Vector v = new Vector(3, 4);
            Vector u = new Vector(3, 4);
            Console.WriteLine(v + v);
            Console.WriteLine(2 * v);
            Console.WriteLine(v / 2);
            Console.WriteLine(v == u);
            
        }
    }
}
