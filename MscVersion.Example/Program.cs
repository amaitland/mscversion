using System;
using System.Linq;

namespace MscVersion.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var installedVersions = VcRuntime.GetInstalled((x) => true).ToList();

            Console.WriteLine("Installed VC++ Versions");

            foreach (var ver in installedVersions)
            {
                Console.WriteLine($"{ver.MscVer} {ver.Architecture} {ver.Version} {ver.ProductCode} ");
            }
        }
    }
}
