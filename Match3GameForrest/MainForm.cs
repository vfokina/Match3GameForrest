using System;
using System.Drawing;
using System.Windows.Forms;

namespace Match3GameForrest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Создание кнопки Play и добавление её на форму
            Button playButton = new Button();
            playButton.Text = "Play";
            playButton.BackColor = Color.LightBlue; // Цвет фона кнопки
            playButton.ForeColor = Color.DarkBlue; // Цвет текста кнопки
            playButton.Font = new Font("Arial", 14); // Шрифт и размер текста кнопки
            playButton.Location = new Point((this.ClientSize.Width - playButton.Width) / 2, (this.ClientSize.Height - playButton.Height) / 2); // Центрирование кнопки
            this.Controls.Add(playButton);

            // Обработчик события нажатия на кнопку Play
            playButton.Click += (sender, args) =>
            {
                // Показ игрового экран при нажатии на кнопку Play
                var gameScreen = new GameScreen();
                gameScreen.Show();
                // Скрытие главного меню после перехода на игровой экран
                this.Hide();
            };
        }

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Match3 Game";
            this.StartPosition = FormStartPosition.CenterScreen; // Центрирование окна при старте
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Установка рамки без кнопок закрытия и минимизации
        }
    }
}