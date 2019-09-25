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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffordableHousingDesktopApp));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.appTitleLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.Location = new System.Drawing.Point(260, 26);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(339, 33);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "Affordable Housing Desktop";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(217, 134);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(153, 30);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(57, 142);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 22);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(57, 186);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(55, 22);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State:";
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyLabel.Location = new System.Drawing.Point(57, 231);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(71, 22);
            this.countyLabel.TabIndex = 6;
            this.countyLabel.Text = "County:";
            // 
            // countyTextBox
            // 
            this.countyTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyTextBox.Location = new System.Drawing.Point(217, 223);
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.Size = new System.Drawing.Size(153, 30);
            this.countyTextBox.TabIndex = 5;
            // 
            // minimumQualityLabel
            // 
            this.minimumQualityLabel.AutoSize = true;
            this.minimumQualityLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumQualityLabel.Location = new System.Drawing.Point(57, 277);
            this.minimumQualityLabel.Name = "minimumQualityLabel";
            this.minimumQualityLabel.Size = new System.Drawing.Size(154, 22);
            this.minimumQualityLabel.TabIndex = 8;
            this.minimumQualityLabel.Text = "Minimum Quality:";
            // 
            // minimumQualityTextBox
            // 
            this.minimumQualityTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumQualityTextBox.Location = new System.Drawing.Point(217, 269);
            this.minimumQualityTextBox.Name = "minimumQualityTextBox";
            this.minimumQualityTextBox.Size = new System.Drawing.Size(153, 30);
            this.minimumQualityTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Aqua;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(148, 328);
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
            this.stateComboBox.Location = new System.Drawing.Point(217, 178);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(153, 30);
            this.stateComboBox.TabIndex = 11;
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(423, 134);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.Size = new System.Drawing.Size(335, 165);
            this.resultsGridView.TabIndex = 12;
            this.resultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultsGridView_CellContentClick);
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersLabel.Location = new System.Drawing.Point(197, 84);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(62, 22);
            this.filtersLabel.TabIndex = 13;
            this.filtersLabel.Text = "Filters";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(555, 84);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(68, 22);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "Results";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.SteelBlue;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(524, 328);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 39);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(768, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AffordableHousingDesktopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.filtersLabel);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.minimumQualityLabel);
            this.Controls.Add(this.minimumQualityTextBox);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.countyTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.appTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AffordableHousingDesktopApp";
            this.Text = "Affordable Housing Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

