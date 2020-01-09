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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaiThiWindows1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnKetThuc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnTinh_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)radioChia.IsChecked)
                RadioChia();
            else
                   if ((bool)radioDu.IsChecked)
                RadioDu();
            else
                       if ((bool)radioMu.IsChecked)
                RadioMu();
            else
                           if ((bool)radioCongChuoi.IsChecked)
                RadioCongChuoi();
        }

        private void RadioChia()
        {
            float a = float.Parse(txt1.Text);
            float b = float.Parse(txt2.Text);
            float outcome = 0;

            if (b == 0)
                MessageBox.Show("error");
            else
            {
                outcome = a / b;
                txtKetQua.Text = outcome.ToString();
            }
        }

        private void RadioDu()
        {
            float a = float.Parse(txt1.Text);
            float b = float.Parse(txt2.Text);
            float outcome = 0;

            if (b == 0)
                MessageBox.Show("vui long nhap lai");
            else
            {
                outcome = a % b;
                txtKetQua.Text = outcome.ToString();
            }
        }

        private void RadioMu()
        {
            float a = float.Parse(txt1.Text);
            float b = float.Parse(txt2.Text);
            float outcome = 1;

            for (int i = 1; i <= b; i++)
                outcome *= a;

            txtKetQua.Text = outcome.ToString();
        }

        private void RadioCongChuoi()
        {
            txtKetQua.Text = txt1.Text + txt2.Text;
        }
    }
}
