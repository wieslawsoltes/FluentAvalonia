using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using FluentAvalonia.Core;
using FluentAvalonia.UI.Controls;
using FluentAvaloniaSamples.Pages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using IconElement = FluentAvalonia.UI.Controls.IconElement;

namespace FluentAvaloniaSamples.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

#if DEBUG
            this.AttachDevTools();
#endif
        }
    
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
