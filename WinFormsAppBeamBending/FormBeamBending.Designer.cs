namespace WinFormsAppBeamBending;

partial class FormBeamBending
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeamBending));
        pictureBox1 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        textBoxBeamLenght = new TextBox();
        textBoxPressure = new TextBox();
        textBoxM0 = new TextBox();
        textBoxQ0 = new TextBox();
        listBoxX = new ListBox();
        label7 = new Label();
        label8 = new Label();
        listBoxEIv = new ListBox();
        label9 = new Label();
        listBoxEIdv = new ListBox();
        label10 = new Label();
        listBoxM = new ListBox();
        label11 = new Label();
        listBoxQ = new ListBox();
        buttonСalculate = new Button();
        buttonClose = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(439, 23);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(270, 159);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(35, 35);
        label1.Name = "label1";
        label1.Size = new Size(98, 20);
        label1.TabIndex = 1;
        label1.Text = "Длина балки";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(14, 58);
        label2.Name = "label2";
        label2.Size = new Size(16, 20);
        label2.TabIndex = 2;
        label2.Text = "L";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 155);
        label3.Name = "label3";
        label3.Size = new Size(18, 20);
        label3.TabIndex = 3;
        label3.Text = "q";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(192, 58);
        label4.Name = "label4";
        label4.Size = new Size(30, 20);
        label4.TabIndex = 4;
        label4.Text = "M0";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(192, 158);
        label5.Name = "label5";
        label5.Size = new Size(28, 20);
        label5.TabIndex = 5;
        label5.Text = "Q0";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(35, 131);
        label6.Name = "label6";
        label6.Size = new Size(72, 20);
        label6.TabIndex = 6;
        label6.Text = "Нагрузка";
        // 
        // textBoxBeamLenght
        // 
        textBoxBeamLenght.Location = new Point(35, 58);
        textBoxBeamLenght.Name = "textBoxBeamLenght";
        textBoxBeamLenght.Size = new Size(125, 27);
        textBoxBeamLenght.TabIndex = 7;
        // 
        // textBoxPressure
        // 
        textBoxPressure.Location = new Point(35, 155);
        textBoxPressure.Name = "textBoxPressure";
        textBoxPressure.Size = new Size(125, 27);
        textBoxPressure.TabIndex = 8;
        // 
        // textBoxM0
        // 
        textBoxM0.Location = new Point(254, 58);
        textBoxM0.Name = "textBoxM0";
        textBoxM0.ReadOnly = true;
        textBoxM0.Size = new Size(125, 27);
        textBoxM0.TabIndex = 9;
        // 
        // textBoxQ0
        // 
        textBoxQ0.Location = new Point(254, 155);
        textBoxQ0.Name = "textBoxQ0";
        textBoxQ0.ReadOnly = true;
        textBoxQ0.Size = new Size(125, 27);
        textBoxQ0.TabIndex = 10;
        // 
        // listBoxX
        // 
        listBoxX.FormattingEnabled = true;
        listBoxX.ItemHeight = 20;
        listBoxX.Location = new Point(35, 309);
        listBoxX.Name = "listBoxX";
        listBoxX.Size = new Size(115, 344);
        listBoxX.TabIndex = 11;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(78, 276);
        label7.Name = "label7";
        label7.Size = new Size(16, 20);
        label7.TabIndex = 12;
        label7.Text = "x";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(213, 276);
        label8.Name = "label8";
        label8.Size = new Size(28, 20);
        label8.TabIndex = 14;
        label8.Text = "EIv";
        // 
        // listBoxEIv
        // 
        listBoxEIv.FormattingEnabled = true;
        listBoxEIv.ItemHeight = 20;
        listBoxEIv.Location = new Point(169, 309);
        listBoxEIv.Name = "listBoxEIv";
        listBoxEIv.Size = new Size(115, 344);
        listBoxEIv.TabIndex = 13;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(361, 276);
        label9.Name = "label9";
        label9.Size = new Size(37, 20);
        label9.TabIndex = 16;
        label9.Text = "EIdv";
        // 
        // listBoxEIdv
        // 
        listBoxEIdv.FormattingEnabled = true;
        listBoxEIdv.ItemHeight = 20;
        listBoxEIdv.Location = new Point(314, 309);
        listBoxEIdv.Name = "listBoxEIdv";
        listBoxEIdv.Size = new Size(115, 344);
        listBoxEIdv.TabIndex = 15;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(496, 276);
        label10.Name = "label10";
        label10.Size = new Size(22, 20);
        label10.TabIndex = 18;
        label10.Text = "M";
        // 
        // listBoxM
        // 
        listBoxM.FormattingEnabled = true;
        listBoxM.ItemHeight = 20;
        listBoxM.Location = new Point(451, 309);
        listBoxM.Name = "listBoxM";
        listBoxM.Size = new Size(115, 344);
        listBoxM.TabIndex = 17;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(637, 276);
        label11.Name = "label11";
        label11.Size = new Size(20, 20);
        label11.TabIndex = 20;
        label11.Text = "Q";
        // 
        // listBoxQ
        // 
        listBoxQ.FormattingEnabled = true;
        listBoxQ.ItemHeight = 20;
        listBoxQ.Location = new Point(594, 309);
        listBoxQ.Name = "listBoxQ";
        listBoxQ.Size = new Size(115, 344);
        listBoxQ.TabIndex = 19;
        // 
        // buttonСalculate
        // 
        buttonСalculate.Location = new Point(215, 232);
        buttonСalculate.Name = "buttonСalculate";
        buttonСalculate.Size = new Size(94, 29);
        buttonСalculate.TabIndex = 21;
        buttonСalculate.Text = "Рассчитать";
        buttonСalculate.UseVisualStyleBackColor = true;
        buttonСalculate.Click += buttonCalculate_Click;
        // 
        // buttonClose
        // 
        buttonClose.Location = new Point(405, 232);
        buttonClose.Name = "buttonClose";
        buttonClose.Size = new Size(94, 29);
        buttonClose.TabIndex = 22;
        buttonClose.Text = "Закрыть";
        buttonClose.UseVisualStyleBackColor = true;
        buttonClose.Click += buttonClose_Click;
        // 
        // FormBeamBending
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(750, 725);
        Controls.Add(buttonClose);
        Controls.Add(buttonСalculate);
        Controls.Add(label11);
        Controls.Add(listBoxQ);
        Controls.Add(label10);
        Controls.Add(listBoxM);
        Controls.Add(label9);
        Controls.Add(listBoxEIdv);
        Controls.Add(label8);
        Controls.Add(listBoxEIv);
        Controls.Add(label7);
        Controls.Add(listBoxX);
        Controls.Add(textBoxQ0);
        Controls.Add(textBoxM0);
        Controls.Add(textBoxPressure);
        Controls.Add(textBoxBeamLenght);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Name = "FormBeamBending";
        Text = "РАСЧЕТ БАЛКИ НА ИЗГИБ";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox textBoxBeamLenght;
    private TextBox textBoxPressure;
    private TextBox textBoxM0;
    private TextBox textBoxQ0;
    private ListBox listBoxX;
    private Label label7;
    private Label label8;
    private ListBox listBoxEIv;
    private Label label9;
    private ListBox listBoxEIdv;
    private Label label10;
    private ListBox listBoxM;
    private Label label11;
    private ListBox listBoxQ;
    private Button buttonСalculate;
    private Button buttonClose;
}