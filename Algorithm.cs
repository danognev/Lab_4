using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Lab_4
{
  public class Algorithm
  {
    static DataTable dt = new DataTable();
    static public DataTable Dt { get { return dt; } set { dt = value; } }
    public static void Retrieve(object sender)
    {
        using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
        {
          SQLiteCommand cmd;
          SQLiteDataAdapter adapter = new SQLiteDataAdapter();
          DataGridView dataGridView = sender as DataGridView;
          string sql = "SELECT * FROM Film";
          cmd = new SQLiteCommand(sql, connection);
          adapter.SelectCommand = cmd;
          adapter.Fill(Dt);
          dataGridView.DataSource = Dt;
        }
    }
    public static void CreateRowDB() {
        using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
        {
          SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Film (id) VALUES (@ID)", connection);
          cmd.Parameters.AddWithValue("@ID", Dt.Rows[Dt.Rows.Count - 1][(int)MainForm.Index.id]);
          connection.Open();
          cmd.ExecuteNonQuery();
          connection.Close();
        }
    }
    public static void DeleteRowDB(int id)
    {
        using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
        {
          SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Film WHERE id = @ID", connection);
          cmd.Parameters.AddWithValue("@ID", id);
          connection.Open();
          cmd.ExecuteNonQuery();
          connection.Close();
        }
    }
    public static void UpdateRowDB(int id, string genreText, string nameText, int year,int cost)
    {
        using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
        {
          SQLiteCommand cmd = 
          new SQLiteCommand("UPDATE Film SET genre = @GENRE, name = @NAME, year = @YEAR, cost = @COST WHERE id = @ID", connection);
          cmd.Parameters.AddWithValue("@GENRE",genreText);
          cmd.Parameters.AddWithValue("@NAME",nameText);
          cmd.Parameters.AddWithValue("@YEAR",year);
          cmd.Parameters.AddWithValue("@COST",cost);
          cmd.Parameters.AddWithValue("@ID",id);
          connection.Open();
          cmd.ExecuteNonQuery();
          connection.Close();
        }
    }
    public static void Connect()
    {
      if (!File.Exists("database.db"))
      {
        SQLiteConnection.CreateFile("database.db");
        using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
        {
          string table = "CREATE TABLE IF NOT EXISTS Film ( id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, genre VARCHAR(12)," +
"         name VARCHAR(128),year INTEGER, cost INTEGER)";
          SQLiteCommand cmd = new SQLiteCommand(table, connection);
          connection.Open();
          cmd.ExecuteNonQuery();
          connection.Close();
        }
      }
    }
  }
}
