namespace patterns.generating
{
    class AbstractFactoryUse
    {
        AbstractFactoryUse()
        {
            GuiFactory guiFactory = new MotifFactory(); // Можем подставить конкретную реализацию интерфейса в этой строчке
            ScrollBar sb = guiFactory.CreateScrollBar();
        }
    }

    /// <summary>
    /// Абстрактная фабрика
    /// Определяет общий интерфейс для создания объектов
    /// В примере создается ScrollBar, но на самом деле должны быть методы для создания других объектов
    /// Button, Grid и пр.
    /// Особенностью паттерна является наличие Create... в названии операций
    /// </summary>
    abstract class GuiFactory
    {
        public abstract ScrollBar CreateScrollBar();
    }

    /// <summary>
    /// Реализация происходит в подклассах
    /// </summary>
    class MotifFactory : GuiFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }
    }

    class MacFactory : GuiFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new MacScrollBar();
        }
    }

    /// <summary>
    /// Глиф - это любой графический элемент, аналог класса object в c#
    /// </summary>
    class Glyph
    {
    }
    abstract class ScrollBar : Glyph
    {
    }

    class MotifScrollBar : ScrollBar
    {
        
    }

    class MacScrollBar : ScrollBar
    {
        
    }
}
