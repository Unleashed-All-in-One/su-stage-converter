using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SUC_Converter
{
    public static class Structs
    {
        public struct Highlight
        {
            public int highlightStart { get; set; }
            public int highlightEnd { get; set; }
            public int highlightMarker { get; set; }
            public byte highlightAlpha { get; set; }
            public byte highlightRed { get; set; }
            public byte highlightGreen { get; set; }
            public byte highlightBlue { get; set; }
        }

        public struct Skip
        {
            public int skip1 { get; set; }
            public int skip2 { get; set; }
            public int skip2Big { get; set; }
            public int skip3 { get; set; }
        }

        public struct ColourSub2
        {
            public int colourSub2Start { get; set; }
            public int colourSub2End { get; set; }
            public int colourSub2Marker { get; set; }
            public byte colourSub2Alpha { get; set; }
            public byte colourSub2Red { get; set; }
            public byte colourSub2Green { get; set; }
            public byte colourSub2Blue { get; set; }
        }

        public struct ColourSub1
        {
            public int colourSub1Start { get; set; }
            public int colourSub1End { get; set; }
            public int colourSub1Marker { get; set; }
            public byte colourSub1Alpha { get; set; }
            public byte colourSub1Red { get; set; }
            public byte colourSub1Green { get; set; }
            public byte colourSub1Blue { get; set; }
        }

        public struct ColourMain
        {
            public int colourMainStart { get; set; }
            public int colourMainEnd { get; set; }
            public int colourMainMarker { get; set; }
            public byte colourMainAlpha { get; set; }
            public byte colourMainRed { get; set; }
            public byte colourMainGreen { get; set; }
            public byte colourMainBlue { get; set; }
        }

        public struct Cell
        {
            public string CellName { get; set; }
            public byte[] CellNameWrite { get; set; }
            public int CellNameCharsCount { get; set; }
            public string CellMessage { get; set; }
            public byte[] CellMessageWrite { get; set; }
            public int MessageCharAmount { get; set; }
            public List<ColourMain> ColourMainList { get; set; }
            public List<ColourSub1> ColourSub1List { get; set; }
            public List<ColourSub2> ColourSub2List { get; set; }
            public List<Highlight> HighlightList { get; set; }
        }

        public struct Group
        {
            public string GroupName { get; set; }
            public int GroupNameCharsCount { get; set; }
            public List<Cell> CellList { get; set; }
        }
    }
    public static class FCO
    {

        public static bool skipFlag = false;
        public static int EndianSwap(int a)
        {
            byte[] x = BitConverter.GetBytes(a);
            //if (BitConverter.IsLittleEndian)
            Array.Reverse(x);
            int b = BitConverter.ToInt32(x, 0);
            return b;
        }

        public class SWAFCOData
        {
            public List<Structs.Group> groups = new List<Structs.Group>();
            public SWAFCOData(List<Structs.Group> g)
            {
                groups = g;
            }

            public string GetStringDataFromCellName(string cellName)
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    for (int j = 0; j < groups[i].CellList.Count; j++)
                    {
                        if(cellName == groups[i].CellList[j].CellName)
                        {
                            return groups[i].CellList[j].CellMessage;
                        }
                    }
                }
                return "NotFound";
            }
        }
        public static SWAFCOData ParseFCO(string path)
        {
            // ==================================================================================
            // Reading FCO File

            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);

            // Why do we need 2 encodings? Well, the actual text data for the cells are in unicode,
            // when names of cells, categories and styles are in UTF-8
            Encoding Unicode = Encoding.GetEncoding("Unicode");
            Encoding UTF8Encoding = Encoding.GetEncoding("UTF-8");

            binaryReader.ReadInt64();   // Seems to always be the same

            List<Structs.Group> groups = new List<Structs.Group>();

            // Groups
            int groupCount = binaryReader.ReadInt32();
            int groupCountBig = EndianSwap(groupCount);
            Console.WriteLine("Group Count = " + groupCountBig);

            for (int i = 0; i < groupCountBig; i++)
            {
                Structs.Group groupData = new Structs.Group();

                // Name
                int groupNameCharsCount = binaryReader.ReadInt32();
                int groupNameCharsCountBig = EndianSwap(groupNameCharsCount);
                Console.WriteLine("Group Name Chara Count = " + groupNameCharsCountBig);
                groupData.GroupName = UTF8Encoding.GetString(binaryReader.ReadBytes(groupNameCharsCountBig));

                while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                    byte afterGroupName = binaryReader.ReadByte();
                    int afterGroupNameBig = EndianSwap(afterGroupName);

                    if (afterGroupNameBig == 64)
                    {
                        // Move forward if the next byte is 64
                        // In this case, we'll just skip one byte
                        binaryReader.BaseStream.Seek(1, SeekOrigin.Current);
                    }
                    else if (afterGroupNameBig < 64)
                    {
                        binaryReader.BaseStream.Seek(-1, SeekOrigin.Current);
                        break;
                    }
                }

                // Cells count
                int cellCount = binaryReader.ReadInt32();
                int cellCountBig = EndianSwap(cellCount);
                Console.WriteLine("Cell Count = " + cellCountBig);

                // Cells
                List<Structs.Cell> Cells = new List<Structs.Cell>();
                for (int j = 0; j < cellCountBig; j++)
                {
                    Structs.Cell cellData = new Structs.Cell();

                    // Cell's name
                    int cellNameCharCount = binaryReader.ReadInt32();
                    int cellNameCharCountBig = EndianSwap(cellNameCharCount);
                    Console.WriteLine("Cell Name Chara Count = " + cellNameCharCountBig);
                    cellData.CellName = UTF8Encoding.GetString(binaryReader.ReadBytes(cellNameCharCountBig));

                    while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                    {
                        byte afterCellName = binaryReader.ReadByte();
                        int afterCellNameBig = EndianSwap(afterCellName);

                        if (afterCellNameBig == 64)
                        {
                            // Move forward if the next byte is 64
                            // In this case, we'll just skip one byte
                            binaryReader.BaseStream.Seek(1, SeekOrigin.Current);
                        }
                        else if (afterCellNameBig < 64)
                        {
                            binaryReader.BaseStream.Seek(-1, SeekOrigin.Current);
                            break;
                        }
                    }

                    int cellLength = binaryReader.ReadInt32();
                    int cellLengthBig = EndianSwap(cellLength);
                    Console.WriteLine("Cell Length = " + cellLengthBig);

                    // Read the hexadecimal data as a byte array
                    //byte[] cellMessageBytes = binaryReader.ReadBytes(cellLengthBig * 4);
                    byte[] cellMessageBytes = binaryReader.ReadBytes(cellLengthBig * 4);

                    cellData.CellMessage = BitConverter.ToString(cellMessageBytes).Replace("-", " ");
                    //cellData.CellMessage = String.Format("x{0:X2}", cellMessageBytes);

                    //cellData.CellMessage = Unicode.GetString(binaryReader.ReadBytes(cellLengthBig * 4));
                    Console.WriteLine("Cell Message Read!");

                    binaryReader.ReadInt32();

                    //Colour Data
                    List<Structs.ColourMain> ColourMain = new List<Structs.ColourMain>();
                    for (int p = 0; p < 1; p++)
                    {
                        Structs.ColourMain colourMainData = new Structs.ColourMain();

                        colourMainData.colourMainStart = binaryReader.ReadInt32();
                        colourMainData.colourMainEnd = binaryReader.ReadInt32();
                        colourMainData.colourMainMarker = binaryReader.ReadInt32();
                        colourMainData.colourMainAlpha = binaryReader.ReadByte();
                        colourMainData.colourMainRed = binaryReader.ReadByte();
                        colourMainData.colourMainGreen = binaryReader.ReadByte();
                        colourMainData.colourMainBlue = binaryReader.ReadByte();

                        ColourMain.Add(colourMainData);
                        Console.WriteLine("Colour Data Read!");
                    }

                    //ColourSub1 Data
                    List<Structs.ColourSub1> ColourSub1 = new List<Structs.ColourSub1>();
                    for (int p = 0; p < 1; p++)
                    {
                        Structs.ColourSub1 colourSub1Data = new Structs.ColourSub1();

                        colourSub1Data.colourSub1Start = binaryReader.ReadInt32();
                        colourSub1Data.colourSub1End = binaryReader.ReadInt32();
                        colourSub1Data.colourSub1Marker = binaryReader.ReadInt32();
                        colourSub1Data.colourSub1Alpha = binaryReader.ReadByte();
                        colourSub1Data.colourSub1Red = binaryReader.ReadByte();
                        colourSub1Data.colourSub1Green = binaryReader.ReadByte();
                        colourSub1Data.colourSub1Blue = binaryReader.ReadByte();

                        ColourSub1.Add(colourSub1Data);
                        Console.WriteLine("ColourSub1 Data Read!");
                    }

                    //ColourSub2 Data
                    List<Structs.ColourSub2> ColourSub2 = new List<Structs.ColourSub2>();
                    for (int p = 0; p < 1; p++)
                    {
                        Structs.ColourSub2 colourSub2Data = new Structs.ColourSub2();

                        colourSub2Data.colourSub2Start = binaryReader.ReadInt32();
                        colourSub2Data.colourSub2End = binaryReader.ReadInt32();
                        colourSub2Data.colourSub2Marker = binaryReader.ReadInt32();
                        colourSub2Data.colourSub2Alpha = binaryReader.ReadByte();
                        colourSub2Data.colourSub2Red = binaryReader.ReadByte();
                        colourSub2Data.colourSub2Green = binaryReader.ReadByte();
                        colourSub2Data.colourSub2Blue = binaryReader.ReadByte();

                        int colourExtraStart = binaryReader.ReadInt32();
                        int colourExtraEnd = binaryReader.ReadInt32();
                        binaryReader.ReadInt32();

                        ColourSub2.Add(colourSub2Data);
                        Console.WriteLine("ColourSub2 Data Read!");
                    }

                    cellData.ColourMainList = ColourMain;
                    cellData.ColourSub1List = ColourSub1;
                    cellData.ColourSub2List = ColourSub2;

                    //Separater
                    Structs.Skip skipData = new Structs.Skip();
                    skipData.skip1 = binaryReader.ReadInt32();
                    skipData.skip2 = binaryReader.ReadInt32();
                    skipData.skip2Big = EndianSwap(skipData.skip2);

                    List<Structs.Highlight> Highlights = new List<Structs.Highlight>();
                    for (int h = 0; h < skipData.skip2Big; h++)
                    {
                        Structs.Highlight hightlightData = new Structs.Highlight();

                        hightlightData.highlightStart = binaryReader.ReadInt32();
                        hightlightData.highlightEnd = binaryReader.ReadInt32();
                        hightlightData.highlightMarker = binaryReader.ReadInt32();
                        hightlightData.highlightAlpha = binaryReader.ReadByte();
                        hightlightData.highlightRed = binaryReader.ReadByte();
                        hightlightData.highlightGreen = binaryReader.ReadByte();
                        hightlightData.highlightBlue = binaryReader.ReadByte();

                        Highlights.Add(hightlightData);
                        Console.WriteLine("Highlight Data Read!");
                        skipFlag = true;
                    }

                    cellData.HighlightList = Highlights;

                    /*if (skipData.skip2Big > 0)
                    {
                        skipFlag = true;
                        List<Structs.Highlight> Highlights = new List<Structs.Highlight>();
                        for (int h = 0; h < skipData.skip2Big; h++)
                        {
                            Structs.Highlight hightlightData = new Structs.Highlight();

                            hightlightData.highlightStart = binaryReader.ReadInt32();
                            hightlightData.highlightEnd = binaryReader.ReadInt32();
                            hightlightData.highlightMarker = binaryReader.ReadInt32();
                            hightlightData.highlightAlpha = binaryReader.ReadByte();
                            hightlightData.highlightRed = binaryReader.ReadByte();
                            hightlightData.highlightGreen = binaryReader.ReadByte();
                            hightlightData.highlightBlue = binaryReader.ReadByte();

                            Highlights.Add(hightlightData);
                            Console.WriteLine("Highlight Data Read!");
                        }

                        cellData.HighlightList = Highlights;
                    }*/

                    int skip3 = binaryReader.ReadInt32();

                    Cells.Add(cellData);
                    Console.WriteLine("Cell Read!");
                }

                // Adding the cell list in the group
                groupData.CellList = Cells;

                // Adding the group in the categories list
                groups.Add(groupData);
            }

            binaryReader.Close();

            // ==================================================================================
            // Writing XML File

            return new SWAFCOData(groups);
        }

        public static Structs.Highlight Highlight { get; set; }
        public static Structs.Skip Skip { get; set; }
        public static Structs.ColourSub2 ColourSub2 { get; set; }
        public static Structs.ColourSub1 ColourSub1 { get; set; }
        public static Structs.ColourMain ColourMain { get; set; }
        public static Structs.Cell Cell { get; set; }
        public static Structs.Group Group { get; set; }
    }
}
