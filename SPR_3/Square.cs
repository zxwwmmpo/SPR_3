﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPR_3;

public class Square : Abstract
{
    public Square(int width, int height) : base(width, height)
    {
    }

    public override int Width { get; set; }
    public override int Height { get; set; }

    public override void Draw(Graphics g, Pen pen, Brush brush)
    {       
        g.DrawRectangle(pen, number1, number2, Width, Height);        
    }
}
