using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp2025.ViewModels;

/// <summary>
/// Represents the ViewModel for the main window in the WPF application.
/// </summary>
/// <remarks>
/// This class serves as the data context for the main window, providing commands and logic
/// to interact with the user interface. It includes an <see cref="ICommand"/> for exiting the application.
/// </remarks>
public class MainWindowViewModel
{
    public ICommand ExitCommand { get; } = new RelayCommand(ExecuteExit);

    private static void ExecuteExit(object obj)
    {
        Application.Current.MainWindow?.Close();
    }
}
