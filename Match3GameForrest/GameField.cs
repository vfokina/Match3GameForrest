using System;
using System.Drawing;

namespace Match3GameForrest
{
    public class GameField
    {
        private Element[,] elements; // Хранение элементов в двумерном массиве

        public GameField(int size)
        {
            elements = new Element[size, size];
            InitializeField(); // Инициализация поля
        }

        private void InitializeField()
        {
            // Заполнение поля случайными значениями
            Random random = new Random();
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    int elementType = random.Next(1, 6); // Генерация случайного типа элемента
                    Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)); // Генерация случайного цвета
                    elements[i, j] = new RegularElement(color, new Rectangle(i * 32, j * 32, 32, 32)); // Создание элемента с случайным цветом и позицией
                }
            }
        }

        // Дополнительные методы для работы с игровым полем
        public void RemoveElements(int x, int y)
        {
            // Логика удаления элементов
        }

        public bool CheckCombination(int x, int y)
        {
            // Логика проверки на наличие комбинаций
            return false;
        }

        public void UpdateField()
        {
            // Логика обновления состояния игрового поля
        }
    }
}