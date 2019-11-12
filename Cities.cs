using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{

    struct MyCities
    {
        private int cityid;
        public int cityID
            {
            get { return cityid; }
            }
        private string cityname;
        public string cityName
        {
            get { return cityname; }
        }
        private int citypop;
        public int cityPop
        {
            get { return citypop; }
        }

        private float cityarea;
        public float cityArea
        {
            get { return cityarea; }
        }


        /// <summary>
        /// Add a new City to the List Of Cities you Are creating
        /// </summary>
        /// <param name="cName">Name of the City</param>
        /// <param name="cArea">Area Size of the City</param>
        public void Add(string cName, float cArea)
        {
            cityid ++;
            cityname = cName;
            cityarea = cArea;
            citypop = 2;
        }

    }
}
