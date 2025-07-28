using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp2025.Classes;

namespace WpfApp2025;
    /// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        SetupLogging.Development();
    }
}

