namespace AffordableHousingDesktopApp
{
    partial class AffordableHousingDesktopApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.countyLabel = new System.Windows.Forms.Label();
            this.countyTextBox = new System.Windows.Forms.TextBox();
            this.minimumQualityLabel = new System.Windows.Forms.Label();
            this.minimumQualityTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.heatMapGmapControl = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchSavedResButton = new System.Windows.Forms.Button();
            this.searchSavedResTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.savedResultsGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savedResultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.appTitleLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.Location = new System.Drawing.Point(247, 21);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(339, 33);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "Affordable Housing Desktop";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(219, 128);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(153, 30);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(59, 136);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 22);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(59, 180);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(55, 22);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State:";
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyLabel.Location = new System.Drawing.Point(59, 225);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(71, 22);
            this.countyLabel.TabIndex = 6;
            this.countyLabel.Text = "County:";
            // 
            // countyTextBox
            // 
            this.countyTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyTextBox.Location = new System.Drawing.Point(219, 217);
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.Size = new System.Drawing.Size(153, 30);
            this.countyTextBox.TabIndex = 5;
            // 
            // minimumQualityLabel
            // 
            this.minimumQualityLabel.AutoSize = true;
            this.minimumQualityLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumQualityLabel.Location = new System.Drawing.Point(59, 271);
            this.minimumQualityLabel.Name = "minimumQualityLabel";
            this.minimumQualityLabel.Size = new System.Drawing.Size(154, 22);
            this.minimumQualityLabel.TabIndex = 8;
            this.minimumQualityLabel.Text = "Minimum Quality:";
            // 
            // minimumQualityTextBox
            // 
            this.minimumQualityTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumQualityTextBox.Location = new System.Drawing.Point(219, 263);
            this.minimumQualityTextBox.Name = "minimumQualityTextBox";
            this.minimumQualityTextBox.Size = new System.Drawing.Size(153, 30);
            this.minimumQualityTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Aqua;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(150, 322);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(140, 39);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(219, 172);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(153, 30);
            this.stateComboBox.TabIndex = 11;
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(425, 128);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.Size = new System.Drawing.Size(335, 165);
            this.resultsGridView.TabIndex = 12;
            this.resultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultsGridView_CellContentClick);
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersLabel.Location = new System.Drawing.Point(199, 78);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(62, 22);
            this.filtersLabel.TabIndex = 13;
            this.filtersLabel.Text = "Filters";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(557, 78);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(68, 22);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "Results";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.SteelBlue;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(607, 322);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 39);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // heatMapGmapControl
            // 
            this.heatMapGmapControl.Bearing = 0F;
            this.heatMapGmapControl.CanDragMap = true;
            this.heatMapGmapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.heatMapGmapControl.GrayScaleMode = false;
            this.heatMapGmapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.heatMapGmapControl.LevelsKeepInMemmory = 5;
            this.heatMapGmapControl.Location = new System.Drawing.Point(63, 387);
            this.heatMapGmapControl.MarkersEnabled = true;
            this.heatMapGmapControl.MaxZoom = 17;
            this.heatMapGmapControl.MinZoom = 1;
            this.heatMapGmapControl.MouseWheelZoomEnabled = true;
            this.heatMapGmapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.heatMapGmapControl.Name = "heatMapGmapControl";
            this.heatMapGmapControl.NegativeMode = false;
            this.heatMapGmapControl.PolygonsEnabled = true;
            this.heatMapGmapControl.RetryLoadTile = 0;
            this.heatMapGmapControl.RoutesEnabled = true;
            this.heatMapGmapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.heatMapGmapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.heatMapGmapControl.ShowTileGridLines = false;
            this.heatMapGmapControl.Size = new System.Drawing.Size(697, 323);
            this.heatMapGmapControl.TabIndex = 17;
            this.heatMapGmapControl.Zoom = 0D;
            this.heatMapGmapControl.Load += new System.EventHandler(this.HeatMapGmapControl_Load);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 766);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.filtersLabel);
            this.tabPage1.Controls.Add(this.heatMapGmapControl);
            this.tabPage1.Controls.Add(this.resultsGridView);
            this.tabPage1.Controls.Add(this.countyTextBox);
            this.tabPage1.Controls.Add(this.appTitleLabel);
            this.tabPage1.Controls.Add(this.stateLabel);
            this.tabPage1.Controls.Add(this.minimumQualityLabel);
            this.tabPage1.Controls.Add(this.stateComboBox);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.cityLabel);
            this.tabPage1.Controls.Add(this.minimumQualityTextBox);
            this.tabPage1.Controls.Add(this.countyLabel);
            this.tabPage1.Controls.Add(this.cityTextBox);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 740);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchSavedResButton);
            this.tabPage2.Controls.Add(this.searchSavedResTextBox);
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.savedResultsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 740);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchSavedResButton
            // 
            this.searchSavedResButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchSavedResButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSavedResButton.Location = new System.Drawing.Point(470, 40);
            this.searchSavedResButton.Name = "searchSavedResButton";
            this.searchSavedResButton.Size = new System.Drawing.Size(80, 39);
            this.searchSavedResButton.TabIndex = 18;
            this.searchSavedResButton.Text = "Search";
            this.searchSavedResButton.UseVisualStyleBackColor = false;
            this.searchSavedResButton.Click += new System.EventHandler(this.SearchSavedResButton_Click);
            // 
            // searchSavedResTextBox
            // 
            this.searchSavedResTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSavedResTextBox.Location = new System.Drawing.Point(292, 45);
            this.searchSavedResTextBox.Name = "searchSavedResTextBox";
            this.searchSavedResTextBox.Size = new System.Drawing.Size(153, 30);
            this.searchSavedResTextBox.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(339, 350);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(140, 39);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // savedResultsGridView
            // 
            this.savedResultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedResultsGridView.Location = new System.Drawing.Point(99, 92);
            this.savedResultsGridView.Name = "savedResultsGridView";
            this.savedResultsGridView.Size = new System.Drawing.Size(634, 238);
            this.savedResultsGridView.TabIndex = 0;
            this.savedResultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SavedResultsGridView_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(436, 322);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 39);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AffordableHousingDesktopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 757);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AffordableHousingDesktopApp";
            this.Text = "Affordable Housing Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savedResultsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.TextBox countyTextBox;
        private System.Windows.Forms.Label minimumQualityLabel;
        private System.Windows.Forms.TextBox minimumQualityTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button clearButton;
        private GMap.NET.WindowsForms.GMapControl heatMapGmapControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView savedResultsGridView;
        private System.Windows.Forms.Button searchSavedResButton;
        private System.Windows.Forms.TextBox searchSavedResTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
    }
}

