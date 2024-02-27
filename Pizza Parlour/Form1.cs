using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Media;

namespace Pizza_Parlour
{
    public partial class form : System.Windows.Forms.Form
    {
        int novel = 0;
        int graphic = 0;
        int toy = 0;
        int game = 0;
        double novelPrice = 1.65;
        double graphicPrice = 3.45;
        double toyPrice = 4.36;
        double gamePrice = 7.50;
        double novelTotal;
        double graphicTotal;
        double toyTotal;
        double gameTotal;
        double subtotal;
        double tax;
        double taxamount = 0.13;
        double total;
        double tenderedAmount;
        double changeAmount;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public form()
        {
            InitializeComponent();
            this.Size = new Size(512, 415);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                novel = Convert.ToInt32(novelInput.Text);
                graphic = Convert.ToInt32(graphicInput.Text);
                toy = Convert.ToInt32(toyInput.Text);
                game = Convert.ToInt32(gamesInput.Text);
                novelTotal = novel * novelPrice;
                graphicTotal = graphic * graphicPrice;
                toyTotal = toy * toyPrice;
                gameTotal = game * gamePrice;
                subtotal = novelTotal + graphicTotal + toyTotal + gameTotal;
                tax = subtotal * taxamount;
                total = subtotal + tax;

                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{tax.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
                changeButton.Enabled = true;
            }
            catch
            {
                subtotalOutput.Text = "Input";
                taxOutput.Text = "Error";
                totalOutput.Text = "Bozo";
                player.URL = @"C:\Users\KNS\Downloads\Error - Sound Effects (No Copyright).mp3";
                player.controls.play();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                player.URL = @"C:\Users\KNS\Downloads\cha ching-sound effect (download).mp3";
                player.controls.play();
                tenderedAmount = Convert.ToDouble(TenderedInput.Text);
                changeAmount = tenderedAmount - total;
                changeOutput.Text = $"{changeAmount.ToString("C")}";
                printButton.Enabled = true;
            }
            catch
            {
                TenderedInput.Text = "NO. PUT IN NUMBER!";
                player.URL = @"C:\Users\KNS\Downloads\Error - Sound Effects (No Copyright).mp3";
                player.controls.play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(810, 415);
            player.URL = @"C:\Users\KNS\Downloads\Wooden Long Sliding Door (Sound Effect) #shorts.mp3";
            player.controls.play();

            novelOutput.Text = $"{novelTotal.ToString("C")}";
            graphicOutput.Text = $"{graphicTotal.ToString("C")}";
            toyOutput.Text = $"{toyTotal.ToString("C")}";
            gameOutput.Text = $"{gameTotal.ToString("C")}";

            subtotalOutput2.Text = $"{subtotal.ToString("C")}";
            taxOutput2.Text = $"{tax.ToString("C")}";
            totalOutput2.Text = $"{total.ToString("C")}";
            tenderedOutput.Text = $"{tenderedAmount.ToString("C")}";
            totalOutput.Text = $"{total.ToString("C")}";
            changeOutput2.Text = $"{changeAmount.ToString("C")}";
        }
    }
}
