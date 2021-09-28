namespace Lab_4
{
  partial class MainForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.StatusStrip statusStrip;
      this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.idcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.namecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.yearcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.costcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AddBtn = new System.Windows.Forms.Button();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      statusStrip = new System.Windows.Forms.StatusStrip();
      statusStrip.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // statusStrip
      // 
      statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
      statusStrip.Location = new System.Drawing.Point(0, 304);
      statusStrip.Name = "statusStrip";
      statusStrip.Size = new System.Drawing.Size(507, 22);
      statusStrip.TabIndex = 4;
      statusStrip.Text = "statusStrip";
      // 
      // statusText
      // 
      this.statusText.BackColor = System.Drawing.Color.White;
      this.statusText.Name = "statusText";
      this.statusText.Size = new System.Drawing.Size(0, 17);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.информацияToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(507, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
      // 
      // информацияToolStripMenuItem
      // 
      this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
      this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
      this.информацияToolStripMenuItem.Text = "Информация";
      this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToAddRows = false;
      this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
      this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcolumn,
            this.genre,
            this.namecolumn,
            this.yearcolumn,
            this.costcolumn});
      this.dataGridView.Location = new System.Drawing.Point(0, 24);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.Size = new System.Drawing.Size(507, 231);
      this.dataGridView.TabIndex = 2;
      this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
      this.dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView_UserDeletingRow);
      // 
      // idcolumn
      // 
      this.idcolumn.DataPropertyName = "id";
      this.idcolumn.HeaderText = "ID";
      this.idcolumn.Name = "idcolumn";
      this.idcolumn.Width = 43;
      // 
      // genre
      // 
      this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.genre.DataPropertyName = "genre";
      this.genre.HeaderText = "Жанр";
      this.genre.Name = "genre";
      this.genre.Width = 5;
      // 
      // namecolumn
      // 
      this.namecolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.namecolumn.DataPropertyName = "name";
      this.namecolumn.HeaderText = "Название";
      this.namecolumn.Name = "namecolumn";
      // 
      // yearcolumn
      // 
      this.yearcolumn.DataPropertyName = "year";
      this.yearcolumn.HeaderText = "Год";
      this.yearcolumn.Name = "yearcolumn";
      this.yearcolumn.Width = 50;
      // 
      // costcolumn
      // 
      this.costcolumn.DataPropertyName = "cost";
      this.costcolumn.HeaderText = "Цена";
      this.costcolumn.Name = "costcolumn";
      this.costcolumn.Width = 58;
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(381, 248);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(114, 53);
      this.AddBtn.TabIndex = 3;
      this.AddBtn.Text = "Добавить";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.Filter = "Text Files|*.txt";
      this.saveFileDialog.Title = "Сохранить";
      this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.ClientSize = new System.Drawing.Size(507, 326);
      this.Controls.Add(statusStrip);
      this.Controls.Add(this.AddBtn);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Фильмотека";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      statusStrip.ResumeLayout(false);
      statusStrip.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
    private System.Windows.Forms.Button AddBtn;
    public System.Windows.Forms.ToolStripStatusLabel statusText;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcolumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn genre;
    private System.Windows.Forms.DataGridViewTextBoxColumn namecolumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn yearcolumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn costcolumn;
    public System.Windows.Forms.DataGridView dataGridView;
  }
}

