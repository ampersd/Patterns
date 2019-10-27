using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.behavioral
{
    class Bridge
    {
    }
    /// <summary>
    /// Зависимость от оконной системы содержится в классе реализации
    /// </summary>
    abstract class Window
    {
        private WindowImp _imp = new MacWindowImp();
        // задавать нужную реализацию можно через абстрактную фабрику, например 
        // WindowSystemFactory windowSystemFactory = new MacSystemFactory(); - где-то во время инициализации фабрики
        // _imp = windowSystemFactory.CreateWindowImp(); - в этом месте

        public void Raise()
        {
            _imp.DeviceRaise();
        }

        public void Rect()
        {
            _imp.DeviceRect();
        }
    }
    
    abstract class WindowImp
    {
        public abstract void DeviceRaise();
        public abstract void DeviceRect();
    }
    /// <summary>
    /// Конкретная реализация оконной системы
    /// </summary>
    class MacWindowImp : WindowImp
    {
        public override void DeviceRaise(){}
        public override void DeviceRect(){}
    }
}
