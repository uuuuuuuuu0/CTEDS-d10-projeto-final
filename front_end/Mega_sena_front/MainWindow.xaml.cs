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
        public SolidColorBrush grayColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#494949"));
        public SolidColorBrush pseudoBlackColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000001"));

        public Thickness lightThickness = new Thickness(0, 4, 0, 4);
        public Thickness darkThickness = new Thickness(0, 0, 0, 0);

        private readonly Context context;
        private Search search;
        private string currentLottery;
        private bool inSearch = false;

        private Grid createFillerGrid()
        {
            Grid fillerGrid = new();
            fillerGrid.Height = 40;
            fillerGrid.Width = 1600;
            return fillerGrid;
        }

        private Grid createTile(MegaSena megaSena)
        {
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
            endDateTextBlock.Text = "Data de Término: " + megaSena.EndTime.ToString("dd/MM/yyyy");
            endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
            endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            endDateTextBlock.FontSize = 24;
            endDateTextBlock.Foreground = blackColor;
            grid.Children.Add(endDateTextBlock);
            return grid;
        }

        private Grid createTile(LotoFacil lotoF)
        {
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
            endDateTextBlock.Text = "Data de Término: " + lotoF.EndTime.ToString("dd/MM/yyyy");
            endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
            endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            endDateTextBlock.FontSize = 24;
            endDateTextBlock.Foreground = blackColor;
            grid.Children.Add(endDateTextBlock);
            return grid;
        }

        private Grid createTile(Quina quina)
        {
            Grid grid = new();
            grid.Margin = new Thickness(0, 40, 0, 0);
            grid.Width = 1400;
            grid.Height = 180;
            grid.Background = whiteColor;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Top;

            TextBlock nameTextBlock = new();
            nameTextBlock.Text = "Quina (" + quina.Id + ")";
            nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
            nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
            nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
            nameTextBlock.FontSize = 32;
            nameTextBlock.Foreground = blackColor;
            grid.Children.Add(nameTextBlock);
            TextBlock statusTextBlock = new();
            statusTextBlock.Text = "Status: " + quina.Status;
            statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
            statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
            statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            statusTextBlock.FontSize = 24;
            statusTextBlock.Foreground = blackColor;
            grid.Children.Add(statusTextBlock);
            if (quina.Result != null)
            {
                TextBlock resultTextBlock = new();
                resultTextBlock.Text = "Números: " + quina.Result[0] + quina.Result[1] + " " +
                                                       quina.Result[2] + quina.Result[3] + " " +
                                                       quina.Result[4] + quina.Result[5] + " " +
                                                       quina.Result[6] + quina.Result[7] + " " +
                                                       quina.Result[8] + quina.Result[9];
                resultTextBlock.Margin = new Thickness(46, 0, 0, 26);
                resultTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                resultTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                resultTextBlock.FontSize = 24;
                resultTextBlock.Foreground = blackColor;
                grid.Children.Add(resultTextBlock);

            }
            TextBlock prizeTextBlock = new();
            prizeTextBlock.Text = "Prêmio: R$" + String.Format("{0:0.00}", quina.Prize);
            prizeTextBlock.Margin = new Thickness(0, 30, 46, 0);
            prizeTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            prizeTextBlock.VerticalAlignment = VerticalAlignment.Top;
            prizeTextBlock.FontSize = 32;
            prizeTextBlock.Foreground = blackColor;
            grid.Children.Add(prizeTextBlock);
            TextBlock startDateTextBlock = new();
            startDateTextBlock.Text = "Data de Início: " + quina.StartTime.ToString("dd/MM/yyyy");
            startDateTextBlock.Margin = new Thickness(0, 0, 46, 26);
            startDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            startDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            startDateTextBlock.FontSize = 24;
            startDateTextBlock.Foreground = blackColor;
            grid.Children.Add(startDateTextBlock);
            TextBlock endDateTextBlock = new();
            endDateTextBlock.Text = "Data de Término: " + quina.EndTime.ToString("dd/MM/yyyy");
            endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
            endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            endDateTextBlock.FontSize = 24;
            endDateTextBlock.Foreground = blackColor;
            grid.Children.Add(endDateTextBlock);
            return grid;
        }

        private Grid createTile(Lotomania lotomania)
        {
            Grid grid = new();
            grid.Margin = new Thickness(0, 40, 0, 0);
            grid.Width = 1400;
            grid.Height = 180;
            grid.Background = whiteColor;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Top;

            TextBlock nameTextBlock = new();
            nameTextBlock.Text = "Lotomania (" + lotomania.Id + ")";
            nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
            nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
            nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
            nameTextBlock.FontSize = 32;
            nameTextBlock.Foreground = blackColor;
            grid.Children.Add(nameTextBlock);
            TextBlock statusTextBlock = new();
            statusTextBlock.Text = "Status: " + lotomania.Status;
            statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
            statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
            statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            statusTextBlock.FontSize = 24;
            statusTextBlock.Foreground = blackColor;
            grid.Children.Add(statusTextBlock);
            if (lotomania.Result != null)
            {
                TextBlock resultTextBlock = new();
                resultTextBlock.Text = "Números: " + lotomania.Result[0] + lotomania.Result[1] + " " +
                                                       lotomania.Result[2] + lotomania.Result[3] + " " +
                                                       lotomania.Result[4] + lotomania.Result[5] + " " +
                                                       lotomania.Result[6] + lotomania.Result[7] + " " +
                                                       lotomania.Result[8] + lotomania.Result[9] + " " +
                                                       lotomania.Result[10] + lotomania.Result[11] + " " +
                                                       lotomania.Result[12] + lotomania.Result[13] + " " +
                                                       lotomania.Result[14] + lotomania.Result[15] + " " +
                                                       lotomania.Result[16] + lotomania.Result[17] + " " +
                                                       lotomania.Result[18] + lotomania.Result[19] + " " +
                                                       lotomania.Result[20] + lotomania.Result[21] + " " +
                                                       lotomania.Result[22] + lotomania.Result[23] + " " +
                                                       lotomania.Result[24] + lotomania.Result[25] + " " +
                                                       lotomania.Result[26] + lotomania.Result[27] + " " +
                                                       lotomania.Result[28] + lotomania.Result[29] + " " +
                                                       lotomania.Result[30] + lotomania.Result[31] + " " +
                                                       lotomania.Result[32] + lotomania.Result[33] + " " +
                                                       lotomania.Result[34] + lotomania.Result[35] + " " +
                                                       lotomania.Result[36] + lotomania.Result[37] + " " +
                                                       lotomania.Result[38] + lotomania.Result[39];

                resultTextBlock.Margin = new Thickness(46, 0, 0, 26);
                resultTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                resultTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                resultTextBlock.FontSize = 24;
                resultTextBlock.Foreground = blackColor;
                grid.Children.Add(resultTextBlock);

            }
            TextBlock prizeTextBlock = new();
            prizeTextBlock.Text = "Prêmio: R$" + String.Format("{0:0.00}", lotomania.Prize);
            prizeTextBlock.Margin = new Thickness(0, 30, 46, 0);
            prizeTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            prizeTextBlock.VerticalAlignment = VerticalAlignment.Top;
            prizeTextBlock.FontSize = 32;
            prizeTextBlock.Foreground = blackColor;
            grid.Children.Add(prizeTextBlock);
            TextBlock startDateTextBlock = new();
            startDateTextBlock.Text = "Data de Início: " + lotomania.StartTime.ToString("dd/MM/yyyy");
            startDateTextBlock.Margin = new Thickness(0, 0, 46, 26);
            startDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            startDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            startDateTextBlock.FontSize = 24;
            startDateTextBlock.Foreground = blackColor;
            grid.Children.Add(startDateTextBlock);
            TextBlock endDateTextBlock = new();
            endDateTextBlock.Text = "Data de Término: " + lotomania.EndTime.ToString("dd/MM/yyyy");
            endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
            endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            endDateTextBlock.FontSize = 24;
            endDateTextBlock.Foreground = blackColor;
            grid.Children.Add(endDateTextBlock);
            return grid;
        }

        private Grid createTile(DuplaSena duplaSena)
        {
            Grid grid = new();
            grid.Margin = new Thickness(0, 40, 0, 0);
            grid.Width = 1400;
            grid.Height = 196;
            grid.Background = whiteColor;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Top;

            TextBlock nameTextBlock = new();
            nameTextBlock.Text = "Mega-Sena (" + duplaSena.Id + ")";
            nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
            nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
            nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
            nameTextBlock.FontSize = 32;
            nameTextBlock.Foreground = blackColor;
            grid.Children.Add(nameTextBlock);
            TextBlock statusTextBlock = new();
            statusTextBlock.Text = "Status: " + duplaSena.Status;
            statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
            statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
            statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            statusTextBlock.FontSize = 24;
            statusTextBlock.Foreground = blackColor;
            grid.Children.Add(statusTextBlock);
            if (duplaSena.Result != null)
            {
                TextBlock resultTextBlock1 = new();
                resultTextBlock1.Text = "1º sorteio: " + duplaSena.Result[0] + duplaSena.Result[1] + " " +
                                                       duplaSena.Result[2] + duplaSena.Result[3] + " " +
                                                       duplaSena.Result[4] + duplaSena.Result[5] + " " +
                                                       duplaSena.Result[6] + duplaSena.Result[7] + " " +
                                                       duplaSena.Result[8] + duplaSena.Result[9] + " " +
                                                       duplaSena.Result[10] + duplaSena.Result[11];
                resultTextBlock1.Margin = new Thickness(46, 0, 0, 26);
                resultTextBlock1.HorizontalAlignment = HorizontalAlignment.Left;
                resultTextBlock1.VerticalAlignment = VerticalAlignment.Bottom;
                resultTextBlock1.FontSize = 24;
                resultTextBlock1.Foreground = blackColor;
                grid.Children.Add(resultTextBlock1);

                TextBlock resultTextBlock2 = new();
                resultTextBlock2.Text = "2º sorteio: " + duplaSena.Result[12] + duplaSena.Result[13] + " " +
                                                       duplaSena.Result[14] + duplaSena.Result[15] + " " +
                                                       duplaSena.Result[16] + duplaSena.Result[17] + " " +
                                                       duplaSena.Result[18] + duplaSena.Result[19] + " " +
                                                       duplaSena.Result[20] + duplaSena.Result[21] + " " +
                                                       duplaSena.Result[22] + duplaSena.Result[23];
                resultTextBlock2.Margin = new Thickness(46, 0, 0, 36);
                resultTextBlock2.HorizontalAlignment = HorizontalAlignment.Left;
                resultTextBlock2.VerticalAlignment = VerticalAlignment.Bottom;
                resultTextBlock2.FontSize = 24;
                resultTextBlock2.Foreground = blackColor;
                grid.Children.Add(resultTextBlock2);

            }
            TextBlock prizeTextBlock = new();
            prizeTextBlock.Text = "Prêmio: R$" + String.Format("{0:0.00}", duplaSena.Prize);
            prizeTextBlock.Margin = new Thickness(0, 30, 46, 0);
            prizeTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            prizeTextBlock.VerticalAlignment = VerticalAlignment.Top;
            prizeTextBlock.FontSize = 32;
            prizeTextBlock.Foreground = blackColor;
            grid.Children.Add(prizeTextBlock);
            TextBlock startDateTextBlock = new();
            startDateTextBlock.Text = "Data de Início: " + duplaSena.StartTime.ToString("dd/MM/yyyy");
            startDateTextBlock.Margin = new Thickness(0, 0, 46, 26);
            startDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            startDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            startDateTextBlock.FontSize = 24;
            startDateTextBlock.Foreground = blackColor;
            grid.Children.Add(startDateTextBlock);
            TextBlock endDateTextBlock = new();
            endDateTextBlock.Text = "Data de Término: " + duplaSena.EndTime.ToString("dd/MM/yyyy");
            endDateTextBlock.Margin = new Thickness(0, 0, 46, 64);
            endDateTextBlock.HorizontalAlignment = HorizontalAlignment.Right;
            endDateTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
            endDateTextBlock.FontSize = 24;
            endDateTextBlock.Foreground = blackColor;
            grid.Children.Add(endDateTextBlock);
            return grid;
        }

        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
            context.SaveChanges();

            search = new(context);
            currentLottery = "MegaSena";

            Busca.Text = "Busca";
            Busca.Foreground = pseudoBlackColor;

            foreach (MegaSena megaSena in context.megaSenas)
            {
                childrenHolder.Children.Add(createTile(megaSena));
                childrenHolder.Children.Add(createFillerGrid());
            }
            if (childHolderTwo != null)
            {
                MegaSena[] megaSenass = new MegaSena[3];
                int i = 0;
                foreach (MegaSena m in context.megaSenas)
                {
                    megaSenass[i] = m;
                    i++;
                }
                MegaSena[] megaSenasss = Feature.SortByPrize(megaSenass);

                foreach (MegaSena megaSena in megaSenasss)
                {
                    childHolderTwo.Children.Add(createTile(megaSena));
                    childHolderTwo.Children.Add(createFillerGrid());
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem lottery = cbBox.SelectedItem as ComboBoxItem;
            returnButton.Visibility = Visibility.Collapsed;
            inSearch = false;
            switch (lottery.Name)
            {
                case "MegaSena":
                    currentLottery = "MegaSena";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (MegaSena megaSena in context.megaSenas)
                        {
                            childrenHolder.Children.Add(createTile(megaSena));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                        randomNumber.Foreground = grayColor;
                        randomNumber.Content = "XX XX XX XX XX XX";
                    }
                    if (childHolderTwo != null)
                    {
                        childHolderTwo.Children.Clear();
                        int size = 0;
                        foreach (MegaSena megaSena in context.megaSenas) size++;
                        MegaSena[] megaSenass = new MegaSena[size];
                        int i = 0;
                        foreach (MegaSena m in context.megaSenas)
                        {
                            megaSenass[i] = m;
                            i++;
                        }
                        MegaSena[] megaSenasss = Feature.SortByPrize(megaSenass);

                        foreach (MegaSena megaSena in megaSenasss)
                        {
                            childHolderTwo.Children.Add(createTile(megaSena));
                            childHolderTwo.Children.Add(createFillerGrid());
                        }
                    }
                    break;
                case "Lotofacil":
                    currentLottery = "Lotofacil";
                    if (childrenHolder != null)
                    { 
                        childrenHolder.Children.Clear();
                        foreach (LotoFacil lotoF in context.lotoFacils)
                        {
                            childrenHolder.Children.Add(createTile(lotoF));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                        if (childHolderTwo != null)
                        {
                            childHolderTwo.Children.Clear();
                            int size = 0;
                            foreach (LotoFacil lf in context.lotoFacils) size++;
                            LotoFacil[] lotofacill = new LotoFacil[size];
                            int i = 0;
                            foreach (LotoFacil m in context.lotoFacils)
                            {
                                lotofacill[i] = m;
                                i++;
                            }
                            LotoFacil[] lotofacilll = Feature.SortByPrize(lotofacill);

                            foreach (LotoFacil lotoF in lotofacilll)
                            {
                                childHolderTwo.Children.Add(createTile(lotoF));
                                childHolderTwo.Children.Add(createFillerGrid());
                            }
                        }
                        randomNumber.Foreground =  grayColor;
                        randomNumber.Content = "XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX";
                    }
                    break;
                case "Quina":
                    currentLottery = "Quina";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (Quina quina in context.quinas)
                        {
                            childrenHolder.Children.Add(createTile(quina));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                        randomNumber.Foreground = grayColor;
                        randomNumber.Content = "XX XX XX XX XX";
                    }
                    if (childHolderTwo != null)
                    {
                        childHolderTwo.Children.Clear();
                        int size = 0;
                        foreach (Quina q in context.quinas) size++;
                        Quina[] quinas = new Quina[size];
                        int i = 0;
                        foreach (Quina q in context.quinas)
                        {
                            quinas[i] = q;
                            i++;
                        }
                        Quina[] quinass = Feature.SortByPrize(quinas);

                        foreach (Quina quina in quinass)
                        {
                            childHolderTwo.Children.Add(createTile(quina));
                            childHolderTwo.Children.Add(createFillerGrid());
                        }
                    }
                    break;
                case "Lotomania":
                    currentLottery = "Quina";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (Lotomania lotomania in context.lotomanias)
                        {
                            childrenHolder.Children.Add(createTile(lotomania));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                        randomNumber.Foreground = grayColor;
                        randomNumber.Content = "XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX";
                    }
                    if (childHolderTwo != null)
                    {
                        childHolderTwo.Children.Clear();
                        int size = 0;
                        foreach (Lotomania lm in context.lotomanias) size++;
                        Lotomania[] lotomanias = new Lotomania[size];
                        int i = 0;
                        foreach (Lotomania m in context.lotomanias)
                        {
                            lotomanias[i] = m;
                            i++;
                        }
                        Lotomania[] lotomaniass = Feature.SortByPrize(lotomanias);

                        foreach (Lotomania lotomania in lotomaniass)
                        {                            
                            childHolderTwo.Children.Add(createTile(lotomania));
                            childHolderTwo.Children.Add(createFillerGrid());
                        }
                    }
                    break;
                case "DuplaSena":
                    currentLottery = "DuplaSena";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (DuplaSena duplaSena in context.duplaSenas)
                        {
                            childrenHolder.Children.Add(createTile(duplaSena));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                        randomNumber.Foreground = grayColor;
                        randomNumber.Content = "XX XX XX XX XX XX";
                    }
                    if (childHolderTwo != null)
                    {
                        childHolderTwo.Children.Clear();
                        DuplaSena[] duplas = new DuplaSena[context.duplaSenas.Count(t => t.Id == '1')];
                        int i = 0;
                        foreach (DuplaSena d in context.duplaSenas)
                        {
                            duplas[i] = d;
                            i++;
                        }
                        DuplaSena[] duplass = Feature.SortByPrize(duplas);
                        foreach (DuplaSena duplaSena in duplass)
                        {
                            childHolderTwo.Children.Add(createTile(duplaSena));
                            childHolderTwo.Children.Add(createFillerGrid());
                        }
                    }
                    break;
                default:
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
            titleTwo.Foreground = blackColor;
            
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
            titleTwo.Foreground = whiteColor;
        }

        private bool emptySearch = true;
        private void kbFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                //If nothing has been entered yet.
                if (((TextBox)sender).Foreground == pseudoBlackColor)
                {
                    ((TextBox)sender).Text = "";
                    emptySearch = false;
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
                    emptySearch = true;
                }
            }
        }

        private void Results_Click(object sender, RoutedEventArgs e)
        {
            statisticsWindow.Visibility = Visibility.Collapsed;
            resultsWindow.Visibility = Visibility.Visible;
            if (inSearch) returnButton.Visibility = Visibility.Visible;
            else returnButton.Visibility = Visibility.Collapsed;
            Busca.Visibility = Visibility.Visible;
            searchButton.Visibility = Visibility.Visible;
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            resultsWindow.Visibility = Visibility.Collapsed;
            statisticsWindow.Visibility = Visibility.Visible;
            returnButton.Visibility = Visibility.Collapsed;
            Busca.Visibility = Visibility.Collapsed;
            searchButton.Visibility = Visibility.Collapsed;
        }

        private void RandomNumber_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem lottery = cbBox.SelectedItem as ComboBoxItem;
            randomNumber.Foreground = blackColor;
            int[] vet = Feature.GenerateSequence(lottery.Name);
            string ran = "";
            int controll = 0;
            foreach (int v in vet) 
            {
                if (controll == 0)
                {
                    ran = ran + v;
                    controll = 1;
                }
                else 
                {
                    ran = ran + " " + v;
                }
            }
            randomNumber.Content = ran;

        }

        private void clipBoard_Click(object sender, RoutedEventArgs e)
        {
            if (randomNumber.Content.ToString()[0] != 'X') Clipboard.SetDataObject(randomNumber.Content);
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!emptySearch)
            {
                inSearch = true;
                resultsWindow.Visibility = Visibility.Visible;
                statisticsWindow.Visibility = Visibility.Collapsed;
                returnButton.Visibility = Visibility.Visible;
                TextBlock textResult = new();
                Grid textHolder = new Grid();

                textResult.Text = "Resultados da pesquisa:";
                textResult.FontSize = 48;
                textResult.Foreground = whiteColor;
                textResult.Padding = new Thickness{Left =  24, Top =  24, Right = 0, Bottom = 32};
               
                childrenHolder.Children.Clear();
                childrenHolder.Children.Add(textResult);

                switch (currentLottery)
                {
                    case "MegaSena":
                        
                        List<MegaSena> megas = search.MegaSenas(Busca.Text);
                        if (megas != null)
                        {
                            foreach (MegaSena megaSena in megas)
                            {
                                childrenHolder.Children.Add(createTile(megaSena));
                                childrenHolder.Children.Add(createFillerGrid());
                            }
                        }
                        break;

                    case "Lotofacil":
                       
                        List<LotoFacil> lfacil = search.LotoFaceis(Busca.Text);
                        if (lfacil != null)
                        {
                            foreach (LotoFacil lf in lfacil)
                            {
                                childrenHolder.Children.Add(createTile(lf));
                                childrenHolder.Children.Add(createFillerGrid());
                            }                           
                        }
                        break;

                    case "Quina":
                        
                        List<Quina> quinas = search.Quinas(Busca.Text);
                        if (quinas != null)
                        {
                            foreach (Quina q in quinas)
                            {
                                childrenHolder.Children.Add(createTile(q));
                                childrenHolder.Children.Add(createFillerGrid());
                            }
                        }
                        break;

                    case "DuplaSena":
                        
                        List<DuplaSena> duplas = search.DuplaSenas(Busca.Text);
                        if (duplas != null)
                        {
                            foreach (DuplaSena d in duplas)
                            {
                                childrenHolder.Children.Add(createTile(d));
                                childrenHolder.Children.Add(createFillerGrid());
                            }
                        }
                        break;

                    case "Lotomania":
                        
                        List<Lotomania> lmanias = search.Lotomanias(Busca.Text);
                        if (lmanias != null)
                        {
                            foreach (Lotomania lm in lmanias)
                            {
                                childrenHolder.Children.Add(createTile(lm));
                                childrenHolder.Children.Add(createFillerGrid());
                            }
                        }
                        break;

                    default:
                        childrenHolder.Children.Clear();
                        TextBlock errorBox = new();
                        errorBox.Text = "Não encontrado";
                        childrenHolder.Children.Add(errorBox);
                        break;
                }
            }
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            childrenHolder.Children.Clear();
            returnButton.Visibility = Visibility.Collapsed;
            inSearch = false;
            switch (currentLottery)
            {
                case "MegaSena":
                    currentLottery = "MegaSena";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (MegaSena megaSena in context.megaSenas)
                        {
                            childrenHolder.Children.Add(createTile(megaSena));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                        randomNumber.Foreground = grayColor;
                        randomNumber.Content = "XX XX XX XX XX XX";
                    }
                    break;
                case "Lotofacil":
                    currentLottery = "Lotofacil";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (LotoFacil lotoF in context.lotoFacils)
                        {
                            childrenHolder.Children.Add(createTile(lotoF));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                    }
                    break;
                case "Quina":
                    currentLottery = "Quina";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (Quina quina in context.quinas)
                        {
                            childrenHolder.Children.Add(createTile(quina));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                        randomNumber.Foreground = grayColor;
                        randomNumber.Content = "XX XX XX XX XX";
                    }
                    break;
                case "Lotomania":
                    currentLottery = "Quina";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (Lotomania lotomania in context.lotomanias)
                        {
                            childrenHolder.Children.Add(createTile(lotomania));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                    }
                    break;
                case "DuplaSena":
                    currentLottery = "DuplaSena";
                    if (childrenHolder != null)
                    {
                        childrenHolder.Children.Clear();
                        foreach (DuplaSena duplaSena in context.duplaSenas)
                        {
                            childrenHolder.Children.Add(createTile(duplaSena));
                            childrenHolder.Children.Add(createFillerGrid());
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
