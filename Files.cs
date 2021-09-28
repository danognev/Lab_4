using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Lab_4
{
  class Files
  {
    static public void CreateFile(SaveFileDialog saveFileDialog) {
      string fileName = saveFileDialog.FileName;
      try {
        using (StreamWriter file = new StreamWriter(fileName)) {
          string text = "Фильмотека\n";
          foreach(DataRow row in Algorithm.Dt.Rows) {
            text = text + "| ID: "+ row[(int)MainForm.Index.id].ToString() +" | Жанр: " + 
            row[(int)MainForm.Index.genre].ToString()+ " | Название: "+ row[(int)MainForm.Index.name].ToString() + 
            " | Год: " + row[(int)MainForm.Index.year].ToString()+ " | Стоимость: " + row[(int)MainForm.Index.cost]+ " |\n";
          }
          file.Write(text);
          file.Close();
        }
      }
      catch(Exception ex) {
        MessageBox.Show("Произошла ошибка!\n" + ex.Message, "Ошибка!");

      }
    }
  }
}
