using System;

namespace Wantsome_Week_04.Handlers
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
