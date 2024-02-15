using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SUC_Converter
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    public static class CutsceneConverter
    {
        static List<string> pathsArchives = new List<string>();
        static List<string> namesForPathArchives = new List<string>();
        static Different.InspireResource inspireSource;
        static string outXML_Filename;
        static string evs_ID;
        static string directoryOutput
        {
            get
            {
                return Path.Combine(Utility.CutscenesFilesDirectory, "CutsceneAR");
            }
        }
        static Scene evsOutput;
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
                    bool mode0 = false;
                    if (pathToFirst.EndsWith("00"))
                        mode0 = true;
                    if (!mode0)
                    {
                        if (File.Exists(pathToFirst))
                        {
                            File.Copy(pathToFirst, Path.Combine(destination, Path.GetFileName(pathToFirst)));
                        }                        
                    }
                    else
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
                    }
                    //Copy .arl if it exists
                    if (!File.Exists(Utility.GetFullPathWithoutExtensionPastPoint(firstFileOutputPath)))
                    {
                        if (File.Exists(filenameWithoutExtension + ".arl"))
                        {
                            string outputPath = @Path.Combine(destination, Path.GetFileName(filenameWithoutExtension) + ".arl");
                            File.Copy(@filenameWithoutExtension + ".arl", outputPath);
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
                            Utility.xbdecompress(@firstFileOutputPath);
                        }
                    }
                }

                if (!forceNoExtract)
                    Utility.ExtractAR(@firstFileOutputPath);
            }
        }
        public static void Test1()
        {
            Console.Clear();
            if (Directory.Exists(Utility.CutscenesFilesDirectory))
                Directory.Delete(Utility.CutscenesFilesDirectory, true);
            if (!Directory.Exists(Utility.CutscenesFilesDirectory))
                Directory.CreateDirectory(Utility.CutscenesFilesDirectory);
            if (!Directory.Exists(directoryOutput))
                Directory.CreateDirectory(directoryOutput);
            Console.WriteLine("CutsceneConverter");
            Console.WriteLine("This tool will attempt to convert an Inspire cutscene to an EVS format so that Generations can play them back.");
            Utility.ColoredTextLine("NOTE: For some reason, some objects may crash the game because of invalid/missing materials and animations, if the cutscene crashes, make sure you have everything, and if it still crashes then try to strip down the \"Object\" values in the ev(ID).xml file and convert it to evs again using EVSXML.", ConsoleColor.Blue, ConsoleColor.Black);
            Console.WriteLine("Path to cutscene archive (Inspire\\scene\\m_xxxxx.ar): ");
            string path = Console.ReadLine();
            string pathWithoutQuotes = path.Replace("\"", "");
            CopyAndExtractAR(@pathWithoutQuotes, directoryOutput, true);
            var f = Directory.EnumerateFiles(Path.Combine(directoryOutput, Path.GetFileName(Utility.GetFullPathWithoutExtensionPastPoint(@pathWithoutQuotes))));
            foreach (var f2 in f)
            {
                if (f2.Contains(".inspire_resource.xml") && !f2.Contains("bgm") && !f2.Contains("voice"))
                {
                    Console.WriteLine($"GOT XML FILE {f2}");
                    ConvertInspireToEVS(f2);
                    break;
                }
            }
            Utility.evs2xml(outXML_Filename);

            Console.WriteLine("\n\nYou have to find these following model files yourself:");
            foreach (var e in namesForPathArchives)
            {
                string test3 = Path.Combine(Directory.GetParent(outXML_Filename).FullName, e + ".model");
                if (!File.Exists(test3))
                    Console.WriteLine($"     {e}");
            }
            Console.WriteLine($"Once you've done that and you've dragged the required files into {Directory.GetParent(outXML_Filename).FullName}, press any key.");
            Console.ReadKey();
            string folderOut = Path.Combine(Utility.CutscenesFilesDirectory, evs_ID);
            Directory.Move(Directory.GetParent(outXML_Filename).FullName, Path.Combine(Utility.CutscenesFilesDirectory, evs_ID));
            var filesOut = Directory.EnumerateFiles(folderOut);

            foreach (var e in namesForPathArchives)
            {

            }
            foreach (var file in filesOut)
            {
                if (file.EndsWith(".hkx"))
                {
                    Console.WriteLine($"Converting HKX {Path.GetFileName(file)}");
                    Utility.hkxconverter(file);
                }
                if (file.EndsWith(".material") || file.EndsWith(".model"))
                {
                    Utility.matfixer(file);
                }
            }
            Console.Write("Packing AR...");
            Utility.PackAR(folderOut);
            Utility.OpenFolder(Directory.GetParent(folderOut).FullName);
            //foreach (var e in namesForPathArchives)
            //{
            //    Console.WriteLine($"Please enter the path to an archive containing \"{e}\"");
            //    string outs = Console.ReadLine();
            //    if (File.Exists(outs))
            //    {
            //        pathsArchives.Add(outs);
            //        CopyAndExtractAR(@outs, Utility.CutscenesFilesDirectory, true);
            //        string pathNew = Path.Combine(Utility.CutscenesFilesDirectory,Path.GetFileName(Utility.GetFullPathWithoutExtensionPastPoint(outs)));
            //        var f = Directory.EnumerateFiles(pathNew);
            //        foreach(var ef in f)
            //        {

            //            if(!File.Exists(Path.Combine(pathNew, Path.GetFileName(ef))))
            //                File.Copy(ef, Path.Combine(pathNew, Path.GetFileName(ef)));

            //        }
            //    }
            //}

        }

        static void ConvertInspireToEVS(string path)
        {
            var e = File.ReadAllLines(@path);
            XmlSerializer serializer = new XmlSerializer(typeof(Different.InspireResource));
            using (StreamReader reader = new StreamReader(@path))
            {
                inspireSource = (Different.InspireResource)(serializer.Deserialize(reader));
            }

            Console.WriteLine("Enter evsID for cutscene (e.g: ev013):");
            evs_ID = Console.ReadLine();
            Console.WriteLine("Enter stageID for cutscene:");
            string stageID = Console.ReadLine();
            Console.WriteLine("Enter sound cue sheet (default: 30VCE_STE): ");
            string soundCueSheet = Console.ReadLine();
            if(string.IsNullOrEmpty(soundCueSheet))
            {
                soundCueSheet = "30VCE_STE";
            }

            Console.WriteLine($"Enter sound cue (default: {evs_ID}):");
            string soundCue = Console.ReadLine();
            if(string.IsNullOrEmpty(soundCue))
            {
                soundCue = evs_ID;
            }
            evsOutput = new Scene();
            evsOutput.Pause = new ScenePause();
            evsOutput.Pause.Mode = true;
            evsOutput.Name = evs_ID;

            evsOutput.Offset = new SceneOffset();
            evsOutput.Offset.Tx = 0;
            evsOutput.Offset.Ty = 0;
            evsOutput.Offset.Tz = 0;
            evsOutput.Offset.Ry = 0;

            evsOutput.Wait = new SceneWait();
            evsOutput.Wait.Before = 30;
            evsOutput.Wait.After = 30;

            evsOutput.Sound = new SceneSound();
            evsOutput.Sound.CueSheet = soundCueSheet;
            evsOutput.Sound.Cue = soundCue;
            evsOutput.Sound.Localize = true;

            evsOutput.Stage = new SceneStage();
            evsOutput.Stage.Name = stageID;
            evsOutput.Stage.HideSetParticle = false;
            evsOutput.Stage.HideAutoDraw = false;

            evsOutput.FadeIn = new SceneFadeIn();
            evsOutput.FadeIn.Length = 15;

            evsOutput.FadeOut = new SceneFadeOut();
            evsOutput.FadeOut.Length = 15;
            List<SceneObject> objects = new List<SceneObject>();
            List<SceneShadowSet> shadows = new List<SceneShadowSet>();
            foreach (var ri in inspireSource.ResourceInfo)
            {
                if (ri.Type == "CameraMotionData")
                {
                    if (evsOutput.Camera == null)
                    {
                        evsOutput.Camera = new SceneCamera();
                        evsOutput.Camera.FarClip = (ushort)ri.Param.FarPlane;
                        evsOutput.Camera.NearClip = 0.001m;
                        evsOutput.Camera.Animation = ri.Param.FileName;
                    }
                    if (evsOutput.Shadow == null)
                        evsOutput.Shadow = new SceneShadow();
                    SceneShadowSet sceneShadowSet = new SceneShadowSet();
                    sceneShadowSet.MapBoxFar = ri.Param.ShadowMapBoxFar;
                    sceneShadowSet.MapBoxWidth = ri.Param.ShadowMapBoxWidth;
                    sceneShadowSet.MapBoxNear = ri.Param.ShadowMapBoxNear;
                    sceneShadowSet.MapSize = 1;
                    sceneShadowSet.MapBoxHeight = ri.Param.ShadowMapBoxHeight;
                    sceneShadowSet.Bias = 0.002m;
                    sceneShadowSet.Vertical = true;
                    sceneShadowSet.Cut = shadows.Count + 1;
                    shadows.Add(sceneShadowSet);
                }
                if (ri.Type == "ModelData")
                {
                    SceneObject obj = new SceneObject();
                    obj.Model = ri.Param.FileName;
                    obj.Name = $"object{objects.Count}";
                    obj.Skeleton = ri.Param.SkeltonData;
                    obj.Animation = ri.Param.SkeltonData;
                    namesForPathArchives.Add(obj.Model);
                    objects.Add(obj);
                }
                if (ri.Type == "TexcoordAnimationData")
                {
                    if (objects[^1].UVAnimation == null)
                        objects[^1].UVAnimation = new List<SceneObjectUVAnimation>();
                    SceneObjectUVAnimation sceneObjectUVAnimation = new SceneObjectUVAnimation();
                    sceneObjectUVAnimation.Name = ri.Param.FileName;
                    objects[^1].UVAnimation.Add(sceneObjectUVAnimation);
                }
                if (ri.Type == "AnimationData")
                {
                    decimal modelID = ri.Param.ModelID;
                    var idname = inspireSource.ResourceInfo.FirstOrDefault(x => x.ID == modelID);
                    if (idname != default)
                    {
                        var objS = objects.First(x => x.Model.Contains(idname.Param.FileName));

                        if (string.IsNullOrEmpty(objS.Animation))
                            objS.Animation = ri.Param.FileName;
                        else
                            Utility.ColoredTextLine($"More than one anim defined for {objS.Model}.", ConsoleColor.Yellow, ConsoleColor.Black);
                    }
                }
                if (ri.Type == "MorphMotionData")
                {
                    decimal modelID = ri.Param.ModelID;
                    var idname = inspireSource.ResourceInfo.FirstOrDefault(x => x.ID == modelID);
                    if (idname != default)
                    {
                        var objS = objects.First(x => x.Model.Contains(idname.Param.FileName));
                        objS.VisibilityAnimation = new SceneObjectVisibilityAnimation();
                        objS.VisibilityAnimation.Name = ri.Param.FileName;
                    }
                }
                Console.WriteLine($"ID: {ri.ID} | {ri.Param} | {ri.Type}");
            }

            evsOutput.Shadow.Set = shadows.ToArray();
            evsOutput.Object = objects.ToArray();
            XmlSerializer serializer2 = new XmlSerializer(typeof(Scene));
            var newPath = Directory.GetParent(path);
            var path2 = Path.Combine(newPath.FullName, $"{evs_ID}.xml");
            using (var fileStream = new FileStream(path2, FileMode.Create))
            {
                serializer2.Serialize(fileStream, evsOutput);
            }
            outXML_Filename = path2;
        }
    }
}
