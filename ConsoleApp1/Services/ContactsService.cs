using HW_10.Models;
using Newtonsoft.Json;

namespace HW_10.Services
{
    internal class ContactsService
    {

        public static void WrongInput()
        {
            Console.WriteLine("You've made a mistake. Please try again");
        }

        public static string FindGrouping(string name)
        {
            string[] cultures = new string[4] {"en_US", "ru_Ru", "num", "Other"};
            Cultures? culturesObj = LoadJson();
            if(culturesObj != null)
            {
                for(int i = 0; i < name.Length; i++)
                {
                    if (name.ToUpper()[i] == culturesObj.En[i])
                    {
                        return cultures[0];
                    }
                    if(name.ToLower()[i] == culturesObj.Ru[i])
                    {
                        return cultures[1];
                    }
                    if (name[i] == culturesObj.Num[i])
                    {
                        return cultures[2];
                    }
                }
            } else
            {
                WrongInput();
            }
            return "";
        }

        public static Cultures LoadJson()
        {
            string jsonData = File.ReadAllText("../../../Config/config.json", System.Text.Encoding.ASCII);
            dynamic? jsonConfig = JsonConvert.DeserializeObject<object>(jsonData);
            if (jsonConfig != null)
            {
                return new Cultures((string)jsonConfig.cultures.en_US, (string)jsonConfig.cultures.ru_Ru, (string)jsonConfig.cultures.num);
            }
            else
            {
                WrongInput();
            }
            return null;
        }
    }
}
