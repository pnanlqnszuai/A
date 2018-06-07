using System.ComponentModel;
using System;
using Notifications.Model;
using PostSharp;

namespace Notifications
{
    class Program
  {
    static void Main(string[] args)
    {
        var rect = new Rectangle();
        //((INotifyPropertyChanged) rect).PropertyChanged += OnPropertyChanged;
          Post.Cast<Rectangle, INotifyPropertyChanged>(rect).PropertyChanged += OnPropertyChanged;
        rect.Height = 200;

      Console.ReadKey();
    }

    private static void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        Console.WriteLine("Property changed: {0}", e.PropertyName);
    }
  }
}
