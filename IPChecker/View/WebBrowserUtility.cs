using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace IPChecker.View
{
    // Утилита дающая возможно использовать Binding для элемента WebBrowser.

    public static class WebBrowserUtility
    {
        //Регистрируем свойство.

        public static readonly DependencyProperty BindableSourceProperty =
            DependencyProperty.RegisterAttached("BindableSource", typeof(string), typeof(WebBrowserUtility), new UIPropertyMetadata(null, BindableSourcePropertyChanged));

        // Получаем прибиндженное свойство для uri.

        public static string GetBindableSource(DependencyObject obj)
        {
            return (string)obj.GetValue(BindableSourceProperty);
        }

        // Устанавливаем прибиндженное свойство для uri.

        public static void SetBindableSource(DependencyObject obj, string value)
        {
            obj.SetValue(BindableSourceProperty, value);
        }

        // Событие устанавливающее uri для источника WebBrowser

        public static void BindableSourcePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser browser = obj as WebBrowser;

            if (browser != null)
            {
                string uri = e.NewValue as string;

                browser.Source = !String.IsNullOrEmpty(uri) ? new Uri(uri) : null;
            }
        }
    }
}
