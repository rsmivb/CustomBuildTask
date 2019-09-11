using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace BuildCustomTask
{
    public class MyCustomBuildTask : Task
    {
        [Required]
        public string Value { get; set; }
        public override bool Execute()
        {
            // Your logic goes here
            Log.LogMessage(MessageImportance.High, $"Hi, I'm running a custom build task -> {Value}");
            return true;
        }
    }
}
