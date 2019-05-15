using System;

namespace IODS.Handlers
{
    public class ProgramFlowHandling
    {
        public static void Exit(string exitMessage)
        {
            OutputHandling.ExitMessage(exitMessage);
            Console.ReadKey();
        }
    }
}
