﻿using EasyEat.HelperClasses;
using EasyEat.Pages;
using EasyEat.Windows;
using System.Windows;

namespace EasyEat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            EatDishWindow eatDishWindow = new EatDishWindow();
            eatDishWindow.ShowDialog();

            FrameManager.MainFrame = MainWindowFrame;
            FrameManager.MainFrame.Navigate(new StartPage());
        }
    }
}
