using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;


using SonicAudioLib;
using SonicAudioLib.CriMw;
using SonicAudioLib.IO;
using SonicAudioLib.Archives;

using System.Globalization;
using CsbBuilder.Project;
using CsbBuilder.Importer;
using CsbBuilder.Serialization;

namespace SUC_Converter
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    public static class SoundfileChecker
    {
        class CsbData
        {
            public string path;
            public CsbProject project;
            public CsbData(string p, CsbProject c)
            {
                path = p;
                project = c;
            }
        }
        public static void Func()
        {
            string path = "G:\\Steam\\steamapps\\common\\Sonic Generations\\mods\\Manual test";
            Console.WriteLine("Search all directories or manually insert files?");
            string option = Console.ReadLine();
            Random rnd = new Random();
            if (option == "1")
            {
                string[] files = Directory.GetFiles(path, "*.csb", SearchOption.AllDirectories);
                List<CsbData> datas = new List<CsbData>();
                foreach (string file in files)
                {
                    Console.WriteLine("Opening " + file);
                    CsbProject proj = new CsbProject();
                    CsbImporter.Import(file, proj);
                    datas.Add(new CsbData(file, proj));
                }

                for (int i = 0; i < datas.Count; i++)
                {
                    var csbData = datas[i];
                    for (int j = 0; j < datas.Count; j++)
                    {
                        if (i == j)
                            continue;

                        var csbData2 = datas[j];
                        for (int k = 0; k < csbData.project.CueNodes.Count; k++)
                        {
                            var cueTable1 = csbData.project.CueNodes[k];
                            for (int l = 0; l < csbData2.project.CueNodes.Count; l++)
                            {
                                var cueTable2 = csbData2.project.CueNodes[l];
                                if (cueTable1.Id == cueTable2.Id)
                                {
                                    Utility.ColoredTextLine($"{cueTable1.Name} in {Path.GetFileName(csbData.path)} has the same ID as {cueTable2.Id} in {Path.GetFileName(csbData2.path)}.", ConsoleColor.Yellow, ConsoleColor.Black);
                                    Console.WriteLine("Change ID for first or second?");
                                    string opt = Console.ReadLine();
                                    if (opt == "1")
                                    {
                                        datas[i].project.CueNodes[k].Id = (uint)(8000000 + rnd.Next(12288));
                                    }
                                    if (opt == "2")
                                    {
                                        datas[j].project.CueNodes[k].Id = (uint)(8000000 + rnd.Next(12288));
                                    }
                                }
                            }
                        }
                    }
                }
                //foreach (var proj in  datas)
                //{
                //
                //    CsbBuilder.Builder.CsbBuilder.Build(proj.project, proj.path);
                //}
            }
            if(option == "2")
            {
                //Console.WriteLine("Enter next file");
                //List<string> lines = new List<string>();
                //string lastLine = Console.ReadLine();
                //while (lastLine != "end")
                //{
                //    lines.Add(lastLine);
                //    Console.WriteLine("Enter next file");
                //    lastLine = Console.ReadLine();
                //}
                //List<CsbData> datas = new List<CSBData>();
                //foreach (string file in lines)
                //{
                //    Console.WriteLine("Opening " + file);
                //    try
                //    {
                //        datas.Add(CsbImporter.Import(file));
                //    }
                //    catch
                //    {

                //    }
                //}

                //foreach (var csbData in datas)
                //{
                //    foreach (var csbData2 in datas)
                //    {
                //        if (csbData.path == csbData2.path)
                //            continue;
                //        foreach (SerializationCueTable cueTable1 in csbData.cueTables)
                //        {
                //            foreach (SerializationCueTable cueTable2 in csbData2.cueTables)
                //            {
                //                if (cueTable1.Id == cueTable2.Id)
                //                {
                //                    Utility.ColoredTextLine($"{cueTable1.Name} in {Path.GetFileName(csbData.path)} has the same ID as {cueTable2.Id} in {Path.GetFileName(csbData2.path)}.", ConsoleColor.Yellow, ConsoleColor.Black);
                //                }
                //            }
                //        }
                //    }
                //}
            }
            

        }

        
    }
    
}

