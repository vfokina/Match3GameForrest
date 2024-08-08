using Match3GameForrest;
using System.Collections.Generic;
using System.Drawing;
using System;

public class GameField
{
    private Element[,] elements; // Хранение элементов в двумерном массиве
    private const int Size = 8; // Размер игрового поля

    // Конструктор, который принимает размер игрового поля в качестве аргумента
    public GameField(int size)
    {
        elements = new Element[size, size];
        InitializeField(); // Инициализация поля
    }

    private void InitializeField()
    {
        Random random = new Random();
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                int elementType = random.Next(1, 6); // Генерация случайного типа элемента
                Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)); // Генерация случайного цвета
                elements[i, j] = new RegularElement(color, new Rectangle(i * 32, j * 32, 32, 32)); // Создание элемента с случайным цветом и позицией
            }
        }
    }

    // Метод для удаления элементов по координатам
    public void RemoveElements(int x, int y)
    {
        // Логика удаления элементов
        elements[x, y] = null;
    }

    // Метод для проверки наличия комбинаций
    public List<(int x, int y)> CheckCombination()
    {
        List<(int x, int y)> combinations = new List<(int x, int y)>();
        // Логика проверки наличия комбинаций
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                int count = CountSameElements(j, i, 3);
                if (count >= 3)
                {
                    combinations.Add((i, j));
                }
            }
        }
        return combinations;
    }

    private int CountSameElements(int direction, int start, int count)
    {
        int currentCount = 1;
        for (int i = start + 1; i < Size; i++)
        {
            switch (direction)
            {
                case 0: // Горизонтальная проверка
                    if (elements[start, i].GetType() == elements[start, start].GetType())
                        currentCount++;
                    else
                        break;
                    break;
                case 1: // Вертикальная проверка
                    if (elements[i, start].GetType() == elements[start, start].GetType())
                        currentCount++;
                    else
                        break;
                    break;
            }
            if (currentCount == count)
                return count;
        }
        return 0;
    }

    // Метод для обновления состояния игрового поля
    public void UpdateField(List<(int x, int y)> removedPositions)
    {
        // Логика обновления состояния игрового поля
    }
}