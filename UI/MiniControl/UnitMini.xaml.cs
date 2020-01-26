using BE;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UI.MiniControl
{
    /// <summary>
    /// Interaction logic for UnitMini.xaml
    /// </summary>
    public partial class UnitMini : UserControl
    {
        int imageIndex;
        Viewbox vbImage;
        Image MyImage;
        public HostingUnit CurrentUnit { get; set; }

        public UnitMini(HostingUnit unit)
        {
            vbImage = new Viewbox();
            InitializeComponent();
            this.CurrentUnit = unit;
            this.DataContext = CurrentUnit;
            MainGrid.DataContext = CurrentUnit;


            imageIndex = 0;
            vbImage.Width = 100;
            vbImage.Height = 90;
            vbImage.Stretch = Stretch.Fill;
            imageGride.Children.Add(vbImage);
            Grid.SetColumn(vbImage, 2);
            Grid.SetRow(vbImage, 0);
            vbImage.MouseUp += vbImage_MouseUp;
            vbImage.MouseEnter += vbImage_MouseEnter;
            vbImage.MouseLeave += vbImage_MouseLeave;
            MyImage = CreateViewImage();
            vbImage.Child = null;
            vbImage.Child = MyImage;
        }
        private Image CreateViewImage()
        {
            Image dynamicImage = new Image();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@CurrentUnit.Uris[imageIndex]);
            bitmap.EndInit();

            //Set Image.Source
            dynamicImage.Source = bitmap;

            //Add Image to Window
            return dynamicImage;
        }
        private void vbImage_MouseLeave(object sender, MouseEventArgs e)
        {
            vbImage.Width = 75;
            vbImage.Height = 75;
        }
        private void vbImage_MouseEnter(object sender, MouseEventArgs e)
        {
            vbImage.Width = this.Width / 3;
            vbImage.Height = this.Height;
        }
        private void vbImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            vbImage.Child = null;
            imageIndex =
           (imageIndex + CurrentUnit.Uris.Count - 1) % CurrentUnit.Uris.Count;
            MyImage = CreateViewImage();
            vbImage.Child = MyImage;
        }
    }
}
