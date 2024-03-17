using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Media;
using SUC_Converter;

static class Program
{
    static int origRow;
    static int origCol;
    static string pathToStageArchive;
    static string pathToSetArchive;
    static string pathToStagePfd;
    static string pathToStagePfdAdd;


    static string m_FolderStage;
    static string m_FolderHashtag;
    static string m_FolderStagePFD;
    static string m_FolderStagePFDAdd;

    static string m_FolderNewHashtag;
    static string m_FolderNewStage;

    static string m_StageID = "ghz200";
    static List<string> m_ListOriginalFiles = new List<string>();
    static List<string> m_ListTempFolders= new List<string>();

    public static void CopyAndExtractAR(string pathToFirst, string destination, bool isArchive = true, bool forceNoExtract = false)
    {
        string pathC = @Path.Combine(destination, Path.GetFileName(@pathToFirst));
        //Has the file been copied before?
        if (!File.Exists(pathC))
        {
            string firstFileOutputPath = Path.Combine(destination, Path.GetFileName(pathToFirst));
            string filenameWithoutExtension = Utility.GetFullPathWithoutExtensionPastPoint(pathToFirst, isArchive ? ".ar" : ".pfd");
            bool shouldExit = false;
            // for .ar.00 files
            if (isArchive)
            {
                //Go through all possible extra archives, 100 because its unlikely archives will get bigger than that
                for (int i = 0; i < 100; i++)
                {
                    string pathToNumberedArchive = $"{filenameWithoutExtension}.ar.{i.ToString("D2")}";
                    //Does archive.ar.[i] exist?
                    if (File.Exists(pathToNumberedArchive))
                    {
                        if (shouldExit)
                        {
                            Utility.ColoredTextLine("[W] One of the ar numbered files is missing. This may cause ar0unpacker to unpack nothing.", ConsoleColor.Yellow, ConsoleColor.Black);
                        }

                        File.Copy(@pathToNumberedArchive, Path.Combine(destination, Path.GetFileName(@pathToNumberedArchive)));
                        m_ListOriginalFiles.Add(Path.Combine(destination, Path.GetFileName(@pathToNumberedArchive)));
                        Utility.xbdecompress(Path.Combine(destination, Path.GetFileName(@pathToNumberedArchive)));
                    }
                    else
                    {
                        if (!shouldExit)
                            shouldExit = true;
                        else
                            break;
                    }
                }
                //Copy .arl if it exists
                if (!File.Exists(Utility.GetFullPathWithoutExtensionPastPoint(firstFileOutputPath)))
                {
                    if (File.Exists(filenameWithoutExtension + ".arl"))
                    {
                        string outputPath = @Path.Combine(destination, Path.GetFileName(filenameWithoutExtension) + ".arl");
                        File.Copy(@filenameWithoutExtension + ".arl", outputPath);
                        m_ListOriginalFiles.Add(outputPath);
                        Utility.xbdecompress(outputPath);
                    }
                }

            }
            else // for .pfd files
            {
                if (!File.Exists(firstFileOutputPath))
                {
                    if (File.Exists(pathToFirst))
                    {
                        File.Copy(pathToFirst, firstFileOutputPath);
                        Utility.IsFileLocked(new FileInfo(@firstFileOutputPath));
                        m_ListOriginalFiles.Add(firstFileOutputPath);
                        Utility.xbdecompress(@firstFileOutputPath);
                    }
                }
            }

            if (!forceNoExtract)
                Utility.ExtractAR(@firstFileOutputPath);
        }
    }
    static void Main()
    {
        Startup();
    }
    public static void Startup()
    {
        Console.Clear();
        Utility.ColoredTextLine("SUC-Converter v0.4", ConsoleColor.Black, ConsoleColor.White);
        Utility.ColoredTextLine("Using ar0unpack, ar0pack, Unleashed2Generations from Skyth, HKXConverter from Team Unleashed, and XBCompress", ConsoleColor.DarkGray, ConsoleColor.Black);
        Console.WriteLine("Do you want to port a stage (1), separate level archives from Unleashed(2), or convert an Inspire cutscene to EVS(3)?");
        var choice = Console.ReadLine();
        if (choice == "1")
        {
            PorterScreen();
        }
        else if(choice == "2")
        {
            OrganizeFiles();
        }
        else if(choice == "3")
        {
            try
            {
                CutsceneConverter.Start();
            }
            catch(Exception e)
            {
                Utility.ColoredTextLine($"{e.Message} {e.StackTrace} {e.Source}", ConsoleColor.Red, ConsoleColor.Black);
                Utility.ColoredTextLine($"\n{e.InnerException}", ConsoleColor.Red, ConsoleColor.Black);
                Console.ReadLine();
            }
        }
    }
    static void OrganizeFiles()
    {
        Console.Clear();
        Console.WriteLine("Do you want to separate ALL archives from an extracted Unleashed copy (1) or do you want to separate just one (2)?");
        var choice = Console.ReadLine();
        if (choice == "1")
        {

            Console.WriteLine("Enter the path to your extracted Unleashed installation:");
            var path = Console.ReadLine();
            var files = Directory.EnumerateFiles(path).Where(x => x.Contains("#ActD_") && (x.EndsWith(".ar.00") || x.EndsWith(".ar")));
            var filesN = Directory.EnumerateFiles(path).Where(x => x.Contains("#ActN_") && (x.EndsWith(".ar.00") || x.EndsWith(".ar")));
            var total = files.ToList();
            total.AddRange(filesN);
            OrganizeFiles(total);
        }
        else
        {

        }
    }
    static void OrganizeFiles(List<string> files)
    {
        var m_FolderFilesOrg = Directory.CreateDirectory(Path.Combine(Utility.ProgramPath, "OrganizedFiles"));
        foreach(var file in files)
        {
            if(File.Exists(file))
            {
                var folderPath = Path.Combine(m_FolderFilesOrg.FullName, Path.GetFileName(file).Replace(".ar.00", "").Replace("#", ""));
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                if (!Directory.Exists(Path.Combine(folderPath, "Packed")))
                {
                    Directory.CreateDirectory(Path.Combine(folderPath, "Packed"));
                }
                CopyAndExtractAR(file, folderPath, true, true);

                CopyAndExtractAR(file.Replace("#", ""), folderPath, true, true);
                string test = Path.Combine(Directory.GetParent(file).FullName, "Packed", Path.GetFileName(file).Replace(".ar.00", "").Replace("#", ""), "Stage.pfd");
                CopyAndExtractAR(test, Path.Combine(folderPath, "Packed"), false, true);
            }
        }
        Cleanup(false);
        Utility.EndScreen("Files have been reorganized successfully!", "", m_FolderFilesOrg.FullName);

    }
    static void PorterScreen()
    {
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        //Define archive path
        Utility.ColoredTextLine("Enter the path to your STAGE archive from Sonic Unleashed (Root/stagename.ar.00):", ConsoleColor.Black, ConsoleColor.White);
        pathToStageArchive = Utility.GetTextWithoutQuotations(Console.ReadLine());
        if (File.Exists(pathToStageArchive))
        {
            Console.WriteLine("OK!");
        }
        else
        {
            Console.WriteLine("Path does not exist. Please try again.");
            return;
        }

        //Define #archive path
        Utility.ColoredTextLine("Enter the path to your STAGE PROPERTIES archive from Sonic Unleashed (Root/#stagename.ar.00):", ConsoleColor.Black, ConsoleColor.White);
        pathToSetArchive = Utility.GetTextWithoutQuotations(Console.ReadLine());
        if (File.Exists(pathToSetArchive))
        {
            Console.WriteLine("OK!");
        }
        else
        {
            Console.WriteLine("Path does not exist. Please try again.");
            return;
        }

        //Define PFD path
        Utility.ColoredTextLine("Enter the path to your STAGE.PFD file from Sonic Unleashed (Root/Packed/stagename/Stage.pfd):", ConsoleColor.Black, ConsoleColor.White);
        pathToStagePfd = Utility.GetTextWithoutQuotations(Console.ReadLine());
        if (File.Exists(pathToStagePfd) && Path.GetExtension(pathToStagePfd).Contains("pfd"))
        {
            Console.WriteLine("OK!");
        }
        else
        {
            Console.WriteLine("Path does not exist. Please try again.");
            return;
        }

        //Define PFD HD path
        Utility.ColoredTextLine("Enter the path to your STAGE-ADD.PFD file from Sonic Unleashed (Root/Packed/stagename/Stage.pfd), you can leave it empty if you don't have it:", ConsoleColor.Black, ConsoleColor.White);
        pathToStagePfdAdd = Utility.GetTextWithoutQuotations(Console.ReadLine());
        if (File.Exists(pathToStagePfdAdd) && Path.GetExtension(pathToStagePfdAdd).Contains("pfd"))
        {
            Console.WriteLine("OK!");
        }


        Console.Clear();
        Console.WriteLine("This tool is going to guide you through the process of porting a stage from SWA to BB. Whenever you'll have to do something yourself, the program will pause and wait for the next input.\r\nFollowing steps in order:\r\n\t1. Extract archives\r\n\t2. Move files to Generations style structure\r\n\t3. Reorganize xml files\r\n\t4. Convert and repack hkx and pfd files");
        Utility.ColoredTextLine("WARNING: This converter expects you to use the files from the Xbox 360 version of Sonic Unleashed. The converter may still work, but it may fail to launch in Generations.", ConsoleColor.Black, ConsoleColor.Red);

        Thread.Sleep(1000);
        Console.WriteLine("\nPlease press any key to start the conversion process... ");
        Console.ReadKey();
        Utility.ColoredTextLine("Enter the stage's new StageID:", ConsoleColor.Black, ConsoleColor.White);
        m_StageID = Utility.GetTextWithoutQuotations(Console.ReadLine());
        if (string.IsNullOrEmpty(m_StageID))
        {
            m_StageID = "ghz200";
        }
        Console.Clear();




        CleanupLastTry();
        CopyArchivesToProgram();
        MoveFilesToCorrectLocations();
        MoveStageToBBStyleFolder();
        MakeNewHashtagFolderContents();
        UncompressPFD();
        MatFixer();
        RepackEverything();
        Cleanup();
        Utility.EndScreen("Stage has been converted successfully!", "NOTE: Now that you've run this, you need to go in GLVL 0.5.7 (NOT SVN), do File > Fix all materials in folder and pick the packed stage folder, then open the stage and repack with visibility tree ticked off.\r\nDo note that Spagonia levels may have a \"Stage_old\" XML which is actually the Stage xml, copy the contents of the _old to the regular one.\r\nPress any key to close, or R to go back to the start...\r\n", Utility.FilesDirectory);
    }

