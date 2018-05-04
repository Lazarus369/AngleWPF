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
using System.Windows.Shapes;

namespace SPCGeneratorS
{
    /// <summary>
    /// Logika interakcji dla klasy CustomMsgBox.xaml
    /// </summary>
    public partial class CustomMsgBox : Window
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }        

        public string Message
        {
            get { return textBlock1.Text; }
            set { textBlock1.Text = value; }
        }

        internal static void Show(string messageText)
        {
            CustomMsgBox customMsg = new CustomMsgBox()
            {
                Message = messageText
            };
            customMsg.ShowDialog();
            customMsg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }      
                
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
