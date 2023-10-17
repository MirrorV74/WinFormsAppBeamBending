namespace WinFormsAppBeamBending;

public partial class FormBeamBending : Form
{
    public FormBeamBending()
    {
        InitializeComponent();
    }

    // При нажатии кнопки "Рассчитать" срабатывает следующий алгоритм
    private void buttonCalculate_Click(object sender, EventArgs e)
    {
        // Инициализация переменных
        double L, q, M0, Q0, x, EIv, EIdv, M, Q;
        double step = 0.1;

        // Считывание данных. Если введён неправильный формат открывается окно с ошибкой
        try
        {
            L = Convert.ToDouble(textBoxBeamLenght.Text);
            q = Convert.ToDouble(textBoxPressure.Text);
        }
        catch (FormatException)
        {
            L = 0;
            q = 0;
            MessageBox.Show("Неверный формат данных");
        }

        // Вычисление M0 и Q0 и вывод данных в текстбоксы

        double a11 = Math.Pow(L, 2) / 2;
        double a12 = Math.Pow(L, 3) / 6;
        double a21 = 1;
        double a22 = L;
        double b1 = q * (Math.Pow(L, 4) / 24 - Math.Pow(L, 5) / (120 * L));
        double b2 = q * (Math.Pow(L, 2) / 2 - Math.Pow(L, 3) / (6 * L));

        double D = a11 * a22 - a12 * a21;
        double D1 = b1 * a22 - b2 * a12;
        double D2 = a11 * b2 - a21 * b1;
        M0 = D1 / D;
        Q0 = D2 / D;

        textBoxM0.Text = Convert.ToString(Math.Round(Q0, 3));
        textBoxQ0.Text = Convert.ToString(Math.Round(Q0, 3));

        // Расчёт параметров балки

        // Цикл от 0 до L

        x = 0;
        while (Math.Round(x, 3) <= L)
        {
            // Добавление текущего значения x в листбокс 
            listBoxX.Items.Add(Math.Round(x, 3));

            // Рассчёт прогиба оси балки при текущем x и добавление его значения в листбокс
            EIv = -M0 * Math.Pow(x, 2) / 2 - Q0 * Math.Pow(x, 3) / 6 +
                q * (Math.Pow(x, 4) / 24 - Math.Pow(x, 5) / (120 * L));
            listBoxEIv.Items.Add(Math.Round(EIv, 3));

            // Рассчёт угла поворота оси балки при текущем x и добавление его значения в листбокс
            EIdv = -M0 * x - Q0 * Math.Pow(x, 2) / 2 +
                q * (Math.Pow(x, 3) / 6 - Math.Pow(x, 4) / (24 * L));
            listBoxEIdv.Items.Add(Math.Round(EIdv, 3));

            // Рассчёт изгибающего момента оси балки при текущем x и добавление его значения в листбокс
            M = M0 + Q0 * x - q * (Math.Pow(x, 2) / 2 - Math.Pow(x, 3) / (6 * L));
            listBoxM.Items.Add(Math.Round(M, 3));

            // Рассчёт перерезываюей силы оси балки при текущем x и добавление его значения в листбокс
            Q = Q0 -
                q * (x - Math.Pow(x, 2) / (2 * L));
            listBoxQ.Items.Add(Math.Round(Q, 3));

            x += step;
        }
    }

    // При нажатии кнопки "Закрыть" приложение закрывается
    private void buttonClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}


