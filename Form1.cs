using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloLearn
{
    public partial class Form1 : Form
    {
        List<MyCities> myCityList = new List<MyCities>(); //List To Hold Cities
        private int AutoIncremntedCityID; //ID Generated automatically for CITY ID
        MyCities myCity; // Var to hold new City
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //myCity = new MyCities();// New instance of A City
            
            listCityNames.Items.Clear(); // Clear Listbox To refresh Cities

            if (CityExists()) // Check The City Exists Method to check if a city has already been created.
            {
                MessageBox.Show("City Exists"); // If city already exists this messagebox appears.
            }
            else
            {
                AddNewCity(); // Else a new city is created and added to list of cities myCityList.
            }

            foreach (MyCities city in myCityList) //Iterate though the list of cities in myCityList and add them to the Listbox
            {
                listCityNames.Items.Add(city.cityName);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCityDetails.Items.Clear();
            foreach (MyCities city in myCityList)//Iterate though List of cities in myCityList
            {
                if(city.cityName == listCityNames.Text) // Check if citynmae in myCityList matches selected name in lIstbox
                {
                    listCityDetails.Items.Add($"ID-{city.cityID} | Population-{city.cityPop} | Area-{city.cityArea}");
                }
            }  
        }

        #region Check If City Exists
        private bool CityExists()
        {
            int track=0; // Tracking id for checking cityname while iterating through myCityList

            if (myCityList.Count == 0)// if myCityList is Empty Set CityExists to false.
            {
                return false;
            }
            else
            {
                foreach (MyCities city in myCityList)
                {
                    if(city.cityName == txtCityName.Text.ToUpper())
                    {
                        track++; //if mathcing city name is found this value will increment by 1.
                    }
                }

                if(track > 0) // if this value is > 1 that means city already exists.
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        #region Method To Add New City

        private void AddNewCity()
        {
            myCity.Add(txtCityName.Text.ToUpper(), (float)Convert.ToInt32(txtCityArea.Text));
            
            //AutoIncremntedCityID++;

            myCityList.Add(myCity);
        }
        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveData.SaveMyCities(myCity);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //PlayerData data = SaveData.LoadPlayer();

            //myCity.cityName = data.cityName;
            //myCity.cityID = data.cityID;
            //myCity.cityPop = data.cityPop;
            //myCity.cityArea = data.cityArea;
        }
    }
}


