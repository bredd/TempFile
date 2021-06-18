using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CodeBit.IO;
using System.Diagnostics;

namespace TempFileUnitTest
{
    class Program
    {
        const string sampleText = "All your base are belong to us.";

        static void Main(string[] args)
        {
            try
            {
                string saveName;
                using (var tempFile = new TempFile())
                {
                    Console.WriteLine($"Filename: {tempFile.FullName}");
                    Trace.Assert(File.Exists(tempFile.FullName));

                    using (var stream = tempFile.Open())
                    {
                        using (var writer = new StreamWriter(stream, Encoding.UTF8, 128, true))
                        {
                            writer.WriteLine(sampleText);
                        }
                        stream.Position = 0;
                        using (var reader = new StreamReader(stream, true))
                        {
                            Trace.Assert(string.Equals(reader.ReadLine(), sampleText, StringComparison.Ordinal));
                        }
                    }

                    Trace.Assert(File.Exists(tempFile.FullName));

                    saveName = tempFile.FullName;
                }

                Trace.Assert(!File.Exists(saveName));
                Console.WriteLine("All tests complete.");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
