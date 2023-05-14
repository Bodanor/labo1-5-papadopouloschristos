using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Xceed.Wpf.Toolkit;

namespace SettingsForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void notify(object sender, OptionEventArgs e);
        public event notify SettingCompleted;

        private bool CanClose { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            CanClose = true;
        }

        public void CloseWindow()
        {
            CanClose = false;
            Close();
        }

        private void OnSettingChange(object sender, OptionEventArgs e)
        {
            SettingCompleted(this, e);
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if (SettingEvent())
            {
                Hide();
            }
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void BtnAppliquer_Click(object sender, RoutedEventArgs e)
        {
            SettingEvent();
        }

        private bool SettingEvent()
        {
            try
            {
                if (SettingCompleted != null)
                {
                    OnSettingChange(this, new OptionEventArgs(int.Parse(TextBoxTailleTexte.Text), ColorPickerCouleurBackground.SelectedColor.Value));
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Veuillez saisir une taille et une couleur correctes !");
            }
            return false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = CanClose;
            base.OnClosing(e);
            Hide();
        }
    }
}
