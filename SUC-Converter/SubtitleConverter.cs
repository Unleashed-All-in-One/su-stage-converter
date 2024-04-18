using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static SUC_Converter.FCO;

namespace SUC_Converter
{/// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Caption
    {

        private List<CaptionText> textField = new List<CaptionText>();

        private string nameField;

        private string groupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public List<CaptionText> Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class CaptionText
    {

        private int startField;

        private int lengthField;

        private string cellField;

        

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cell
        {
            get
            {
                return this.cellField;
            }
            set
            {
                this.cellField = value;
            }
        }
    }


    internal class SubtitleConverter
    {
        //for context, i cant use constructors or xmlserializer will scream at me
        public static CaptionText CreateCaptionText(int start, int lenght, string cellName)
        {
            CaptionText ctxt = new CaptionText();
            ctxt.Start = start;
            ctxt.Length = lenght;
            ctxt.Cell = cellName;
            return ctxt;
        }
        static SUC_ConverterConverse.InspireResourceResource GetResourceFromID(SUC_ConverterConverse.InspireResource file, int id)
        {
            return file.ResourceInfo.First(x => x.ID == id);
        }
        public static void Run()
        {
            Console.WriteLine("Enter path to the subtitle xml (Inspire/subtitle/[eventid].ar/[eventid]_subtitle_English.inspire_resource.xml");
            string path = Console.ReadLine();
            Console.WriteLine("Enter path to the FCO");
            string pathFCO = Console.ReadLine();
            Console.WriteLine("What's the conversion cutscene id for this specific cutscene?");
            string eventName = Console.ReadLine();
            SUC_ConverterConverse.InspireResource resourceSWA = new SUC_ConverterConverse.InspireResource();
            path = path.Replace("\"", "");
            pathFCO = pathFCO.Replace("\"", "");
            XmlSerializer serializer = new XmlSerializer(typeof(SUC_ConverterConverse.InspireResource));
            using (StreamReader reader = new StreamReader(@path))
            {
                resourceSWA = (SUC_ConverterConverse.InspireResource)(serializer.Deserialize(reader));
            }
            SWAFCOData fcoData = FCO.ParseFCO(@pathFCO);
            resourceSWA.TriggerInfo = resourceSWA.TriggerInfo.ToList().OrderBy(x => x.Frame.Start).ToArray();

            int zeroFrameCount = 0;
            int lastFrameStart = -1;
            Caption newBBSubtitlesNode = new Caption();
            foreach (var f in resourceSWA.TriggerInfo)
            {
                if (f.Frame.Start == lastFrameStart || f.Frame.Start == 0)
                {
                    Console.WriteLine($"There may be an unused entry or a duplicate one at frame {lastFrameStart}. Ignoring.");
                    continue;
                }
                if(string.IsNullOrEmpty(fcoData.GetStringDataFromCellName(GetResourceFromID(resourceSWA, f.ResourceID).Param.CellIDName)))
                {
                    Console.WriteLine($"Blank FCO entry.");
                    continue;
                }
                Console.WriteLine($"SWA value: (Start: {f.Frame.Start}, End:{f.Frame.End}) | BB Value: (Start: {f.Frame.Start}, Length: {f.Frame.End - f.Frame.Start}). #ResourceID: {f.ResourceID}");
                lastFrameStart = f.Frame.Start;
                newBBSubtitlesNode.Text.Add(CreateCaptionText(f.Frame.Start, f.Frame.End - f.Frame.Start, $"Subtitle{newBBSubtitlesNode.Text.Count.ToString("D2")}"));
            }
            Console.WriteLine("Do you want to type in the fco entries for automatic generation? (Y/n)");
            string choice = Console.ReadLine();
            List<string> stringsForFco = new List<string>();
            if(choice.ToLower() == "y")
            {
                string argumentForFco = "";
                for (int i = 0; i < newBBSubtitlesNode.Text.Count; i++)
                {
                    Console.WriteLine($"Enter a line for {i} (or type \"quit\" to exit):");
                    string newline = Console.ReadLine();
                    if (newline.ToLower() == "quit")
                        break;
                    stringsForFco.Add(newline);
                    argumentForFco += $"-add \"{eventName}\" \"{newBBSubtitlesNode.Text[i].Cell}\" \"{newline}\" ";
                }

                Console.WriteLine("Enter path to the Subtitle_Cnv.fco file (ActionCommon in Gens)");
                string pathFCOGens = Console.ReadLine();
                pathFCOGens = pathFCOGens.Replace("\"", "");
                pathFCOGens = pathFCOGens.Insert(0, "\"");
                pathFCOGens = pathFCOGens.Insert(pathFCOGens.Length, "\"");
                Utility.fcoEditorCommandline(pathFCOGens, argumentForFco);
            }
            newBBSubtitlesNode.Name = eventName;
            newBBSubtitlesNode.Group = eventName;
            string output = "";
            XmlSerializer serializer2 = new XmlSerializer(typeof(Caption));
            using (var fileStream = new StringWriter())
            {
                serializer2.Serialize(fileStream, newBBSubtitlesNode);
                output = fileStream.ToString();
            }
            output = output.Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ", "");
            Utility.ColoredTextLine(output, ConsoleColor.Blue, ConsoleColor.Black);
        }
    }
}
