using System;
using System.Windows.Forms;
using System.Data;
using System.Media;

namespace Lab_4
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    public enum Index { id = 0, genre, name, year, cost };

    private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SystemSounds.Asterisk.Play();
      About form = new About();
      form.Show(this);
    }

    public void SetStatus(string status)
    {
      statusText.Text = status;
    }
    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
      {
        DataForm form = new DataForm(ref statusText);
        form.ShowDataDialog(dataGridView, e);
      }
    }
    public void UpdateData(int index, string genreText, string nameText, int year, int cost)
    {
      Algorithm.Dt.Rows[index][(int)Index.genre] = genreText;
      Algorithm.Dt.Rows[index][(int)Index.name] = nameText;
      Algorithm.Dt.Rows[index][(int)Index.year] = year;
      Algorithm.Dt.Rows[index][(int)Index.cost] = cost;
      Algorithm.UpdateRowDB(
      int.Parse(Algorithm.Dt.Rows[index][(int)Index.id].ToString()), genreText,
      nameText,year,cost);
    }
    private void MainForm_Load(object sender, EventArgs e)
    {
      try
      {
        Algorithm.Connect();
        Algorithm.Retrieve(dataGridView);
        SetStatus("Успешно загружено!");
      }
      catch (Exception ex)
      {
        ShowError(ex.Message);
      }
    }
    public void ShowError(string errorText)
    {
      MessageBox.Show("Произошла ошибка!\n" + errorText, "Ошибка!");
      SetStatus("Произошла ошибка!");
    }
    private void AddBtn_Click(object sender, EventArgs e)
    {
      try
      {
        int id, Index;
        Index = Algorithm.Dt.Rows.Count;
        DataRow row = Algorithm.Dt.NewRow();
        Algorithm.Dt.Rows.Add(row);
        if (Index == 0)
          id = 1;
        else
        {
          id = int.Parse(Algorithm.Dt.Rows[Index - 1][(int)MainForm.Index.id].ToString()) + 1;
        }
        row[(int)MainForm.Index.id] = id;
        Algorithm.CreateRowDB();
        SetStatus("Запись успешно добавлена!");
      }
      catch (Exception ex)
      {
        ShowError(ex.Message);
      }
    }
    private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      Algorithm.DeleteRowDB(int.Parse(e.Row.Cells[(int)Index.id].Value.ToString()));
      SetStatus("Успешно удалено!");
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      saveFileDialog.ShowDialog();
    }

    private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Files.CreateFile(saveFileDialog);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.Save();
    }
  }
}
