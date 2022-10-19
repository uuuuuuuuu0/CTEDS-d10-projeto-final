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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Runtime.CompilerServices;

using Mega_sena_front.Data;

namespace Mega_sena_front
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SolidColorBrush lightMainColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D6D6D6"));
        public SolidColorBrush darkMainColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#262626"));

        public SolidColorBrush lightSecondColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A81B9"));
        public SolidColorBrush darkSecondColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

        public SolidColorBrush lightTitleColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        public SolidColorBrush darkTitleColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        
        public SolidColorBrush whiteColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        public SolidColorBrush blackColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        public SolidColorBrush pseudoBlackColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000001"));

        public Thickness lightThickness = new Thickness(0, 4, 0, 4);
        public Thickness darkThickness = new Thickness(0, 0, 0, 0);

        private readonly Context context;
        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
            context.SaveChanges();
            Busca.Text = "Busca";
            Busca.Foreground = pseudoBlackColor;

            //TextBlock auxBlock = new();

            //< TextBlock x: Name = "auxDiv" VerticalAlignment = "Top" Margin = "0,-4,24,0" HorizontalAlignment = "Right" Width = "628" Height = "5" Background = "#262626" ></ TextBlock >

            foreach (MegaSena megaSena in context.megaSenas)
            {
                Grid fillerGrid = new();
                fillerGrid.Height = 40;
                fillerGrid.Width = 1600;

                Grid grid = new();
                grid.Margin = new Thickness(0, 40, 0, 0);
                grid.Width = 1400;
                grid.Height = 180;
                grid.Background = whiteColor;
                grid.HorizontalAlignment = HorizontalAlignment.Center;
                grid.VerticalAlignment = VerticalAlignment.Top;

                TextBlock nameTextBlock = new();
                nameTextBlock.Text = "Mega-Sena (" + megaSena.Id + ")";
                nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
                nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
                nameTextBlock.FontSize = 32;
                nameTextBlock.Foreground = blackColor;
                grid.Children.Add(nameTextBlock);
                TextBlock statusTextBlock = new();
                statusTextBlock.Text = "Status: " + megaSena.Status;
                statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
                statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                statusTextBlock.FontSize = 24;
                statusTextBlock.Foreground = blackColor;
                grid.Children.Add(statusTextBlock);
                if (megaSena.Result != null)
                {
                    TextBlock resultTextBlock = new();
                    resultTextBlock.Text = "Números: " + megaSena.Result[0] + megaSena.Result[1] + " " +
                                                           megaSena.Result[2] + megaSena.Result[3] + " " +
                                                           megaSena.Result[4] + megaSena.Result[5] + " " +
                                                           megaSena.Result[6] + megaSena.Result[7] + " " +
                                                           megaSena.Result[8] + megaSena.Result[9] + " " +
                                                           megaSena.Result[10] + megaSena.Result[11];
                    resultTextBlock.Margin = new Thickness(46, 0, 0, 26);
                    resultTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                    resultTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                    resultTextBlock.FontSize = 24;
                    resultTextBlock.Foreground = blackColor;
                    grid.Children.Add(resultTextBlock);

                }
                TextBlock prizeTextBlock = new();
                prizeTextBlock.Text = "Prêmio: R$" + String.Format("{0:0.00}", megaSena.Prize);
                prizeTextBlock.Margin = new Thickness(0, 30, 46, 0);
                prizeTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                prizeTextBlock.VerticalAlignment = VerticalAlignment.Top;
                prizeTextBlock.FontSize = 32;
                prizeTextBlock.Foreground = blackColor;
                grid.Children.Add(prizeTextBlock);
                TextBlock startDateTextBlock = new();
                startDateTextBlock.Text = "Data de Início: " + megaSena.StartTime.ToString("dd/MM/yyyy");
                startDateTextBlock.Margin = new Thickness(0, 0, 46, 26);
                startDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                startDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                startDateTextBlock.FontSize = 24;
                startDateTextBlock.Foreground = blackColor;
                grid.Children.Add(startDateTextBlock);
                TextBlock endDateTextBlock = new();
                endDateTextBlock.Text = "Data de Início: " + megaSena.EndTime.ToString("dd/MM/yyyy");
                endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
                endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                endDateTextBlock.FontSize = 24;
                endDateTextBlock.Foreground = blackColor;
                grid.Children.Add(endDateTextBlock);

                childrenHolder.Children.Add(grid);
                childrenHolder.Children.Add(fillerGrid);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //OnPropertyChanged();
            ComboBoxItem sorteio = cbBox.SelectedItem as ComboBoxItem;
            switch (sorteio.Name)
            {
                case "MegaSena":
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (MegaSena megaSena in context.megaSenas)
                        {
                            Grid fillerGrid = new();
                            fillerGrid.Height = 40;
                            fillerGrid.Width = 1600;

                            Grid grid = new();
                            grid.Margin = new Thickness(0, 40, 0, 0);
                            grid.Width = 1400;
                            grid.Height = 180;
                            grid.Background = whiteColor;
                            grid.HorizontalAlignment = HorizontalAlignment.Center;
                            grid.VerticalAlignment = VerticalAlignment.Top;

                            TextBlock nameTextBlock = new();
                            nameTextBlock.Text = "Mega-Sena (" + megaSena.Id + ")";
                            nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
                            nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                            nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
                            nameTextBlock.FontSize = 32;
                            nameTextBlock.Foreground = blackColor;
                            grid.Children.Add(nameTextBlock);
                            TextBlock statusTextBlock = new();
                            statusTextBlock.Text = "Status: " + megaSena.Status;
                            statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
                            statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                            statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                            statusTextBlock.FontSize = 24;
                            statusTextBlock.Foreground = blackColor;
                            grid.Children.Add(statusTextBlock);
                            if (megaSena.Result != null)
                            {
                                TextBlock resultTextBlock = new();
                                resultTextBlock.Text = "Números: " + megaSena.Result[0] + megaSena.Result[1] + " " +
                                                                       megaSena.Result[2] + megaSena.Result[3] + " " +
                                                                       megaSena.Result[4] + megaSena.Result[5] + " " +
                                                                       megaSena.Result[6] + megaSena.Result[7] + " " +
                                                                       megaSena.Result[8] + megaSena.Result[9] + " " +
                                                                       megaSena.Result[10] + megaSena.Result[11];
                                resultTextBlock.Margin = new Thickness(46, 0, 0, 26);
                                resultTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                                resultTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                                resultTextBlock.FontSize = 24;
                                resultTextBlock.Foreground = blackColor;
                                grid.Children.Add(resultTextBlock);

                            }
                            TextBlock prizeTextBlock = new();
                            prizeTextBlock.Text = "Prêmio: R$" + String.Format("{0:0.00}", megaSena.Prize);
                            prizeTextBlock.Margin = new Thickness(0, 30, 46, 0);
                            prizeTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                            prizeTextBlock.VerticalAlignment = VerticalAlignment.Top;
                            prizeTextBlock.FontSize = 32;
                            prizeTextBlock.Foreground = blackColor;
                            grid.Children.Add(prizeTextBlock);
                            TextBlock startDateTextBlock = new();
                            startDateTextBlock.Text = "Data de Início: " + megaSena.StartTime.ToString("dd/MM/yyyy");
                            startDateTextBlock.Margin = new Thickness(0, 0, 46, 26);
                            startDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                            startDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                            startDateTextBlock.FontSize = 24;
                            startDateTextBlock.Foreground = blackColor;
                            grid.Children.Add(startDateTextBlock);
                            TextBlock endDateTextBlock = new();
                            endDateTextBlock.Text = "Data de Início: " + megaSena.EndTime.ToString("dd/MM/yyyy");
                            endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
                            endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                            endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                            endDateTextBlock.FontSize = 24;
                            endDateTextBlock.Foreground = blackColor;
                            grid.Children.Add(endDateTextBlock);

                            childrenHolder.Children.Add(grid);
                            childrenHolder.Children.Add(fillerGrid);
                        }
                    }
                    break;
                case "Lotofacil":
                    if (childrenHolder != null)
                    { 
                        childrenHolder.Children.Clear();
                        foreach (LotoFacil lotoF in context.lotoFacils)
                        {
                            Grid fillerGrid = new();
                            fillerGrid.Height = 40;
                            fillerGrid.Width = 1600;

                            Grid grid = new();
                            grid.Margin = new Thickness(0, 40, 0, 0);
                            grid.Width = 1400;
                            grid.Height = 180;
                            grid.Background = whiteColor;
                            grid.HorizontalAlignment = HorizontalAlignment.Center;
                            grid.VerticalAlignment = VerticalAlignment.Top;

                            TextBlock nameTextBlock = new();
                            nameTextBlock.Text = "Lotofácil (" + lotoF.Id + ")";
                            nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
                            nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                            nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
                            nameTextBlock.FontSize = 32;
                            nameTextBlock.Foreground = blackColor;
                            grid.Children.Add(nameTextBlock);
                            TextBlock statusTextBlock = new();
                            statusTextBlock.Text = "Status: " + lotoF.Status;
                            statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
                            statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                            statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                            statusTextBlock.FontSize = 24;
                            statusTextBlock.Foreground = blackColor;
                            grid.Children.Add(statusTextBlock);
                            if (lotoF.Result != null)
                            {
                                TextBlock resultTextBlock = new();
                                resultTextBlock.Text = "Números: " + lotoF.Result[0] + lotoF.Result[1] + " " +
                                                                       lotoF.Result[2] + lotoF.Result[3] + " " +
                                                                       lotoF.Result[4] + lotoF.Result[5] + " " +
                                                                       lotoF.Result[6] + lotoF.Result[7] + " " +
                                                                       lotoF.Result[8] + lotoF.Result[9] + " " +
                                                                       lotoF.Result[10] + lotoF.Result[11] + " " +
                                                                       lotoF.Result[12] + lotoF.Result[13] + " " +
                                                                       lotoF.Result[14] + lotoF.Result[15] + " " +
                                                                       lotoF.Result[16] + lotoF.Result[17] + " " +
                                                                       lotoF.Result[18] + lotoF.Result[19] + " " +
                                                                       lotoF.Result[20] + lotoF.Result[21] + " " +
                                                                       lotoF.Result[22] + lotoF.Result[23] + " " +
                                                                       lotoF.Result[24] + lotoF.Result[25] + " " +
                                                                       lotoF.Result[26] + lotoF.Result[27] + " " +
                                                                       lotoF.Result[28] + lotoF.Result[29];
                                resultTextBlock.Margin = new Thickness(46, 0, 0, 26);
                                resultTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                                resultTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                                resultTextBlock.FontSize = 24;
                                resultTextBlock.Foreground = blackColor;
                                grid.Children.Add(resultTextBlock);

                            }
                            TextBlock prizeTextBlock = new();
                            prizeTextBlock.Text = "Prêmio: R$" + String.Format("{0:0.00}", lotoF.Prize);
                            prizeTextBlock.Margin = new Thickness(0, 30, 46, 0);
                            prizeTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                            prizeTextBlock.VerticalAlignment = VerticalAlignment.Top;
                            prizeTextBlock.FontSize = 32;
                            prizeTextBlock.Foreground = blackColor;
                            grid.Children.Add(prizeTextBlock);
                            TextBlock startDateTextBlock = new();
                            startDateTextBlock.Text = "Data de Início: " + lotoF.StartTime.ToString("dd/MM/yyyy");
                            startDateTextBlock.Margin = new Thickness(0, 0, 46, 26);
                            startDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                            startDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                            startDateTextBlock.FontSize = 24;
                            startDateTextBlock.Foreground = blackColor;
                            grid.Children.Add(startDateTextBlock);
                            TextBlock endDateTextBlock = new();
                            endDateTextBlock.Text = "Data de Início: " + lotoF.EndTime.ToString("dd/MM/yyyy");
                            endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
                            endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                            endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                            endDateTextBlock.FontSize = 24;
                            endDateTextBlock.Foreground = blackColor;
                            grid.Children.Add(endDateTextBlock);

                            childrenHolder.Children.Add(grid);
                            childrenHolder.Children.Add(fillerGrid);
                        }
                    }
                    break;
                case "Quina":
                    break;
                case "Lotomania":
                    break;
                case "DuplaSena":
                    break;
                default:
                    //childrenHolder.Children.Clear();
                    //foreach (LotoFacil lotoF in context.lotoFacils)
                    //{
                    //    Grid fillerGrid = new();
                    //    fillerGrid.Height = 40;
                    //    fillerGrid.Width = 1600;

                    //    Grid grid = new();
                    //    grid.Margin = new Thickness(0, 40, 0, 0);
                    //    grid.Width = 1400;
                    //    grid.Height = 180;
                    //    grid.Background = whiteColor;
                    //    grid.HorizontalAlignment = HorizontalAlignment.Center;
                    //    grid.VerticalAlignment = VerticalAlignment.Top;

                    //    TextBlock nameTextBlock = new();
                    //    nameTextBlock.Text = "Lotofácil (" + lotoF.Id + ")";
                    //    nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
                    //    nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                    //    nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
                    //    nameTextBlock.FontSize = 32;
                    //    nameTextBlock.Foreground = blackColor;
                    //    grid.Children.Add(nameTextBlock);
                    //    TextBlock statusTextBlock = new();
                    //    statusTextBlock.Text = "Status: " + lotoF.Status;
                    //    statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
                    //    statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                    //    statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                    //    statusTextBlock.FontSize = 24;
                    //    statusTextBlock.Foreground = blackColor;
                    //    grid.Children.Add(statusTextBlock);
                    //    if (lotoF.Result != null)
                    //    {
                    //        TextBlock resultTextBlock = new();
                    //        resultTextBlock.Text = "Números: " + lotoF.Result[0] + lotoF.Result[1] + " " +
                    //                                               lotoF.Result[2] + lotoF.Result[3] + " " +
                    //                                               lotoF.Result[4] + lotoF.Result[5] + " " +
                    //                                               lotoF.Result[6] + lotoF.Result[7] + " " +
                    //                                               lotoF.Result[8] + lotoF.Result[9] + " " +
                    //                                               lotoF.Result[10] + lotoF.Result[11] + " " +
                    //                                               lotoF.Result[12] + lotoF.Result[13] + " " +
                    //                                               lotoF.Result[14] + lotoF.Result[15] + " " +
                    //                                               lotoF.Result[16] + lotoF.Result[17] + " " +
                    //                                               lotoF.Result[18] + lotoF.Result[19] + " " +
                    //                                               lotoF.Result[20] + lotoF.Result[21] + " " +
                    //                                               lotoF.Result[22] + lotoF.Result[23] + " " +
                    //                                               lotoF.Result[24] + lotoF.Result[25] + " " +
                    //                                               lotoF.Result[26] + lotoF.Result[27] + " " +
                    //                                               lotoF.Result[28] + lotoF.Result[29];
                    //        resultTextBlock.Margin = new Thickness(46, 0, 0, 26);
                    //        resultTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                    //        resultTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                    //        resultTextBlock.FontSize = 24;
                    //        resultTextBlock.Foreground = blackColor;
                    //        grid.Children.Add(resultTextBlock);

                    //    }
                    //    TextBlock prizeTextBlock = new();
                    //    prizeTextBlock.Text = "Prêmio: R$" + String.Format("{0:0.00}", lotoF.Prize);
                    //    prizeTextBlock.Margin = new Thickness(0, 30, 46, 0);
                    //    prizeTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                    //    prizeTextBlock.VerticalAlignment = VerticalAlignment.Top;
                    //    prizeTextBlock.FontSize = 32;
                    //    prizeTextBlock.Foreground = blackColor;
                    //    grid.Children.Add(prizeTextBlock);
                    //    TextBlock startDateTextBlock = new();
                    //    startDateTextBlock.Text = "Data de Início: " + lotoF.StartTime.ToString("dd/MM/yyyy");
                    //    startDateTextBlock.Margin = new Thickness(0, 0, 46, 26);
                    //    startDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                    //    startDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                    //    startDateTextBlock.FontSize = 24;
                    //    startDateTextBlock.Foreground = blackColor;
                    //    grid.Children.Add(startDateTextBlock);
                    //    TextBlock endDateTextBlock = new();
                    //    endDateTextBlock.Text = "Data de Início: " + lotoF.EndTime.ToString("dd/MM/yyyy");
                    //    endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
                    //    endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
                    //    endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                    //    endDateTextBlock.FontSize = 24;
                    //    endDateTextBlock.Foreground = blackColor;
                    //    grid.Children.Add(endDateTextBlock);

                    //    childrenHolder.Children.Add(grid);
                    //    childrenHolder.Children.Add(fillerGrid);
                    //}
                    break;
            }
        }

        private void ChangingToLight(object sender, RoutedEventArgs e)
        {
            mainColor.Background = lightMainColor;
            secondColor.Background = lightSecondColor;
            titleColor.Foreground = lightTitleColor;
            titleColor.Background = lightMainColor;
            Busca.Background = lightMainColor;
            Busca.BorderBrush = blackColor;
            mainColor.Height = 120;
            titleBorder.BorderThickness = lightThickness;
            auxDiv.Background = lightMainColor;
            
        }

        private void ChangingToDark(object sender, RoutedEventArgs e)
        {
            mainColor.Background = darkMainColor;
            secondColor.Background = darkSecondColor;
            titleColor.Foreground = darkTitleColor;
            titleColor.Background = darkMainColor;
            Busca.Background = whiteColor;
            Busca.BorderBrush = whiteColor;
            mainColor.Height = 128;
            titleBorder.BorderThickness = darkThickness;
            auxDiv.Background = darkMainColor;
        }

        private void kbFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                //If nothing has been entered yet.
                if (((TextBox)sender).Foreground == pseudoBlackColor)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).Foreground = blackColor;
                }
            }
        }


        private void KbLostFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            //Make sure sender is the correct Control.
            if (sender is TextBox)
            {
                //If nothing was entered, reset default text.
                if (((TextBox)sender).Text.Trim().Equals(""))
                {
                    ((TextBox)sender).Foreground = pseudoBlackColor;
                    ((TextBox)sender).Text = "Busca";
                }
            }
        }

        private void Results_Click(object sender, RoutedEventArgs e)
        {
            statisticsWindow.Visibility = Visibility.Collapsed;
            resultsWindow.Visibility = Visibility.Visible;

        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            resultsWindow.Visibility = Visibility.Collapsed;
            statisticsWindow.Visibility = Visibility.Visible;
        }

        private void RandomNumber_Click(object sender, RoutedEventArgs e)
        {
            randomNumber.Foreground = blackColor;
            randomNumber.Content = "01 02 03 04 05 06";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
