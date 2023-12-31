﻿using Microsoft.Toolkit.Uwp.UI.Helpers;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ivirius_Hub.Pages.CrimsonUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CheckBoxCUI : Page
    {
        public CheckBoxCUI()
        {
            this.InitializeComponent();
            var x = new ThemeListener();
            if (x.CurrentTheme == ApplicationTheme.Light) ItemsViewer.RequestedTheme = ElementTheme.Light;
            else ItemsViewer.RequestedTheme = ElementTheme.Dark;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window.Current.Content as Frame).Content as MainPage).NavigateToStore();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsViewer.RequestedTheme == ElementTheme.Dark) ItemsViewer.RequestedTheme = ElementTheme.Light;
            else ItemsViewer.RequestedTheme = ElementTheme.Dark;
        }
    }
}
