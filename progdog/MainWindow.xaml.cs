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

namespace progdog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        int[,] m = new int[6, 6];

        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int R = 0, C = 0, I = 0;
            xy.Children.Clear();
            
            Console.WriteLine(m.Length);

            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 6; j++)
                {

                    m[i, j] = r.Next(1, 4);
                    Label qwe = new Label();
                    qwe.Content = m[i, j];
                    Thickness ewq = new Thickness(10, 10, 10, 10);
                    qwe.Margin = ewq;
                    qwe.VerticalAlignment = VerticalAlignment.Center;
                    qwe.HorizontalContentAlignment = HorizontalAlignment.Center;

                    if (m[i, j] == 1)
                    {

                        qwe.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                        R++;

                    }

                    else if (m[i, j] == 2)
                    {

                        qwe.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                        C++;

                    }

                    else if (m[i, j] == 3)
                    {

                        qwe.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                        I++;

                    }

                    else
                    {

                        Console.WriteLine("na hat igen");
                    }

                    Grid.SetRow(qwe, i);
                    Grid.SetColumn(qwe, j);
                    xy.Children.Add(qwe);

                    LR.Content = R;
                    LR.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));

                    LC.Content = C;
                    LC.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));

                    LI.Content = I;
                    LI.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));

                    PBR.Maximum = 12;
                    PBR.Minimum = 0;
                    PBR.Value = R;
                    PBR.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));

                    PBR.Maximum = 12;
                    PBR.Minimum = 0;
                    PBC.Value = C;
                    PBC.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));

                    PBR.Maximum = 12;
                    PBR.Minimum = 0;
                    PBI.Value = I;
                    PBI.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));

                    if (R > 14 || R < 10)
                    {
                        LR.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    }
                    else if (C > 14 || C < 10)
                    {
                        LC.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    }
                    else if (I > 14 || I < 10)
                    {
                        LI.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    }
                    else
                    {
                        MessageBox.Show("heble");
                        Console.WriteLine("heble");
                    }

                }
            }
        }

        private void PBR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
