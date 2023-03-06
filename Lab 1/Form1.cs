using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //Рисуем каркас дома
            e.Graphics.DrawRectangle(new Pen(Color.Red, 5), 230, 230, 300, 200);

            //Рисуем крышу
            e.Graphics.DrawLine(new Pen(Color.BurlyWood, 5), 200, 230, 380, 60);
            e.Graphics.DrawLine(new Pen(Color.BurlyWood, 5), 380, 60, 560, 230);
            e.Graphics.DrawLine(new Pen(Color.BurlyWood, 5), 200, 230, 560, 230);

            //Рисуем трубу
            e.Graphics.DrawLine(new Pen(Color.Brown, 5), 290, 145, 290, 80);
            e.Graphics.DrawLine(new Pen(Color.Brown, 5), 290, 80, 315, 80);
            e.Graphics.DrawLine(new Pen(Color.Brown, 5), 315, 80, 315, 122);

            //Рисуем окно
            e.Graphics.DrawRectangle(new Pen(Color.Black, 5), 260, 260, 120, 120);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), 270, 270, 100, 100);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 320, 270, 320, 370);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 270, 320, 370, 320);

            //Рисуем окно на чердаке
            e.Graphics.DrawEllipse(new Pen(Color.Black, 5), 340, 130, 80, 80);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 380, 130, 380, 210);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 340, 170, 420, 170);

            //Рисуем дверь
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), 430, 290, 80, 138);
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), 435, 360, 12, 12);

            //Рисуем Дым
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 300, 50, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 320, 55, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 315, 50, 15, 15);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 290, 48, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 300, 70, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 350, 68, 8, 8);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 286, 66, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 320, 35, 13, 13);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 307, 38, 8, 8);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 330, 80, 8, 8);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 344, 30, 15, 15);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 339, 17, 16, 16);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 328, 20, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), 309, 24, 10, 10);

            //Рисуем забор
            e.Graphics.DrawLine(new Pen(Color.BurlyWood, 6), 533, 330, 770, 330);
            e.Graphics.DrawLine(new Pen(Color.BurlyWood, 6), 533, 400, 770, 400);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 540, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 570, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 600, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 630, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 660, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 690, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 720, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 750, 300, 20, 130);
            e.Graphics.DrawRectangle(new Pen(Color.BurlyWood, 4), 780, 300, 20, 130);

            //Рисуем солнышко
            e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), -40, -40, 140, 140);
            e.Graphics.DrawLine(new Pen(Color.Yellow, 3), 0, 0, 120, 120);
            e.Graphics.DrawLine(new Pen(Color.Yellow, 3), 0, 0, 145, 65);
            e.Graphics.DrawLine(new Pen(Color.Yellow, 3), 0, 0, 130, 80);
            e.Graphics.DrawLine(new Pen(Color.Yellow, 3), 0, 0, 126, 100);
            e.Graphics.DrawLine(new Pen(Color.Yellow, 3), 0, 0, 136, 30);
            e.Graphics.DrawLine(new Pen(Color.Yellow, 3), 0, 0, 142, 43);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + " " + e.Y.ToString();
        }
    }
}
