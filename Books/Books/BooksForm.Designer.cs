namespace Books
{
    partial class BooksForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохрнаитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.отсортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrice = new System.Windows.Forms.CheckBox();
            this.checkPages = new System.Windows.Forms.CheckBox();
            this.checkYear = new System.Windows.Forms.CheckBox();
            this.checkEdition = new System.Windows.Forms.CheckBox();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.checkAuthor = new System.Windows.Forms.CheckBox();
            this.checkIsbn = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textPages = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textEdition = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textIsbn = new System.Windows.Forms.TextBox();
            this.listOfCurrentBooks = new System.Windows.Forms.ListBox();
            this.labelCurrentBooks = new System.Windows.Forms.Label();
            this.labelFoundBooks = new System.Windows.Forms.Label();
            this.listOfFoundBooks = new System.Windows.Forms.ListBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(772, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохрнаитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.отсортироватьToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохрнаитьToolStripMenuItem
            // 
            this.сохрнаитьToolStripMenuItem.Name = "сохрнаитьToolStripMenuItem";
            this.сохрнаитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохрнаитьToolStripMenuItem.Text = "Открыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // отсортироватьToolStripMenuItem
            // 
            this.отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
            this.отсортироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отсортироватьToolStripMenuItem.Text = "Отсортировать";
            // 
            // checkPrice
            // 
            this.checkPrice.AutoSize = true;
            this.checkPrice.ForeColor = System.Drawing.Color.White;
            this.checkPrice.Location = new System.Drawing.Point(17, 283);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(52, 17);
            this.checkPrice.TabIndex = 65;
            this.checkPrice.Text = "Цена";
            this.checkPrice.UseVisualStyleBackColor = true;
            // 
            // checkPages
            // 
            this.checkPages.AutoSize = true;
            this.checkPages.ForeColor = System.Drawing.Color.White;
            this.checkPages.Location = new System.Drawing.Point(17, 241);
            this.checkPages.Name = "checkPages";
            this.checkPages.Size = new System.Drawing.Size(68, 17);
            this.checkPages.TabIndex = 64;
            this.checkPages.Text = "Страниц";
            this.checkPages.UseVisualStyleBackColor = true;
            // 
            // checkYear
            // 
            this.checkYear.AutoSize = true;
            this.checkYear.ForeColor = System.Drawing.Color.White;
            this.checkYear.Location = new System.Drawing.Point(17, 204);
            this.checkYear.Name = "checkYear";
            this.checkYear.Size = new System.Drawing.Size(44, 17);
            this.checkYear.TabIndex = 63;
            this.checkYear.Text = "Год";
            this.checkYear.UseVisualStyleBackColor = true;
            // 
            // checkEdition
            // 
            this.checkEdition.AutoSize = true;
            this.checkEdition.ForeColor = System.Drawing.Color.White;
            this.checkEdition.Location = new System.Drawing.Point(17, 168);
            this.checkEdition.Name = "checkEdition";
            this.checkEdition.Size = new System.Drawing.Size(98, 17);
            this.checkEdition.TabIndex = 62;
            this.checkEdition.Text = "Издательство";
            this.checkEdition.UseVisualStyleBackColor = true;
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.ForeColor = System.Drawing.Color.White;
            this.checkName.Location = new System.Drawing.Point(17, 131);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(76, 17);
            this.checkName.TabIndex = 61;
            this.checkName.Text = "Название";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // checkAuthor
            // 
            this.checkAuthor.AutoSize = true;
            this.checkAuthor.ForeColor = System.Drawing.Color.White;
            this.checkAuthor.Location = new System.Drawing.Point(17, 94);
            this.checkAuthor.Name = "checkAuthor";
            this.checkAuthor.Size = new System.Drawing.Size(56, 17);
            this.checkAuthor.TabIndex = 60;
            this.checkAuthor.Text = "Автор";
            this.checkAuthor.UseVisualStyleBackColor = true;
            // 
            // checkIsbn
            // 
            this.checkIsbn.AutoSize = true;
            this.checkIsbn.ForeColor = System.Drawing.Color.White;
            this.checkIsbn.Location = new System.Drawing.Point(17, 59);
            this.checkIsbn.Name = "checkIsbn";
            this.checkIsbn.Size = new System.Drawing.Size(51, 17);
            this.checkIsbn.TabIndex = 59;
            this.checkIsbn.Text = "ISBN";
            this.checkIsbn.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(193, 328);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 23);
            this.buttonDelete.TabIndex = 58;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.Location = new System.Drawing.Point(101, 328);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(65, 23);
            this.buttonFind.TabIndex = 57;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(17, 328);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 23);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.textPrice.ForeColor = System.Drawing.Color.White;
            this.textPrice.Location = new System.Drawing.Point(121, 281);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(83, 20);
            this.textPrice.TabIndex = 55;
            // 
            // textPages
            // 
            this.textPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.textPages.ForeColor = System.Drawing.Color.White;
            this.textPages.Location = new System.Drawing.Point(121, 239);
            this.textPages.Name = "textPages";
            this.textPages.Size = new System.Drawing.Size(137, 20);
            this.textPages.TabIndex = 54;
            // 
            // textYear
            // 
            this.textYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.textYear.ForeColor = System.Drawing.Color.White;
            this.textYear.Location = new System.Drawing.Point(121, 202);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(137, 20);
            this.textYear.TabIndex = 53;
            // 
            // textEdition
            // 
            this.textEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.textEdition.ForeColor = System.Drawing.Color.White;
            this.textEdition.Location = new System.Drawing.Point(121, 166);
            this.textEdition.Name = "textEdition";
            this.textEdition.Size = new System.Drawing.Size(137, 20);
            this.textEdition.TabIndex = 52;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(121, 129);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(137, 20);
            this.textName.TabIndex = 51;
            // 
            // textAuthor
            // 
            this.textAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.textAuthor.ForeColor = System.Drawing.Color.White;
            this.textAuthor.Location = new System.Drawing.Point(121, 92);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(137, 20);
            this.textAuthor.TabIndex = 50;
            // 
            // textIsbn
            // 
            this.textIsbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.textIsbn.ForeColor = System.Drawing.Color.White;
            this.textIsbn.Location = new System.Drawing.Point(121, 57);
            this.textIsbn.Name = "textIsbn";
            this.textIsbn.Size = new System.Drawing.Size(137, 20);
            this.textIsbn.TabIndex = 49;
            // 
            // listOfCurrentBooks
            // 
            this.listOfCurrentBooks.FormattingEnabled = true;
            this.listOfCurrentBooks.Location = new System.Drawing.Point(315, 56);
            this.listOfCurrentBooks.Name = "listOfCurrentBooks";
            this.listOfCurrentBooks.Size = new System.Drawing.Size(197, 290);
            this.listOfCurrentBooks.TabIndex = 66;
            // 
            // labelCurrentBooks
            // 
            this.labelCurrentBooks.AutoSize = true;
            this.labelCurrentBooks.ForeColor = System.Drawing.Color.White;
            this.labelCurrentBooks.Location = new System.Drawing.Point(349, 39);
            this.labelCurrentBooks.Name = "labelCurrentBooks";
            this.labelCurrentBooks.Size = new System.Drawing.Size(117, 13);
            this.labelCurrentBooks.TabIndex = 67;
            this.labelCurrentBooks.Text = "Текущий список книг";
            // 
            // labelFoundBooks
            // 
            this.labelFoundBooks.AutoSize = true;
            this.labelFoundBooks.ForeColor = System.Drawing.Color.White;
            this.labelFoundBooks.Location = new System.Drawing.Point(583, 39);
            this.labelFoundBooks.Name = "labelFoundBooks";
            this.labelFoundBooks.Size = new System.Drawing.Size(128, 13);
            this.labelFoundBooks.TabIndex = 69;
            this.labelFoundBooks.Text = "Список найденных книг";
            // 
            // listOfFoundBooks
            // 
            this.listOfFoundBooks.FormattingEnabled = true;
            this.listOfFoundBooks.Location = new System.Drawing.Point(546, 56);
            this.listOfFoundBooks.Name = "listOfFoundBooks";
            this.listOfFoundBooks.Size = new System.Drawing.Size(197, 290);
            this.listOfFoundBooks.TabIndex = 68;
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(108)))));
            this.course.ForeColor = System.Drawing.Color.White;
            this.course.Items.AddRange(new object[] {
            "$",
            "€",
            "Br"});
            this.course.Location = new System.Drawing.Point(202, 281);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(56, 21);
            this.course.Sorted = true;
            this.course.TabIndex = 70;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(772, 370);
            this.Controls.Add(this.course);
            this.Controls.Add(this.labelFoundBooks);
            this.Controls.Add(this.listOfFoundBooks);
            this.Controls.Add(this.labelCurrentBooks);
            this.Controls.Add(this.listOfCurrentBooks);
            this.Controls.Add(this.checkPrice);
            this.Controls.Add(this.checkPages);
            this.Controls.Add(this.checkYear);
            this.Controls.Add(this.checkEdition);
            this.Controls.Add(this.checkName);
            this.Controls.Add(this.checkAuthor);
            this.Controls.Add(this.checkIsbn);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textPages);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textEdition);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textIsbn);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "BooksForm";
            this.Shown += new System.EventHandler(this.BooksForm_Shown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохрнаитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkPrice;
        private System.Windows.Forms.CheckBox checkPages;
        private System.Windows.Forms.CheckBox checkYear;
        private System.Windows.Forms.CheckBox checkEdition;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.CheckBox checkAuthor;
        private System.Windows.Forms.CheckBox checkIsbn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textPages;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textEdition;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textIsbn;
        private System.Windows.Forms.ListBox listOfCurrentBooks;
        private System.Windows.Forms.Label labelCurrentBooks;
        private System.Windows.Forms.Label labelFoundBooks;
        private System.Windows.Forms.ListBox listOfFoundBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьToolStripMenuItem;
        private System.Windows.Forms.ComboBox course;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

