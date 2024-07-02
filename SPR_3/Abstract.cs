using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPR_3;

public abstract class Abstract
{
    //карандаш кисточка graphics и вызывается абстр методы отвеч за отрисовку фигруры
    public abstract int Width { get; set; }
    public abstract int Height { get; set; }
    Random random = new Random();
    public int number1;
    public int number2;

    public Abstract(int width, int height)
    {
        Width = width;
        Height = height;

        number1 = random.Next(0, 100);
        number2 = random.Next(0, 100);
    }

    public abstract void Draw(Graphics g, Pen pen, Brush brush);

    public void SetDraw(Graphics g)
    {
        Pen pen = new Pen(Color.Red, 4);
        Brush brush = new SolidBrush(Color.Blue);
        Draw(g, pen, brush);
    }
}
