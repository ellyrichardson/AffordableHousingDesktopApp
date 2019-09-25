using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffordableHousingDesktopApp
{
    public partial class AffordableHousingDesktopApp : Form
    {
        public AffordableHousingDesktopApp()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RestAPIConnection restAPIHelper = new RestAPIConnection();
            createDataGridItems(parseJSONToDataObjects(restAPIHelper.getSearchResults(getSearchFilters())));
        }

        private void createDataGridItems(List<APIDataObject> apiDataObjects)
        {
            resultsGridView.ColumnCount = 4;
            resultsGridView.Columns[0].Name = "Quality";
            resultsGridView.Columns[1].Name = "City";
            resultsGridView.Columns[2].Name = "State";
            resultsGridView.Columns[3].Name = "County";

            for (int i = 0; i < apiDataObjects.Count; i++) {
                string[] row = new string[] { apiDataObjects[i].Quality, apiDataObjects[i].City, apiDataObjects[i].State,
                    apiDataObjects[i].County };
                resultsGridView.Rows.Add(row);
            }

            /*
            string[] row = new string[] { "89", "Lenexa", "KS", "Johnson County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "94", "Boulder City", "CO", "Leavenworth County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "75", "Lees Summit", "MO", "Jefferson County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "89", "Lenexa", "KS", "Johnson County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "94", "Boulder City", "CO", "Leavenworth County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "75", "Lees Summit", "MO", "Jefferson County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "89", "Lenexa", "KS", "Johnson County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "94", "Boulder City", "CO", "Leavenworth County" };
            resultsGridView.Rows.Add(row);
            row = new string[] { "75", "Lees Summit", "MO", "Jefferson County" };
            resultsGridView.Rows.Add(row);
            */
        }

        List<APIDataObject> parseJSONToDataObjects(string jsonData)
        {
            JObject baseJSONData = new JObject();
            baseJSONData = JObject.Parse(jsonData);

            JArray jsonResultsArray = new JArray();
            // Converts the results property of the baseJSONData to an array.
            jsonResultsArray = JArray.Parse((string)baseJSONData["results"]);

            int jsonResultsLength = jsonResultsArray.Count;

            List<APIDataObject> dataObjects = new List<APIDataObject>();

            for (int i = 0; i < jsonResultsLength; i++) {
                string quality = (string)jsonResultsArray[i]["inspection_score"];
                string city = (string)jsonResultsArray[i]["city"];
                string state = (string)jsonResultsArray[i]["state_code"];
                string county = (string)jsonResultsArray[i]["county_name"];
                dataObjects.Add(new APIDataObject(quality, city, state, county));
            }

            return dataObjects;
        }

        public string getSearchFilters()
        {
            string cityValue = cityTextBox.Text;
            string stateValue = stateComboBox.Text;

            // Only two parameters for because of current API limitations
            string urlParemeters = "?search=" + cityValue + "," + stateValue;

            return urlParemeters;
        }
    }
}
