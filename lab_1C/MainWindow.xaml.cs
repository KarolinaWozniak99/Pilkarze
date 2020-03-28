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

namespace lab_1C
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            TextBoxWithErrorProvider.BrushForAll = Brushes.Green;
            InitializeComponent();
            
            
           
        }

        private bool IsNotEmpty(TextBoxWithErrorProvider tb)
        {
            if (tb.Text.Trim() == "")
            {
                tb.SetError("Pole nie może być puste!");
                return false;
            }
            tb.SetError("");
            return true;
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            if (IsNotEmpty(textBoxW) & IsNotEmpty(textBoxW1))
            {
                listBoxPilkarze.Items.Add(new Pilkarz("Robert","Lewandowski",30,80));
            }
            
        }
    }
}
