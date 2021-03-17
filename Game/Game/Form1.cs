using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int N = 7;
        private int M = 5;
        const int WIDTH = 47;
        const int HEIGHT = 23;
        const Boolean HINT = true;
        bool[,] light = new bool[1,1];
        Button[,] buttons = new Button[1,1];
        int[,] clicks = new int[1, 1];
        List<Point> moves = new List<Point>();


        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            rest.Visible = true;
            btnUndo.Visible = true;
            btnResize.Visible = true;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    light[i, j] = false;
                    clicks[i, j] = 0;
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(53 * j, 29 * i);
                    buttons[i, j].BackColor = System.Drawing.Color.Black;
                    buttons[i, j].Size = new Size(47, 23);
                    Controls.Add(buttons[i, j]);
                    this.buttons[i, j].Click += new System.EventHandler(this.Button_Click);
                }
            }
            rest.Location = new Point(buttons[0, 0].Location.X, buttons[N - 1, M - 1].Location.Y + 30);
            btnUndo.Location = new Point(rest.Location.X + 63, rest.Location.Y);
            btnResize.Location = new Point(btnUndo.Location.X + 63, btnUndo.Location.Y);
            this.Height = rest.Location.Y + 70;
            this.Width = Math.Max(buttons[N - 1, M - 1].Location.X + 50 + 50,btnResize.Location.X + 100);
        }

        private int checkScoreOfButton(int i, int j)
        {
            int score = 0;
            score += light[i, j] ? -1: 1;
            if (j - 1 >= 0)
                score += light[i, j - 1] ? -1 : 1;
            if (j + 1 < M)
                score += light[i, j + 1] ? -1 : 1;
            if (i - 1 >= 0)
                score += light[i - 1, j] ? -1 : 1;
            if (i + 1 < N)
                score += light[i + 1, j] ? -1 : 1;
            return score;
        }

        private void clickSingleButtonUsingXandY(int i, int j)
        {
            if (j < 0 || j >= M || i < 0 || i >= N)
                return;
            light[i, j] = !light[i, j];
            if (light[i, j])
                buttons[i, j].BackColor = System.Drawing.Color.Yellow;
            else
                buttons[i, j].BackColor = System.Drawing.Color.Black;

        }

        private void clickButtonUsingXandY(int i, int j)
        {
            clicks[i, j] = (clicks[i, j] + 1) % 2;
            clickSingleButtonUsingXandY(i, j);
            clickSingleButtonUsingXandY(i, j - 1);
            clickSingleButtonUsingXandY(i, j + 1);
            clickSingleButtonUsingXandY(i - 1, j);
            clickSingleButtonUsingXandY(i + 1, j);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if(buttons[i,j].Equals(sender))
                    {
                        moves.Add(new Point(i, j));
                        clickButtonUsingXandY(i, j);
                    }
                }
            }

            Color();
        }

        public void Color()
        {
            bool win = true;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (light[i, j])
                        buttons[i, j].BackColor = System.Drawing.Color.Yellow;
                    else
                    {
                        buttons[i, j].BackColor = System.Drawing.Color.Black;
                        win = false;
                    }
                }
            }
            if (win)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (clicks[i, j] == 1)
                            buttons[i, j].BackColor = System.Drawing.Color.Orange;
                        else
                        {
                            buttons[i, j].BackColor = System.Drawing.Color.Yellow;
                        }
                    }
                }
                MessageBox.Show("Holy Shit You Won!!");
            }
        }

        private void rest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    light[i, j] = false;
                    clicks[i, j] = 0;
                    buttons[i, j].BackColor = System.Drawing.Color.Black;
                }
            }
            Color();
            moves.Clear();
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            if (txtHeight.Value <= 0 || txtWidth.Value <= 0)
                MessageBox.Show("Height and Width must be greater than 0");
            else
            {
                N = (int)txtHeight.Value;
                M = (int) txtWidth.Value;
                light = new bool[N, M];
                buttons = new Button[N, M];
                clicks = new int[N, M];
                panel1.Visible = false;
                StartGame();
            }

        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (moves.Count > 0)
            {
                Point p = moves.Last();
                int i = p.X;
                int j = p.Y;
                moves.Remove(p);
                clickButtonUsingXandY(i, j);
            }
        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            this.Height = 353;
            this.Width = 503;
            rest.Visible = false;
            btnUndo.Visible = false;
            btnResize.Visible = false;
            panel1.Visible = true;
            foreach (Control c in buttons)
                this.Controls.Remove(c);
            moves.Clear();
        }
    }
}
