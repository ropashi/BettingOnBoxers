using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOXBET
{
    public partial class Form1 : Form
    {
        

        Boxer adam=new Boxer();
        Boxer bela=new Boxer();
        int bet1=0,bet2=0;
        int sieger = 0;
        int money =400;
        

        List<string> history=new List<string>(30); int historyCount=0;

        public Form1()
        {
            InitializeComponent();


        }

        private void startBTN_Click(object sender , EventArgs e)
        {
            leftboxer.BackColor = Color.FromArgb(0255 , 0255 , 0255);
            rightboxer.BackColor = Color.FromArgb(0255 , 0255 , 0255);
            Random rnd = new Random();
            adam = new Boxer(rnd.Next() , "ADAM");
            bela = new Boxer(rnd.Next() , "BELA");
            tenon1.Visible = true;
            tenon2.Visible = true;
            hundredon1.Visible = true;
            hundredon2.Visible = true;
            fightBTN.Visible = true;
            bet1 = bet2 = 0;
            
            startBTN.Visible = false;
            Speak("2 new fighters are ready!");

        }

        private void fightBTN_Click(object sender , EventArgs e)
        {
            fightBTN.Visible = false;
            ;
            tenon1.Visible = false;
            tenon2.Visible = false;
            hundredon1.Visible = false;
            hundredon2.Visible = false;
            sieger = 0;
            Random rnd = new Random();
            Speak("The Fight starts");
            System.Threading.Thread.Sleep(1500);
            
            while (sieger == 0)
            {
                int p = rnd.Next() % 50;
                bela.GetsPunched(adam.Punches(p));
                Speak( "Adam punches (" + adam.Punches(p)+ " )");
                System.Threading.Thread.Sleep(1500);
                if (bela.GetHP() <= 0)
                {
                    rightboxer.BackColor = Color.FromArgb(255 , 232 , 232);
                    sieger = 1;
                    money += bet1*2;
                    Speak( "Bela goes down ! K.O.");
                    System.Threading.Thread.Sleep(1500);
                    break;
                }
                p = rnd.Next() % 50;
                adam.GetsPunched(bela.Punches(p));
                Speak("Bela punches (" + bela.Punches(p) + " )");
                System.Threading.Thread.Sleep(1000);
                if (adam.GetHP() <= 0)
                {
                    leftboxer.BackColor = Color.FromArgb(255 , 232 , 232);
                    sieger = 2;
                    money += bet2*2;
                    ausgabe.Text = "Adam goes down ! K.O.";
                    System.Threading.Thread.Sleep(1000);
                 
                    break;
                }
               
            }
            startBTN.Visible = true;
            Speak("The fight is over.");
            if (money<=0)
            {
                MessageBox.Show("You cant pay your debts. No more gambling for you!");
                Application.Exit();
            }
        }

        private void ausgabe_TextChanged(object sender , EventArgs e)
        {
            
           




        }
        private void Speak(string s)
        {
            moneylbl.Text = money + " $";
              
            ausgabe.Text = s;

            leftboxer.Text = adam.ToString();       
            rightboxer.Text = bela.ToString();
          
            hpLeft.Value =(int)((double)adam.GetHP() * 1000.0 / (double)adam.GetMaxHP()/10.0);
            hpRight.Value = bela.GetHP() * 10000 / bela.GetMaxHP()/100;

            string hold = "";
            foreach (var item in history)
            {

                hold += item + "\n";
            }
            
            verlauf.Text = hold; //
            
            history.Add(ausgabe.Text);
            historyCount++;
            if (historyCount > 16)
            {
                history.RemoveAt(0);
            }
            moneylbl.Refresh();
            ausgabe.Refresh();
            leftboxer.Refresh();
            rightboxer.Refresh();
            hpLeft.Refresh();
            hpRight.Refresh();
            verlauf.Refresh();
        }

        private void tenon1_Click(object sender , EventArgs e)
        {
            bet1 += 10;
            money -= 10;
            Speak("10 auf Adam");
        }

        private void hundredon1_Click(object sender , EventArgs e)
        {
            bet1 += 100;
            money -= 100;
            Speak("100 auf Adam");
        }

        private void hundredon2_Click(object sender , EventArgs e)
        {
            bet2 += 100;
            money -= 100;
            Speak("100 auf Bela");
        }

        private void tenon2_Click(object sender , EventArgs e)
        {
            bet2 += 10;
            money -= 10;
            Speak("10 auf Bela");
        }
    }
}
