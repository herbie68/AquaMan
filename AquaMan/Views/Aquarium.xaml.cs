using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AquaMan.Views
{
    /// <summary>
    /// Interaction logic for Aquarium.xaml
    /// </summary>
    public partial class Aquarium : Page
    {
        public Aquarium()
        {
            InitializeComponent();
            AquariumType.Items.Add("Rechthoek");
            AquariumType.Items.Add("Vierkant");
            AquariumType.Items.Add("Hoek");
            AquariumType.Items.Add("Cilinder");
        }
    }
}
