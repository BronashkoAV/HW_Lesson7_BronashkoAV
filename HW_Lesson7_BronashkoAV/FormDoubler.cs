using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Lesson7_BronashkoAV
{
    public partial class FormDoubler : Form
    {
        int counter = 0;
        Stack<int> counters = new Stack<int>();

        //Конструкторы для нужного числа и для кол-ва шагов (Так как они требуются в разных классах, их приходится инкапсулировать)
        int target, bestSteps;
        public int Target { get => target; set => target = value; }
        public int BestSteps { get => bestSteps; set => bestSteps = value; }

        public FormDoubler()
        {
            InitializeComponent();

            Random rnd = new Random();
            Target = rnd.Next(0, 100);


            lblTarget.Text = $"Вам нужно получить число: {Target}";
            MessageBox.Show($"Вам нужно получить число: {Target}\r\n(За наименьшее число ходов)");

            //Вычисляем лучшее кол-во шагов
            int temp = Target;
            while (temp != 0)
            {
                if (temp % 2 == 0) { temp /= 2; BestSteps++; }
                if (temp % 2 != 0) { temp -= 1; BestSteps++; }
            }

        }

        private void Doubler_Load(object sender, EventArgs e)
        {

        }

        private void btnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            counter++;
            counters.Push(counter);
            lblCounter.Text = $"Ваше число: {counters.First()}";
            lblStep.Text = $"Кол-во шагов: {counters.Count}";
            if (counter > Target) { MessageBox.Show("Вы проиграли.\r\nВы превысили допускаемое значение.\r\nИгра окончена."); this.Close(); }
            if (counter == Target)
            {
                if (counters.Count == BestSteps) MessageBox.Show("Поздравляю! Вы выиграли игру!");
                else if (counters.Count >= BestSteps) MessageBox.Show("Вы достигли нужного числа, но за большее число ходов.");
                this.Close();
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            counter *= 2;
            counters.Push(counter);
            lblCounter.Text = $"Ваше число: {counters.First()}";
            lblStep.Text = $"Кол-во шагов: {counters.Count}";
            if (counter > Target) { MessageBox.Show("Вы проиграли.\r\nВы превысили допускаемое значение.\r\nИгра окончена."); this.Close(); }
            if (counter == Target)
            {
                if (counters.Count == BestSteps) MessageBox.Show("Поздравляю! Вы выиграли игру!");
                else if (counters.Count >= BestSteps) MessageBox.Show("Вы достигли нужного числа, но за большее число ходов.");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (counters.Count > 1)
            {
                counter = counters.Pop();//Удаляет и возвращает объект, находящийся в начале Stack.
                lblCounter.Text = $"Ваше число: {counters.First()}";
                lblStep.Text = $"Кол-во шагов: {counters.Count}";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counters.Clear();
            counter = 0;
            lblCounter.Text = "Ваше число: 0";
            lblStep.Text = "Кол-во шагов: 0";
        }
    }
}
