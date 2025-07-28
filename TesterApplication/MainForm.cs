
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Serilog;
using TesterApplication.Models;

namespace TesterApplication;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void GetHelpDeskButton_Click(object sender, EventArgs e)
    {
        var helpDesk = GetHelpDesk();
        var message = $"Phone: {helpDesk.Phone}\nEmail: {helpDesk.Email}";
        Debug.WriteLine(message);
        Log.Information(message);
    }

    private void GetConnectionStringsButton_Click(object sender, EventArgs e)
    {
        var connectionStrings = GetConnectionStrings();
        var message = $"Main Connection: {connectionStrings.MainConnection}\nSecondary Connection: {connectionStrings.SecondaryConnection}";
        Debug.WriteLine(message);
        Log.Information(message);
    }

    private HelpDesk GetHelpDesk()
    {
        return new HelpDesk
        {
            Phone = Config.Helpers.GetSetting<string>(nameof(HelpDesk), nameof(HelpDesk.Phone)),
            Email = Config.Helpers.GetSetting<string>(nameof(HelpDesk), nameof(HelpDesk.Email))
        };
    }

    private ConnectionStrings GetConnectionStrings()
    {
        return new ConnectionStrings
        {
            MainConnection = Config.Helpers.GetSetting<string>(nameof(ConnectionStrings), nameof(ConnectionStrings.MainConnection)),
            SecondaryConnection = Config.Helpers.GetSetting<string>(nameof(ConnectionStrings), nameof(ConnectionStrings.SecondaryConnection))
        };
    }
}
