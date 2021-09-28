using System;
using System.Windows.Forms;

namespace Lab_4
{
  public partial class DataForm : Form
  {
    static private ToolStripStatusLabel statusText;
    public DataForm(ref ToolStripStatusLabel Text)
    {
      InitializeComponent();
      statusText = Text;
    }
    private int RowIndex;
    public void ShowDataDialog(DataGridView dataGridView, DataGridViewCellEventArgs index) {
      RowIndex = index.RowIndex;
      GenreBox.Text = dataGridView.Rows[RowIndex].Cells[(int)MainForm.Index.genre].Value.ToString();
      NameBox.Text = dataGridView.Rows[RowIndex].Cells[(int)MainForm.Index.name].Value.ToString();
      YearBox.Text = dataGridView.Rows[RowIndex].Cells[(int)MainForm.Index.year].Value.ToString();
      CostBox.Text = dataGridView.Rows[RowIndex].Cells[(int)MainForm.Index.cost].Value.ToString();
      ShowDialog();
    }
    private void SaveBtn_Click(object sender, EventArgs e)
    {
      MainForm form = new MainForm();
      try
      {
          if (!int.TryParse(YearBox.Text, out int year) || year < 0)
            throw new Exception("Некорректные данные в поле 'Год'");
          if (!int.TryParse(CostBox.Text, out int cost) || cost < 0)
            throw new Exception("Некорректные данные в поле 'Цена'");
          form.UpdateData(RowIndex, GenreBox.Text, NameBox.Text, year, cost);
          Close();
          statusText.Text = "Успешно изменено!";
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Произошла ошибка!");
        statusText.Text = "Произошла ошибка!";
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
      var mess = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo);
      if (mess != DialogResult.No)
      {
        try
        {
          Algorithm.DeleteRowDB(int.Parse(Algorithm.Dt.Rows[RowIndex][(int)MainForm.Index.id].ToString()));
          Algorithm.Dt.Rows.Remove(Algorithm.Dt.Rows[RowIndex]);
          statusText.Text = "Успешно удалено!";
          Close();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Произошла ошибка!");
          statusText.Text = "Произошла ошибка!";
        }
      }
    }
  }
}
