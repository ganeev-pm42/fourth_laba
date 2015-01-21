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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(Grid.GridDisplayMode.Colors);
            comboBox1.Items.Add(Grid.GridDisplayMode.NumberAndColors);
            comboBox1.Items.Add(Grid.GridDisplayMode.Numbers);
            comboBox1.SelectedIndex = 0;
        }

        private void red_button1_Click(object sender, EventArgs e)
        {
            red_button1.Crossed = !red_button1.Crossed;
            Random rnd = new Random();
            int i = rnd.Next(0, grid1.ColumnCount);
            int j = rnd.Next(0, grid1.RowCount);
            grid1[i, j] = rnd.Next(0, 5);
        }

        private void grid1_CellClick(object sender, int row, int column)
        {
            grid1.SetCell(row, column, new Random().Next(0, 5));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid1.DisplayMode = (Grid.GridDisplayMode)comboBox1.SelectedItem;
            grid1.Invalidate();
            
        }
        // дополнительное задание. событие на передвижение мышки
        private void grid1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove (e);
            if (e.X <= grid1.CellSize * 5 && e.Y <= grid1.CellSize * 4) // проверка попал или нет в ячейку
            {
                grid1_CellClick(this, e.Y / grid1.CellSize, e.X / grid1.CellSize);
            }
        }
    }
}
