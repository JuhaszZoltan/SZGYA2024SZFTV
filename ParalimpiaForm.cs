using MySql.Data.MySqlClient;

namespace SZGYA2024SZFTV;

public partial class ParalimpiaForm : Form
{
    const string CONSTR =
        "SERVER=127.0.0.1;" +
        "DATABASE=paralimpia;" +
        "UID=root;" +
        "PWD=;";

    private string selectedID; 

    public ParalimpiaForm()
    {
        InitializeComponent();
        Load += ParalimpiaFormLoad;
        searchTextBox.TextChanged += SearchTextBoxTextChanged;
        medalsDataGridView.CellClick += MedalsDataGridViewCellClick;
        updateMedalsButton.Click += UpdateMedalsButtonClick;
    }

    private void UpdateMedalsButtonClick(object? sender, EventArgs e)
    {
        if (medalsDataGridView.SelectedRows.Count <= 0) return;

        DialogResult result = MessageBox.Show(
            caption: "MEGERÕSÍTÉS", 
            text: $"biztosan módosítani kívánja a {selectedYearLabel.Text} évi paralimpia éremszámait?", 
            buttons: MessageBoxButtons.YesNo, 
            icon: MessageBoxIcon.Question);

        if (result != DialogResult.Yes || selectedID is null) return;

        using MySqlConnection connection = new(CONSTR);
        connection.Open();
        MySqlDataAdapter adapter = new()
        {
            UpdateCommand = new(
                cmdText: "UPDATE nyari_magyar_ermetablazat " +
                $"SET arany = {goldNumericUpDown.Value}, ezust = {silverNumericUpDown.Value}, bronz = {bronzeNumericUpDown.Value} " +
                $"WHERE id = {selectedID};",
                connection: connection),
        };
        adapter.UpdateCommand.ExecuteNonQuery();

        searchTextBox.Text = string.Empty;
        QueryForDGVFill();
    }

    private void MedalsDataGridViewCellClick(object? sender, DataGridViewCellEventArgs e)
    {
        selectedID = $"{(sender as DataGridView)[0, e.RowIndex].Value}";
        selectedYearLabel.Text = $"{(sender as DataGridView)[3, e.RowIndex].Value}";
        goldNumericUpDown.Value = (int)(sender as DataGridView)[4, e.RowIndex].Value;
        silverNumericUpDown.Value = (int)(sender as DataGridView)[5, e.RowIndex].Value;
        bronzeNumericUpDown.Value = (int)(sender as DataGridView)[6, e.RowIndex].Value;
    }

    private void SearchTextBoxTextChanged(object? sender, EventArgs e) =>
        QueryForDGVFill((sender as TextBox).Text);

    private void ParalimpiaFormLoad(object? sender, EventArgs e) =>
        QueryForDGVFill();

    private void QueryForDGVFill(string st = null)
    {
        medalsDataGridView.Rows.Clear();

        using MySqlConnection connection = new(CONSTR);
        connection.Open();

        MySqlDataReader reader = new MySqlCommand(
            cmdText: "SELECT * FROM nyari_magyar_ermetablazat " +
            $"WHERE orszag LIKE '{st}%' OR varos LIKE '{st}%';",
            connection: connection)
            .ExecuteReader();
        while(reader.Read()) medalsDataGridView.Rows.Add(
            reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);

        selectedID = $"{medalsDataGridView.SelectedCells[0].Value}";
    }
}
