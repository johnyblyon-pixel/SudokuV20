using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace sudoku_practice
{


    public partial class Form2 : Form
    {
        private TextBox[,] sudokuTextBoxes = new TextBox[9, 9];
        private int[,] sudokuGrid = new int[9, 9];
        private int[,] initpuzzle = new int[9, 9];

        private int secondsElapsed = 0;
        public Form2()
        {
            InitializeComponent();

            CreateSudokuGrid();

            gametime.Start();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Control cell in panelGrid.Controls)
            {
                if (cell is TextBox)
                {
                    cell.KeyPress += CharLimit;
                }
            }
        }





        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateSudokuGrid()
        {
            int cellsize = 40;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    TextBox tb = new TextBox() // sets the properties for the Textboxes
                    {
                        Width = cellsize,
                        Height = cellsize,
                        Multiline = true,
                        MaxLength = 1,                        
                        Font = new Font("Segoe UI", 18),
                        TextAlign = HorizontalAlignment.Center,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(col * cellsize, row * cellsize)
                    };

                    if (((row / 3) + (col / 3)) % 2 == 0)
                        tb.BackColor = Color.LightGray;

                    tb.Tag = tb.BackColor; // Store original color

                    tb.MouseEnter += SudokuTextBox_MouseEnter;
                    tb.MouseLeave += SudokuTextBox_MouseLeave;

                    panelGrid.Controls.Add(tb); // adds the Textboxes tb to the panelgrid controlls
                    sudokuTextBoxes[row, col] = tb;
                }
            }
        }

        // allow only 1-9 to be entered
        private void CharLimit(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && ((!char.IsDigit(e.KeyChar)) || (e.KeyChar == '0')))
            { e.Handled = true; }
        }



        private void SudokuTextBox_MouseEnter(object sender, EventArgs e) // highlighting the textbox when the mouse hovers over it
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.BackColor = Color.LightBlue;
            }
        }
        private void SudokuTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.Tag is Color originalColor)
            {
                tb.BackColor = originalColor;
            }
        }




        public void Starter( ) // calls the FillGrid subroutine in the first position of the Grid
        {
            FillGrid(0, 0);
        }

        public bool FillGrid(int row, int col)
        {
            if (row == 9)
                return true; // Finished

            int nextRow = (col == 8) ? row + 1 : row;
            int nextCol = (col + 1) % 9;
            
            List<int> candidates = Shuffled();            
            foreach (int num in candidates)
            {
                if (CheckValid(row, col, num))
                {
                    sudokuGrid[row, col] = num;
                    //sudokuTextBoxes[row, col].Text = num.ToString();
                    if (FillGrid(nextRow, nextCol))
                    {
                        return true; // calls subroutine recursively for the next row & column
                    }
                    // Backtracks
                    sudokuGrid[row, col] = 0;
                    //sudokuTextBoxes[row, col].Text = "";
                }
            }



            return false; // No valid number found, trigger backtracking
        }

        public bool CheckValid(int row, int column, int num) // checks if the number is valid in the current position
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudokuGrid[row, i] == num)
                {
                    return false;
                }
                if (sudokuGrid[i, column] == num)
                {
                    return false;
                }

                
                int boxRowStart = (row / 3) * 3;
                int boxColStart = (column / 3) * 3;
                for (int r = boxRowStart; r < boxRowStart + 3; r++)
                {
                    for (int c = boxColStart; c < boxColStart + 3; c++)
                    {
                        if (sudokuGrid[r, c] == num)
                        {
                            return false;
                        }
                    } 
                }
            }
            return true;
        }

        static List<int> Shuffled()
        {
            bool[] used = new bool[10];// boolean aray used to track which numbers have been used

            List<int> candidates = new List<int>(); // sets up list of candidates
            for (int i = 1; i <= 9; i++)
                    candidates.Add(i);



            // Shuffle candidates for randomness with Fisher Yates Shuffle
            Random rnd = new Random();
            for (int i = candidates.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                int temp = candidates[i];
                candidates[i] = candidates[j];
                candidates[j] = temp;
            }

            return candidates;
        }


        public void RemoveGivens(int givens)
        {
            int[,] sdpuzzle = new int[9, 9]; // temporary puzzle to remove givens from to set up puzzle
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    sdpuzzle[i, j] = sudokuGrid[i, j];


            int clear = 81 - givens; // number of cells to clear

            Random rnd = new Random();
            HashSet<(int, int)> ClearCount = new HashSet<(int, int)>();

            while (ClearCount.Count < clear)
            {
                int row = rnd.Next(0, 9);
                int col = rnd.Next(0, 9);

                if (!ClearCount.Contains((row, col)))
                {
                    ClearCount.Add((row, col));
                    sdpuzzle[row, col] = 0;
                }
            }

            for (int i = 0; i < 9; i++) // I want to make it clear which numbers are givens and which are user input
                for (int j = 0; j < 9; j++)
                {
                    TextBox tb = sudokuTextBoxes[i, j];
                    if (sdpuzzle[i, j] != 0)
                    {
                        sudokuTextBoxes[i, j].Text = sdpuzzle[i, j].ToString();
                        tb.Font = new Font(tb.Font, FontStyle.Bold);                        
                    }
                }
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {                    
                    TextBox tb = sudokuTextBoxes[row, col];
                    if (int.TryParse(tb.Text, out int userValue))
                    {                        
                        if (userValue != sudokuGrid[row, col])
                        {
                            tb.ForeColor = Color.Red; // Incorrect input
                        }
                        else
                        {
                            tb.ForeColor = Color.Black; // Correct input
                        }
                    }
                }
            }
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }
        private void Restart() 
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    sudokuGrid[row, col] = 0;
                    sudokuTextBoxes[row, col].Text = "";
                    TextBox tb = sudokuTextBoxes[row, col];
                    
                    tb.Font = new Font("Segoe UI", 18);
                }
            }
        }
        private void btnEasy_Click(object sender, EventArgs e)
        {
            Restart();
            int givens = 81;
            Starter();
            RemoveGivens(givens);
            // easy > 35–45 
        }
        private void btnIntermediate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Restart();
            int givens = rnd.Next(25,30);
            Starter();
            RemoveGivens(givens);
            // intermediate > 25–30
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Restart();
            int givens = 20;
            Starter();
            RemoveGivens(givens);
            // Hard > 20–25
        }
        private void gametime_Tick(object sender, EventArgs e)
        {
            gametime.Interval = 1000; 
            secondsElapsed++;
            lblTimer.Text = "Time: " + secondsElapsed.ToString() + "s";
        }
        private void lblTimer_Click(object sender, EventArgs e)
        {
            //this.Controls.Add(lblTimer);            
        }
    }
}
