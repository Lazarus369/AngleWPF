using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AngleWPF
{
    public class MaskedTextBox : TextBox
    {
        public TextBoxMask Mask { get; set; }

        public MaskedTextBox()
        {
            this.TextChanged += new TextChangedEventHandler(MaskedTextBox_TextChanged);
        }

        void MaskedTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.CaretIndex = this.Text.Length;

            var tbEntry = sender as MaskedTextBox;

            if (tbEntry != null && tbEntry.Text.Length > 0)
            {
                tbEntry.Text = formatNumber(tbEntry.Text, tbEntry.Mask);
            }
        }

        public static string formatNumber(string MaskedNum, TextBoxMask format)
        {
            int x;
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            if (MaskedNum != null)
            {
                for (int i = 0; i < MaskedNum.Length; i++)
                {
                    if (int.TryParse(MaskedNum.Substring(i, 1), out x))
                    {
                        sb.Append(x.ToString());
                    }
                }
                switch (format)
                {
                    case TextBoxMask.HourHHmm:
                        return FormatForHourHHmm(sb.ToString()).ToString();                   

                    default:
                        break;
                }

            }
            return sb.ToString();
        }

        public enum TextBoxMask
        {
            HourHHmm            
        }

        public static StringBuilder FormatForHourHHmm(string sb)
        {
            StringBuilder sb2 = new StringBuilder();            

            if (sb.Length > 0) sb2.Append(sb.Substring(0, 1));
            if (sb.Length > 1) sb2.Append(sb.Substring(1, 1));            

            if (sb.Length > 2) sb2.Append(":");

            if (sb.Length > 2) sb2.Append(sb.Substring(2, 1));
            if (sb.Length > 3) sb2.Append(sb.Substring(3, 1));            

            return sb2;
        }
    }

}
