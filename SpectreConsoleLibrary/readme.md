# About

Provides various methods for Spectre.Console listed below.

:small_orange_diamond: If pills may need to use `SpectreConsoleHelpers.SetEncoding();` at start of a project to ensure proper UTF-8 encoding.

- Uses NET 9.0
- Spectre.Console library version 0.54.0

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

## Diagnostics & Caller Info

| Method Signature | Description |
|:-----------------|:------------|
| PrintCyan(string? methodName = null) | Prints the calling method name in cyan using CallerMemberName. |
| PrintPink(string? filePath = null, string? methodName = null) | Prints project, file, and method name using pink/yellow formatting. |

---

## Spectre.Console Markup Utilities

| Method Signature | Description |
|:-----------------|:------------|
| ConsoleEscape(this string sender) | Escapes Spectre.Console markup characters in a string. |
| ConsoleRemove(this string sender) | Removes Spectre.Console markup from a string. |
| PanelDisplay(string content, string title = "", Justify alignment = Justify.Center) | Displays content within a styled Spectre.Console panel with title and alignment. |


## JSON Utilities

| Method Signature | Description |
|:-----------------|:------------|
| WriteJson(string json) | Writes a JSON string to the console with common syntax highlighting. |

---