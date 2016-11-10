using System;
using System.Diagnostics;
using System.Linq;
using System.IO;
using Microsoft.DotNet.PlatformAbstractions;

namespace dotnetallversion
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Installed .Net versions are:");

            string clipath = Path.GetDirectoryName(new Microsoft.DotNet.Cli.Utils.Muxer().MuxerPath);
            DirectoryInfo di = new DirectoryInfo(Path.Combine(clipath,"sdk"));
        
            Console.WriteLine("Active version: " + Microsoft.DotNet.Cli.Utils.Product.Version);
            Console.WriteLine();

            foreach (var item in di.GetDirectories()){
                string versionfile = Path.Combine(item.FullName,".version");
                if (IsVersionFilePresent(versionfile))
                {
                    string version = item.Name;
                    string hash = GetHash(versionfile);
                    
                    string template = $@"Product Information:
 Version:            {version}
 Commit SHA-1 hash:  {hash}
";
                    Console.WriteLine(template);
                }
            }
            Console.WriteLine($@"Runtime Environment:
 OS Name:     {RuntimeEnvironment.OperatingSystem}
 OS Version:  {RuntimeEnvironment.OperatingSystemVersion}
 OS Platform: {RuntimeEnvironment.OperatingSystemPlatform}
 RID:         {RuntimeEnvironment.GetRuntimeIdentifier()}");
        }

        static string GetHash(string versionfile)
        {
            var lines = File.ReadAllLines(versionfile);
            return lines[0].Substring(0,8);
        }

        static bool IsVersionFilePresent(string versionfile){
            return File.Exists(versionfile);
        }
    }
}