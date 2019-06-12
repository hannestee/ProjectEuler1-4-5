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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

            int num1 = 300000000;
            int divisibleCounter = 0;
            int smallestNumber = 0;

            for (int i = 1; i < num1; i++)
            {
                //Debug.WriteLine(i + " testing");
                for (int y= 1; y <= 20; y++)
                {
                    //Debug.WriteLine(y + " testing divisable by");
                    if (i % y == 0)
                    {
                        divisibleCounter += 1;
                        //Debug.WriteLine(i + " is divisible");
                    }
                }
                if (divisibleCounter == 20)
                {
                    Debug.WriteLine(i);
                    smallestNumber = i;
                    divisibleCounter = 0;
                } else
                {
                    divisibleCounter = 0;
                }
            }
            this.displayText.Text += "Answer is: " + smallestNumber;
        }
    }
}
