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
                storeLabel.Visible = false;
                novelLabel2.Visible = false;
                graphicLabel2.Visible = false;
                toyLabel2.Visible = false;
                gameLabel2.Visible = false;
                subtotalLabel2.Visible = false;
                taxLabel2.Visible = false;
                totalLabel2.Visible = false;
                tenderedLabel2.Visible = false;
                totalLabel2.Visible = false;
                changeLabel2.Visible = false;
                thnakYou.Visible = false;
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

            storeLabel.Visible = true;
            novelOutput.Text = $"{novelTotal.ToString("C")}";
            Thread.Sleep(1000);
            novelLabel2.Visible = true;
            novelOutput.Text = $"{novelTotal.ToString("C")}";
            Thread.Sleep(1000);
            graphicLabel2.Visible = true;
            graphicOutput.Text = $"{graphicTotal.ToString("C")}";
            Thread.Sleep(1000);
            toyLabel2.Visible = true;
            toyOutput.Text = $"{toyTotal.ToString("C")}";
            Thread.Sleep(1000);
            gameLabel2.Visible = true;
            gameOutput.Text = $"{gameTotal.ToString("C")}";
            Thread.Sleep(1000);
            subtotalLabel2.Visible = true;
            subtotalOutput2.Text = $"{subtotal.ToString("C")}";
            Thread.Sleep(1000);
            taxLabel2.Visible = true;
            taxOutput2.Text = $"{tax.ToString("C")}";
            Thread.Sleep(1000);
            totalLabel2.Visible = true;
            totalOutput2.Text = $"{total.ToString("C")}";
            Thread.Sleep(1000);
            tenderedLabel2.Visible = true;
            tenderedOutput.Text = $"{tenderedAmount.ToString("C")}";
            Thread.Sleep(1000);
            totalLabel2.Visible = true;
            totalOutput.Text = $"{total.ToString("C")}";
            Thread.Sleep(1000);
            changeLabel2.Visible = true;
            changeOutput2.Text = $"{changeAmount.ToString("C")}";
            Thread.Sleep(1000);
            thnakYou.Visible = true;
        }
    }
}
