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

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace AffordableHousingDesktopApp
{
    public partial class AffordableHousingDesktopApp : Form
    {
        private GMapOverlay markers;
        private int savedResultsGridViewRows = 0;
        

        public AffordableHousingDesktopApp()
        {
            InitializeComponent();
            setGmapMarker();
            prepareResultsDataGrid();
            prepareSavedResultsDataGrid();
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
            List<APIDataObject> apiDataObjects = parseJSONToDataObjects(restAPIHelper.getSearchResults(getSearchFilters()));
            createDataGridItems(apiDataObjects);
            showResultsInHeatMap(apiDataObjects);
        }

        private void prepareResultsDataGrid() {
            resultsGridView.ColumnCount = 4;
            resultsGridView.Columns[0].Name = "Quality";
            resultsGridView.Columns[1].Name = "City";
            resultsGridView.Columns[2].Name = "State";
            resultsGridView.Columns[3].Name = "County";
        }

        private void prepareSavedResultsDataGrid() {
            savedResultsGridView.ColumnCount = 4;
            savedResultsGridView.Columns[0].Name = "Quality";
            savedResultsGridView.Columns[1].Name = "City";
            savedResultsGridView.Columns[2].Name = "State";
            savedResultsGridView.Columns[3].Name = "County";
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
                double latitude = (double)jsonResultsArray[i]["latitude"];
                double longitude = (double)jsonResultsArray[i]["longitude"];
                dataObjects.Add(new APIDataObject(city, state, county, quality, latitude, longitude));
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

        private void showResultsInHeatMap(List<APIDataObject> dataObjects) {
            //GMapOverlay markers = new GMapOverlay("markers");

            for (int i = 0; i < dataObjects.Count; i++) {
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(dataObjects[i].Lat, dataObjects[i].Long),
                    GMarkerGoogleType.blue_dot);
                markers.Markers.Add(marker);
            }
            heatMapGmapControl.Overlays.Add(markers);
        }

        private void setGmapMarker()
        {
            this.markers = new GMapOverlay("markers");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultsGridView.Rows.Clear();
            markers.Markers.Clear();
        }

        private void HeatMapGmapControl_Load(object sender, EventArgs e)
        {
            //GMap gmap = new GMap();

            heatMapGmapControl.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            heatMapGmapControl.SetPositionByKeywords("Paris, France");
            //heatMapGmapControl.Position = new GMap.NET.PointLatLng(48.8589507, 2.2775175);
            heatMapGmapControl.ShowCenter = false;
        }

        // Gets selected results from resultsGridView.
        private DataRow[] getSelectedResults(DataGridView grid)
        {
            int selectedRowCount = grid.SelectedRows.Count;
            DataRow[] selectedResultRows = new DataRow[selectedRowCount];
            for (int i = 1; i < selectedRowCount; i++) {
                selectedResultRows[i] = ((DataRowView)grid.SelectedRows[i].DataBoundItem).Row;
            }

            return selectedResultRows;
        }

        // Add rows to a selected grid view.
        private void copyRows(DataGridView dest, DataRow[] rowsToCopy) {
            
            for (int i = 0; i < rowsToCopy.Length; i++) {
                dest.Rows.Add(rowsToCopy[i].ItemArray);
            }
            
            /*
            foreach (DataRow row in rowsToCopy)
            {
                // add to dest
                dest.Rows.Add(row.ItemArray);
            }
            */
        }

        private void SearchSavedResButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < resultsGridView.SelectedRows.Count; i++) {
                savedResultsGridView.Rows.Add(resultsGridView.SelectedRows[i]);
            }
            */
            // Copies rows from resultsGridView to savedResultsGridView.
            //copyRows(savedResultsGridView, getSelectedResults(resultsGridView));
            int selectedIndexesCount = resultsGridView.SelectedRows.Count;
            int[] selectedIndexes = new int[selectedIndexesCount];
            //int selectedIndex = resultsGridView.SelectedRows[0].Index;
            for (int i = 0; i < selectedIndexesCount; i++) {
                int selectedIndex = resultsGridView.SelectedRows[i].Index;
                for (int j = 0; j < resultsGridView.Columns.Count; j++)
                {
                    savedResultsGridView.Rows[i].Cells[j].Value = resultsGridView.Rows[selectedIndex].Cells[j].Value;
                }
                //savedResultsGridView.Rows[0].Cells[i].Value = resultsGridView.Rows[selectedIndex].Cells[i].Value;
            }
        }

        private void SavedResultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
