namespace Lab_4
{
  partial class DataForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.GenreBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CostBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.YearBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.GenreBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.CostBox);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.YearBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.NameBox);
			this.panel1.Controls.Add(this.DeleteBtn);
			this.panel1.Controls.Add(this.SaveBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(279, 175);
			this.panel1.TabIndex = 0;
			// 
			// GenreBox
			// 
			this.GenreBox.FormattingEnabled = true;
			this.GenreBox.Items.AddRange(new object[] {
            "Ужасы",
            "Фантастика",
            "Драма",
            "Комедия",
            "Документальный",
            "Боевик",
            "Вестерн",
            "Детектив",
            "Мелодрама",
            "Музыкальный",
            "Политический"});
			this.GenreBox.Location = new System.Drawing.Point(116, 44);
			this.GenreBox.Name = "GenreBox";
			this.GenreBox.Size = new System.Drawing.Size(156, 21);
			this.GenreBox.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(3, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Цена";
			// 
			// CostBox
			// 
			this.CostBox.Location = new System.Drawing.Point(116, 110);
			this.CostBox.Name = "CostBox";
			this.CostBox.Size = new System.Drawing.Size(156, 20);
			this.CostBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(3, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Год";
			// 
			// YearBox
			// 
			this.YearBox.Location = new System.Drawing.Point(116, 76);
			this.YearBox.Name = "YearBox";
			this.YearBox.Size = new System.Drawing.Size(156, 20);
			this.YearBox.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(3, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Жанр";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(3, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Название";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(116, 12);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(156, 20);
			this.NameBox.TabIndex = 2;
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(116, 145);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 0;
			this.DeleteBtn.Text = "Удалить";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// SaveBtn
			// 
			this.SaveBtn.Location = new System.Drawing.Point(197, 145);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(75, 23);
			this.SaveBtn.TabIndex = 0;
			this.SaveBtn.Text = "Сохранить";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// DataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(279, 175);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataForm";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Данные";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox NameBox;
    private System.Windows.Forms.Button SaveBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox YearBox;
    private System.Windows.Forms.ComboBox GenreBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox CostBox;
  }
}