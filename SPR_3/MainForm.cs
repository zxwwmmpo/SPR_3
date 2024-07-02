using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPR_3;

public partial class MainForm : Form
{
    List<First> obj = new();
    List<Abstract> draw = new();
    First task = new First();

    public MainForm()
    {
        InitializeComponent();
        
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {         
            task.SetHight(int.Parse(textBoxHight.Text));
            task.SetSize(int.Parse(textBoxSize.Text));
            task.SetColor(textBoxColor.Text);
            task.SetPrice(int.Parse(textBoxPrice.Text));
            obj.Add(task);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonOutPut_Click(object sender, EventArgs e)
    {
        listBoxOutPut.Items.Clear();
        for (int i = 0; i < obj.Count; i++)
        {            
            listBoxOutPut.Items.Add(obj[i].Print());
        }
    }

    //******************************************************//

    //oval
    private void buttonAddPicture_Click(object sender, EventArgs e)
    {
        Oval oval = new Oval(int.Parse(textBoxWIdth.Text), int.Parse(textBoxHeight.Text));
        draw.Add(oval);
        listBoxOutPutPicture.Items.Add(oval);
    }

    //square
    private void buttonAddSquare_Click(object sender, EventArgs e)
    {
        Square square = new Square(int.Parse(textBoxWIdth.Text), int.Parse(textBoxHeight.Text));
        draw.Add(square);
        listBoxOutPutPicture.Items.Add(square);
    }

    private void buttonView_Click(object sender, EventArgs e)
    {
;
        if (listBoxOutPutPicture.SelectedItem is Oval oval)
        {
            Bitmap bitmap = new(pictureBoxDraw.Width, pictureBoxDraw.Height);
            Graphics g = Graphics.FromImage(bitmap);
            oval.SetDraw(g);
            pictureBoxDraw.Image = bitmap;
        }
        if (listBoxOutPutPicture.SelectedItem is Square square)
        {
            Bitmap bitmap = new(pictureBoxDraw.Width, pictureBoxDraw.Height);
            Graphics g = Graphics.FromImage(bitmap);
            square.SetDraw(g);
            pictureBoxDraw.Image = bitmap;            
        }
    }

    //**************************************************************//

    private void button1_Click(object sender, EventArgs e)
    {
        Task3A task3A = new Task3A();
        textBoxA.Text += Convert.ToString(task3A.Task3(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text)));
        Task3B task3B = new Task3B();
        textBoxB.Text += Convert.ToString(task3B.Task3(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text)));
    }
}
