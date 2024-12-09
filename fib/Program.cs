//fib bundle --output 
using System.CommandLine;
using System.IO;
var bundleCommand = new Command("bundle", "Bundle code files to a single file");
var bundleOption = new Option<FileInfo>("--output", "file path and name");
bundleOption.AddAlias("o");

var languageOption = new Option<List<string>>("--language", "language in the bundle");
languageOption.AddAlias("l");
languageOption.IsRequired = true;   

bundleCommand.AddOption(bundleOption);
bundleCommand.AddOption(languageOption);
bundleCommand.SetHandler((output,lan) =>
{
    try
    {
        File.Create(output.FullName);
        for (int i = 0; i < lan.Count; i++)
        {
           // Directory.GetFiles(output
            string[] files = Directory.GetFiles(output.FullName,);
            if (lan[0] == "all")
            {

            }

            for (int j = 0; j < files.Length; j++)
            {
               

            }
        }
        Console.WriteLine("File was created");
    }
 
    catch(Exception ex)
    {
        Console.WriteLine("Error: File psth is invalid");
    }
},bundleOption,languageOption);
var rootCommand = new RootCommand("Root Command for file Bundler CLI");
rootCommand.AddCommand(bundleCommand);
rootCommand.InvokeAsync(args);