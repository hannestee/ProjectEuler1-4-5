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
using System.Diagnostics;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

            int maxNum = 999;
            string num;
            List<int> numberList = new List<int>();
            int numAcceptable;
            int highestEntry;


            for (int i = 0; i < maxNum; i++)
            {
                for (int y = 0; y < maxNum; y++)
                {
                    num = (y * i).ToString();
                    //Debug.WriteLine(num);
                    //Debug.WriteLine(Reverse(num));

                    if (num == Reverse(num) && num != "0")
                    {
                        numAcceptable = Convert.ToInt32(num);
                        numberList.Add(numAcceptable);
                        Debug.WriteLine(numAcceptable);
                    }
                } 
            }
            highestEntry = numberList.Max();

            Debug.WriteLine(highestEntry);
            this.displayText.Text += "Answer is: " + highestEntry;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
