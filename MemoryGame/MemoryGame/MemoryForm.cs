using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace MemoryGame
{
    public partial class MemoryForm : Form
    {
        private List<Button> Pairs = new List<Button>();
        private List<Button> tiles = new List<Button>();
        private List<Button> lag = new List<Button>();

        private static System.Timers.Timer aTimer;

        private static System.Timers.Timer RainbowTimer;
        private int R = 0;
        private int G = 0;
        private int B = 0;

        private static Random rng = new Random();

        public MemoryForm()
        {
            InitializeComponent();

            
        }
        // panel 780, 640
        private void TileLoad(int size, int Cols, int Rows)
        {
            //int[] arr = ColsAndRows(size);
            //int Cols = arr[0];
            //int Rows = arr[1];
            int width = (tilePanel.Width - 2 * tilePanel.Padding.All) / Cols;
            int height = (tilePanel.Height - 2 * tilePanel.Padding.All) / Rows;
            int x = tilePanel.Padding.All;
            int y = tilePanel.Padding.All;
            int dx = width;
            int dy = height;           

            for (int i = 0; i < size; i++)
            {
                Button tile = new Button()
                {
                    Parent = tilePanel,
                    //SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(width, height),
                    Location = new Point(x, y),                   
                    BackgroundImageLayout = ImageLayout.Stretch,
                    //BorderStyle = BorderStyle.Fixed3D
                    FlatStyle = FlatStyle.Standard,
                    //BackColor = Color.Black,
                    ForeColor = Color.Black,
                    Font = new Font(familyName: "Times New Roman", width / 4)                    
                };
                if (!rainbowModeCheckBox.Checked)
                {
                    BackgroundImage = GrayPic.Image;
                }
                CheckForIllegalCrossThreadCalls = false;
                tile.Click += Tile_Click;

                tiles.Add(tile);

                TilePopulate(tiles, size);

                x += dx;
                if (x >= ((Cols - 1) * dx) + width)
                {
                    y += dy;
                    x = tilePanel.Padding.All;
                }
                
            }
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            if (lag.Count != 0)
            {
                return;
            }
            Button tile = (Button)sender;
            tile.Enabled = false;
            if (tile.Name.Contains("_"))
            {
                int last = tile.Name.Length - 2;
                tile.Text = tile.Name.Remove(last);               
            }
            else
            {
                tile.Text = tile.Name;
            }
            

            Pairs.Add(tile);

            if (Pairs.Count == 2)
            {
                Moves();
                if (Pairs[0].Name == $"{ Pairs[1].Name }_2" || $"{ Pairs[0].Name }_2" == $"{Pairs[1].Name}")
                {
                    Pairs[0].Visible = false;
                    Pairs[1].Visible = false;

                    Pairs[0].Enabled = false;
                    Pairs[1].Enabled = false;

                    tiles.Remove(Pairs[0]);
                    tiles.Remove(Pairs[1]);

                    Pairs = new List<Button>();
                }
                else
                {
                    lag.Add(Pairs[1]);
                    aTimer = new System.Timers.Timer(580)
                    {
                        Enabled = true,
                        AutoReset = false
                    };
                    Pairs[0].Enabled = true;
                    Pairs[1].Enabled = true;
                    Pairs[0].Text = "";                   
                    aTimer.Elapsed += (source, ElapsedEventArgs) => { OnTimedEvent(source, ElapsedEventArgs); };
                    Pairs = new List<Button>();                    
                }

                if (tiles.Count == 0)
                {
                    MessageBox.Show("Congratulations, You have Won.");
                    Close();
                }
            }

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            lag[0].Text = "";
            lag = new List<Button>();
        }
        private void TilePopulate(List<Button> tiles, int size)
        {
            var list = tiles.OrderBy(a => rng.Next()).ToList();
            List<int> ints = new List<int>();

            for (int i = 1; i <= size / 2; i++)
            {
                ints.Add(i);
            }

            for(int i = 0; i < (list.Count / 2); i++)
            {
                list[i].Name = $"{ ints[i] }";
                list[i + (list.Count / 2)].Name = $"{ints[i]}_2";
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool Even = int.TryParse(sizeValue.Text, out int size);

            if (!Even || size == 2)
            {
                return;
            }
            if (size % 2 != 0)
            {
                return;
            }

            int[] CR = ColsAndRows(size);
            if (CR[0] > (CR[1] + 50))
            {
                return;
            }

            sizeValue.Visible = false;
            sizeValue.Enabled = false;
            selectButton.Visible = false;
            selectButton.Enabled = false;
            tilePanel.Visible = true;

            if (rainbowModeCheckBox.Checked)
            {
                RainbowMode();
            }
            
            TileLoad(size, CR[0], CR[1]);
        }

        private List<int> Factorials(int factor)
        {
            List<int> output = new List<int>();
            for (int i = 1; i < factor; i++)
            {
                if (factor % i == 0)
                {
                    output.Add(i);
                }
            }
            return output;
        }

        private int[] ColsAndRows(int size)
        {
            List<int> factors = Factorials(size);
            int[] output = new int[2];

            factors.Reverse();

            foreach (int i in factors)
            {
                foreach (int i2 in factors)
                {
                    if (i2 == i && i2 * i == size)
                    {
                        output[0] = i;
                        output[1] = i;
                        return output;
                    }
                    if ((i == i2 + 1 || i == i2 + 2) && i * i2 == size)
                    {
                        output[0] = i;
                        output[1] = i2;
                        return output;
                    }
                }
            }

            List<List<int>> ave = new List<List<int>>();

            if (output[0] == 0 || output[1] == 0)
            {
                foreach (int i in factors)
                {
                    foreach (int j in factors)
                    {
                        if (i * j == size)
                        {
                            List<int> fac = new List<int>
                            {
                                i,
                                j
                            };
                            ave.Add(fac);
                        }
                    }
                }
                double average = (ave[0][0] + ave[0][1]) / 2;
                output[0] = ave[0][0];
                output[1] = ave[0][1];

                foreach (List<int> af in ave)
                {
                    double x = (double)(af[0] + af[1]) / 2;
                    if (x < average)
                    {
                        average = x;
                        output[0] = af[0];
                        output[1] = af[1];
                    }

                }
            }
            return output;
        }

        private void Moves()
        {
            int moves = int.Parse(movesValues.Text);

            moves++;

            movesValues.Text = $"{ moves }";
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!darkmode.Checked)
            {
                BackColor = Color.White;
                ForeColor = Color.Black;

                selectButton.BackColor = Color.White;
                selectButton.ForeColor = Color.Black;

                sizeValue.BackColor = Color.White;
                sizeValue.ForeColor = Color.Black;

                darkmode.BackColor = Color.White;
                darkmode.ForeColor = Color.Black;

                movesLabel.BackColor = Color.White;
                movesLabel.ForeColor = Color.Black;

                movesValues.BackColor = Color.White;
                movesValues.ForeColor = Color.Black;
            }

            if (darkmode.Checked)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;

                selectButton.BackColor = Color.Black;
                selectButton.ForeColor = Color.White;

                sizeValue.BackColor = Color.Black;
                sizeValue.ForeColor = Color.White;

                darkmode.BackColor = Color.Black;
                darkmode.ForeColor = Color.White;

                movesLabel.BackColor = Color.Black;
                movesLabel.ForeColor = Color.White;

                movesValues.BackColor = Color.Black;
                movesValues.ForeColor = Color.White;
            }          
        }

        private void RainbowMode()
        {
            R = 255;
            G = 0;
            B = 0;
            RainbowTimer = new System.Timers.Timer(500)
            {
                Enabled = true,
                AutoReset = true
            };

            RainbowTimer.Elapsed += RainbowTimer_Elapsed;
        }

        private void RainbowTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RainbowTimer.Stop();
            if (R == 238 && G == 130 && B == 238)
            {
                R = 255;
                G = 0;
                B = 0;
                SetColor();
                RainbowTimer.Start();
                return;
            }
            if (R == 255 && G == 0 && B == 0)
            {
                R = 255;
                G = 165;
                B = 0;
                SetColor();
                RainbowTimer.Start();
                return;
            }

            if (R == 255 && G == 165 && B == 0)
            {
                R = 255;
                G = 255;
                B = 0;
                SetColor();
                RainbowTimer.Start();
                return;
            }

            if (R == 255 && G == 255 && B == 0)
            {
                R = 0;
                G = 255;
                B = 0;
                SetColor();
                RainbowTimer.Start();
                return;
            }

            if (R == 0 && G == 255 && B == 0)
            {
                R = 0;
                G = 0;
                B = 255;
                SetColor();
                RainbowTimer.Start();
                return;
            }

            if (R == 0 && G == 0 && B == 255)
            {
                R = 75;
                G = 0;
                B = 130;
                SetColor();
                RainbowTimer.Start();
                return;
            }

            if (R == 75 && G == 0 && B == 130)
            {
                R = 238;
                G = 130;
                B = 238;
                SetColor();
                RainbowTimer.Start();
                return;
            }
        }
        private void SetColor()
        {
            movesLabel.ForeColor = Color.FromArgb(R, G, B);
            movesValues.ForeColor = Color.FromArgb(R, G, B);
            darkmode.ForeColor = Color.FromArgb(R, G, B);
            BackColor = Color.FromArgb(R, G, B);
            rainbowModeCheckBox.ForeColor = Color.FromArgb(R, G, B);

            foreach(Button b in tiles)
            {
                b.BackColor = Color.FromArgb(R, G, B);
            }
        }
    }
}
