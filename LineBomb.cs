using System;
using System.Collections.Generic;

namespace Match3GameForrest
{
    public class LineBomb : Bonus
    {
        private int _direction; // Направление бонуса (вертикальное или горизонтальное)
        private Color _color; // Цвет бонуса, соответствующий цвету элементов, участвующих в матче

        public LineBomb(GameField field, int direction, Color color)
            : base(field)
        {
            _direction = direction;
            _color = color;
        }

        public override void ApplyEffect()
        {
            // Здесь будет логика применения эффекта LineBomb
            // удаление элементов вокруг места возникновения бонуса
            Console.WriteLine($"Applying LineBomb effect in {_direction} direction with color {_color}");

            // Здесь будет реализация логики удаления элементов
            // удаление всех элементов вокруг места возникновения бонуса
        }
    }
}