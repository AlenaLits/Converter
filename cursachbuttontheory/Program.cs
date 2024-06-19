using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursachbuttontheory
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public partial class MainForm : Form
    {
        private ComboBox fromComboBox;
        private ComboBox toComboBox;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button convertButton;
        private Button helpButton;
        private Button theoryButton;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.theoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // fromComboBox
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Items.AddRange(new object[] {"Десятичная", "Двоичная", "Восьмеричная", "Шестнадцатеричная",
            "Троичная", "Четверичная", "Двенадцатеричная", "Пятеричная"
            });
            this.fromComboBox.Location = new System.Drawing.Point(50, 35);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(150, 21);
            this.fromComboBox.TabIndex = 0;
            this.fromComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fromComboBox.BackColor = System.Drawing.Color.White;
            this.fromComboBox.ForeColor = System.Drawing.Color.Black;

            // toComboBox

            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {"Десятичная", "Двоичная", "Восьмеричная", "Шестнадцатеричная",
            "Троичная", "Четверичная", "Двенадцатеричная", "Пятеричная"
            });
            this.toComboBox.Location = new System.Drawing.Point(390, 35);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(150, 21);
            this.toComboBox.TabIndex = 1;
            this.toComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toComboBox.BackColor = System.Drawing.Color.White;
            this.toComboBox.ForeColor = System.Drawing.Color.Black;

            // inputTextBox
            this.inputTextBox.Location = new System.Drawing.Point(50, 65);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(150, 200);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.inputTextBox.BackColor = System.Drawing.Color.Azure;
            this.inputTextBox.ForeColor = System.Drawing.Color.Black;

            // outputTextBox
            this.outputTextBox.Location = new System.Drawing.Point(390, 65);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(150, 200);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.outputTextBox.BackColor = System.Drawing.Color.Azure;
            this.outputTextBox.ForeColor = System.Drawing.Color.Black;

            // convertButton
            this.convertButton.Location = new System.Drawing.Point(220, 100); 
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(150, 30);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Конвертировать";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.convertButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.convertButton.ForeColor = System.Drawing.Color.White;

            // helpButton
            this.helpButton.Location = new System.Drawing.Point(220, 150); 
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(150, 30);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Помощь";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HlpButton_Click);
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.helpButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.helpButton.ForeColor = System.Drawing.Color.White;

            //// theoryButton
            this.theoryButton.Location = new System.Drawing.Point(220, 200);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(150, 30);
            this.theoryButton.TabIndex = 6;
            this.theoryButton.Text = "Теория";
            this.theoryButton.UseVisualStyleBackColor = true;
            this.theoryButton.Click += new System.EventHandler(this.TheoryButton_Click);
            this.theoryButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.theoryButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.theoryButton.ForeColor = System.Drawing.Color.White;

            // MainForm
            this.ClientSize = new System.Drawing.Size(590, 330);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.theoryButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Name = "MainForm";
            this.Text = "Конвертер чисел";
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void HlpButton_Click(object sender, EventArgs e)
        {
            string commandText = "\"C:\\Users\\User\\OneDrive\\Рабочий стол\\cursachbuttontheory\\Рекомендации по освоению.docx\"";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            string commandText = "\"C:\\Users\\User\\OneDrive\\Рабочий стол\\cursachbuttontheory\\Справочная информация.docx\"";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        // Обработчик события для ввода текста в поле ввода
        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Определяем выбранную исходную систему счисления
                string selectedFromBase = fromComboBox.SelectedItem.ToString();
                TextBox textBox = sender as TextBox;

                // Проверяем, что целое число не начинается с нуля (разрешаем ввод дробных чисел)
                if (textBox.Text == "0" && char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Число в десятичной системе не может начинаться с 0, если это не дробное число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверяем, что в любой системе счисления число не начинается с нуля или -0
                if ((textBox.Text == "-" && e.KeyChar == '0'))
                {
                    e.Handled = true;
                    MessageBox.Show("Число не может начинаться с -0.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Разрешаем ввод только определенных символов в зависимости от выбранной исходной системы счисления
                bool isValidInput = false;
                switch (selectedFromBase)
                {
                    case "Двоичная":
                        isValidInput = e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    case "Десятичная":
                        isValidInput = char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    case "Восьмеричная":
                        isValidInput = (e.KeyChar >= '0' && e.KeyChar <= '7') || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    case "Шестнадцатеричная":
                        isValidInput = (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    case "Троичная":
                        isValidInput = e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    case "Четверичная":
                        isValidInput = (e.KeyChar >= '0' && e.KeyChar <= '3') || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    case "Пятеричная":
                        isValidInput = (e.KeyChar >= '0' && e.KeyChar <= '4') || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    case "Двенадцатеричная":
                        isValidInput = (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 'A' || e.KeyChar == 'a' || e.KeyChar == 'B' || e.KeyChar == 'b') || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar);
                        break;
                    default:
                        isValidInput = false;
                        break;
                }

                if (!isValidInput)
                {
                    e.Handled = true;

                    // Выводим сообщение об ошибке, если введен символ, который не используется в выбранной исходной системе счисления
                    string message = $"Нельзя вводить символ '{e.KeyChar}' в выбранной системе счисления ({selectedFromBase})";
                    string caption = "Ошибка ввода";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(message, caption, buttons, icon);
                }

                // Разрешаем ввод только одного разделителя дробной части (запятой или точки)
                if ((e.KeyChar == ',' || e.KeyChar == '.') && !char.IsControl(e.KeyChar))
                {
                    if (textBox.Text.Contains(",") || textBox.Text.Contains("."))
                    {
                        e.Handled = true;
                        MessageBox.Show("Нельзя вводить несколько запятых или точек", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                        MessageBox.Show("Перед вводом запятой или точки необходимо ввести целую часть", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Разрешаем ввод только одного минуса - только в начале строки
                if (e.KeyChar == '-' && !char.IsControl(e.KeyChar))
                {
                    if (textBox.Text.Contains("-") || textBox.SelectionStart != 0)
                    {
                        e.Handled = true;
                        MessageBox.Show("Символ '-' может быть введен только в начале числа и только один раз", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик события для кнопки конвертации
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // Проверяем, что выбраны обе системы счисления
            if (fromComboBox.SelectedItem == null || toComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите исходную и целевую системы счисления перед конвертацией.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем введенное пользователем значение
            string input = inputTextBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Пожалуйста, введите число для конвертации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем наличие дробной части, если введена запятая или точка
            if (input.Contains(",") || input.Contains("."))
            {
                string[] parts = input.Split(new char[] { ',', '.' });
                if (parts.Length != 2 || string.IsNullOrEmpty(parts[1]))
                {
                    MessageBox.Show("Пожалуйста, введите дробную часть после запятой или точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Получаем введенное пользователем значение
            if (!string.IsNullOrEmpty(input))
            {
                if (!string.IsNullOrEmpty(input))
                {
                    string fromBase = fromComboBox.SelectedItem.ToString();
                    string toBase = toComboBox.SelectedItem.ToString();
                    string output;
                    try
                    {
                        switch (fromBase)
                        {
                            case "Десятичная":
                                switch (toBase)
                                {
                                    case "Двоичная":
                                        output = ConvertFromDecimal(input, 2);
                                        break;
                                    case "Восьмеричная":
                                        output = ConvertFromDecimal(input, 8);
                                        break;
                                    case "Шестнадцатеричная":
                                        output = ConvertFromDecimal(input, 16);
                                        break;
                                    case "Троичная":
                                        output = ConvertFromDecimal(input, 3);
                                        break;
                                    case "Четверичная":
                                        output = ConvertFromDecimal(input, 4);
                                        break;
                                    case "Двенадцатеричная":
                                        output = ConvertFromDecimal(input, 12);
                                        break;
                                    case "Пятеричная":
                                        output = ConvertFromDecimal(input, 5);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }
                                break;
                            case "Двоичная":
                                switch (toBase)
                                {
                                    case "Десятичная":
                                        output = ConvertToDecimal(input, 2);
                                        break;
                                    case "Восьмеричная":
                                        string decimalValue = ConvertToDecimal(input, 2);
                                        output = ConvertFromDecimal(decimalValue, 8);
                                        break;
                                    case "Шестнадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 2);
                                        output = ConvertFromDecimal(decimalValue, 16);
                                        break;
                                    case "Троичная":
                                        decimalValue = ConvertToDecimal(input, 2);
                                        output = ConvertFromDecimal(decimalValue, 3);
                                        break;
                                    case "Четверичная":
                                        decimalValue = ConvertToDecimal(input, 2);
                                        output = ConvertFromDecimal(decimalValue, 4);
                                        break;
                                    case "Двенадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 2);
                                        output = ConvertFromDecimal(decimalValue, 12);
                                        break;
                                    case "Пятеричная":
                                        decimalValue = ConvertToDecimal(input, 2);
                                        output = ConvertFromDecimal(decimalValue, 5);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }
                                break;
                            case "Восьмеричная":
                                switch (toBase)
                                {
                                    case "Десятичная":
                                        output = ConvertToDecimal(input, 8);
                                        break;
                                    case "Двоичная":
                                        string decimalValue = ConvertToDecimal(input, 8);
                                        output = ConvertFromDecimal(decimalValue, 2);
                                        break;
                                    case "Шестнадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 8);
                                        output = ConvertFromDecimal(decimalValue, 16);
                                        break;
                                    case "Троичная":
                                        decimalValue = ConvertToDecimal(input, 8);
                                        output = ConvertFromDecimal(decimalValue, 3);
                                        break;
                                    case "Четверичная":
                                        decimalValue = ConvertToDecimal(input, 8);
                                        output = ConvertFromDecimal(decimalValue, 4);
                                        break;
                                    case "Двенадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 8);
                                        output = ConvertFromDecimal(decimalValue, 12);
                                        break;
                                    case "Пятеричная":
                                        decimalValue = ConvertToDecimal(input, 8);
                                        output = ConvertFromDecimal(decimalValue, 5);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }
                                break;
                            case "Шестнадцатеричная":
                                switch (toBase)
                                {
                                    case "Десятичная":
                                        output = ConvertToDecimal(input, 16);
                                        break;
                                    case "Двоичная":
                                        string decimalValue = ConvertToDecimal(input, 16);
                                        output = ConvertFromDecimal(decimalValue, 2);
                                        break;
                                    case "Восьмеричная":
                                        decimalValue = ConvertToDecimal(input, 16);
                                        output = ConvertFromDecimal(decimalValue, 8);
                                        break;
                                    case "Троичная":
                                        decimalValue = ConvertToDecimal(input, 16);
                                        output = ConvertFromDecimal(decimalValue, 3);
                                        break;
                                    case "Четверичная":
                                        decimalValue = ConvertToDecimal(input, 16);
                                        output = ConvertFromDecimal(decimalValue, 4);
                                        break;
                                    case "Двенадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 16);
                                        output = ConvertFromDecimal(decimalValue, 12);
                                        break;
                                    case "Пятеричная":
                                        decimalValue = ConvertToDecimal(input, 16);
                                        output = ConvertFromDecimal(decimalValue, 5);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }
                                break;
                            case "Троичная":
                                switch (toBase)
                                {
                                    case "Десятичная":
                                        output = ConvertToDecimal(input, 3);
                                        break;
                                    case "Двоичная":
                                        string decimalValue = ConvertToDecimal(input, 3);
                                        output = ConvertFromDecimal(decimalValue, 2);
                                        break;
                                    case "Восьмеричная":
                                        decimalValue = ConvertToDecimal(input, 3);
                                        output = ConvertFromDecimal(decimalValue, 8);
                                        break;
                                    case "Шестнадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 3);
                                        output = ConvertFromDecimal(decimalValue, 16);
                                        break;
                                    case "Четверичная":
                                        decimalValue = ConvertToDecimal(input, 3);
                                        output = ConvertFromDecimal(decimalValue, 4);
                                        break;
                                    case "Двенадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 3);
                                        output = ConvertFromDecimal(decimalValue, 12);
                                        break;
                                    case "Пятеричная":
                                        decimalValue = ConvertToDecimal(input, 3);
                                        output = ConvertFromDecimal(decimalValue, 5);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }
                                break;
                            case "Четверичная":
                                switch (toBase)
                                {
                                    case "Десятичная":
                                        output = ConvertToDecimal(input, 4);
                                        break;
                                    case "Двоичная":
                                        string decimalValue = ConvertToDecimal(input, 4);
                                        output = ConvertFromDecimal(decimalValue, 2);
                                        break;
                                    case "Восьмеричная":
                                        decimalValue = ConvertToDecimal(input, 4);
                                        output = ConvertFromDecimal(decimalValue, 8);
                                        break;
                                    case "Шестнадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 4);
                                        output = ConvertFromDecimal(decimalValue, 16);
                                        break;
                                    case "Троичная":
                                        decimalValue = ConvertToDecimal(input, 4);
                                        output = ConvertFromDecimal(decimalValue, 3);
                                        break;
                                    case "Двенадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 4);
                                        output = ConvertFromDecimal(decimalValue, 12);
                                        break;
                                    case "Пятеричная":
                                        decimalValue = ConvertToDecimal(input, 4);
                                        output = ConvertFromDecimal(decimalValue, 5);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }
                                break;
                            case "Двенадцатеричная":
                                switch (toBase)
                                {
                                    case "Десятичная":
                                        output = ConvertToDecimal(input, 12);
                                        break;
                                    case "Двоичная":
                                        string decimalValue = ConvertToDecimal(input, 12);
                                        output = ConvertFromDecimal(decimalValue, 2);
                                        break;
                                    case "Восьмеричная":
                                        decimalValue = ConvertToDecimal(input, 12);
                                        output = ConvertFromDecimal(decimalValue, 8);
                                        break;
                                    case "Шестнадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 12);
                                        output = ConvertFromDecimal(decimalValue, 16);
                                        break;
                                    case "Троичная":
                                        decimalValue = ConvertToDecimal(input, 12);
                                        output = ConvertFromDecimal(decimalValue, 3);
                                        break;
                                    case "Четверичная":
                                        decimalValue = ConvertToDecimal(input, 12);
                                        output = ConvertFromDecimal(decimalValue, 4);
                                        break;
                                    case "Пятеричная":
                                        decimalValue = ConvertToDecimal(input, 12);
                                        output = ConvertFromDecimal(decimalValue, 5);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }

                                break;
                            case "Пятеричная":
                                switch (toBase)
                                {
                                    case "Десятичная":
                                        output = ConvertToDecimal(input, 5);
                                        break;
                                    case "Двоичная":
                                        string decimalValue = ConvertToDecimal(input, 5);
                                        output = ConvertFromDecimal(decimalValue, 2);
                                        break;
                                    case "Восьмеричная":
                                        decimalValue = ConvertToDecimal(input, 5);
                                        output = ConvertFromDecimal(decimalValue, 8);
                                        break;
                                    case "Шестнадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 5);
                                        output = ConvertFromDecimal(decimalValue, 16);
                                        break;
                                    case "Троичная":
                                        decimalValue = ConvertToDecimal(input, 5);
                                        output = ConvertFromDecimal(decimalValue, 3);
                                        break;
                                    case "Четверичная":
                                        decimalValue = ConvertToDecimal(input, 5);
                                        output = ConvertFromDecimal(decimalValue, 4);
                                        break;
                                    case "Двенадцатеричная":
                                        decimalValue = ConvertToDecimal(input, 5);
                                        output = ConvertFromDecimal(decimalValue, 12);
                                        break;
                                    default:
                                        output = "Нельзя перевести в одну и ту же систему счисления";
                                        break;
                                }
                                break;

                            default:
                                output = "Не поддерживаемая конвертация";
                                break;
                        }
                        outputTextBox.Text = output;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите корректное число в выбранной исходной системе счисления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string ConvertFromDecimal(string input, int baseNumber)
        {
            input = input.Replace(',', '.');

            decimal decimalValue; // Объявление переменной
            if (decimal.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out decimalValue))
            {
                // Определяем знак числа
                bool isNegative = decimalValue < 0;

                // Получаем целую и дробную части числа
                long integerPart = (long)Math.Abs(decimalValue);
                decimal fractionalPart = Math.Abs(decimalValue) - integerPart;

                // Конвертируем целую часть
                string integerPartConverted = ConvertIntegerPartFromDecimal(integerPart, baseNumber);

                // Конвертируем дробную часть, если она есть
                string fractionalPartConverted = string.Empty;
                if (fractionalPart > 0)
                {
                    fractionalPartConverted = ConvertFractionalPartFromDecimal(fractionalPart, baseNumber);
                }

                string result = isNegative ? "-" : "";
                result += integerPartConverted;
                if (!string.IsNullOrEmpty(fractionalPartConverted) && fractionalPartConverted != "0")
                {
                    result += "." + fractionalPartConverted;
                }

                return result;
            }
            else
            {
                return "Неверный ввод";
            }
        }

        //Конвертация целой части из 10чного числа
        public static string ConvertIntegerPartFromDecimal(decimal decimalValue, int baseNumber)
        {
            if (decimalValue == 0)
                return "0";

            // Специальные символы для оснований больше 10
            char[] baseDigits = "0123456789ABCDEF".ToCharArray();

            // Если основание больше допустимого количества символов
            if (baseNumber > baseDigits.Length)
                throw new ArgumentOutOfRangeException(nameof(baseNumber), "Базовое число слишком большое.");

            string result = "";
            long value = (long)Math.Abs(decimalValue);

            while (value > 0)
            {
                long remainder = value % baseNumber;
                result = baseDigits[remainder] + result;
                value /= baseNumber;
            }
            return result;
        }

        //Конвертация дробной части из 10чного числа
        public static string ConvertFractionalPartFromDecimal(decimal fractionalPart, int baseNumber)
        {
            const int maxFractionalDigits = 10;
            string result = "";

            for (int i = 0; i < maxFractionalDigits; i++)
            {
                fractionalPart *= baseNumber;

                int integerPart = (int)fractionalPart;
                result += integerPart.ToString();

                fractionalPart -= integerPart;

                if (fractionalPart == decimal.Zero)
                {
                    break;
                }
            }

            // Добавляем специфическую обработку для двенадцатеричной системы
            if (baseNumber == 12)
            {
                char[] duodecimalDigits = "0123456789AB".ToCharArray();

                for (int i = 0; i < maxFractionalDigits; i++)
                {
                    fractionalPart *= 12;

                    int integerPart = (int)fractionalPart;
                    result += duodecimalDigits[integerPart];

                    fractionalPart -= integerPart;

                    if (fractionalPart == decimal.Zero)
                    {
                        break;
                    }
                }
            }
            // Добавляем специфическую обработку для шестнадцатеричной системы
            else if (baseNumber == 16)
            {
                for (int i = 0; i < maxFractionalDigits; i++)
                {
                    fractionalPart *= 16;

                    int integerPart = (int)fractionalPart;
                    result += integerPart.ToString("X");

                    fractionalPart -= integerPart;

                    if (fractionalPart == decimal.Zero)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        //Конвертация в 10чное число
        public static string ConvertToDecimal(string input, int baseNumber)
        {
            bool isNegative = input.StartsWith("-");
            if (isNegative)
            {
                input = input.Substring(1); // Убираем знак минус для дальнейшей обработки
            }


            // Разделяем целую и дробную части числа
            string[] parts = input.Split(new char[] { '.', ',' });
            string integerPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : "";

            // Конвертируем целую часть в десятичную систему
            decimal integerDecimal = ConvertIntegerPartToDecimal(integerPart, baseNumber);

            // Конвертируем дробную часть в десятичную систему
            decimal fractionalDecimal = ConvertFractionalPartToDecimal(fractionalPart, baseNumber);

            // Собираем итоговое значение
            decimal result = integerDecimal + fractionalDecimal;
            if (isNegative)
            {
                result = -result;
            }
            return result.ToString();
        }

        //Конвертация целой части в 10чное число
        public static decimal ConvertIntegerPartToDecimal(string value, int baseNumber)
        {
            decimal result = 0;
            int length = value.Length;

            for (int i = 0; i < length; i++)
            {
                char digit = value[i];
                int digitValue = 0;

                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else if (char.ToUpper(digit) >= 'A' && char.ToUpper(digit) <= 'F')
                {
                    digitValue = char.ToUpper(digit) - 'A' + 10;
                }
                else
                {
                    throw new ArgumentException($"Неверное число '{digit}' для системы с основанием {baseNumber}");
                }

                result += digitValue * (decimal)Math.Pow(baseNumber, length - i - 1);
            }

            return result;
        }

        //Конвертация дробной части в 10чное число
        public static decimal ConvertFractionalPartToDecimal(string value, int baseNumber)
        {
            value = value.Replace(',', '.');

            decimal result = 0;
            int length = value.Length;

            for (int i = 0; i < length; i++)
            {
                char digit = value[i];
                int digitValue = 0;

                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else if (char.ToUpper(digit) >= 'A' && char.ToUpper(digit) <= 'F')
                {
                    digitValue = char.ToUpper(digit) - 'A' + 10;
                }

                result += digitValue / (decimal)Math.Pow(baseNumber, i + 1);
            }

            return result;
        }
    }
}