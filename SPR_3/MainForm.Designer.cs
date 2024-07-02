namespace SPR_3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxPrice = new TextBox();
            textBoxColor = new TextBox();
            textBoxHight = new TextBox();
            textBoxSize = new TextBox();
            buttonOutPut = new Button();
            buttonAdd = new Button();
            listBoxOutPut = new ListBox();
            tabPage2 = new TabPage();
            buttonAddSquare = new Button();
            buttonView = new Button();
            buttonAddPicture = new Button();
            textBoxHeight = new TextBox();
            textBoxWIdth = new TextBox();
            listBoxOutPutPicture = new ListBox();
            pictureBoxDraw = new PictureBox();
            tabPage3 = new TabPage();
            button1 = new Button();
            textBoxA = new TextBox();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            textBoxB = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 294);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxPrice);
            tabPage1.Controls.Add(textBoxColor);
            tabPage1.Controls.Add(textBoxHight);
            tabPage1.Controls.Add(textBoxSize);
            tabPage1.Controls.Add(buttonOutPut);
            tabPage1.Controls.Add(buttonAdd);
            tabPage1.Controls.Add(listBoxOutPut);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(729, 261);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(163, 94);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(148, 27);
            textBoxPrice.TabIndex = 6;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(163, 61);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(148, 27);
            textBoxColor.TabIndex = 5;
            // 
            // textBoxHight
            // 
            textBoxHight.Location = new Point(6, 94);
            textBoxHight.Name = "textBoxHight";
            textBoxHight.Size = new Size(148, 27);
            textBoxHight.TabIndex = 4;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(6, 61);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(148, 27);
            textBoxSize.TabIndex = 3;
            // 
            // buttonOutPut
            // 
            buttonOutPut.Location = new Point(6, 217);
            buttonOutPut.Name = "buttonOutPut";
            buttonOutPut.Size = new Size(94, 29);
            buttonOutPut.TabIndex = 2;
            buttonOutPut.Text = "вывод";
            buttonOutPut.UseVisualStyleBackColor = true;
            buttonOutPut.Click += buttonOutPut_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 156);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 55);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "добавить объект";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxOutPut
            // 
            listBoxOutPut.FormattingEnabled = true;
            listBoxOutPut.ItemHeight = 20;
            listBoxOutPut.Location = new Point(317, 6);
            listBoxOutPut.Name = "listBoxOutPut";
            listBoxOutPut.Size = new Size(390, 244);
            listBoxOutPut.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonAddSquare);
            tabPage2.Controls.Add(buttonView);
            tabPage2.Controls.Add(buttonAddPicture);
            tabPage2.Controls.Add(textBoxHeight);
            tabPage2.Controls.Add(textBoxWIdth);
            tabPage2.Controls.Add(listBoxOutPutPicture);
            tabPage2.Controls.Add(pictureBoxDraw);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(729, 261);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddSquare
            // 
            buttonAddSquare.Location = new Point(126, 76);
            buttonAddSquare.Name = "buttonAddSquare";
            buttonAddSquare.Size = new Size(110, 47);
            buttonAddSquare.TabIndex = 6;
            buttonAddSquare.Text = "добавить 2";
            buttonAddSquare.UseVisualStyleBackColor = true;
            buttonAddSquare.Click += buttonAddSquare_Click;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(12, 129);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(108, 47);
            buttonView.TabIndex = 5;
            buttonView.Text = "отобразить";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // buttonAddPicture
            // 
            buttonAddPicture.Location = new Point(10, 76);
            buttonAddPicture.Name = "buttonAddPicture";
            buttonAddPicture.Size = new Size(110, 47);
            buttonAddPicture.TabIndex = 4;
            buttonAddPicture.Text = "добавить";
            buttonAddPicture.UseVisualStyleBackColor = true;
            buttonAddPicture.Click += buttonAddPicture_Click;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(137, 17);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(125, 27);
            textBoxHeight.TabIndex = 3;
            // 
            // textBoxWIdth
            // 
            textBoxWIdth.Location = new Point(6, 17);
            textBoxWIdth.Name = "textBoxWIdth";
            textBoxWIdth.Size = new Size(125, 27);
            textBoxWIdth.TabIndex = 2;
            // 
            // listBoxOutPutPicture
            // 
            listBoxOutPutPicture.FormattingEnabled = true;
            listBoxOutPutPicture.ItemHeight = 20;
            listBoxOutPutPicture.Location = new Point(350, 171);
            listBoxOutPutPicture.Name = "listBoxOutPutPicture";
            listBoxOutPutPicture.Size = new Size(373, 84);
            listBoxOutPutPicture.TabIndex = 1;
            // 
            // pictureBoxDraw
            // 
            pictureBoxDraw.Location = new Point(350, 6);
            pictureBoxDraw.Name = "pictureBoxDraw";
            pictureBoxDraw.Size = new Size(373, 152);
            pictureBoxDraw.TabIndex = 0;
            pictureBoxDraw.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBoxB);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(textBoxA);
            tabPage3.Controls.Add(textBoxY);
            tabPage3.Controls.Add(textBoxX);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(729, 261);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(35, 93);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(21, 147);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 2;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(167, 43);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(125, 27);
            textBoxY.TabIndex = 1;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(21, 43);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 0;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(167, 147);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonOutPut;
        private Button buttonAdd;
        private ListBox listBoxOutPut;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBoxPrice;
        private TextBox textBoxColor;
        private TextBox textBoxHight;
        private TextBox textBoxSize;
        private TextBox textBoxHeight;
        private TextBox textBoxWIdth;
        private ListBox listBoxOutPutPicture;
        private PictureBox pictureBoxDraw;
        private Button buttonView;
        private Button buttonAddPicture;
        private Button buttonAddSquare;
        private Button button1;
        private TextBox textBoxA;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private TextBox textBoxB;
    }
}