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
            // Добавление кнопки Play и обработчик событий
            Button playButton = new Button();
            playButton.Text = "Play";
            this.Controls.Add(playButton);
            playButton.Click += (sender, args) =>
            {
                // Открытие игрового экрана
                var gameScreen = new GameScreen();
                gameScreen.Show();
            };
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Match3 Game";
            // Добавление кнопки Play через дизайнер формы
            Button playButton = new Button();
            playButton.Location = new Point(350, 275);
            playButton.Size = new Size(100, 30);
            playButton.Text = "Play";
            this.Controls.Add(playButton);
            this.ResumeLayout(false);
        }
    }
}
