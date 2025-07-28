using System.Windows.Input;

namespace WpfApp2025.ViewModels;

/// <summary>
/// Represents a command that can be executed and determines whether it can execute based on a specified condition.
/// </summary>
/// <remarks>
/// This class implements the <see cref="System.Windows.Input.ICommand"/> interface, allowing it to be used for commanding in WPF applications.
/// It encapsulates an <see cref="Action{T}"/> delegate to execute the command logic and an optional <see cref="Predicate{T}"/> delegate to determine if the command can execute.
/// </remarks>
public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Predicate<object>? _canExecute;

    public RelayCommand(Action<object> execute, Predicate<object>? canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter!) ?? true;
    public void Execute(object? parameter) => _execute(parameter!);
    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}
