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
        static SUC_Converter.InspireResource inspireSource;
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
        public static void Start()
        {
            Console.Clear();
            Utility.ColoredTextLine("Clearing last attempt...", ConsoleColor.DarkGray, ConsoleColor.Black);
            if (Directory.Exists(Utility.CutscenesFilesDirectory))
                Directory.Delete(Utility.CutscenesFilesDirectory, true);
            if (!Directory.Exists(Utility.CutscenesFilesDirectory))
                Directory.CreateDirectory(Utility.CutscenesFilesDirectory);
            if (!Directory.Exists(directoryOutput))
                Directory.CreateDirectory(directoryOutput);
            Console.Clear();
            Utility.ColoredTextLine("CutsceneConverter", ConsoleColor.Black, ConsoleColor.White);
            Utility.ColoredTextLine("This tool will attempt to convert an Inspire cutscene to an EVS format so that Generations can play them back.", ConsoleColor.White, ConsoleColor.Black);
            Utility.ColoredTextLine("NOTE: For some reason, some objects may crash the game because of invalid/missing materials and animations, if the cutscene crashes, make sure you have everything, and if it still crashes then try to strip down the \"Object\" values in the ev(ID).xml file and convert it to evs again using EVSXML.\n", ConsoleColor.Black, ConsoleColor.Blue);
            Utility.ColoredTextLine("Path to cutscene archive (Inspire\\scene\\m_xxxxx.ar): ", ConsoleColor.Black, ConsoleColor.White);
            string path = Console.ReadLine();
            string pathWithoutQuotes = path.Replace("\"", "");
            CopyAndExtractAR(@pathWithoutQuotes, directoryOutput, true);
            var f = Directory.EnumerateFiles(Path.Combine(directoryOutput, Path.GetFileName(Utility.GetFullPathWithoutExtensionPastPoint(@pathWithoutQuotes))));
            foreach (var f2 in f)
            {
                if (f2.Contains(".inspire_resource.xml") && !f2.Contains("bgm") && !f2.Contains("voice"))
                {
                    Utility.ColoredTextLine($"Found inspire_resource file: \"{Path.GetFileName(f2)}\".", ConsoleColor.DarkGray, ConsoleColor.Black);
                    ConvertInspireToEVS(f2);
                    break;
                }
            }
            Utility.evs2xml(outXML_Filename);

            Utility.ColoredTextLine($"\nYou have to find these following model files yourself:", ConsoleColor.Blue, ConsoleColor.Black);
            foreach (var e in namesForPathArchives)
            {
                string test3 = Path.Combine(Directory.GetParent(outXML_Filename).FullName, e + ".model");
                if (!File.Exists(test3))
                    Console.WriteLine($"     {e}");
            }
            Utility.ColoredTextLine($"Once you've done that and you've dragged the required files into {Directory.GetParent(outXML_Filename).FullName}, press any key.", ConsoleColor.Blue, ConsoleColor.Black);
            Console.ReadKey();
            string folderOut = Path.Combine(Utility.CutscenesFilesDirectory, evs_ID);
            Directory.Move(Directory.GetParent(outXML_Filename).FullName, Path.Combine(Utility.CutscenesFilesDirectory, evs_ID));
            var filesOut = Directory.EnumerateFiles(folderOut);

            foreach (var file in filesOut)
            {
                if (file.EndsWith(".hkx"))
                {
                    Console.WriteLine($"[i] Converting HKX \"{Path.GetFileName(file)}\" and resaving meta...");
                    Utility.hkxconverter(file);
                }
                if (file.EndsWith(".material"))
                {
                    Console.WriteLine($"[i] Running Unleashed2Generations on \"{Path.GetFileName(file)}\"...");
                    Utility.matfixer(file);
                }
            }
            Console.Write("[i] Repacking AR...");
            Utility.PackAR(folderOut);
            Utility.EndScreen("Cutscene has been converted successfully!", "The cutscene may crash because of invalid animations, please check that your animation files exist.\nIf you want to get rid of shader errors, use SUC-ShaderConverter.", Directory.GetParent(folderOut).FullName);
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

        public const double Rad2Deg = 180.0 / Math.PI;
        static void ConvertInspireToEVS(string path)
        {
            var e = File.ReadAllLines(@path);
            XmlSerializer serializer = new XmlSerializer(typeof(SUC_Converter.InspireResource));
            using (StreamReader reader = new StreamReader(@path))
            {
                inspireSource = (SUC_Converter.InspireResource)(serializer.Deserialize(reader));
            }
            Utility.ColoredTextLine("Enter evsID for cutscene (default: ev031):", ConsoleColor.Black, ConsoleColor.White);
            evs_ID = Console.ReadLine();
            if (string.IsNullOrEmpty(evs_ID))
                evs_ID = "ev031";

            Utility.ColoredTextLine("Enter stageID for the cutscene (default: cpz200):", ConsoleColor.Black, ConsoleColor.White);
            string stageID = Console.ReadLine();
            if (string.IsNullOrEmpty(stageID))
                stageID = "cpz200";

            Utility.ColoredTextLine("Enter sound cue sheet (default: 30VCE_STE): ", ConsoleColor.Black, ConsoleColor.White);
            string soundCueSheet = Console.ReadLine();
            if(string.IsNullOrEmpty(soundCueSheet))
            {
                soundCueSheet = "30VCE_STE";
            }

            Utility.ColoredTextLine($"Enter sound cue (default: {evs_ID}):", ConsoleColor.Black, ConsoleColor.White);
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
            List<SUC_Converter.InspireResourceResource> modelData = new List<SUC_Converter.InspireResourceResource>();
            List<SUC_Converter.InspireResourceResource> animData = new List<SUC_Converter.InspireResourceResource>();
            List<SUC_Converter.InspireResourceResource> texcoordData = new List<SUC_Converter.InspireResourceResource>();
            List<SUC_Converter.InspireResourceResource> morphAnimData = new List<SUC_Converter.InspireResourceResource>();
            var strings = inspireSource.TerrainInfo.Matrix.Split(" ");
            evsOutput.Offset.Tx = strings[12];
            evsOutput.Offset.Ty = strings[13];
            evsOutput.Offset.Tz = strings[14];
            float rotation = float.Parse(strings[10].Replace(".", ","));
            evsOutput.Offset.Ry = (-(Math.Round(Math.Acos(rotation) * Rad2Deg))).ToString().Replace(",", ".");
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
                    modelData.Add(ri);
                }
                if (ri.Type == "TexcoordAnimationData")
                {
                    texcoordData.Add(ri);
                }
                if (ri.Type == "AnimationData")
                {
                    animData.Add(ri);
                }
                if (ri.Type == "MorphMotionData")
                {
                    morphAnimData.Add(ri);
                }
                Console.WriteLine($"ID: {ri.ID} | {ri.Param} | {ri.Type}");
            }
            foreach (var modelSingle in modelData)
            {
                SceneObject obj = new SceneObject();
                obj.Model = modelSingle.Param.FileName;
                obj.Name = $"object{objects.Count}";
                obj.Skeleton = modelSingle.Param.SkeltonData;
                obj.internal_ID = (int)modelSingle.ID;
                namesForPathArchives.Add(obj.Model);
                objects.Add(obj);
            }
            foreach (var texcoordSingle in texcoordData)
            {
                decimal modelID = texcoordSingle.Param.ModelID;
                var objectFound = objects.FirstOrDefault(x => x.internal_ID == modelID);
                if (objectFound != default)
                {
                    SceneObjectUVAnimation sceneObjectUVAnimation = new SceneObjectUVAnimation();
                    sceneObjectUVAnimation.Name = texcoordSingle.Param.FileName;
                    if (objectFound.UVAnimation == null)
                        objectFound.UVAnimation = new List<SceneObjectUVAnimation>();
                    objectFound.UVAnimation.Add(sceneObjectUVAnimation);
                }
            }
            foreach (var animSingle in animData)
            {
                decimal modelID = animSingle.Param.ModelID;
                var objectFound = objects.FirstOrDefault(x => x.internal_ID == modelID);
                if (objectFound != default)
                {
                    if (string.IsNullOrEmpty(objectFound.Animation))
                        objectFound.Animation = animSingle.Param.FileName;
                    else
                    {
                        Utility.ColoredTextLine($"More than one anim defined for {objectFound.Model}. We currently don't know how to play anims at different times, so a new object will be made.", ConsoleColor.Yellow, ConsoleColor.Black);
                        var newObj = new SceneObject();
                        newObj.Model = objectFound.Model;
                        newObj.Name = $"object{objects.Count + 1}";
                        newObj.Skeleton = objectFound.Skeleton;
                        newObj.Animation = animSingle.Param.FileName;
                        newObj.internal_ID = objectFound.internal_ID;
                        objects.Add(newObj);
                    }
                }
            }
            foreach (var morpherSingle in morphAnimData)
            {
                decimal modelID = morpherSingle.Param.ModelID;
                var objectFound = objects.FirstOrDefault(x => x.internal_ID == modelID);
                if (objectFound != default)
                {
                    objectFound.VisibilityAnimation = new SceneObjectVisibilityAnimation();
                    objectFound.VisibilityAnimation.Name = morpherSingle.Param.FileName;
                }                
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
