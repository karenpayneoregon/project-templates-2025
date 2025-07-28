using Serilog;
using System.Windows;
using WpfApp2025.ViewModels;

namespace WpfApp2025;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new MainWindowViewModel();
        Log.Information("MainWindow initialized");
    }

    private void ExecuteExit(object obj)
    {
        Application.Current.Shutdown();
    }
}