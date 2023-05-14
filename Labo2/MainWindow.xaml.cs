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
using SettingsForm;
namespace Labo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SettingsForm.MainWindow SettingsForm = new();
        public MainWindow()
        {
            InitializeComponent();
            SettingsForm.SettingCompleted += SettingsForm_SettingsCompleted;
        }

        private void SettingsForm_SettingsCompleted(object sender, OptionEventArgs e)
        {
            if (sender is SettingsForm.MainWindow)
            {
                Background = new SolidColorBrush(e.Couleur);
                FontSize = e.Taille;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SettingsForm.Show();
            SettingsForm.Focus();
            SettingsForm.Activate();
        }
    }
}
