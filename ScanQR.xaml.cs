﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;

namespace bibliotech
{
    /// <summary>
    /// Логика взаимодействия для ScanQR.xaml
    /// </summary>
    public partial class ScanQR : UserControl
    {
        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public ScanQR()
        {
            InitializeComponent();
        }

        private void buttonScanQR_Click(object sender, RoutedEventArgs e)
        {
            if(openFileDialog.ShowDialog() == true)
            {
                ingQR.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                textQR.Text = decoder.Decode(new QRCodeBitmapImage(new Bitmap(openFileDialog.FileName)));
            }
        }
    }
}
