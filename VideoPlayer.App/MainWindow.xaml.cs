using System;
using System.Windows;
using Microsoft.Win32;
//

namespace VideoPlayer.App;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonOpen_OnClick(object sender, RoutedEventArgs e)
    {
        var fileOpenDialog = new OpenFileDialog()
        {
            Filter = "Video|*.mp4",
            Title = "Открыть видео-файл"
        };
        var result = fileOpenDialog.ShowDialog();
        if (result != true) return;
        Video.Source = new Uri(fileOpenDialog.FileName);
        StatusBar.Content = $"Path: {fileOpenDialog.FileName}";
    }

    private void ButtonPlay_OnClick(object sender, RoutedEventArgs e)
    {
        Video.Play();
        StatusBar.Content = "Play";
    }

    private void ButtonPause_OnClick(object sender, RoutedEventArgs e)
    {
        Video.Pause();
        StatusBar.Content = "Pause";
    }

    private void ButtonStop_OnClick(object sender, RoutedEventArgs e)
    {
        Video.Stop();
        StatusBar.Content = "Stop";
    }
}
