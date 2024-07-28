using System;
using System.Drawing;

namespace Match3GameForrest
{

    public abstract class Element
    {
        public Color Color { get; set; }
        public Rectangle Position { get; set; }

        public Element(Color color, Rectangle position)
        {
            Color = color;
            Position = position;
        }

        public abstract void Draw(Graphics g); // Отрисовка элемента
    }
    public class RegularElement : Element
    {
        public RegularElement(Color color, Rectangle position) : base(color, position) { }

        public override void Draw(Graphics g)
        {
            // Рисование обычного элемента
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, Position);
            }
        }
    }
}