using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SoloLearn
{
    [System.Serializable]
    class SaveData
    {
        public static void SaveMyCities(MyCities city)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = "D:/mycities.save";
            FileStream stream = new FileStream(path, FileMode.Create);

            PlayerData data = new PlayerData(city);

            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static PlayerData LoadPlayer()
        {
            string path = "D:/mycities.save";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                stream.Close();
                return data;
            }
            else
            {
                return null; 
            }
        }
    }
}
