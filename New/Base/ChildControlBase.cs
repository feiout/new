using System.Windows;
using System.Windows.Controls;

namespace New.Base
{
    public class ChildControlBase : UserControl
    {
//        private int _loadedTimes;
        public static readonly RoutedEvent MyEvent = EventManager.RegisterRoutedEvent("MyCustom", RoutingStrategy.Bubble,
            typeof (RoutedEventHandler), typeof (ChildControlBase));
        public event RoutedEventHandler MyCustom
        {
            add { AddHandler(MyEvent,value);}
            remove { AddHandler(MyEvent,value);}
        }

    }
}