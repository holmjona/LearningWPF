using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningWPF {
    /// <summary>
    /// Jon Holmes
    /// CS/INFO 1182 
    /// 15 Jan 2019
    ///  What it does or is for.
    /// </summary>
    public partial class MainWindow : Window {
        private int _ButtonID = 0;
        public MainWindow() {
            InitializeComponent();
        }

        /// <summary>
        /// This gets a file
        /// </summary>
        private void BtnGetFile_Click(object sender, RoutedEventArgs e) {
            try {
                MessageBox.Show("Trying file");
                string[] lines = File.ReadAllLines("../../data/greeneggs.txt");
                for (int i = 0; i < lines.Length; i++) {
                    lbLines.Items.Add(lines[i]);
                }
                MessageBox.Show("Got file!");
            } catch (Exception ex) {
                MessageBox.Show("Oops: " + ex.Message);

            } finally {
                //MessageBox.Show("always runs");

            }
            //addStuff(1,2);


        }

        /// <summary>
        /// I have no idea.
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns></returns>
        private int addStuff(int x, double y) {
            int b = 5;
            return b + x - (int)y;
        }

        private int addStuff(int x) {
            
            return x;
        }

        private void BtnAqua_Click(object sender, RoutedEventArgs e) {
            double dbl = 3;
            int iii = (int)'1';
            //MessageBox.Show(iii.ToString());
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);


        }

        private void BtnRed_Click(object sender, RoutedEventArgs e) {
            object thingIFound = this.FindName("btnaq");
            Button bbbb = (Button)thingIFound;
            if (bbbb == null) {
                MessageBox.Show("oopsy!");

            } else
                MessageBox.Show(bbbb.Name);

        }

        private void BtnPurple_Click(object sender, RoutedEventArgs e) {
            Button btn = (Button)sender;

            btn.Visibility = Visibility.Collapsed;

        }

        private void BtnGreen_Click(object sender, RoutedEventArgs e) {
            Button btn = (Button)sender;
            if (btn.Visibility == Visibility.Visible)
                btn.Visibility = Visibility.Hidden;
            else
                btn.Visibility = Visibility.Visible;

        }

        private void Btn4552345436_Click(object sender, RoutedEventArgs e) {
            //object thingIFound = this.FindName("btnPurple");
            //Button btnP = (Button)thingIFound;
            //btnP.Visibility = Visibility.Visible;

            Button btn = new Button();
            stkButtons.Children.Add(btn);
            btn.Content = "Hello!";
            btn.Name = "ButtonOfAwesomeness" + _ButtonID;
            _ButtonID++;
            btn.Click += BtnAqua_Click;
        }

        private void BtnIAm_Click(object sender, RoutedEventArgs e) {
            this.Background = new SolidColorBrush(Colors.RosyBrown);
        }
    }
}
