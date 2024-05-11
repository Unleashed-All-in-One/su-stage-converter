using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC_Converter
{
    public static class Utility
    {
        static List<string> m_ListTempFolders = new List<string>();
        public static string? ProgramPath
        {
            get
            {
                string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string exeDir = System.IO.Path.GetDirectoryName(exePath);
                exeDir = exeDir.Replace("\"", "");

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
        public static string? CutscenesFilesDirectory
        {
            get
            {
                return Path.Combine(ProgramPath, "Output_evs");
            }
        }
        public static bool IsFileLocked(FileInfo file)
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
        public static void fcoEditorCommandline(string path, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @Path.Combine(ProgramPath, "fcoEditorCLI.exe");
            startInfo.Arguments = path + " " + arguments;
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked = Process.Start(startInfo);
            extractPacked.WaitForExit();
        }
        public static void pfdPack(string path)
        {
            path = Utility.AddQuotesIfRequired(path);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @Path.Combine(ProgramPath, "pfdpack.exe");
            startInfo.Arguments = $"{path} {path}";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked = Process.Start(startInfo);
            while (!extractPacked.HasExited)
            {
            }
            extractPacked.WaitForExit();
        }
        public static void evs2xml(string path)
        {
            string path2 = Utility.GetTextWithoutQuotations(path);
            path2.Insert(0, "\"");
            path2.Insert(path2.Length, "\"");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @Path.Combine(ProgramPath, "evsxml.exe");
            startInfo.Arguments = $" {@path2}";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked = Process.Start(startInfo);
            extractPacked.WaitForExit();
        }
        public static void OpenFolder(string path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "explorer.exe";
            startInfo.Arguments = $"{path}";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            Process? extractPacked = Process.Start(startInfo);
        }
        public static void hkxconverter(string path)
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
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

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
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked2 = Process.Start(startInfo2);
            extractPacked2.WaitForExit();
            Thread.Sleep(100);
        }
        public static void CloneDirectory(string root, string dest)
        {
            if (!Directory.Exists(dest))
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
            string toreturn = path.Split(find)[0];
            return toreturn;
        }       
        public static void ClearFolder(string FolderName)
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
        public static void xbdecompress(string path)
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
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked = Process.Start(startInfo);
            extractPacked.WaitForExit();
            if (File.Exists(Path.Combine(ProgramPath, Path.GetFileName(path))))
            {
                File.Delete(@path);
                File.Move(Path.Combine(ProgramPath, Path.GetFileName(path)), path);
            }
        }
        public static string AddQuotesIfRequired(string path)
        {
            path = path.Replace("\"", "");
            if(path.Contains(" "))
            {
                path = path.Insert(0, "\"");
                path = path.Insert(path.Length, "\"");
            }
            return path;
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
        public static void PackAR(string? path)
        {
            path = Utility.AddQuotesIfRequired(path);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @Path.Combine(ProgramPath, "ar0pack.exe");
            startInfo.Arguments = path;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked = Process.Start(startInfo);
            while (!extractPacked.HasExited)
            {
            }
            extractPacked.WaitForExit();
        }
        public static string ExtractAR(string? path)
        {
            path = Utility.AddQuotesIfRequired(path);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @Path.Combine(ProgramPath, "ar0unpack.exe");
            startInfo.Arguments = path;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked = Process.Start(startInfo);
            extractPacked.WaitForExit();
            while (!extractPacked.HasExited)
            {
            }
            path = Path.ChangeExtension(path, null);
            path = Path.ChangeExtension(path, null);
            path = path.Replace("\"", "");
            return path;
        }
        public static string matfixer(string? path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @Path.Combine(ProgramPath, "matfixer.exe");
            startInfo.Arguments = path;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process? extractPacked = Process.Start(startInfo);
            extractPacked.WaitForExit();

            path = Path.ChangeExtension(path, null);
            path = Path.ChangeExtension(path, null);
            path = path.Replace("\"", "");
            return path;
        }
        public static void EndScreen(string title, string note, string folderPath = null)
        {
            Console.Clear();
            Utility.ColoredTextLine($"[v] {title}", ConsoleColor.White, ConsoleColor.DarkGreen);
            if(!string.IsNullOrEmpty(note))
                Console.WriteLine($"\nNOTE: {note}");
            Utility.ColoredTextLine("\nPress any key to close, or R to go back to the start...", ConsoleColor.Yellow, ConsoleColor.Black);
            var key = Console.ReadKey();
            if (key.KeyChar.ToString().ToLower() == "r")
            {
                Program.Startup();
            }
            else
            {
                if(folderPath != null)
                    Utility.OpenFolder(folderPath);
            }
        }
    }
}
