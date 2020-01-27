using BL;
using BE;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Collections.Generic;

namespace UI.MiniControl
{
    /// <summary>
    /// Interaction logic for UnitMini.xaml
    /// </summary>
    public partial class UnitMini : UserControl
    {
        Ibl bl;
        int imageIndex;
        Viewbox vbImage;
        Image MyImage;
        public HostingUnit CurrentUnit { get; set; }
        List<string> currentUris = new List<string>
                        {
                           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                        };
        public UnitMini(HostingUnit unit)
        {
            vbImage = new Viewbox();
            InitializeComponent();
            bl = FactoryBL.GetFactory();
            //this.CurrentUnit = unit;
            CurrentUnit = bl.GetHostingUnit(unit.HostingUnitKey);
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
            bitmap.UriSource = new Uri(@currentUris[imageIndex]);
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

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            bl.DeleteHostingUnit(CurrentUnit);
          
        }

        private void SelectionChangedUpdate(object sender, RoutedEventArgs e)
        {
            // Window UpdateHost = new Control.UpdateHost(CurrentHost);
            // UpdateHost.Show
            Window updateUnit = new Control.UpdateUnit(CurrentUnit);
            updateUnit.Show();
        }

    }
}
