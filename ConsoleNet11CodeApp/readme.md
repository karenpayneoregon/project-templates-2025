# About

Project template for .NET 11 with the following



| Package | Description | 
| :--- | :--- | 
| Serilog | Logging to file | 
| Spectre.Console | Console UI library | 
| Spectre.Console.Json | JSON support for Spectre.Console | 

---

## Pills

| Method Name        | Description |
|:-------------------|:------------|
| ExitPrompt         | Shows a “press any key to exit” prompt and waits for user input. |
| InfoPill           | Displays an informational (blue) pill with specified alignment and optional text. |
| ErrorPill          | Displays an error (red) pill with specified alignment and optional text. |
| ErrorPill          | Displays an error pill alongside an exception message for detailed error output. |
| SuccessPill        | Displays a success (green) pill with specified alignment and optional text. |
| WarningPill        | Displays a warning (yellow) pill with specified alignment and optional text. |
| WindowTitle        | Renders a centered, styled window title using a Spectre.Console info pill. |

---

## Read connection string from appsettings.json

See Core\DataConnections

## User Interaction

| Method Signature | Description |
|:-----------------|:------------|
| ExitPrompt(Justify alignment = Justify.Center) | Displays a “press any key to exit” prompt and blocks until input. |

---

## Console Configuration

| Method Signature | Description |
|:-----------------|:------------|
| SetEncoding() | Sets console input/output encoding to UTF-8 without a BOM. |

---

## ExceptionSettings Style

| Method Signature | Description |
|:-----------------|:------------|
| ExceptionSettingsStyle | Defines styles used with `AnsiConsole.WriteException` |

