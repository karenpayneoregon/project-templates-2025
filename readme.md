# Sample VS2022 project templates

The template are to give developers an idea how to use custom project templates in Visual Studio 2022 rather than sstandard project templates.

## Export folder

C:\Users\\`username`\\Documents\Visual Studio 2022\My Exported Templates

- Replace `username` with your Windows user name.
- Replace `Visual Studio 2022` with the appropriate version.

## Two project template

See folder `TwoProjectTemplateSample` for a sample project template that creates two projects in a solution.

Note that when uses give the project name something like `Support`. This is because when using the template the template property to create the projects in the root of the solution is ignored.

## :bulb: copilot-instructions.md

Each project template has a `copilot-instructions.md` file that describes the project template and how to use it.

To view the file, select a project template in the Solution Explorer and then under the project menu select `Show all files` and the file is under the `.github` folder.

## :stop_sign: Data operations

Any project with a connection string in `appsettings.json` will to change to match local database.