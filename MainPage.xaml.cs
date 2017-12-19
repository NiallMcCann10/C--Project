using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Timer
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        Stopwatch Timmer = new Stopwatch();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Timmer.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            text.Text = Timmer.Elapsed.ToString();
            string milliseconds = Timmer.ElapsedMilliseconds.ToString();
            Timmer.Stop();
        }

    }
}
