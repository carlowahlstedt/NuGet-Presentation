using System;
using System.Collections.Generic;
using NuspecGenerator;

namespace NuspecGeneratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var pullCord = new PullCord()
            {
                ID = "Nuspec",
                VersionNumber = new Version(0, 1)
            };
            pullCord.Dependencies.Add(new Dependency()
            {
                ID = "System"
            });
            pullCord.Dependencies.Add(new Dependency()
            {
                ID = "System.Core",
                VersionNumber = new Version(4,0,0,0)
            });

            var output = pullCord.Yank();

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
