﻿using System;
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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace project
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Page1));

        }
        private void NavView_SelectionChanged(
             Windows.UI.Xaml.Controls.NavigationView sender,
             NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                NavView.Header = "SettingsPage";
            }
            else
            {
                NavigationViewItem item =
                    args.SelectedItem as NavigationViewItem;

                switch (item.Tag)
                {
                    case "PortraitItem":
                        NavView.Header = "Portrait";
                        Frame.Navigate(typeof(Page1));
                        break;

                    case "SceneryItem":
                        NavView.Header = "Scenery";
                       Frame.Navigate(typeof(scenery));
                        break;

                    case "FoodItem":
                        NavView.Header = "Food";
                        Frame.Navigate(typeof(food));
                        break;
                    case "DrawItem":
                        NavView.Header = "Draw";
                        Frame.Navigate(typeof(draw));
                        break;

                }
            }
        }
    }
}
