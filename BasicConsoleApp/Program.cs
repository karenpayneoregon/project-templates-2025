

namespace BasicConsoleApp;
internal partial class Program
{
    private static void Main(string[] args)
    {

        SCL.PanelDisplay(" :information:  [yellow]Code sample[/] ", "This project is for demonstrating [b]SpectreConsoleLibrary2025[/]");
        Console.ReadLine();

        try
        {
            File.ReadAllLines("doesNotExists.txt");
        }
        catch (Exception ex)
        {
            AnsiConsole.WriteException(ex, SCL.ExceptionSettingsStyle);
        }

        // see BasicConsoleApp.SpectreSamples\DisplaySamples class for more examples
        SCL.ExitPrompt(Justify.Left);
    }

    private static string Data()
    {
        return """
               [
                 {
                   "AccountId": 1,
                   "Number": "KP100",
                   "UserName": "KarenPayne",
                   "PIN": "Payne111",
                   "FirstName": "Karen",
                   "LastName": "Payne",
                   "Transactions": [
                     {
                       "TransactionId": 1,
                       "AccountId": 1,
                       "TransactionType": 1,
                       "Description": "First deposit",
                       "Amount": 1000,
                       "TransactionDate": "2022-01-12T00:00:00"
                     },
                     {
                       "TransactionId": 2,
                       "AccountId": 1,
                       "TransactionType": 1,
                       "Description": "Second deposit",
                       "Amount": 150,
                       "TransactionDate": "2022-02-06T00:00:00"
                     },
                     {
                       "TransactionId": 3,
                       "AccountId": 1,
                       "TransactionType": 1,
                       "Description": "Third deposit",
                       "Amount": 1800,
                       "TransactionDate": "2022-03-22T00:00:00"
                     },
                     {
                       "TransactionId": 3,
                       "AccountId": 1,
                       "TransactionType": 2,
                       "Description": "First withdraw",
                       "Amount": 50,
                       "TransactionDate": "2022-04-15T00:00:00"
                     }
                   ],
                   "Balance": 2900,
                   "InsufficientFunds": false
                 },
                 {
                   "AccountId": 2,
                   "Number": "MA100",
                   "UserName": "MikeAdams",
                   "PIN": "Adams123",
                   "FirstName": "Mike",
                   "LastName": "Adams",
                   "Transactions": [
                     {
                       "TransactionId": 1,
                       "AccountId": 2,
                       "TransactionType": 1,
                       "Description": "First deposit for Mike",
                       "Amount": 2000,
                       "TransactionDate": "2022-05-02T00:00:00"
                     },
                     {
                       "TransactionId": 2,
                       "AccountId": 2,
                       "TransactionType": 1,
                       "Description": "Second deposit for Mike",
                       "Amount": 100,
                       "TransactionDate": "2022-05-08T00:00:00"
                     }
                   ],
                   "Balance": 2100,
                   "InsufficientFunds": false
                 }
               ]
               """;
    }
}
