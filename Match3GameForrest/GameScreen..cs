using System;
using System.Drawing;
using System.Windows.Forms;

namespace Match3GameForrest
{
    public partial class GameScreen : UserControl
    {
        private GameField gameField;
        private Timer timer;
        private Label scoreLabel;
        private Label timeLabel;
        private int score = 0;
        private int timeLeft = 60;

        public GameScreen()
        {
            // Инициализация игрового поля и других элементов UI
            InitializeGameField();
            InitializeTimer();
            InitializeUIComponents();

            // Отслеживание событий мыши для взаимодействия с игровым полем
            this.MouseClick += GameScreen_MouseClick;
        }

        private void InitializeGameField()
        {
            gameField = new GameField(8);
            // Добавить логику инициализации игрового поля
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }

        private void InitializeUIComponents()
        {
            scoreLabel = new Label();
            scoreLabel.Text = $"Score: {score}";
            Controls.Add(scoreLabel);

            timeLabel = new Label();
            timeLabel.Text = $"Time Left: {timeLeft}s";
            Controls.Add(timeLabel);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timeLabel.Text = $"Time Left: {timeLeft}s";

            if (timeLeft <= 0)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            MessageBox.Show("Game Over");
            //Добавить логику для возврата в главное меню
        }

        private void GameScreen_MouseClick(object sender, MouseEventArgs e)
        {
            // Логика обработки клика мыши
            // Например, выделение элемента под курсором
        }

        // ВОзможно,напишу дополнительные методы для управления игрой, например, обработчики событий мыши
    }
}
