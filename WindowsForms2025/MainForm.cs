
using Serilog;

namespace WindowsForms2025;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        Log.Information("MainForm initialized");
    }

}
