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
    public partial class FormGuessingGame : Form
    {

        int target, input, step;
        public int Target { get => target; set => target = value; }
        public int Input { get => input; set => input = value; }
        public int Step { get => step; set => step = value; }

        public FormGuessingGame()
        {
            InitializeComponent();

            Random rnd = new Random();
            Target = rnd.Next(0, 100);

            tbInput.KeyUp += TbInput_KeyUp;
        }

        private void TbInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnOk.PerformClick();
        }

        private void btnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Input = Convert.ToInt32(tbInput.Text);
            Step++;
            lblHint.Text = $"Кол-во попыток: {Step}";
            if (Input == Target) { MessageBox.Show($"Поздравляю! Вы угадали!\r\nВам понадобилось всего {Step} попыток.\r\nИгра окончена"); this.Close(); }
            if (Input > Target) MessageBox.Show("Попытайтесь еще. Нужное число меньше");
            if (Input < Target) MessageBox.Show("Попытайтесь еще. Нужное число больше");
        }
    }
}
