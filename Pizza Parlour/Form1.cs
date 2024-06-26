﻿using System;
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
                this.Size = new Size(512, 415);
                novelLabel2.Visible = false;
                graphicLabel2.Visible = false;
                toyLabel2.Visible = false;
                gameLabel2.Visible = false;
                subtotalLabel2.Visible = false;
                taxLabel2.Visible = false;
                totalLabel2.Visible = false;
                tenderedLabel2.Visible = false;
                changeLabel2.Visible = false;
                thankYou.Visible = false;
                novelOutput.Visible = false;
                graphicOutput.Visible = false;
                toyOutput.Visible = false;
                gameOutput.Visible = false;
                subtotalOutput2.Visible = false;
                taxOutput2.Visible = false;
                totalOutput2.Visible = false;
                tenderedOutput.Visible = false;
                totalOutput2.Visible = false;
                changeOutput2.Visible = false;
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
                Refresh();
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
            this.Size = new Size(840, 415);
            player.URL = @"C:\Users\KNS\Downloads\Wooden Long Sliding Door (Sound Effect) #shorts.mp3";
            player.controls.play();

            label6.Size = new Size(292, 78);
            novelLabel2.Visible = true;
            novelOutput.Visible = true;
            novelOutput.Text = $"{novelTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 102);
            graphicLabel2.Visible = true;
            graphicOutput.Visible = true;
            graphicOutput.Text = $"{graphicTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 133);
            toyOutput.Visible = true;
            toyLabel2.Visible = true;
            toyOutput.Text = $"{toyTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 166);
            gameOutput.Visible = true;
            gameLabel2.Visible = true;
            gameOutput.Text = $"{gameTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 196);
            subtotalOutput2.Visible = true;
            subtotalLabel2.Visible = true;
            subtotalOutput2.Text = $"{subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 229);
            taxOutput2.Visible = true;
            taxLabel2.Visible = true;
            taxOutput2.Text = $"{tax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 260);
            totalOutput2.Visible = true;
            totalLabel2.Visible = true;
            totalOutput2.Text = $"{total.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 289);
            tenderedOutput.Visible = true;
            tenderedLabel2.Visible = true;
            tenderedOutput.Text = $"{tenderedAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            label6.Size = new Size(292, 333);
            changeOutput2.Visible = true;
            changeLabel2.Visible = true;
            changeOutput2.Text = $"{changeAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            thankYou.Visible = true;
            newOrderButton.Enabled = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            novel = 0;
            graphic = 0;
            toy = 0;
            game = 0;
            novelTotal = 0;
            graphicTotal = 0;
            toyTotal = 0;
            gameTotal = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
            tenderedAmount = 0;
            changeAmount = 0;
            this.Size = new Size(512, 415);
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            TenderedInput.Text = "";
            changeOutput.Text = "";
            novelInput.Text = "";
            toyInput.Text = "";
            graphicInput.Text = "";
            gamesInput.Text = "";
        }
    }
}
