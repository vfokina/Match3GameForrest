using System;

namespace Match3GameForrest
{
    public abstract class Bonus
    {
        public abstract void ApplyEffect(GameField field);
    }

    public class LineBonus : Bonus
    {
        public LineBonus(Element element)
        {
            // Сюда добавлю конструктор для LineBonus
        }

        public override void ApplyEffect(GameField field)
        {
            // Сюда добавлю логику применения эффекта LineBonus
        }
    }

    public class BombBonus : Bonus
    {
        public BombBonus(Element element)
        {
            // Сюда добавлю конструктор для BombBonus
        }

        public override void ApplyEffect(GameField field)
        {
            // Сюда добавлю логику применения эффекта BombBonus
        }
    }
}