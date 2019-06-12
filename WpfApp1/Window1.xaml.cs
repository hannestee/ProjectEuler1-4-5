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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //If we list all the natural numbers 
        //below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        //The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.

        int num2 = 3;
        int num3 = 5;
        List<int> listOfMultiples = new List<int>();

        int numTotal = 0;
        int maxNum = 1000;

        public Window1()
        {
            InitializeComponent();

            for (int i = 1; i < maxNum; i++)
            {
                if (i % num2 == 0 || i % num3 == 0)
                {
                    //Debug.WriteLine(i, "accepted");
                    listOfMultiples.Add(i);

                } else
                {
                    //Debug.WriteLine(i, "deny");
                }
            }

            for (int i = 0; i < listOfMultiples.Count; i++)
            {
                Debug.WriteLine(listOfMultiples[i]);
                numTotal += listOfMultiples[i]; 
            }

            Debug.WriteLine(numTotal);
            //Debug.WriteLine(listOfMultiples[0]);
            this.displayText.Text += "Answer is: " + numTotal;
        }
    }
}
