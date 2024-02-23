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

namespace CE_UAA14WPF24_Ramsamy_Ewan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int nbrL = int.Parse(TextBox.lignes);
            int nbrC = int.Parse(TextBox.colonnes);
            InitializeComponent();
            BtnValider.Click += new RoutedEventHandler(BtnValider_Click);

            if (solitaire is checked() && BtnValider_Click)
            {
                Button[,] buttons = new Button[9, 9];
                ColumnDefinition[] coldef = new ColumnDefinition[9];
                RowDefinition[] ligdef = new RowDefinition[9];

                for (int i = 0;i < 9; i++)
                {
                    coldef[i] = new ColumnDefinition();
                    Main.ColumnDefinitions.Add(coldef[i]);
                    ligdef[i] = new RowDefinition();
                    Main.RowDefinitions.Add(ligdef[i]);
                }

                for (int i = 0;i < 9; i++)
                {
                    for (int j = 0;j < 9; j++)
                    {
                        buttons[i, j] = new Button();
                    }
                }
            }
            else if (marelle is checked() && BtnValider_Click)
            {
                Button[,] buttons = new Button[7, 7];
                ColumnDefinition[] coldef = new ColumnDefinition[7];
                RowDefinition[] ligdef = new RowDefinition[7];

                for (int i = 0; i < 7; i++)
                {
                    coldef[i] = new ColumnDefinition();
                    Main.ColumnDefinitions.Add(coldef[i]);
                    ligdef[i] = new RowDefinition();
                    Main.RowDefinitions.Add(ligdef[i]);
                }

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        buttons[i, j] = new Button();
                    }
                }
            }
            else if (bande is checked() && BtnValider_Click)
            {
                Button[,] buttons = new Button[nbrC, nbrL];
                ColumnDefinition[] coldef = new ColumnDefinition[nbrC];
                RowDefinition[] ligdef = new RowDefinition[nbrL];

                for (int i = 0; i < nbrL; i++)
                {
                    coldef[i] = new ColumnDefinition();
                    Main.ColumnDefinitions.Add(coldef[i]);
                    ligdef[i] = new RowDefinition();
                    Main.RowDefinitions.Add(ligdef[i]);
                }

                for (int i = 0; i < nbrL; i++)
                {
                    for (int j = 0; j < nbrC; j++)
                    {
                        buttons[i, j] = new Button();
                    }
                }
            }
        }
    }
}
