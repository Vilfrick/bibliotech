using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
    /// Логика взаимодействия для CreateQR.xaml
    /// </summary>
    public partial class CreateQR : UserControl
    {
        QRCodeEncoder encoder = new QRCodeEncoder();
        Bitmap bitmap;
        SaveFileDialog saveFile = new SaveFileDialog();
        public CreateQR()
        {
            InitializeComponent();
        }

        private void ButtonCreateQR_Click(object sender, RoutedEventArgs e)
        {
            encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            encoder.QRCodeScale = 10;
            encoder.QRCodeVersion = 10;
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;

            bitmap = encoder.Encode(textQR.Text);
            ingQR.Source = ConvertImage.ToBitmapImage(bitmap);

        }

        private void buttonSaveQR_Click(object sender, RoutedEventArgs e)
        {
            saveFile.Filter = "PNG|*.png";
            saveFile.FileName = textQR.Text;
            if (saveFile.ShowDialog() == true)
            {
                if(bitmap!=null)
                {
                    bitmap.Save(string.Concat(saveFile.FileName, ".png"), ImageFormat.Png);
                }
            }
        }
    }
}
