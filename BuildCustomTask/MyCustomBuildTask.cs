using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;

namespace BuildCustomTask
{
    public class MyCustomBuildTask : Task
    {
        [Required]
        public string Value { get; set; }
        [Required]
        public string CsProjPath { get; set; }
        public string CsProjItemType { get; set; }
        public override bool Execute()
        {
            // Your logic goes here
            Log.LogMessage(MessageImportance.Normal, $"Hi, I'm running a custom build task -> {Value}");
            // Read csproj and expose it on custom buildTask
            try
            {
                var items = new CsProjReader().GetItems(CsProjPath, CsProjItemType);
                Log.LogMessage($"Reading values from {CsProjItemType}");
                foreach (var item in items)
                {
                    Log.LogMessage(MessageImportance.High, $"Item -> EvaluatedInclude: {item.EvaluatedInclude}, UnevaluadedInclude: {item.UnevaluatedInclude}");
                }
            }
            catch (Exception ex)
            {
                Log.LogErrorFromException(ex);
                return false;
            }
            return true;
        }
    }
}
