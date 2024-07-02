using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SPR_3;
//стул
public class First
{
    private int size;
    private int hight;
    private string? color;
    private int price;
   
    public int GetSize()
    {
        return size;
    }

    public void SetSize(int size)
    {
        if (size < 0)
            throw new ArgumentException("нет данных");

        this.size = size;
    }

    public int GetHight()
    {
         return hight;
    }

    public void SetHight(int hight)
    {
        if (hight < 0)
            throw new ArgumentException("нет данных");

        this.hight = hight;
    }

    public void SetColor(string color)
    {
        if (string.IsNullOrEmpty(color))
            throw new ArgumentException("нет данных");

        this.color = color;
    }

    public string? GetColor()
    {
        return color;        
    }

    public void SetPrice(int price)
    {
        if (price < 0)
            throw new ArgumentException("нет данных");

        this.price = price;
    }

    public int GetPrice()
    {
        return price;        
    }
    
    public string Print()
    {
        return "{ Ширина: " + GetSize() + "\n Высота: " + GetHight() + "\n Цвет: " + GetColor() + "\n Цена: " + GetPrice() + " }";
    }
}
