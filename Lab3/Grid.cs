using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Grid : Control
    {
        int rows = 5, cols = 4, cellSize = 30;
        int selectedRow, selectedCol;
        Pen p = new Pen(Color.Black, 3);
        int[,] data = new int[1000, 1000];
        public int ColumnCount { // вертикальные
                                get { return rows; }
                                set{
                                    if (rows != value)
                                    {
                                        rows = value;
                                        Invalidate(); 
                                    } 
                                }
                            }
        public int RowCount { // горизонтальные
                                     get { return cols; }
                                     set {
                                         if (cols != value)
                                         {
                                            cols = value; 
                                            Invalidate();
                                         }
                                     }
                                }
        public int CellSize {  // размер клетки
                                get { return cellSize; }
                                set {
                                    cellSize = value;
                                        if (cellSize != value) 
                                        {
                                            cellSize = value;
                                            Invalidate();
                                        } 
                                    }
                            }
        public Color LineColor {
                                    get { return p.Color; }
                                    set {
                                            if (p.Color != value)
                                            {
                                                p.Color = value;
                                                Invalidate(); 
                                            } 
                                        }
                                }
        public delegate void CellHandler(Object sender, int row, int column);
        public event CellHandler CellClick;
        public enum GridDisplayMode { Numbers, Colors, NumberAndColors };
        public GridDisplayMode DisplayMode { get; set; }
        public Color[] Colors = new Color[5];
        public Grid()
        {
            InitializeComponent();
            Colors[0] = Color.White;
            Colors[1] = Color.Blue;
            Colors[2] = Color.Brown;
            Colors[3] = Color.Red;
            Colors[4] = Color.Orange;
        }

        public int this[int i, int j] // индексатор
        {
            get
            {
               return data[i, j];
            }
            set
            {
                data[i, j] = value;
                Invalidate();
            }
        }

        public void SetCell(int i, int j, int value) // функция установки элемента массива
        {
            data[i, j] = value;
            selectedCol = j;
            selectedRow = i;
            Console.WriteLine("selectedRow = " + selectedRow + " selectedCol = " + selectedCol + " val = " + value);
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            int step = 0;
            
            if (DisplayMode == GridDisplayMode.Colors || DisplayMode == GridDisplayMode.NumberAndColors)
            {
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                       g.FillRectangle(new SolidBrush(Colors[data[i, j]]), cellSize * j, cellSize * i, cellSize, cellSize);
            }
            if (DisplayMode == GridDisplayMode.Numbers || DisplayMode == GridDisplayMode.NumberAndColors)
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                    {
                        g.DrawString(Convert.ToString(data[i, j]), Font, Brushes.Black, j * cellSize + cellSize / 2 - 10, i * cellSize + cellSize / 2 - 10);
                    }
            for (int i = 0, j = 0; i <= rows || j <= cols; i++, j++)
            {
                if (i <= rows)
                    g.DrawLine(p, 0, step, cellSize * cols, step);
                if (j <= cols)
                    g.DrawLine(p, step, 0, step, cellSize * rows);
                step = cellSize + step;
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X <= cellSize * cols && e.Y <= cellSize * rows) // проверка попал или нет в ячейку
            {
                CellClick(this, e.Y / cellSize, e.X / cellSize);
            }
        }
    }
}
