using System;
using System.Windows.Forms;

namespace Match3GameForrest
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();// Инициализация игрового поля и других элементов UI
        }
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Match3GameForrest";
            // Сюда добавлю код для инициализации элементов управления на форме
        }
    }

}