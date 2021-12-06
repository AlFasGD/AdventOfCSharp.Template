using AdventOfCSharp;

// Enter your main project's namespace
namespace AdventOfCode;

public class Program : BaseProgram
{
    public static void Main()
    {
        // Ensure that, before all, the custom problem file path is set appropriately,
        // if you so choose
        SetCustomProblemFilePath();

        EnterMainMenu();
    }
    
    private static void SetCustomProblemFilePath()
    {
        // Additionally, you may optionally set your problem file (input and output) directory
        // to a custom path instead of the default, which is the base directory of your project
        // NOTE: If you're using a custom build path, it is almost always recommended to set the
        //       custom base directory to whatever best fits you.
        // Ideally, you may also move this function to a private file that will be included in
        // .gitignore and be called in Main()
        ProblemFiles.CustomBaseDirectory = "my custom directory";
    }
}