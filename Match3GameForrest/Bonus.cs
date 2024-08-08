using System;
using System.Collections.Generic;

namespace Match3GameForrest
{
    public abstract class Bonus
    {
        protected GameField Field { get; set; } // Свойство для доступа к игровому полю

        public abstract void ApplyEffect();

        protected List<Element> GetAffectedElements() // Метод для получения элементов, подлежащих эффекту
        {
            // Напишу логику выбора элементов, подлежащих эффекту бонуса
            // Например, для LineBonus это могут быть элементы вдоль линии
            throw new NotImplementedException();
        }
    }

    public class LineBonus : Bonus
    {
        public LineBonus(GameField field)
        {
            Field = field;
        }

        public override void ApplyEffect()
        {
            var affectedElements = GetAffectedElements();
            foreach (var element in affectedElements)
            {
                // Напишу логику применения эффекта LineBonus
                // Будет удаление элемента или замену на новый
                Console.WriteLine($"Applying LineBonus effect to {element}");
            }
        }
    }

    public class BombBonus : Bonus
    {
        public BombBonus(GameField field)
        {
            Field = field;
        }

        public override void ApplyEffect()
        {
            var affectedElements = GetAffectedElements();
            foreach (var element in affectedElements)
            {
                // Логика применения эффекта BombBonus
                // Будет удаление всех элементов вокруг взорвавшегося бонуса
                Console.WriteLine($"Applying BombBonus effect to {element}");
            }
        }
    }
}