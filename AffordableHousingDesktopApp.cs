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
            prepareDataGrid();
            prepareStateComboBox();
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

        private void prepareDataGrid() {
            resultsGridView.ColumnCount = 4;
            resultsGridView.Columns[0].Name = "Quality";
            resultsGridView.Columns[1].Name = "City";
            resultsGridView.Columns[2].Name = "State";
            resultsGridView.Columns[3].Name = "County";
            // try commit
        }

        private void prepareStateComboBox() {
            stateComboBox.Items.Add("KS");
            stateComboBox.Items.Add("MO");
            stateComboBox.Items.Add("CO");
        }

        private void createDataGridItems(List<APIDataObject> apiDataObjects)
        {
            for (int i = 0; i < apiDataObjects.Count; i++) {
                string[] row = new string[] { apiDataObjects[i].Quality, apiDataObjects[i].City, apiDataObjects[i].State,
                    apiDataObjects[i].County };
                resultsGridView.Rows.Add(row);
            }
        }

        List<APIDataObject> parseJSONToDataObjects(string jsonData)
        {
            JObject baseJSONData = new JObject();
            baseJSONData = JObject.Parse(jsonData);

            JArray jsonResultsArray = new JArray();
            // Converts the results property of the baseJSONData to an array.
            jsonResultsArray = baseJSONData["results"] as JArray;

            int jsonResultsLength = jsonResultsArray.Count;

            List<APIDataObject> dataObjects = new List<APIDataObject>();

            for (int i = 0; i < jsonResultsLength; i++) {
                string quality = (string)jsonResultsArray[i]["inspection_score"];
                string city = (string)jsonResultsArray[i]["city"];
                string state = (string)jsonResultsArray[i]["state_code"];
                string county = (string)jsonResultsArray[i]["county_name"];
                dataObjects.Add(new APIDataObject(city, state, county, quality));
            }

            return dataObjects;
        }

        public string getSearchFilters()
        {
            string cityValue = cityTextBox.Text;
            string stateValue = stateComboBox.Text;
            string countyValue = countyTextBox.Text;

            // Only two parameters for because of current API limitations
            string urlParemeters = "?search=" + cityValue + "," + stateValue + "," + countyValue;

            return urlParemeters;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultsGridView.Rows.Clear();
        }
    }
}
