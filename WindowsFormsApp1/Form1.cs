using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            


            textBox2.Text = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (comboBox2.GetItemText(comboBox2.SelectedItem) == "из 10")
            {
                s = "dec";
                

            }
            if (comboBox2.GetItemText(comboBox2.SelectedItem) == "из 16")
            {
                s = "hex";
                
            }
            textBox2.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "в 10")
            {
                textBox2.Text = toDec(textBox1.Text).ToString();

            }
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "в 16")
            {
                textBox2.Text = toHex(int.Parse(textBox1.Text));
            }
           
            
        }
        private string toHex(int dec) 
        {
            string hex = "";
            while (dec != 0)
            {
                int g = dec % 16;
                switch (g)
                {
                    case 0:
                        hex += "0";
                        break;
                    case 1: hex += "1"; 
                        break;
                    case 2:
                        hex += "2";
                        break;
                    case 3:
                        hex += "3";
                        break;
                    case 4:
                        hex += "4";
                        break;
                    case 5:
                        hex += "5";
                        break;
                    case 6:
                        hex += "6";
                        break;
                    case 7:
                        hex += "7";
                        break;
                    case 8:
                        hex += "8";
                        break;
                    case 9:
                        hex += "9";
                        break;
                    case 10:
                        hex += "A";
                        break;
                    case 11:
                        hex += "B";
                        break;
                    case 12:
                        hex += "C";
                        break;
                    case 13:
                        hex += "D";
                        break;
                    case 14:
                        hex += "E";
                        break;
                    case 15:
                        hex += "F";
                        break;
                }

                dec = dec / 16;
            }
            
            return reverse(hex);
        }
        private int toDec(String hex)
        {
            
            hex = reverse(hex);
            char[] hx = hex.ToCharArray();
            int outdec = 0;
            int dec = 0;
            for (int i = 0;i < hex.Length; i++)
            {
                
                switch (hx[i])
                {
                    case '0':
                        dec = 0;
                        break;
                    case '1':
                        dec = 1;
                        break;
                    case '2':
                        dec = 2;
                        break;
                    case '3':
                        dec = 3;
                        break;
                    case '4':
                        dec = 4;
                        break;
                    case '5':
                        dec = 5;
                        break;
                    case '6':
                        dec = 6;
                        break;
                    case '7':
                        dec = 7;
                        break;
                    case '8':
                        dec = 8;
                        break;
                    case '9':
                        dec = 9;
                        break;
                    case 'A':
                        dec = 10;
                        break;
                    case 'B':
                        dec = 11;
                        break;
                    case 'C':
                        dec = 12;
                        break;
                    case 'D':
                        dec = 13;
                        break;
                    case 'E':
                        dec = 14;
                        break;
                    case 'F':
                        dec = 15;
                        break;
                }

                outdec += (int)(dec *  Math.Pow(16,i));
                Console.WriteLine(dec * Math.Pow(16, i));
            }

            return outdec;
        }
        string reverse(string s)
        {
            
            char[] newstring = new char[s.Length];

            for (int i = 0; i<s.Length ;i++)
            {
                newstring[i] = s[s.Length - i - 1];
                Console.WriteLine(i);
            }
        
            return new string(newstring);
        }




    }
}