    private static void MatFixer()
    {
        IEnumerable<FileInfo> files = new DirectoryInfo(m_FolderNewHashtag).EnumerateFiles();
        foreach(var f in files)
        {
            Utility.matfixer(f.FullName);
        }
        IEnumerable<FileInfo> files2 = new DirectoryInfo(m_FolderNewStage).EnumerateFiles();
        foreach(var f in files2)
        {
            Utility.matfixer(f.FullName);
        }
    }

    private static void EndScreen()
    {
        Console.Clear();
        Utility.ColoredTextLine("[v] Stage has been converted successfully!", ConsoleColor.White, ConsoleColor.Green);
        Console.WriteLine("NOTE: Now that you've run this, you need to go in GLVL 0.5.7 (NOT SVN), do File > Fix all materials in folder and pick the packed stage folder, then open the stage and repack with visibility tree ticked off.\n If you want to add the HD GI, run this tool twice with the pfd replaced with the -Add pfd instead. I'll fix this another time.");

        Console.WriteLine("Do note that Spagonia levels may have a \"Stage_old\" XML which is actually the Stage xml, copy the contents of the _old to the regular one.");
        Console.WriteLine("Press any key to close, or R to go back to the start...");
        var key = Console.ReadKey();
        if(key.KeyChar.ToString().ToLower() == "r")
        {
            Startup();
        }
        else
            Utility.OpenFolder(Utility.FilesDirectory);
    }

