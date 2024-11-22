namespace SZGYA2024SZFTV
{
    partial class ParalimpiaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiLabel01 = new Label();
            searchTextBox = new TextBox();
            medalsDataGridView = new DataGridView();
            IndexColumn = new DataGridViewTextBoxColumn();
            CountryColumn = new DataGridViewTextBoxColumn();
            CityColumn = new DataGridViewTextBoxColumn();
            YearColumn = new DataGridViewTextBoxColumn();
            GoldColumn = new DataGridViewTextBoxColumn();
            SilverColumn = new DataGridViewTextBoxColumn();
            BronzeColumn = new DataGridViewTextBoxColumn();
            uiLabel02 = new Label();
            selectedYearLabel = new Label();
            goldNumericUpDown = new NumericUpDown();
            uiLabel03 = new Label();
            uiLabel04 = new Label();
            uiLabel05 = new Label();
            bronzeNumericUpDown = new NumericUpDown();
            silverNumericUpDown = new NumericUpDown();
            updateMedalsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)medalsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goldNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bronzeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)silverNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // uiLabel01
            // 
            uiLabel01.AutoSize = true;
            uiLabel01.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uiLabel01.Location = new Point(12, 29);
            uiLabel01.Name = "uiLabel01";
            uiLabel01.Size = new Size(187, 15);
            uiLabel01.TabIndex = 0;
            uiLabel01.Text = "szűrés ország vagy város alapján:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(205, 26);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(513, 23);
            searchTextBox.TabIndex = 1;
            // 
            // medalsDataGridView
            // 
            medalsDataGridView.AllowUserToAddRows = false;
            medalsDataGridView.AllowUserToDeleteRows = false;
            medalsDataGridView.AllowUserToResizeColumns = false;
            medalsDataGridView.AllowUserToResizeRows = false;
            medalsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medalsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            medalsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medalsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IndexColumn, CountryColumn, CityColumn, YearColumn, GoldColumn, SilverColumn, BronzeColumn });
            medalsDataGridView.Location = new Point(12, 73);
            medalsDataGridView.Name = "medalsDataGridView";
            medalsDataGridView.RowHeadersVisible = false;
            medalsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            medalsDataGridView.Size = new Size(706, 364);
            medalsDataGridView.TabIndex = 2;
            // 
            // IndexColumn
            // 
            IndexColumn.FillWeight = 1F;
            IndexColumn.HeaderText = "#";
            IndexColumn.Name = "IndexColumn";
            // 
            // CountryColumn
            // 
            CountryColumn.FillWeight = 3F;
            CountryColumn.HeaderText = "rendező ország";
            CountryColumn.Name = "CountryColumn";
            // 
            // CityColumn
            // 
            CityColumn.FillWeight = 3F;
            CityColumn.HeaderText = "helyszín";
            CityColumn.Name = "CityColumn";
            // 
            // YearColumn
            // 
            YearColumn.FillWeight = 2F;
            YearColumn.HeaderText = "év";
            YearColumn.Name = "YearColumn";
            // 
            // GoldColumn
            // 
            GoldColumn.FillWeight = 1F;
            GoldColumn.HeaderText = "arany";
            GoldColumn.Name = "GoldColumn";
            // 
            // SilverColumn
            // 
            SilverColumn.FillWeight = 1F;
            SilverColumn.HeaderText = "ezüst";
            SilverColumn.Name = "SilverColumn";
            // 
            // BronzeColumn
            // 
            BronzeColumn.FillWeight = 1F;
            BronzeColumn.HeaderText = "bronz";
            BronzeColumn.Name = "BronzeColumn";
            // 
            // uiLabel02
            // 
            uiLabel02.AutoSize = true;
            uiLabel02.Location = new Point(15, 489);
            uiLabel02.Name = "uiLabel02";
            uiLabel02.Size = new Size(60, 15);
            uiLabel02.TabIndex = 3;
            uiLabel02.Text = "kijelölt év:";
            // 
            // selectedYearLabel
            // 
            selectedYearLabel.AutoSize = true;
            selectedYearLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectedYearLabel.Location = new Point(92, 489);
            selectedYearLabel.Name = "selectedYearLabel";
            selectedYearLabel.Size = new Size(35, 15);
            selectedYearLabel.TabIndex = 0;
            selectedYearLabel.Text = "####";
            // 
            // goldNumericUpDown
            // 
            goldNumericUpDown.Location = new Point(148, 481);
            goldNumericUpDown.Name = "goldNumericUpDown";
            goldNumericUpDown.Size = new Size(48, 23);
            goldNumericUpDown.TabIndex = 4;
            // 
            // uiLabel03
            // 
            uiLabel03.AutoSize = true;
            uiLabel03.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uiLabel03.Location = new Point(148, 463);
            uiLabel03.Name = "uiLabel03";
            uiLabel03.Size = new Size(37, 15);
            uiLabel03.TabIndex = 0;
            uiLabel03.Text = "arany";
            // 
            // uiLabel04
            // 
            uiLabel04.AutoSize = true;
            uiLabel04.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uiLabel04.Location = new Point(217, 463);
            uiLabel04.Name = "uiLabel04";
            uiLabel04.Size = new Size(37, 15);
            uiLabel04.TabIndex = 0;
            uiLabel04.Text = "ezüst";
            // 
            // uiLabel05
            // 
            uiLabel05.AutoSize = true;
            uiLabel05.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uiLabel05.Location = new Point(286, 463);
            uiLabel05.Name = "uiLabel05";
            uiLabel05.Size = new Size(39, 15);
            uiLabel05.TabIndex = 0;
            uiLabel05.Text = "bronz";
            // 
            // bronzeNumericUpDown
            // 
            bronzeNumericUpDown.Location = new Point(286, 481);
            bronzeNumericUpDown.Name = "bronzeNumericUpDown";
            bronzeNumericUpDown.Size = new Size(48, 23);
            bronzeNumericUpDown.TabIndex = 4;
            // 
            // silverNumericUpDown
            // 
            silverNumericUpDown.Location = new Point(217, 481);
            silverNumericUpDown.Name = "silverNumericUpDown";
            silverNumericUpDown.Size = new Size(48, 23);
            silverNumericUpDown.TabIndex = 4;
            // 
            // updateMedalsButton
            // 
            updateMedalsButton.Location = new Point(397, 463);
            updateMedalsButton.Name = "updateMedalsButton";
            updateMedalsButton.Size = new Size(321, 41);
            updateMedalsButton.TabIndex = 5;
            updateMedalsButton.Text = "érmek számának módosítása";
            updateMedalsButton.UseVisualStyleBackColor = true;
            // 
            // ParalimpiaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 535);
            Controls.Add(updateMedalsButton);
            Controls.Add(silverNumericUpDown);
            Controls.Add(bronzeNumericUpDown);
            Controls.Add(goldNumericUpDown);
            Controls.Add(uiLabel02);
            Controls.Add(medalsDataGridView);
            Controls.Add(searchTextBox);
            Controls.Add(uiLabel05);
            Controls.Add(uiLabel04);
            Controls.Add(uiLabel03);
            Controls.Add(selectedYearLabel);
            Controls.Add(uiLabel01);
            Name = "ParalimpiaForm";
            Text = "Magyar Paralimpiai Eredménytábla";
            ((System.ComponentModel.ISupportInitialize)medalsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)goldNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)bronzeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)silverNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uiLabel01;
        private TextBox searchTextBox;
        private DataGridView medalsDataGridView;
        private DataGridViewTextBoxColumn IndexColumn;
        private DataGridViewTextBoxColumn CountryColumn;
        private DataGridViewTextBoxColumn CityColumn;
        private DataGridViewTextBoxColumn YearColumn;
        private DataGridViewTextBoxColumn GoldColumn;
        private DataGridViewTextBoxColumn SilverColumn;
        private DataGridViewTextBoxColumn BronzeColumn;
        private Label uiLabel02;
        private Label selectedYearLabel;
        private NumericUpDown goldNumericUpDown;
        private Label uiLabel03;
        private Label uiLabel04;
        private Label uiLabel05;
        private NumericUpDown bronzeNumericUpDown;
        private NumericUpDown silverNumericUpDown;
        private Button updateMedalsButton;
    }
}
