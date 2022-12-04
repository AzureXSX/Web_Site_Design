using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Web_Site_Design
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DoubleAnimationUsingKeyFrames dk = new DoubleAnimationUsingKeyFrames();
        List<BitmapImage> images = new List<BitmapImage>();
        List<BitmapImage> phoneimages = new List<BitmapImage>();
        List<BitmapImage> gimages = new List<BitmapImage>();
        int bunner_count = 1;
        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
        public MainWindow()
        {
            InitializeComponent();
            Tools.Visibility = Visibility.Hidden;
            Sport.Visibility = Visibility.Hidden;
            House.Visibility = Visibility.Hidden;
            Plumbing.Visibility = Visibility.Hidden;
            Buy_Canvas.Visibility = Visibility.Hidden;
            SMARTPHONES.Visibility = Visibility.Hidden;
            FOR_GAMERS.Visibility = Visibility.Hidden;
            LAPTOPS.Visibility = Visibility.Visible;
            MaxHeight = 750;
            MinHeight = 750;
            MaxWidth = 1000;
            MinWidth = 1000;
            dir = dir.Parent.Parent.Parent;

        }


        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TextBox1.Text.Length > 0)
            {
                Search.Visibility = Visibility.Hidden;
            }
            else
            {
                Search.Visibility = Visibility.Visible;
            }
        }

        private void SmartPhones_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Hidden;
            Sport.Visibility = Visibility.Hidden;
            House.Visibility = Visibility.Hidden;
            Plumbing.Visibility = Visibility.Hidden;
            SMARTPHONES.Visibility = Visibility.Visible;
            Title_label.Content = "SmartPhones";
        }

        private void Laptops_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Hidden;
            Sport.Visibility = Visibility.Hidden;
            House.Visibility = Visibility.Hidden;
            Plumbing.Visibility = Visibility.Hidden;
            LAPTOPS.Visibility = Visibility.Visible;
            Title_label.Content = "Laptops";
        }

        private void ForGamers_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            SMARTPHONES.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Hidden;
            Sport.Visibility = Visibility.Hidden;
            House.Visibility = Visibility.Hidden;
            Plumbing.Visibility = Visibility.Hidden;
            FOR_GAMERS.Visibility = Visibility.Visible;

            Title_label.Content = "For Gamers";
        }


        private void Household_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            SMARTPHONES.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Hidden;
            Sport.Visibility = Visibility.Hidden;
            House.Visibility = Visibility.Visible;
            Plumbing.Visibility = Visibility.Hidden;
            FOR_GAMERS.Visibility = Visibility.Hidden;

            Title_label.Content = "Household appliances";
        }

        private void Tools_and_auto_goods_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            SMARTPHONES.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Visible;
            Sport.Visibility = Visibility.Hidden;
            House.Visibility = Visibility.Hidden;
            Plumbing.Visibility = Visibility.Hidden;
            FOR_GAMERS.Visibility = Visibility.Hidden;

            Title_label.Content = "Tools and auto goods";
        }

        private void Plumbing_and_repair_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            SMARTPHONES.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Hidden;
            Sport.Visibility = Visibility.Hidden;
            House.Visibility = Visibility.Hidden;
            Plumbing.Visibility = Visibility.Visible;
            FOR_GAMERS.Visibility = Visibility.Hidden;

            Title_label.Content = "Plumbing and repair";
        }

        private void Sports_and_hobbies_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            SMARTPHONES.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Hidden;
            Sport.Visibility = Visibility.Visible;
            House.Visibility = Visibility.Hidden;
            Plumbing.Visibility = Visibility.Hidden;
            FOR_GAMERS.Visibility = Visibility.Hidden;

            Title_label.Content = "Sport and hobbies";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Title_label.Content.ToString())
            {
                case "Laptops":
                    Buy_Canvas.Visibility = Visibility.Hidden;
                    LAPTOPS.Visibility = Visibility.Visible;
                    break;
                case "SmartPhones":
                    Buy_Canvas.Visibility = Visibility.Hidden;
                    SMARTPHONES.Visibility = Visibility.Visible;
                    break;
                case "For Gamers":
                    Buy_Canvas.Visibility = Visibility.Hidden;
                    FOR_GAMERS.Visibility = Visibility.Visible;
                    break;
                case "Household appliances":
                    Buy_Canvas.Visibility = Visibility.Hidden;
                    House.Visibility = Visibility.Visible;
                    break;
                case "Tools and auto goods":
                    Buy_Canvas.Visibility = Visibility.Hidden;
                    Tools.Visibility = Visibility.Visible;
                    break;
                case "Plumbing and repair":
                    Buy_Canvas.Visibility = Visibility.Hidden;
                    Plumbing.Visibility = Visibility.Visible;
                    break;
                case "Sport and hobbies":
                    Buy_Canvas.Visibility = Visibility.Hidden;
                    Sport.Visibility = Visibility.Visible;
                    break;
            }


        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }

        private void LButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitm3 = new BitmapImage();
            
            if(bunner_count > 1)
            {
                bunner_count--;
                bitm3.BeginInit();
                bitm3.UriSource = new Uri(dir.FullName + "\\Images\\" + "banner" + bunner_count.ToString() + ".png");
                bitm3.EndInit();
                Banner.Source = bitm3;
            }
            if(bunner_count <= 1)
            {
                LButton.Visibility = Visibility.Hidden;
            }
            else if(LButton.Visibility == Visibility.Hidden)
            {
                LButton.Visibility = Visibility.Visible;
            }
            if (bunner_count < 5 && RButton.Visibility == Visibility.Hidden)
            {
                RButton.Visibility = Visibility.Visible;
            }
        }

        private void RButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitm3 = new BitmapImage();

            if (bunner_count < 5)
            {
                bunner_count++;
                bitm3.BeginInit();
                bitm3.UriSource = new Uri(dir.FullName + "\\Images\\" + "banner" + bunner_count.ToString() + ".png");
                bitm3.EndInit();
                Banner.Source = bitm3;
            }
            if (bunner_count > 4)
            {
                RButton.Visibility = Visibility.Hidden;
            }
            else if (RButton.Visibility == Visibility.Hidden)
            {
                RButton.Visibility = Visibility.Visible;
            }
            if(bunner_count > 1 && LButton.Visibility == Visibility.Hidden)
            {
                LButton.Visibility = Visibility.Visible;
            }
            
        }




        private void LaptopLabel1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Acer Aspire 7 A715-42G-R8BL Charcoal";
            Price.Content = "37 999$";
            Goods_image.Source = images[0];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "ASUS TUF F15FX506LH-HN236";
            Price.Content = "36 999$";
            Goods_image.Source = images[1];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Lenovo IdePad 3 15ALC6 Artic Grey";
            Price.Content = "27 999$";
            Goods_image.Source = images[2];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "MacBook Air 13 M1 256 GB 2020";
            Price.Content = "42 999$";
            Goods_image.Source = images[3];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Acer Aspire 5 A515-45G-R5CN Charcoal";
            Price.Content = "21 999$";
            Goods_image.Source = images[4];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Asus Laptop X515EA-BQ2066";
            Price.Content = "22 999$";
            Goods_image.Source = images[5];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel22_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Lenovo IdePad 3 15IHU6 Shadow ";
            Price.Content = "29 999$";
            Goods_image.Source = images[6];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel33_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Asus TUF F15 FX506HC-HN004 ";
            Price.Content = "42 999$";
            Goods_image.Source = images[7];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel44_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Lenovo V14 G2 ITL (Intel-i3-1115G4) ";
            Price.Content = "17 999$";
            Goods_image.Source = images[8];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel55_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Acer Aspire 7 A715-75G-72ZX Charcoal";
            Price.Content = "38 999$";
            Goods_image.Source = images[9];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel111_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "ASUS LapTop X515JA-EJ4076 Silver";
            Price.Content = "24 999$";
            Goods_image.Source = images[10];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel222_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Lenovo IdePad 3 15ALC6 Arctic Grey";
            Price.Content = "17 999$";
            Goods_image.Source = images[11];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel333_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Acer Aspire 7 A715-42G-R5B1";
            Price.Content = "33 999$";
            Goods_image.Source = images[12];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel444_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "ASUS TUF F15 FX506HE-HN012";
            Price.Content = "43 999$";
            Goods_image.Source = images[13];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel555_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "MacBook Pro 13 M2 256GB 2022";
            Price.Content = "54 999$";
            Goods_image.Source = images[14];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel1111_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "MacBook Pro 16 M1 Pro 512GB 2021";
            Price.Content = "114 999$";
            Goods_image.Source = images[15];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel2222_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "ASUS Laptop X415JA-EK2095W";
            Price.Content = "20 999$";
            Goods_image.Source = images[16];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel3333_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Lenovo IdePad 3 15ITL6 Artic Grey ";
            Price.Content = "23 999$";
            Goods_image.Source = images[17];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel4444_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Acer Aspire 7 A715-42G-R0VS";
            Price.Content = "29 999$";
            Goods_image.Source = images[18];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void LaptopLabel5555_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            LAPTOPS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Asus TUF F15 FX506Hm-HN017";
            Price.Content = "51 999$";
            Goods_image.Source = images[19];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                BitmapImage bitm = new BitmapImage();
                bitm.BeginInit();
                bitm.UriSource = new Uri(dir.FullName + "\\Images\\" + "l" + (i + 1).ToString() + ".jpg");
                bitm.EndInit();
                images.Add(bitm);       
            }
            l1.Source = images[0];
            l2.Source = images[1];
            l3.Source = images[2];
            l4.Source = images[3];
            l5.Source = images[4];
            l6.Source = images[5];
            l7.Source = images[6];
            l8.Source = images[7];
            l9.Source = images[8];
            l10.Source = images[9];
            l11.Source = images[10];
            l12.Source = images[11];
            l13.Source = images[12];
            l14.Source = images[13];
            l15.Source = images[14];
            l16.Source = images[15];
            l17.Source = images[16];
            l18.Source = images[17];
            l19.Source = images[18];
            l20.Source = images[19];
            for (int i = 0; i < 20; i++)
            {
                BitmapImage bitm0 = new BitmapImage();
                bitm0.BeginInit();
                bitm0.UriSource = new Uri(dir.FullName + "\\Images\\" + "p" + (i + 1).ToString() + ".jpg");
                bitm0.EndInit();
                phoneimages.Add(bitm0);
            }

            p1.Source = phoneimages[0];
            p2.Source = phoneimages[1];
            p3.Source = phoneimages[2];
            p4.Source = phoneimages[3];
            p5.Source = phoneimages[4];
            p6.Source = phoneimages[5];
            p7.Source = phoneimages[6];
            p8.Source = phoneimages[7];
            p9.Source = phoneimages[8];
            p10.Source = phoneimages[9];
            p11.Source = phoneimages[10];
            p12.Source = phoneimages[11];
            p13.Source = phoneimages[12];
            p14.Source = phoneimages[13];
            p15.Source = phoneimages[14];
            p16.Source = phoneimages[15];
            p17.Source = phoneimages[16];
            p18.Source = phoneimages[17];
            p19.Source = phoneimages[18];
            p20.Source = phoneimages[19];

            for (int i = 0; i < 20; i++)
            {
                BitmapImage bitm00 = new BitmapImage();
                bitm00.BeginInit();
                bitm00.UriSource = new Uri(dir.FullName + "\\Images\\" + "g" + (i + 1).ToString() + ".jpg");
                bitm00.EndInit();
                gimages.Add(bitm00);
            }

            g1.Source = gimages[0];
            g2.Source = gimages[1];
            g3.Source = gimages[2];
            g4.Source = gimages[3];
            g5.Source = gimages[4];
            g6.Source = gimages[5];
            g7.Source = gimages[6];
            g8.Source = gimages[7];
            g9.Source = gimages[8];
            g10.Source = gimages[9];
            g11.Source = gimages[10];
            g12.Source = gimages[11];
            g13.Source = gimages[12];
            g14.Source = gimages[13];
            g15.Source = gimages[14];
            g16.Source = gimages[15];
            g17.Source = gimages[16];
            g18.Source = gimages[17];
            g19.Source = gimages[18];
            g20.Source = gimages[19];

            BitmapImage bitm2 = new BitmapImage();
            bitm2.BeginInit();
            bitm2.UriSource = new Uri(dir.FullName + "\\Images\\" + "Rozetka.png");
            bitm2.EndInit();

            ROZETKAIMG.Source = bitm2;
            Small_Logo.Source = bitm2;

            BitmapImage bitm3 = new BitmapImage();
            bitm3.BeginInit();
            bitm3.UriSource = new Uri(dir.FullName + "\\Images\\" + "banner1.png");
            bitm3.EndInit();

            Banner.Source = bitm3;


            LButton.Visibility = Visibility.Hidden;


            LaptopLabel1.Content = "Acer Aspire 7\nA715-42G-R8BL\nCharcoal\n37 999$";
            LaptopLabel2.Content = "ASUS TUF\nF15FX506LH-\nHN236\n36 999$";
            LaptopLabel3.Content = "Lenovo IdePad 3\n15ALC6\nArtic Grey\n27 999$";
            LaptopLabel4.Content = "MacBook Air 13\nM1\n256 GB 2020\n42 999$";
            LaptopLabel5.Content = "Acer Aspire 5\nA515-45G-R5CN\nCharcoal\n21 999$";

            LaptopLabel11.Content = "Asus Laptop\nX515EA-\nBQ2066\n22 999$";
            LaptopLabel22.Content = "Lenovo IdePad 3\n15IHU6\nShadow\n29 999$";
            LaptopLabel33.Content = "Asus TUF F15\nFX506HC-\nHN004\n42 999$";
            LaptopLabel44.Content = "Lenovo V14 G2\nITL\n(Intel-i3-1115G4)\n17 999$";
            LaptopLabel55.Content = "Acer Aspire 7\nA715-75G-72ZX\nCharcoal\n38 999$";

            LaptopLabel111.Content = "ASUS LapTop\nX515JA-EJ4076\nSilver\n24 999$";
            LaptopLabel222.Content = "Lenovo IdePad 3\n15ALC6\nArctic Grey\n17 999$";
            LaptopLabel333.Content = "Acer Aspire 7\nA715-42G-\nR5B1\n33 999$";
            LaptopLabel444.Content = "ASUS TUF F15\nFX506HE-\nHN012\n43 999$";
            LaptopLabel555.Content = "MacBook Pro 13\nM2\n256GB 2022\n54 999$";

            LaptopLabel1111.Content = "MacBook Pro 16\nM1 Pro\n512GB 2021\n114 999$";
            LaptopLabel2222.Content = "ASUS Laptop\nX415JA-\nEK2095W\n20 999$";
            LaptopLabel3333.Content = "Lenovo IdePad 3\n15ITL6\nArtic Grey\n23 999$";
            LaptopLabel4444.Content = "Acer Aspire 7\nA715-42G-\nR0VS\n29 999$";
            LaptopLabel5555.Content = "Asus TUF F15\nFX506Hm-\nHN017\n51 999$";


            PhoneLabel1.Content = "Samsung Galaxy\nM32 6/128\nLight Blue\n8 555$";
            PhoneLabel2.Content = "Apple IPhone 14\n 128GB\nProduct Red\n41 499$";
            PhoneLabel3.Content = "Samsung Galaxy\nA53 5G 256GB\nLight Blue\n19 599$";
            PhoneLabel4.Content = "Motorola\nG32 6/128GB\nRose Gold\n6 699$";
            PhoneLabel5.Content = "ZTE Blade\nV30 4/128GB\nBlack\n5 499$";

            PhoneLabel11.Content = "Apple IPhone 11\n128GB\nBlack\n25 499$";
            PhoneLabel22.Content = "Samsung Galaxy\nS21 FE 6/128GB\nLight Blue\n7 499$";
            PhoneLabel33.Content = "Samsung Galaxy\nM13 4/64GB\nLight Blue\n7 499$  ";
            PhoneLabel44.Content = "Apple IPhone 13\n128GB\nBlue\n35 999$";
            PhoneLabel55.Content = "Nokia G10\n3/32GB\nBlue\n3 999$";

            PhoneLabel111.Content = "Samsung Galaxy\nA53 5G 6/128GB\nWhite\n17 299$";
            PhoneLabel222.Content = "Samsung Galaxy\nS22 Ultra 12/512GB\nBlack\n51 099$";
            PhoneLabel333.Content = "Nokia C21\nPlus 3/32\nDark Cyan\n3 999$";
            PhoneLabel444.Content = "Infinix Note 12\n6/128GB\nForce Black\n7 999$";
            PhoneLabel555.Content = "Motorola Moto\nE20 2/32GB\nGraphite\n3 399$";

            PhoneLabel1111.Content = "Samsug Galaxy\nS21 FE 8/256GB\nOlive\n25 499$";
            PhoneLabel2222.Content = "Apple IPhone 12\n128GB\nPurple\n34 499$";
            PhoneLabel3333.Content = "Infinix Smart 6\n2/32GB\nPolar Black\n3 999$";
            PhoneLabel4444.Content = "Techno Spark 8C\n4/64GB NFC\nBlack\n4 999$";
            PhoneLabel5555.Content = "ZTE Blade\nA51 3/64GB\nGray\n3 999$";

            GamerLabel1.Content = "Logitech G Pro\nGaming Wireless\nBlack\n5 999$";
            GamerLabel2.Content = "SteelSeries\nPrime mini\nBlack\n2 299$";
            GamerLabel3.Content = "SteelSeries\nRival 3 USB\nBlack\n1 699$";
            GamerLabel4.Content = "A4Tech \nx-710BK USB\nBlack\n689$";
            GamerLabel5.Content = "SteelSeries\nRival 3 Wireless\nBlack\n2 499$";

            GamerLabel11.Content = "Logitech G305\nWireless\nBlack\n2 499$";
            GamerLabel22.Content = "A4Tech\nXL-750BH USB\nBlack\n899$";
            GamerLabel33.Content = "1stplayer\nFD300 Pro RGB\nBlack\n829$";
            GamerLabel44.Content = "Razer DeathAder\nEssential USB\nWhite\n1 199$";
            GamerLabel55.Content = "Razer Viper\nUltimate Wireless\nBlack\n3 799$";

            GamerLabel111.Content = "RZTK\nClick RGB USB\nBlack\n299$";
            GamerLabel222.Content = "RZTK\nS 400 USB\nBlack\n199$";
            GamerLabel333.Content = "Razer Basilisk\nX Hyper Speed Wireless\nBlack\n2 299$";
            GamerLabel444.Content = "Logitech G Pro\nX Superlght Wireless\nMagenta\n6 699$";
            GamerLabel555.Content = "RZTK\nS 420 USB\nBlack\n299$";

            GamerLabel1111.Content = "Razer Basilisk\nUltimate Wireless\nBlack\n4 999$";
            GamerLabel2222.Content = "Razer DeathAder\nV3 PRO Vireless\nWhite\n6 499$";
            GamerLabel3333.Content = "Hator Pulsar\nEssential USB\nLilac\n999$";
            GamerLabel4444.Content = "Razer Basilisk\nV3 USB \nBlack\n2 999$";
            GamerLabel5555.Content = "Logitech G502\nGaming Mouse\nHigh Performace\n3 999$";
        }



       

        private void PhoneLabel1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Samsung Galaxy M32 6/128 Light Blue ";
            Price.Content = "8 555$";
            Goods_image.Source = phoneimages[0];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Apple IPhone 14 128GB Product Red";
            Price.Content = "41 499$";
            Goods_image.Source = phoneimages[1];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Samsung Galaxy A53 5G 256GB Light Blue";
            Price.Content = "19 599$";
            Goods_image.Source = phoneimages[2];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Motorola G32 6/128GB Rose Gold ";
            Price.Content = "6 699$";
            Goods_image.Source = phoneimages[3];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "ZTE Blade V30 4/128GB Black ";
            Price.Content = "5 499$";
            Goods_image.Source = phoneimages[4];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Apple IPhone 11 128GB Black";
            Price.Content = "25 499$";
            Goods_image.Source = phoneimages[5];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel22_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Samsung Galaxy S21 FE 6/128GB Light Blue";
            Price.Content = "7 499$";
            Goods_image.Source = phoneimages[6];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel33_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Samsung Galaxy M13 4/64GB Light Blue";
            Price.Content = "7 499$";
            Goods_image.Source = phoneimages[7];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel44_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Apple IPhone 13 128GB Blue ";
            Price.Content = "35 999$";
            Goods_image.Source = phoneimages[8];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel55_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Nokia G10 3/32GB Blue";
            Price.Content = "3 999$";
            Goods_image.Source = phoneimages[9];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel111_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Samsung Galaxy A53 5G 6/128GB White";
            Price.Content = "17 299$";
            Goods_image.Source = phoneimages[10];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel222_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Samsung Galaxy S22 Ultra 12/512GB Black ";
            Price.Content = "51 099$";
            Goods_image.Source = phoneimages[11];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel333_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Nokia C21 Plus 3/32 Dark Cyan ";
            Price.Content = "3 999$";
            Goods_image.Source = phoneimages[12];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel444_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Infinix Note 12 6/128GB Force Black";
            Price.Content = "7 999$";
            Goods_image.Source = phoneimages[13];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel555_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Motorola Moto E20 2/32GB Graphite";
            Price.Content = "3 399$";
            Goods_image.Source = phoneimages[14];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel1111_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Samsug Galaxy S21 FE 8/256GB Olive";
            Price.Content = "25 499$";
            Goods_image.Source = phoneimages[15];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel2222_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Apple IPhone 12 128GB Purple ";
            Price.Content = "34 499$";
            Goods_image.Source = phoneimages[16];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel3333_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Infinix Smart 6 2/32GB Polar Black ";
            Price.Content = "3 999$";
            Goods_image.Source = phoneimages[17];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel4444_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "Techno Spark 8C 4/64GB NFC Black";
            Price.Content = "4 999$";
            Goods_image.Source = phoneimages[18];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void PhoneLabel5555_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SMARTPHONES.Visibility = Visibility.Hidden;
            Goods_name.Content = "ZTE Blade A51 3/64GB Gray ";
            Price.Content = "3 999$";
            Goods_image.Source = phoneimages[19];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Logitech G Pro Gaming Wireless Black ";
            Price.Content = "5 999$";
            Goods_image.Source = gimages[0];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "SteelSeries Prime mini Black"; ;
            Price.Content = "2 299$";
            Goods_image.Source = gimages[1];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "SteelSeries Rival 3 USB Black";
            Price.Content = "1 699$";
            Goods_image.Source = gimages[2];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "A4Tech x-710BK USB Black ";
            Price.Content = "689$";
            Goods_image.Source = gimages[3];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "SteelSeries Rival 3 Wireless Black";
            Price.Content = "2 499$";
            Goods_image.Source = gimages[4];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Logitech G305 Wireless Black";
            Price.Content = "2 499$";
            Goods_image.Source = gimages[5];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel22_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "A4Tech XL-750BH USB Black ";
            Price.Content = "899$";
            Goods_image.Source = gimages[6];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel33_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "1stplayer FD300 Pro RGB Black ";
            Price.Content = "829$";
            Goods_image.Source = gimages[7];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel44_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Razer DeathAdder Essential USB White";
            Price.Content = "1 199$";
            Goods_image.Source = gimages[8];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel55_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Razer Viper Ultimate Wireless Black";
            Price.Content = "3 799$";
            Goods_image.Source = gimages[9];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel111_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "RZTK Click RGB USB Black";
            Price.Content = "299$";
            Goods_image.Source = gimages[10];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel222_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "RZTK S 400 USB Black ";
            Price.Content = "199$";
            Goods_image.Source = gimages[11];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel333_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Razer Basilisk X Hyper Speed Wireless Black ";
            Price.Content = "2 299$";
            Goods_image.Source = gimages[12];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel444_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Logitech G Pro X Superlght Wireless Magenta ";
            Price.Content = "6 699$";
            Goods_image.Source = gimages[13];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel555_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "RZTK S 420 USB Black ";
            Price.Content = "299$";
            Goods_image.Source = gimages[14];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel1111_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Razer Basilisk Ultimate Wireless Black";
            Price.Content = "4 999$";
            Goods_image.Source = gimages[15];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel2222_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Razer DeathAder V3 PRO Vireless White ";
            Price.Content = "6 499$";
            Goods_image.Source = gimages[16];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel3333_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Hator Pulsar Essential USB Lilac";
            Price.Content = "999$";
            Goods_image.Source = gimages[17];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel4444_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Razer Basilisk V3 USB Black";
            Price.Content = "2 999$";
            Goods_image.Source = gimages[18];
            Buy_Canvas.Visibility = Visibility.Visible;
        }

        private void GamerLabel5555_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FOR_GAMERS.Visibility = Visibility.Hidden;
            Goods_name.Content = "Logitech G502 Gaming Mouse High Performance\n";
            Price.Content = "3 999$";
            Goods_image.Source = gimages[19];
            Buy_Canvas.Visibility = Visibility.Visible;
        }




        /*
            GamerLabel1.Content = 
            GamerLabel2.Content = 
            GamerLabel3.Content = 
            GamerLabel4.Content = 
            GamerLabel5.Content = 

            GamerLabel11.Content = 
            GamerLabel22.Content = 
            GamerLabel33.Content = 
            GamerLabel44.Content = 
            GamerLabel55.Content = 

            GamerLabel111.Content = 
            GamerLabel222.Content = 
            GamerLabel333.Content = 
            GamerLabel444.Content = 
            GamerLabel555.Content = 

            GamerLabel1111.Content = 
            GamerLabel2222.Content = 
            GamerLabel3333.Content = 
            GamerLabel4444.Content = 
            GamerLabel5555.Content = 
         */
    }
}