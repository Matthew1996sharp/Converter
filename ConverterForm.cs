/* Программа "Конвертер" пересчитывает цену из долларов в рубли.
 * Демонстрирует использование компонентов TextBox и Label для ввода 
 * и отображения числовых данных. Программа спроектирована таким образом, 
 * что пользователь может ввести в поля редактирования только правильные данные*/

/*Также программа демонстрирует использование компонента HelpProvider 
 * для отображения справочной информации из файла справки
 * Нажатие клавиши F1 вызывает файл справки, при этом,
 * если курсор располагается в поле "Цена",
 * откроется соответствующий раздел справки "Цена",
 * нажатие клавиши F1 в поле "Курс" откроет соответствующий раздел "Курс"
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class ConverterForm : Form
    {
        //конструктор формы
        public ConverterForm()
        {
            InitializeComponent();

            ConverterHelpProvider.HelpNamespace = "usd2rub.chm"; //назначаем файл справки

            //задаем раздел справки, который будет выводиться:
            //для основной формы
            ConverterHelpProvider.SetHelpKeyword(this, "usd2rub_01.htm");
            ConverterHelpProvider.SetHelpNavigator(this, HelpNavigator.Topic);
            ConverterHelpProvider.SetShowHelp(this, true);

            //для поля "Цена"
            ConverterHelpProvider.SetHelpKeyword(this.PriceUSDTextBox, "usd2rub_01.htm");
            ConverterHelpProvider.SetHelpNavigator(this.PriceUSDTextBox, HelpNavigator.Topic);
            ConverterHelpProvider.SetShowHelp(this.PriceUSDTextBox, true);

            //для поля "Курс"
            ConverterHelpProvider.SetHelpKeyword(this.ExchangeTextBox, "usd2rub_01.htm");
            ConverterHelpProvider.SetHelpNavigator(this.ExchangeTextBox, HelpNavigator.Topic);
            ConverterHelpProvider.SetShowHelp(this.ExchangeTextBox, true);
        }

        // Нажатие клавиши в поле Цена
        private void PriceUSDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (PriceUSDTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        // Нажатие клавиши в поле Курс
        private void ExchangeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (ExchangeTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        // Щелчок на кнопке "Пересчёт"
        private void CalcButton_Click(object sender, EventArgs e)
        {
            double kurs; //курс (отношение рубля к доллару)
            double usd; //цена в долларах
            double rub; //цена в рублях

            OutputLabel.Text = string.Empty;

            // Конструкция позволяет отлавливать программные ошибки
            try
            {
                //исходные данные
                usd = Convert.ToDouble(PriceUSDTextBox.Text);
                kurs = Convert.ToDouble(ExchangeTextBox.Text);

                rub = usd * kurs; //пересчёт цены из долларов в рубли

                //вывод результата
                OutputLabel.Text = usd.ToString("N") + " USD = " + rub.ToString("C");
            }

            catch
            {
                if ((PriceUSDTextBox.Text == "") || (ExchangeTextBox.Text == ""))
                {
                    MessageBox.Show("Ошибка исходных данных.\n" + 
                        "Необходимо ввести данные в оба поля.", "Конвертер", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка входных данных.\n" +
                        "Неверный формат данных в одном из полей", "Конвертер", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //щелчок на кнопке "Справка"
        private void HelpButton_Click(object sender, EventArgs e)
        {
            //вызываем файл справки, раздел "Конвертер"
            Help.ShowHelp(this, ConverterHelpProvider.HelpNamespace, "usd2rub_01.htm");
        }
    }
}
