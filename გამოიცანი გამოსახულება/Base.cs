using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace გამოიცანი_გამოსახულება
{
    static class Base
    {
        public static string LevelPath { get; private set; }
        public static string[] ImagePath { get; private set; }
        public static readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        static Category _testCategory;
        public static Category TestCategory
        {
            get
            {
                return _testCategory;
            }
            set
            {
                LevelPath = value.ToString() + ".dat";
                GetDictionary(LevelPath);
                _testCategory = value;
            }
        }
        static Base()
        {
            ImagePath = Directory.GetFiles("Images");
        }
        static void GetDictionary(string path)
        {
                _dictionary.Clear();
                BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open));
                while(br.PeekChar() > 0)
                {
                    try
                    {
                        _dictionary.Add(br.ReadString(), br.ReadString());
                    }
                    catch
                    {
                   
                    }
                }
                br.Close();
        }
    }
    public enum Category
    {
        Animals = 0,
        Retro,
        Flags,
        Sports,
        Professions,
        NoCategory
    }
}
