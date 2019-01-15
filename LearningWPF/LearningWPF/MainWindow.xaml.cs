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
        public MainWindow() {
            InitializeComponent();
        }

        /// <summary>
        /// This gets a file
        /// </summary>
        private void BtnGetFile_Click(object sender, RoutedEventArgs e) {
            try {
                MessageBox.Show("Trying file");
string[] lines       =         File.ReadAllLines("../../data/greeneggs.txt");
                for (int i = 0; i < lines.Length; i++) {
                    lbLines.Items.Add(lines[i]);
                }
                MessageBox.Show("Got file!");
            }catch(Exception ex) {
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
    }
}
