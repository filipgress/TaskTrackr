using Microsoft.AspNetCore.Mvc;

namespace TaskTrackr.IO;

public static class Logger
{
    private const string LogFile = "log.txt";

    public static void InternalError(Exception err)
    {
        try
        {
            var errMsg = $"Internal server error: '{err.Message}'";

            Console.WriteLine(errMsg);
            
            using var writer = new StreamWriter(LogFile, true);
            writer.WriteLine(errMsg);
        }
        catch (IOException _)
        {
            Console.WriteLine($"Error while logging to '{LogFile}'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: '{ex}'");
        }
    }

    public static void DbCreationError(string errMsg, Exception err)
    {
        try
        {
            Console.WriteLine(errMsg, err.Message);
            
            using var writer = new StreamWriter(LogFile, true);
            writer.WriteLine(errMsg, err.Message);
        }
        catch (IOException _)
        {
            Console.WriteLine($"Error while logging to '{LogFile}'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: '{ex}'");
        }
        
    }
}