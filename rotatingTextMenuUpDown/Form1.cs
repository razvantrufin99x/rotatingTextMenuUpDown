using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rotatingTextMenuUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> words = new List<string>();
        public int current = 4;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadvaluesintolist();

            loadvaluesintolabels();

            
        }

        public void loadvaluesintolist()
        {
           
           
            words.Add("ianuarie");
            words.Add("februarie");
            words.Add("martie");
            words.Add("aprilie");

            words.Add("mai");
            words.Add("iunie");
            words.Add("iulie");
            words.Add("august");


            words.Add("septembrie");
            words.Add("octombrie");
            words.Add("noiembrie");
            words.Add("decembrie");

           
            
        }
        public void loadvaluesintolabels()
        {
            label1.Text = this.words[0];
            label2.Text = this.words[1];
            label3.Text = this.words[2];
            label4.Text = this.words[3];
            label5.Text = this.words[4];
            label6.Text = this.words[5];
            label7.Text = this.words[6];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gotoup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gotodown();
        }

        public void gotoup()
        {

           
                
                shiftToRight();
                label1.Text = this.words[current - 3];
                label2.Text = this.words[current - 2];
                label3.Text = this.words[current - 1];
                label4.Text = this.words[current];
                label5.Text = this.words[current + 1];
                label6.Text = this.words[current + 2];
                label7.Text = this.words[current + 3];
            
                   
          

        }
        public void gotodown()
        {

            
                shiftToLeft();
                label1.Text = this.words[current - 3];
                label2.Text = this.words[current - 2];
                label3.Text = this.words[current - 1];
                label4.Text = this.words[current];
                label5.Text = this.words[current + 1];
                label6.Text = this.words[current + 2];
                label7.Text = this.words[current + 3];
           
        

        
        }

        public void swap( string a,  string b)
        {
            string aux;
            aux = a;
            a = b;
            b = a;
        }

        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }

        public void shiftToRight()
        {
            string a;
            string b;
          

            for (int i = 0; i < words.Count - 1; i++)
            {
                
                
                a = words[i];
                
                b = words[i+1];

                Swap(ref a, ref b);
                words[i] = a;
                words[i+1] = b;
            }

        }

        public void shiftToLeft()
        {
            string a;
            string b;
         

            for (int i =  words.Count - 1; i >0; i--)
            {
               

                a = words[i];

                b = words[i - 1];

                Swap(ref a, ref b);
                words[i] = a;
                words[i - 1] = b;
            }

           

           
                
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'W' || e.KeyChar == 'w')
            {
                gotoup();
            }
            if (e.KeyChar == 's' || e.KeyChar == 's')
            {
                gotodown();
            }
        }

        public void printList()
        {
            for (int i = 0; i < words.Count; i++)
            {
                textBox1.Text += " \r\n" +  words[i].ToString();
            }
        }
        public void clearTextBox()
        {
            textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clearTextBox();
            shiftToLeft();
            printList();
        }   

        private void button4_Click(object sender, EventArgs e)
        {
            clearTextBox(); 
            shiftToRight();
            printList();
         
        }


    }
}
