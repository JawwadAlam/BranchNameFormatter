namespace BranchNameFormatter;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var args = Environment.GetCommandLineArgs();

        if (args.Length > 1 && !string.IsNullOrWhiteSpace(args[0]))
        {
            string input = string.Join(" ", args.Skip(1).ToList());

            Form1.GenerateBranchName(input);
        }
        else
        {
            Application.Run(new Form1());
        }
    }
}