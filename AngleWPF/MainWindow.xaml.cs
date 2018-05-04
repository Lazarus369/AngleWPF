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
using AngleWinForms;
using SPCGeneratorS;

namespace AngleWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime time = DateTime.Parse(textBox1.Text);

                String.Format("{0:HH:mm}", time);

                int angle = Utilities.GetAngle(Utilities.HoursToZeroAngle(time.Hour), Utilities.MinutesToZeroAngle(time.Minute));
                label1.Content = $"{angle.ToString()}° / {(360 - angle).ToString()}°";
            }
            catch
            {
                label1.Content = "";
                CustomMsgBox.Show("Wprowdź prawidłową godzinę");
            }
        }
    }
}
