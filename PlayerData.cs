using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    [System.Serializable]
    class PlayerData
    {
        public int cityID;
        public string cityName;
        public int cityPop;
        public float cityArea;
        List<MyCities> myCities = new List<MyCities>();

        public PlayerData(MyCities city)
        {
            cityID = city.cityID;
            cityName = city.cityName;
            cityPop = city.cityPop;
            cityArea = city.cityArea;
        }
    }
}
