using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MEnglish
{
    class JsonWords
    {

        private static readonly string EN_DIC_PATH = "EnDic.json";
        private static readonly string RU_DIC_PATH = "RuDic.json";
        private static readonly string GB_DIC_PATH = "GbDic.json";

        public static string[] EWArray;
        public static string[] RWArray;
        public static string[] GBArray;

        static string enData = File.ReadAllText(EN_DIC_PATH);
        static string ruData = File.ReadAllText(RU_DIC_PATH);
        static string gbData = File.ReadAllText(GB_DIC_PATH);
        public static async void Init()
        {
            EWArray = JsonConvert.DeserializeObject<string[]>(enData);
            RWArray = JsonConvert.DeserializeObject<string[]>(ruData);
            GBArray = JsonConvert.DeserializeObject<string[]>(gbData);

            // получаем локальную папку
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            // создаем файл hello.txt
            StorageFile helloFile = await localFolder.CreateFileAsync("ENGLISH_DIC.json",
                                                CreationCollisionOption.ReplaceExisting);

            // если файл уже ранее был создан, то мы можем получить его через GetFileAsync()
            // helloFile = await localFolder.GetFileAsync("hello.txt");
            await FileIO.WriteTextAsync(helloFile, EWArray[0]);
            // запись в файл
            localFolder = ApplicationData.Current.LocalFolder;
            // получаем файл
            helloFile = await localFolder.GetFileAsync("ENGLISH_DIC.json");
            // читаем файл
            string text = await FileIO.ReadTextAsync(helloFile);
        }
    }
}
