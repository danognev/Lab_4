using Lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestProject
{
  [TestClass]
  public class UnitTest
  {
    [TestMethod]
    public void TestMethod()
    {
      MainForm mainForm = new MainForm();
      Algorithm.Connect();
      Algorithm.Retrieve(mainForm.dataGridView);
      int expecterRowCount = Algorithm.Dt.Rows.Count + 1;
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
      Assert.AreEqual(expecterRowCount, Algorithm.Dt.Rows.Count);
    }
  }
}
