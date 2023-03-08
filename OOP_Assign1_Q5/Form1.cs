using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Assign1_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputbox1.Text = "";
            inputbox2.Text = "";
            inputbox3.Text = "";
            inputbox4.Text = "";
            inputbox5.Text = "";
            inputbox6.Text = "";
            inputbox7.Text = "";
            inputbox8.Text = "";
            inputbox9.Text = "";
            totalBoxesWithNo.Text = Convert.ToString(0);
            sumofBoxes.Text = "?";
            avgofBoxes.Text = "?";
            maxofBoxes.Text = "?";
            minofBoxes.Text = "?";
            


        }



        public float Sum()
        {
            float total;

            total = float.Parse(inputbox1.Text) + float.Parse(inputbox2.Text) + float.Parse(inputbox3.Text) + float.Parse(inputbox4.Text) + float.Parse(inputbox5.Text) + float.Parse(inputbox6.Text) + float.Parse(inputbox7.Text) + float.Parse(inputbox8.Text) + float.Parse(inputbox9.Text);
            return total;
        }
        public float Avg()
        {

            float avg;
            avg = (float.Parse(inputbox1.Text) + float.Parse(inputbox2.Text) + float.Parse(inputbox3.Text) + float.Parse(inputbox4.Text) + float.Parse(inputbox5.Text) + float.Parse(inputbox6.Text) + float.Parse(inputbox7.Text) + float.Parse(inputbox8.Text) + float.Parse(inputbox9.Text)) / 9;
            return avg;

        }

        public int totalBox()
        {
            int no=0;
            

            if(inputbox1.Text != null)
                no++;
            if (inputbox2.Text != null)
                no++;
            if (inputbox3.Text != null)
                no++;
            if (inputbox4.Text != null)
                no++;
            if (inputbox5.Text != null)
                no++;
            if (inputbox6.Text != null)
                no++;
            if (inputbox7.Text != null)
                no++;
            if (inputbox8.Text != null)
                no++;
            if (inputbox9.Text != null)
                no++;
            return no;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                sumofBoxes.Text = Convert.ToString(Sum());
                avgofBoxes.Text = Convert.ToString(Avg());

                float n1, n2, n3, n4, n5, n6, n7, n8, n9, max, min;
                n1 = float.Parse(inputbox1.Text);
                n2 = float.Parse(inputbox2.Text);
                n3 = float.Parse(inputbox3.Text);
                n4 = float.Parse(inputbox4.Text);
                n5 = float.Parse(inputbox5.Text);
                n6 = float.Parse(inputbox6.Text);
                n7 = float.Parse(inputbox7.Text);
                n8 = float.Parse(inputbox8.Text);
                n9 = float.Parse(inputbox9.Text);

                max = n1;
                min = n1;

                if (n2 < min)
                    min = n2;
                if (n2 > max)
                    max = n2;

                if (n3 < min)
                    min = n3;
                if (n3 > max)
                    max = n3;

                if (n4 < min)
                    min = n4;
                if (n4 > max)
                    max = n4;

                if (n5 < min)
                    min = n5;
                if (n5 > max)
                    max = n5;

                if (n6 < min)
                    min = n6;
                if (n6 > max)
                    max = n6;

                if (n7 < min)
                    min = n7;
                if (n7 > max)
                    max = n7;

                if (n8 < min)
                    min = n8;
                if (n8 > max)
                    max = n8;

                if (n9 < min)
                    min = n9;
                if (n9 > max)
                    max = n9;

                maxofBoxes.Text = max.ToString();
                minofBoxes.Text = min.ToString();

                totalBoxesWithNo.Text = Convert.ToString(totalBox());
            

           


        }
    }
}