    private static void Cleanup(bool cleanOriginal = true)
    {
        if (Directory.Exists(m_FolderStage))
            Directory.Delete(m_FolderStage, true);

        if (Directory.Exists(m_FolderStagePFD))
            Directory.Delete(m_FolderStagePFD, true);

        if (Directory.Exists(m_FolderStagePFDAdd))
            Directory.Delete(m_FolderStagePFDAdd, true);

        if (Directory.Exists(m_FolderNewHashtag))
            Directory.Delete(m_FolderNewHashtag, true);

        if (Directory.Exists(m_FolderHashtag))
            Directory.Delete(m_FolderHashtag, true);
        if(cleanOriginal)
        {
            foreach (var path in m_ListOriginalFiles)
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }
        foreach(var path in m_ListTempFolders)
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);
        }
    }

    private static void RepackEverything()
    {
        Console.WriteLine($"[i] Repacking pfd...");
        Utility.pfdPack(m_FolderStagePFD);

        if(!string.IsNullOrEmpty(m_FolderStagePFDAdd))
        {
            Console.WriteLine($"[i] Repacking Add pfd...");
            Utility.pfdPack(m_FolderStagePFDAdd);
        }


        Console.WriteLine($"[i] Moving pfi to {m_FolderNewStage}...");
        File.Move(Path.Combine(Utility.FilesDirectory, "Stage.pfi"), Path.Combine(m_FolderNewStage, "Stage.pfi"));
        if (File.Exists(Path.Combine(Utility.FilesDirectory, "Stage-Add.pfi")))
            File.Move(Path.Combine(Utility.FilesDirectory, "Stage-Add.pfi"), Path.Combine(m_FolderNewStage, "Stage-Add.pfi"));

        Console.WriteLine($"[i] Moving pfd to Packed...");
        File.Move(Path.Combine(Utility.FilesDirectory, "Stage.pfd"), Path.Combine(Directory.GetParent(m_FolderNewStage).FullName, "Stage.pfd"));
        if(File.Exists(Path.Combine(Utility.FilesDirectory, "Stage-Add.pfd")))
            File.Move(Path.Combine(Utility.FilesDirectory, "Stage-Add.pfd"), Path.Combine(Directory.GetParent(m_FolderNewStage).FullName, "Stage-Add.pfd"));
        Console.WriteLine($"[i] Repacking {m_FolderNewStage}...");
        Utility.PackAR(m_FolderNewStage);

        Console.WriteLine($"[i] Repacking {m_FolderNewHashtag}...");
        Utility.PackAR(m_FolderNewHashtag);
    }

    private static void UncompressPFD()
    {
        var files = Directory.EnumerateFiles(m_FolderStagePFD);
        foreach(var f in files)
        {
            Console.WriteLine($"[i] Decompressing {f}...");
            Utility.xbdecompress(f);
        }
    }

    private static void MakeNewHashtagFolderContents()
    {
        //awful, i just didnt want to rewrite this part of the old code since its the only thing that actually worked
        string XMLStart = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>\r\n<Stage xsi:noNamespaceSchemaLocation=\"http://web/chao/project/swa/schema/Stage.stg.xsd\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">";
        string XMLEnd = "\r\n</Stage>";
        // ^
        string newTerrainFile = "";
        string newInstancerFile = "";
        bool includeInTerrain = false;
        bool includeInInstancer = false;
        bool setData = false;

        string stagePath = Path.Combine(m_FolderHashtag, "Stage.stg.xml").Replace("\"", "");
        string[] stageXMLContents = File.ReadAllLines(stagePath);
        List<string> newStageXML = stageXMLContents.ToList();

        foreach (var stageString in stageXMLContents)
        {
            if (stageString.Contains("<Evil>"))
                stageString.Replace("<Evil>", "<Sonic>");

            if (stageString.Contains("</Evil>"))
                stageString.Replace("</Evil>", "</Sonic>");

            if (stageString.Contains("<Terrain>"))
            {
                includeInTerrain = true;
            }
            else if (stageString.Contains("</Sky>"))
            {
                includeInTerrain = false;
                newTerrainFile += $"\n{stageString}";
                newStageXML.Remove(stageString);
            }

            if (stageString.Contains("<SetData>"))
            {
                setData = true;
            }
            else if (stageString.Contains("</SetData>"))
            {
                setData = false;
                newStageXML.Remove(stageString);
            }
            if (stageString.Contains("<Instancer>"))
            {
                includeInInstancer = true;
            }
            else if (stageString.Contains("</Instancer>"))
            {
                Console.WriteLine($"Deleted \"{stageString}\"");
                includeInInstancer = false;
                newTerrainFile += $"\n{stageString}";
                newStageXML.Remove(stageString);
            }

            if (setData)
                newStageXML.Remove(stageString);

            if (includeInTerrain)
            {
                Console.WriteLine($"Deleted \"{stageString}\"");
                newTerrainFile += $"\n{stageString}";
                newStageXML.Remove(stageString);
            }
            if (includeInInstancer)
            {
                Console.WriteLine($"Deleted \"{stageString}\"");
                newInstancerFile += $"\n{stageString}";
                newStageXML.Remove(stageString);

            }
        }
        newTerrainFile = newTerrainFile.Insert(0, XMLStart);
        newTerrainFile = newTerrainFile.Insert(newTerrainFile.Length, XMLEnd);

        newInstancerFile = newInstancerFile.Insert(0, XMLStart);
        newInstancerFile = newInstancerFile.Insert(newInstancerFile.Length, XMLEnd);

        File.Delete(Path.Combine(m_FolderHashtag, "Terrain.prm.xml").Replace("\"", ""));
        File.WriteAllText(Path.Combine(m_FolderHashtag, "Terrain.stg.xml").Replace("\"", ""), newTerrainFile);
        File.WriteAllText(Path.Combine(m_FolderHashtag, "Instancer.stg.xml").Replace("\"", ""), newInstancerFile);
        File.WriteAllText(Path.Combine(m_FolderHashtag, "Stage.stg.xml").Replace("\"", ""), string.Join("\n", newStageXML.ToArray()));

        Utility.ColoredTextLine("[W] IT'S REALLY IMPORTANT THAT YOU ENSURE THE BGM CSB EXISTS! If it doesn't, the game will crash.", ConsoleColor.Yellow, ConsoleColor.Black);
        //replace every xml with the unleashed ones except for stage.stg

        IEnumerable<FileInfo> files = Utility.GetFilesByExtensions(new DirectoryInfo(m_FolderHashtag), ".xml");
        foreach(var f in files)
        {
            //if (f.Name.Contains("Stage.stg"))
            //    continue;
            if(File.Exists(Path.Combine(m_FolderNewHashtag, f.Name)))
                File.Delete(Path.Combine(m_FolderNewHashtag, f.Name));
            File.Move(f.FullName, Path.Combine(m_FolderNewHashtag, f.Name));
        }

        IEnumerable<FileInfo> filesHKX = Utility.GetFilesByExtensions(new DirectoryInfo(m_FolderHashtag), ".hkx");
        foreach(var f in filesHKX)
        {
            Console.WriteLine($"[i] Converting {f.Name} from Havok-5.5.0-r1 to hk_2010.2.0-r1...");
            Utility.hkxconverter(f.FullName);
            Thread.Sleep(200);
            File.Move(f.FullName, Path.Combine(m_FolderNewHashtag, f.Name));
        }
    }
    private static void MoveStageToBBStyleFolder()
    {
        var newStageFolderPacked = Path.Combine(Utility.FilesDirectory, "Packed", m_StageID, m_StageID);
        var stageFilesExceptHKX = Directory.GetFiles(m_FolderStage).Where(name => !name.EndsWith(".hkx", StringComparison.OrdinalIgnoreCase));
        var stageFilesHKX = Directory.GetFiles(m_FolderStage).Where(name => name.EndsWith(".hkx", StringComparison.OrdinalIgnoreCase));
        //Move all files that arent HKXs to the new stage folder
        Console.WriteLine($"[i] Moving files from unpacked archive folder to {newStageFolderPacked}...");
        foreach (var f in stageFilesExceptHKX)
        {

            string newPath = Path.Combine(newStageFolderPacked, Path.GetFileName(f));
            File.Move(f, newPath);
        }
        //Convert all leftover HKX files and move them as well
        foreach (var f in stageFilesHKX)
        {
            Console.WriteLine($"[i] Converting {Path.GetFileName(f)} from Havok-5.5.0-r1 to hk_2010.2.0-r1...");
            Utility.hkxconverter(f);
            Thread.Sleep(100);
            string newPath = Path.Combine(newStageFolderPacked, Path.GetFileName(f));
            File.Move(f, newPath);
        }
        m_FolderNewStage = newStageFolderPacked;
    }
    private static void MoveFilesToCorrectLocations()
    {
        m_FolderNewHashtag = @Path.Combine(Utility.FilesDirectory, $"#{m_StageID}");
        Utility.CloneDirectory(@Path.Combine(Utility.ProgramPath, "TemplateHashtag"), @Path.Combine(Utility.FilesDirectory, $"#{m_StageID}")); 
        //Copy files from #stage to stage
        var fromHashtag_toStage = Utility.GetFilesByExtensions(new DirectoryInfo(@m_FolderHashtag), ".gil", ".gi-texture-group-info", ".light", ".light-list", ".tbst", ".terrain", ".terrain-group");
        foreach(var f in fromHashtag_toStage)
        {
            Console.WriteLine($"[i] Copying \"{f.Name}\" to stage archive...");
            string newLoc = Path.Combine(Utility.FilesDirectory, m_FolderStage, f.Name);
            File.Move(f.FullName, newLoc);
        }

        Utility.CreateDirectoryIfNotExist(Path.Combine(Utility.FilesDirectory, "Packed"));
        Utility.CreateDirectoryIfNotExist(Path.Combine(Utility.FilesDirectory, "Packed", $"{m_StageID}"));
        //This'll become an archive
        Utility.CreateDirectoryIfNotExist(Path.Combine(Utility.FilesDirectory, "Packed", $"{m_StageID}", $"{m_StageID}"));        
    }
    private static void CopyArchivesToProgram()
    {
        if (!Directory.Exists(Utility.FilesDirectory))
            Directory.CreateDirectory(Utility.FilesDirectory);
        Utility.ColoredTextLine("[1] Copying files from original folders to \"Output\"", ConsoleColor.Gray, ConsoleColor.Black);
        CopyAndExtractAR(@pathToStageArchive, Utility.FilesDirectory);
        CopyAndExtractAR(@pathToSetArchive, Utility.FilesDirectory);
        CopyAndExtractAR(@pathToStagePfd, Utility.FilesDirectory, false);
        if(File.Exists(@pathToStagePfdAdd))
            CopyAndExtractAR(@pathToStagePfdAdd, Utility.FilesDirectory, false);

        m_FolderStage =     Path.Combine(Utility.FilesDirectory, Path.GetFileNameWithoutExtension(pathToStageArchive).Split(".ar")[0]);
        m_FolderHashtag =   Path.Combine(Utility.FilesDirectory, Path.GetFileNameWithoutExtension(pathToSetArchive).Split(".ar")[0]);
        m_FolderStagePFD =  Path.Combine(Utility.FilesDirectory, Path.GetFileNameWithoutExtension(pathToStagePfd).Split(".pfd")[0]);

        if (File.Exists(@pathToStagePfdAdd))
            m_FolderStagePFDAdd = Path.Combine(Utility.FilesDirectory, Path.GetFileNameWithoutExtension(pathToStagePfdAdd).Split(".pfd")[0]);
    }
    private static void CleanupLastTry()
    {
        string directoryPath = Utility.FilesDirectory;
        if (!Directory.Exists(directoryPath))
            return;

        Utility.ClearFolder(directoryPath);
    }
}