using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Media;

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
    public static string? ProgramPath
    {
        get
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string exeDir = System.IO.Path.GetDirectoryName(exePath);
            return exeDir;
        }
    }
    public static string? FilesDirectory
    {
        get
        {
            return Path.Combine(ProgramPath, "Output");
        }
    }
    private static bool IsFileLocked(FileInfo file)
    {
        FileStream stream = null;

        try
        {
            stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        }
        catch (IOException)
        {
            //the file is unavailable because it is:
            //still being written to
            //or being processed by another thread
            //or does not exist (has already been processed)
            return true;
        }
        finally
        {
            if (stream != null)
                stream.Close();
        }

        //file is not locked
        return false;
    }
    static void pfdPack(string path)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = @Path.Combine(ProgramPath, "pfdpack.exe");
        startInfo.Arguments = $"{path} {path}";
        startInfo.UseShellExecute = false;
        startInfo.RedirectStandardOutput = true;
        startInfo.CreateNoWindow = true;
        Process? extractPacked = Process.Start(startInfo);
        extractPacked.WaitForExit();
    }
    static void OpenFolder(string path)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "explorer.exe";
        startInfo.Arguments = $"{path}";
        startInfo.UseShellExecute = false;
        startInfo.RedirectStandardOutput = true;
        startInfo.CreateNoWindow = true;
        Process? extractPacked = Process.Start(startInfo);
    }
    static void hkxconverter(string path)
    {
        var tempPath = Directory.GetParent(path).FullName;
        tempPath += "_temp";
        CreateDirectoryIfNotExist(tempPath);
        tempPath = Path.Combine(tempPath, Path.GetFileName(path));

        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = @Path.Combine(ProgramPath, "hkxconverter.exe");
        startInfo.Arguments = $"\"{path}\" \"{tempPath}\"";
        startInfo.UseShellExecute = false;
        startInfo.RedirectStandardOutput = true;
        startInfo.CreateNoWindow = false;
        Process? extractPacked = Process.Start(startInfo);

        //assetcc2 --rules4101 output/%%f asset-cced/%%f

        extractPacked.WaitForExit();
        extractPacked.WaitForExit();
        Thread.Sleep(100);


        ProcessStartInfo startInfo2 = new ProcessStartInfo();
        startInfo2.FileName = @Path.Combine(ProgramPath, "assetcc2.exe");
        startInfo2.Arguments = $"--rules4101 \"{tempPath}\" \"{path}\"";
        startInfo2.UseShellExecute = false;
        startInfo2.RedirectStandardOutput = true;
        startInfo2.CreateNoWindow = false;
        Process? extractPacked2 = Process.Start(startInfo2);
        extractPacked2.WaitForExit();
        Thread.Sleep(100);
    }
    private static void CloneDirectory(string root, string dest)
    {
        if(!Directory.Exists(dest))
            Directory.CreateDirectory(dest);
        foreach (var directory in Directory.GetDirectories(root))
        {
            //Get the path of the new directory
            var newDirectory = Path.Combine(dest, Path.GetFileName(directory));
            //Create the directory if it doesn't already exist
            Directory.CreateDirectory(newDirectory);
            //Recursively clone the directory
            CloneDirectory(directory, newDirectory);
        }

        foreach (var file in Directory.GetFiles(root))
        {
            File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
        }
    }
    public static String GetFullPathWithoutExtension(String path)
    {
        return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), System.IO.Path.GetFileNameWithoutExtension(path));
    }
    public static String GetFullPathWithoutExtensionPastPoint(String path, string find = ".ar")
    {
        string path2 = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), System.IO.Path.GetFileNameWithoutExtension(path));
        
        return path.Split(find)[0];
    }
    public static void TopTextSet(string text, Color color)
    {
        try
        {
            Console.SetCursorPosition(origCol, origRow);
            Console.Write($"[i]{text}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }

    }
    private static void ClearFolder(string FolderName)
    {
        DirectoryInfo dir = new DirectoryInfo(FolderName);

        foreach (FileInfo fi in dir.GetFiles())
        {
            fi.Delete();
        }

        foreach (DirectoryInfo di in dir.GetDirectories())
        {
            ClearFolder(di.FullName);
            di.Delete();
        }
    }
    static void xbdecompress(string path)
    {
        var tempPath = Directory.GetParent(path).FullName;
        tempPath += "_temp";
        CreateDirectoryIfNotExist(tempPath);
        m_ListTempFolders.Add(tempPath);
        tempPath = Path.Combine(tempPath, Path.GetFileName(path));

        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = @Path.Combine(ProgramPath, "xbdecompress.exe");
        startInfo.Arguments = $"  /S /F {path}";
        startInfo.UseShellExecute = false;
        startInfo.RedirectStandardOutput = true;
        startInfo.CreateNoWindow = true;
        Process? extractPacked = Process.Start(startInfo);
        extractPacked.WaitForExit();
        if(File.Exists(Path.Combine(ProgramPath, Path.GetFileName(path))))
        {
            File.Delete(@path);
            File.Move(Path.Combine(ProgramPath, Path.GetFileName(path)), path);
        }
    }
    public static void CreateDirectoryIfNotExist(string path)
    {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }
    public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
    {
        if (extensions == null)
            throw new ArgumentNullException("extensions");
        IEnumerable<FileInfo> files = dir.EnumerateFiles();
        return files.Where(f => extensions.Contains(f.Extension));
    }

    public static void CopyAndExtractAR(string pathToFirst, string destination, bool isArchive = true, bool forceNoExtract = false)
    {
        string pathC = @Path.Combine(destination, Path.GetFileName(@pathToFirst));
        //Has the file been copied before?
        if (!File.Exists(pathC))
        {
            string firstFileOutputPath = Path.Combine(destination, Path.GetFileName(pathToFirst));
            string filenameWithoutExtension = GetFullPathWithoutExtensionPastPoint(pathToFirst, isArchive ? ".ar" : ".pfd");
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
                            ColoredTextLine("[W] One of the ar numbered files is missing. This may cause ar0unpacker to unpack nothing.", ConsoleColor.Yellow, ConsoleColor.Black);
                        }

                        File.Copy(@pathToNumberedArchive, Path.Combine(destination, Path.GetFileName(@pathToNumberedArchive)));
                        m_ListOriginalFiles.Add(Path.Combine(destination, Path.GetFileName(@pathToNumberedArchive)));
                        xbdecompress(Path.Combine(destination, Path.GetFileName(@pathToNumberedArchive)));
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
                if (!File.Exists(GetFullPathWithoutExtensionPastPoint(firstFileOutputPath)))
                {
                    if (File.Exists(filenameWithoutExtension + ".arl"))
                    {
                        string outputPath = @Path.Combine(destination, Path.GetFileName(filenameWithoutExtension) + ".arl");
                        File.Copy(@filenameWithoutExtension + ".arl", outputPath);
                        m_ListOriginalFiles.Add(outputPath);
                        xbdecompress(outputPath);
                    }
                }

            }
            else // for .pfd files
            {
                if (!File.Exists(firstFileOutputPath))
                {
                    if(File.Exists(pathToFirst))
                    {
                        File.Copy(pathToFirst, firstFileOutputPath);
                        IsFileLocked(new FileInfo(@firstFileOutputPath));
                        m_ListOriginalFiles.Add(firstFileOutputPath);
                        xbdecompress(@firstFileOutputPath);
                    }
                }
            }

            if(!forceNoExtract)
            ExtractAR(@firstFileOutputPath);
        }
    }
    public static string GetTextWithoutQuotations(string text)
    {
        return text.Replace("\"", "");
    }
    public static void ColoredTextLine(string line, ConsoleColor foreground, ConsoleColor background)
    {
        Console.BackgroundColor = background;
        Console.ForegroundColor = foreground;

        Console.WriteLine(line);
        Console.ResetColor();
    }
    static void PackAR(string? path)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = @Path.Combine(ProgramPath, "ar0pack.exe");
        startInfo.Arguments = path;
        Process? extractPacked = Process.Start(startInfo);
        extractPacked.WaitForExit();
    }
    static string ExtractAR(string? path)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = @Path.Combine(ProgramPath, "ar0unpack.exe");
        startInfo.Arguments = path;
        Process? extractPacked = Process.Start(startInfo);
        extractPacked.WaitForExit();

        path = Path.ChangeExtension(path, null);
        path = Path.ChangeExtension(path, null);
        path = path.Replace("\"", "");
        return path;
    }
    static void Main()
    {
        Startup();
    }
    static void Startup()
    {
        Console.Clear();
        Console.WriteLine("Do you want to port a stage (1), or separate level archives from Unleashed(2)?");
        var choice = Console.ReadLine();
        if (choice == "1")
        {
            PorterScreen();
        }
        else
        {
            OrganizeFiles();
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
        var m_FolderFilesOrg = Directory.CreateDirectory(Path.Combine(ProgramPath, "OrganizedFiles"));
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
        EndScreen();
    }
    static void PorterScreen()
    {
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        //Define archive path
        ColoredTextLine("Enter the path to your STAGE archive from Sonic Unleashed (Root/stagename.ar.00):", ConsoleColor.Black, ConsoleColor.White);
        pathToStageArchive = GetTextWithoutQuotations(Console.ReadLine());
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
        ColoredTextLine("Enter the path to your STAGE PROPERTIES archive from Sonic Unleashed (Root/#stagename.ar.00):", ConsoleColor.Black, ConsoleColor.White);
        pathToSetArchive = GetTextWithoutQuotations(Console.ReadLine());
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
        ColoredTextLine("Enter the path to your STAGE.PFD file from Sonic Unleashed (Root/Packed/stagename/Stage.pfd):", ConsoleColor.Black, ConsoleColor.White);
        pathToStagePfd = GetTextWithoutQuotations(Console.ReadLine());
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
        ColoredTextLine("Enter the path to your STAGE-ADD.PFD file from Sonic Unleashed (Root/Packed/stagename/Stage.pfd), you can leave it empty if you don't have it:", ConsoleColor.Black, ConsoleColor.White);
        pathToStagePfdAdd = GetTextWithoutQuotations(Console.ReadLine());
        if (File.Exists(pathToStagePfdAdd) && Path.GetExtension(pathToStagePfdAdd).Contains("pfd"))
        {
            Console.WriteLine("OK!");
        }


        Console.Clear();
        Console.WriteLine("This tool is going to guide you through the process of porting a stage from SWA to BB. Whenever you'll have to do something yourself, the program will pause and wait for the next input.\r\nFollowing steps in order:\r\n\t1. Extract archives\r\n\t2. Move files to Generations style structure\r\n\t3. Reorganize xml files\r\n\t4. Convert and repack hkx and pfd files");
        ColoredTextLine("WARNING: This converter expects you to use the files from the Xbox 360 version of Sonic Unleashed. The converter may still work, but it may fail to launch in Generations.", ConsoleColor.Black, ConsoleColor.Red);

        Thread.Sleep(1000);
        Console.WriteLine("\nPlease press any key to start the conversion process... ");
        Console.ReadKey();
        ColoredTextLine("Enter the stage's new StageID:", ConsoleColor.Black, ConsoleColor.White);
        m_StageID = GetTextWithoutQuotations(Console.ReadLine());
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
        RepackEverything();
        Cleanup();
        EndScreen();
    }

    private static void EndScreen()
    {
        Console.Clear();
        ColoredTextLine("[v] Stage has been converted successfully!", ConsoleColor.White, ConsoleColor.Green);
        Console.WriteLine("NOTE: Now that you've run this, you need to go in GLVL 0.5.7 (NOT SVN), do File > Fix all materials in folder and pick the packed stage folder, then open the stage and repack with visibility tree ticked off.\n If you want to add the HD GI, run this tool twice with the pfd replaced with the -Add pfd instead. I'll fix this another time.");

        Console.WriteLine("Do note that Spagonia levels may have a \"Stage_old\" XML which is actually the Stage xml, copy the contents of the _old to the regular one.");
        Console.WriteLine("Press any key to close, or R to go back to the start...");
        var key = Console.ReadKey();
        if(key.KeyChar.ToString().ToLower() == "r")
        {
            Startup();
        }
        else
            OpenFolder(FilesDirectory);
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
        pfdPack(m_FolderStagePFD);

        if(!string.IsNullOrEmpty(m_FolderStagePFDAdd))
        {
            Console.WriteLine($"[i] Repacking Add pfd...");
            pfdPack(m_FolderStagePFDAdd);
        }


        Console.WriteLine($"[i] Moving pfi to {m_FolderNewStage}...");
        File.Move(Path.Combine(FilesDirectory, "Stage.pfi"), Path.Combine(m_FolderNewStage, "Stage.pfi"));
        if (File.Exists(Path.Combine(FilesDirectory, "Stage-Add.pfi")))
            File.Move(Path.Combine(FilesDirectory, "Stage-Add.pfi"), Path.Combine(m_FolderNewStage, "Stage-Add.pfi"));

        Console.WriteLine($"[i] Moving pfd to Packed...");
        File.Move(Path.Combine(FilesDirectory, "Stage.pfd"), Path.Combine(Directory.GetParent(m_FolderNewStage).FullName, "Stage.pfd"));
        if(File.Exists(Path.Combine(FilesDirectory, "Stage-Add.pfd")))
            File.Move(Path.Combine(FilesDirectory, "Stage-Add.pfd"), Path.Combine(Directory.GetParent(m_FolderNewStage).FullName, "Stage-Add.pfd"));
        Console.WriteLine($"[i] Repacking {m_FolderNewStage}...");
        PackAR(m_FolderNewStage);

        Console.WriteLine($"[i] Repacking {m_FolderNewHashtag}...");
        PackAR(m_FolderNewHashtag);
    }

    private static void UncompressPFD()
    {
        var files = Directory.EnumerateFiles(m_FolderStagePFD);
        foreach(var f in files)
        {
            Console.WriteLine($"[i] Decompressing {f}...");
            xbdecompress(f);
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

        ColoredTextLine("[W] IT'S REALLY IMPORTANT THAT YOU ENSURE THE BGM CSB EXISTS! If it doesn't, the game will crash.", ConsoleColor.Yellow, ConsoleColor.Black);
        //replace every xml with the unleashed ones except for stage.stg

        IEnumerable<FileInfo> files = GetFilesByExtensions(new DirectoryInfo(m_FolderHashtag), ".xml");
        foreach(var f in files)
        {
            //if (f.Name.Contains("Stage.stg"))
            //    continue;
            if(File.Exists(Path.Combine(m_FolderNewHashtag, f.Name)))
                File.Delete(Path.Combine(m_FolderNewHashtag, f.Name));
            File.Move(f.FullName, Path.Combine(m_FolderNewHashtag, f.Name));
        }

        IEnumerable<FileInfo> filesHKX = GetFilesByExtensions(new DirectoryInfo(m_FolderHashtag), ".hkx");
        foreach(var f in filesHKX)
        {
            Console.WriteLine($"[i] Converting {f.Name} from Havok-5.5.0-r1 to hk_2010.2.0-r1...");
            hkxconverter(f.FullName);
            Thread.Sleep(200);
            File.Move(f.FullName, Path.Combine(m_FolderNewHashtag, f.Name));
        }
    }
    private static void MoveStageToBBStyleFolder()
    {
        var newStageFolderPacked = Path.Combine(FilesDirectory, "Packed", m_StageID, m_StageID);
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
            hkxconverter(f);
            Thread.Sleep(100);
            string newPath = Path.Combine(newStageFolderPacked, Path.GetFileName(f));
            File.Move(f, newPath);
        }
        m_FolderNewStage = newStageFolderPacked;
    }
    private static void MoveFilesToCorrectLocations()
    {
        m_FolderNewHashtag = @Path.Combine(FilesDirectory, $"#{m_StageID}");
        CloneDirectory(@Path.Combine(ProgramPath, "TemplateHashtag"), @Path.Combine(FilesDirectory, $"#{m_StageID}")); 
        //Copy files from #stage to stage
        var fromHashtag_toStage = GetFilesByExtensions(new DirectoryInfo(@m_FolderHashtag), ".gil", ".gi-texture-group-info", ".light", ".light-list", ".tbst", ".terrain", ".terrain-group");
        foreach(var f in fromHashtag_toStage)
        {
            Console.WriteLine($"[i] Copying \"{f.Name}\" to stage archive...");
            string newLoc = Path.Combine(FilesDirectory, m_FolderStage, f.Name);
            File.Move(f.FullName, newLoc);
        }

        CreateDirectoryIfNotExist(Path.Combine(FilesDirectory, "Packed"));
        CreateDirectoryIfNotExist(Path.Combine(FilesDirectory, "Packed", $"{m_StageID}"));
        //This'll become an archive
        CreateDirectoryIfNotExist(Path.Combine(FilesDirectory, "Packed", $"{m_StageID}", $"{m_StageID}"));        
    }
    private static void CopyArchivesToProgram()
    {
        if (!Directory.Exists(FilesDirectory))
            Directory.CreateDirectory(FilesDirectory);
        ColoredTextLine("[1] Copying files from original folders to \"Output\"", ConsoleColor.Gray, ConsoleColor.Black);
        CopyAndExtractAR(@pathToStageArchive, FilesDirectory);
        CopyAndExtractAR(@pathToSetArchive, FilesDirectory);
        CopyAndExtractAR(@pathToStagePfd, FilesDirectory, false);
        if(File.Exists(@pathToStagePfdAdd))
            CopyAndExtractAR(@pathToStagePfdAdd, FilesDirectory, false);

        m_FolderStage =     Path.Combine(FilesDirectory, Path.GetFileNameWithoutExtension(pathToStageArchive).Split(".ar")[0]);
        m_FolderHashtag =   Path.Combine(FilesDirectory, Path.GetFileNameWithoutExtension(pathToSetArchive).Split(".ar")[0]);
        m_FolderStagePFD =  Path.Combine(FilesDirectory, Path.GetFileNameWithoutExtension(pathToStagePfd).Split(".pfd")[0]);

        if (File.Exists(@pathToStagePfdAdd))
            m_FolderStagePFDAdd = Path.Combine(FilesDirectory, Path.GetFileNameWithoutExtension(pathToStagePfdAdd).Split(".pfd")[0]);
    }
    private static void CleanupLastTry()
    {
        string directoryPath = FilesDirectory;
        if (!Directory.Exists(directoryPath))
            return;

        ClearFolder(directoryPath);
    }
}