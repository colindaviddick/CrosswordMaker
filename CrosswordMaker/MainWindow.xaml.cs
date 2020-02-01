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

namespace CrosswordMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox[,] crosswordGrid = new TextBox[12, 12];


        char[,] defaultGame = new char[,]
        {
             {'A','B','C','D','E','F','G','H','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','H','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','H','I','~','K','L','M'},
             {'A','B','C','D','E','F','G','H','I','~','K','L','M'},
             {'A','B','C','D','~','F','G','H','I','~','K','L','M'},
             {'A','B','C','D','E','F','G','H','I','~','K','L','M'},
             {'A','B','C','D','E','F','G','~','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','~','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','~','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','~','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','~','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','H','I','J','K','L','M'},
             {'A','B','C','D','E','F','G','H','I','J','K','L','M'}
        };

        public MainWindow()
        {
            InitializeComponent();
            CreateGrid();
        }

        private void CreateGrid()
        {
            crosswordGrid[0, 0] = A1;
            crosswordGrid[0, 1] = A2;
            crosswordGrid[0, 2] = A3;
            crosswordGrid[0, 3] = A4;
            crosswordGrid[0, 4] = A5;
            crosswordGrid[0, 5] = A6;
            crosswordGrid[0, 6] = A7;
            crosswordGrid[0, 7] = A8;
            crosswordGrid[0, 8] = A9;
            crosswordGrid[0, 9] = A10;
            crosswordGrid[0, 10] = A11;
            crosswordGrid[0, 11] = A12;
            crosswordGrid[0, 12] = A13;

            crosswordGrid[1, 0] = B1;
            crosswordGrid[1, 1] = B2;
            crosswordGrid[1, 2] = B3;
            crosswordGrid[1, 3] = B4;
            crosswordGrid[1, 4] = B5;
            crosswordGrid[1, 5] = B6;
            crosswordGrid[1, 6] = B7;
            crosswordGrid[1, 7] = B8;
            crosswordGrid[1, 8] = B9;
            crosswordGrid[1, 9] = B10;
            crosswordGrid[1, 10] = B11;
            crosswordGrid[1, 11] = B12;
            crosswordGrid[1, 12] = B13;

            crosswordGrid[2, 0] = C1;
            crosswordGrid[2, 1] = C2;
            crosswordGrid[2, 2] = C3;
            crosswordGrid[2, 3] = C4;
            crosswordGrid[2, 4] = C5;
            crosswordGrid[2, 5] = C6;
            crosswordGrid[2, 6] = C7;
            crosswordGrid[2, 7] = C8;
            crosswordGrid[2, 8] = C9;
            crosswordGrid[2, 9] = C10;
            crosswordGrid[2, 10] = C11;
            crosswordGrid[2, 11] = C12;
            crosswordGrid[2, 12] = C13;

            crosswordGrid[3, 0] = D1;
            crosswordGrid[3, 1] = D2;
            crosswordGrid[3, 2] = D3;
            crosswordGrid[3, 3] = D4;
            crosswordGrid[3, 4] = D5;
            crosswordGrid[3, 5] = D6;
            crosswordGrid[3, 6] = D7;
            crosswordGrid[3, 7] = D8;
            crosswordGrid[3, 8] = D9;
            crosswordGrid[3, 9] = D10;
            crosswordGrid[3, 10] = D11;
            crosswordGrid[3, 11] = D12;
            crosswordGrid[3, 12] = D13;

            crosswordGrid[4, 0] = E1;
            crosswordGrid[4, 1] = E2;
            crosswordGrid[4, 2] = E3;
            crosswordGrid[4, 3] = E4;
            crosswordGrid[4, 4] = E5;
            crosswordGrid[4, 5] = E6;
            crosswordGrid[4, 6] = E7;
            crosswordGrid[4, 7] = E8;
            crosswordGrid[4, 8] = E9;
            crosswordGrid[4, 9] = E10;
            crosswordGrid[4, 10] = E11;
            crosswordGrid[4, 11] = E12;
            crosswordGrid[4, 12] = E13;

            crosswordGrid[5, 0] = F1;
            crosswordGrid[5, 1] = F2;
            crosswordGrid[5, 2] = F3;
            crosswordGrid[5, 3] = F4;
            crosswordGrid[5, 4] = F5;
            crosswordGrid[5, 5] = F6;
            crosswordGrid[5, 6] = F7;
            crosswordGrid[5, 7] = F8;
            crosswordGrid[5, 8] = F9;
            crosswordGrid[5, 9] = F10;
            crosswordGrid[5, 10] = F11;
            crosswordGrid[5, 11] = F12;
            crosswordGrid[5, 12] = F13;

            crosswordGrid[6, 0] = G1;
            crosswordGrid[6, 1] = G2;
            crosswordGrid[6, 2] = G3;
            crosswordGrid[6, 3] = G4;
            crosswordGrid[6, 4] = G5;
            crosswordGrid[6, 5] = G6;
            crosswordGrid[6, 6] = G7;
            crosswordGrid[6, 7] = G8;
            crosswordGrid[6, 8] = G9;
            crosswordGrid[6, 9] = G10;
            crosswordGrid[6, 10] = G11;
            crosswordGrid[6, 11] = G12;
            crosswordGrid[6, 12] = G13;

            crosswordGrid[7, 0] = H1;
            crosswordGrid[7, 1] = H2;
            crosswordGrid[7, 2] = H3;
            crosswordGrid[7, 3] = H4;
            crosswordGrid[7, 4] = H5;
            crosswordGrid[7, 5] = H6;
            crosswordGrid[7, 6] = H7;
            crosswordGrid[7, 7] = H8;
            crosswordGrid[7, 8] = H9;
            crosswordGrid[7, 9] = H10;
            crosswordGrid[7, 10] = H11;
            crosswordGrid[7, 11] = H12;
            crosswordGrid[7, 12] = H13;

            crosswordGrid[8, 0] = I1;
            crosswordGrid[8, 1] = I2;
            crosswordGrid[8, 2] = I3;
            crosswordGrid[8, 3] = I4;
            crosswordGrid[8, 4] = I5;
            crosswordGrid[8, 5] = I6;
            crosswordGrid[8, 6] = I7;
            crosswordGrid[8, 7] = I8;
            crosswordGrid[8, 8] = I9;
            crosswordGrid[8, 9] = I10;
            crosswordGrid[8, 10] = I11;
            crosswordGrid[8, 11] = I12;
            crosswordGrid[8, 12] = I13;

            crosswordGrid[9, 0] = J1;
            crosswordGrid[9, 1] = J2;
            crosswordGrid[9, 2] = J3;
            crosswordGrid[9, 3] = J4;
            crosswordGrid[9, 4] = J5;
            crosswordGrid[9, 5] = J6;
            crosswordGrid[9, 6] = J7;
            crosswordGrid[9, 7] = J8;
            crosswordGrid[9, 8] = J9;
            crosswordGrid[9, 9] = J10;
            crosswordGrid[9, 10] = J11;
            crosswordGrid[9, 11] = J12;
            crosswordGrid[9, 12] = J13;

            crosswordGrid[10, 0] = K1;
            crosswordGrid[10, 1] = K2;
            crosswordGrid[10, 2] = K3;
            crosswordGrid[10, 3] = K4;
            crosswordGrid[10, 4] = K5;
            crosswordGrid[10, 5] = K6;
            crosswordGrid[10, 6] = K7;
            crosswordGrid[10, 7] = K8;
            crosswordGrid[10, 8] = K9;
            crosswordGrid[10, 9] = K10;
            crosswordGrid[10, 10] = K11;
            crosswordGrid[10, 11] = K12;
            crosswordGrid[10, 12] = K13;

            crosswordGrid[11, 0] = L1;
            crosswordGrid[11, 1] = L2;
            crosswordGrid[11, 2] = L3;
            crosswordGrid[11, 3] = L4;
            crosswordGrid[11, 4] = L5;
            crosswordGrid[11, 5] = L6;
            crosswordGrid[11, 6] = L7;
            crosswordGrid[11, 7] = L8;
            crosswordGrid[11, 8] = L9;
            crosswordGrid[11, 9] = L10;
            crosswordGrid[11, 10] = L11;
            crosswordGrid[11, 11] = L12;
            crosswordGrid[11, 12] = L13;

            crosswordGrid[12, 0] = M1;
            crosswordGrid[12, 1] = M2;
            crosswordGrid[12, 2] = M3;
            crosswordGrid[12, 3] = M4;
            crosswordGrid[12, 4] = M5;
            crosswordGrid[12, 5] = M6;
            crosswordGrid[12, 6] = M7;
            crosswordGrid[12, 7] = M8;
            crosswordGrid[12, 8] = M9;
            crosswordGrid[12, 9] = M10;
            crosswordGrid[12, 10] = M11;
            crosswordGrid[12, 11] = M12;
            crosswordGrid[12, 12] = M13;

            A1.Text = defaultGame[0, 0].ToString();
            A2.Text = defaultGame[0, 1].ToString();
            A3.Text = defaultGame[0, 2].ToString();
            A4.Text = defaultGame[0, 3].ToString();
            A5.Text = defaultGame[0, 4].ToString();
            A6.Text = defaultGame[0, 5].ToString();
            A7.Text = defaultGame[0, 6].ToString();
            A8.Text = defaultGame[0, 7].ToString();
            A9.Text = defaultGame[0, 8].ToString();
            A10.Text = defaultGame[0, 9].ToString();
            A11.Text = defaultGame[0, 10].ToString();
            A12.Text = defaultGame[0, 11].ToString();
            A13.Text = defaultGame[0, 12].ToString();

            B1.Text = defaultGame[1, 0].ToString();
            B2.Text = defaultGame[1, 1].ToString();
            B3.Text = defaultGame[1, 2].ToString();
            B4.Text = defaultGame[1, 3].ToString();
            B5.Text = defaultGame[1, 4].ToString();
            B6.Text = defaultGame[1, 5].ToString();
            B7.Text = defaultGame[1, 6].ToString();
            B8.Text = defaultGame[1, 7].ToString();
            B9.Text = defaultGame[1, 8].ToString();
            B10.Text = defaultGame[1, 9].ToString();
            B11.Text = defaultGame[1, 10].ToString();
            B12.Text = defaultGame[1, 11].ToString();
            B13.Text = defaultGame[1, 12].ToString();

            C1.Text = defaultGame[2, 0].ToString();
            C2.Text = defaultGame[2, 1].ToString();
            C3.Text = defaultGame[2, 2].ToString();
            C4.Text = defaultGame[2, 3].ToString();
            C5.Text = defaultGame[2, 4].ToString();
            C6.Text = defaultGame[2, 5].ToString();
            C7.Text = defaultGame[2, 6].ToString();
            C8.Text = defaultGame[2, 7].ToString();
            C9.Text = defaultGame[2, 8].ToString();
            C10.Text = defaultGame[2, 9].ToString();
            C11.Text = defaultGame[2, 10].ToString();
            C12.Text = defaultGame[2, 11].ToString();
            C13.Text = defaultGame[2, 12].ToString();

            D1.Text = defaultGame[3, 0].ToString();
            D2.Text = defaultGame[3, 1].ToString();
            D3.Text = defaultGame[3, 2].ToString();
            D4.Text = defaultGame[3, 3].ToString();
            D5.Text = defaultGame[3, 4].ToString();
            D6.Text = defaultGame[3, 5].ToString();
            D7.Text = defaultGame[3, 6].ToString();
            D8.Text = defaultGame[3, 7].ToString();
            D9.Text = defaultGame[3, 8].ToString();
            D10.Text = defaultGame[3, 9].ToString();
            D11.Text = defaultGame[3, 10].ToString();
            D12.Text = defaultGame[3, 11].ToString();
            D13.Text = defaultGame[3, 12].ToString();

            E1.Text = defaultGame[4, 0].ToString();
            E2.Text = defaultGame[4, 1].ToString();
            E3.Text = defaultGame[4, 2].ToString();
            E4.Text = defaultGame[4, 3].ToString();
            E5.Text = defaultGame[4, 4].ToString();
            E6.Text = defaultGame[4, 5].ToString();
            E7.Text = defaultGame[4, 6].ToString();
            E8.Text = defaultGame[4, 7].ToString();
            E9.Text = defaultGame[4, 8].ToString();
            E10.Text = defaultGame[4, 9].ToString();
            E11.Text = defaultGame[4, 10].ToString();
            E12.Text = defaultGame[4, 11].ToString();
            E13.Text = defaultGame[4, 12].ToString();

            F1.Text = defaultGame[5, 0].ToString();
            F2.Text = defaultGame[5, 1].ToString();
            F3.Text = defaultGame[5, 2].ToString();
            F4.Text = defaultGame[5, 3].ToString();
            F5.Text = defaultGame[5, 4].ToString();
            F6.Text = defaultGame[5, 5].ToString();
            F7.Text = defaultGame[5, 6].ToString();
            F8.Text = defaultGame[5, 7].ToString();
            F9.Text = defaultGame[5, 8].ToString();
            F10.Text = defaultGame[5, 9].ToString();
            F11.Text = defaultGame[5, 10].ToString();
            F12.Text = defaultGame[5, 11].ToString();
            F13.Text = defaultGame[5, 12].ToString();

            G1.Text = defaultGame[6, 0].ToString();
            G2.Text = defaultGame[6, 1].ToString();
            G3.Text = defaultGame[6, 2].ToString();
            G4.Text = defaultGame[6, 3].ToString();
            G5.Text = defaultGame[6, 4].ToString();
            G6.Text = defaultGame[6, 5].ToString();
            G7.Text = defaultGame[6, 6].ToString();
            G8.Text = defaultGame[6, 7].ToString();
            G9.Text = defaultGame[6, 8].ToString();
            G10.Text = defaultGame[6, 9].ToString();
            G11.Text = defaultGame[6, 10].ToString();
            G12.Text = defaultGame[6, 11].ToString();
            G13.Text = defaultGame[6, 12].ToString();

            H1.Text = defaultGame[7, 0].ToString();
            H2.Text = defaultGame[7, 1].ToString();
            H3.Text = defaultGame[7, 2].ToString();
            H4.Text = defaultGame[7, 3].ToString();
            H5.Text = defaultGame[7, 4].ToString();
            H6.Text = defaultGame[7, 5].ToString();
            H7.Text = defaultGame[7, 6].ToString();
            H8.Text = defaultGame[7, 7].ToString();
            H9.Text = defaultGame[7, 8].ToString();
            H10.Text = defaultGame[7, 9].ToString();
            H11.Text = defaultGame[7, 10].ToString();
            H12.Text = defaultGame[7, 11].ToString();
            H13.Text = defaultGame[7, 12].ToString();

            I1.Text = defaultGame[8, 0].ToString();
            I2.Text = defaultGame[8, 1].ToString();
            I3.Text = defaultGame[8, 2].ToString();
            I4.Text = defaultGame[8, 3].ToString();
            I5.Text = defaultGame[8, 4].ToString();
            I6.Text = defaultGame[8, 5].ToString();
            I7.Text = defaultGame[8, 6].ToString();
            I8.Text = defaultGame[8, 7].ToString();
            I9.Text = defaultGame[8, 8].ToString();
            I10.Text = defaultGame[8, 9].ToString();
            I11.Text = defaultGame[8, 10].ToString();
            I12.Text = defaultGame[8, 11].ToString();
            I13.Text = defaultGame[8, 12].ToString();

            J1.Text = defaultGame[9, 0].ToString();
            J2.Text = defaultGame[9, 1].ToString();
            J3.Text = defaultGame[9, 2].ToString();
            J4.Text = defaultGame[9, 3].ToString();
            J5.Text = defaultGame[9, 4].ToString();
            J6.Text = defaultGame[9, 5].ToString();
            J7.Text = defaultGame[9, 6].ToString();
            J8.Text = defaultGame[9, 7].ToString();
            J9.Text = defaultGame[9, 8].ToString();
            J10.Text = defaultGame[9, 9].ToString();
            J11.Text = defaultGame[9, 10].ToString();
            J12.Text = defaultGame[9, 11].ToString();
            J13.Text = defaultGame[9, 12].ToString();

            K1.Text = defaultGame[10, 0].ToString();
            K2.Text = defaultGame[10, 1].ToString();
            K3.Text = defaultGame[10, 2].ToString();
            K4.Text = defaultGame[10, 3].ToString();
            K5.Text = defaultGame[10, 4].ToString();
            K6.Text = defaultGame[10, 5].ToString();
            K7.Text = defaultGame[10, 6].ToString();
            K8.Text = defaultGame[10, 7].ToString();
            K9.Text = defaultGame[10, 8].ToString();
            K10.Text = defaultGame[10, 9].ToString();
            K11.Text = defaultGame[10, 10].ToString();
            K12.Text = defaultGame[10, 11].ToString();
            K13.Text = defaultGame[10, 12].ToString();

            L1.Text = defaultGame[11, 0].ToString();
            L2.Text = defaultGame[11, 1].ToString();
            L3.Text = defaultGame[11, 2].ToString();
            L4.Text = defaultGame[11, 3].ToString();
            L5.Text = defaultGame[11, 4].ToString();
            L6.Text = defaultGame[11, 5].ToString();
            L7.Text = defaultGame[11, 6].ToString();
            L8.Text = defaultGame[11, 7].ToString();
            L9.Text = defaultGame[11, 8].ToString();
            L10.Text = defaultGame[11, 9].ToString();
            L11.Text = defaultGame[11, 10].ToString();
            L12.Text = defaultGame[11, 11].ToString();
            L13.Text = defaultGame[11, 12].ToString();

            M1.Text = defaultGame[12, 0].ToString();
            M2.Text = defaultGame[12, 1].ToString();
            M3.Text = defaultGame[12, 2].ToString();
            M4.Text = defaultGame[12, 3].ToString();
            M5.Text = defaultGame[12, 4].ToString();
            M6.Text = defaultGame[12, 5].ToString();
            M7.Text = defaultGame[12, 6].ToString();
            M8.Text = defaultGame[12, 7].ToString();
            M9.Text = defaultGame[12, 8].ToString();
            M10.Text = defaultGame[12, 9].ToString();
            M11.Text = defaultGame[12, 10].ToString();
            M12.Text = defaultGame[12, 11].ToString();
            M13.Text = defaultGame[12, 12].ToString();
        }
    }
}
