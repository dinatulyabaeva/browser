
namespace браузер
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Меню = new System.Windows.Forms.ToolStrip();
            this.Назад = new System.Windows.Forms.ToolStripButton();
            this.Вперед = new System.Windows.Forms.ToolStripButton();
            this.Обновить = new System.Windows.Forms.ToolStripButton();
            this.Строка = new System.Windows.Forms.ToolStripTextBox();
            this.Найти = new System.Windows.Forms.ToolStripButton();
            this.Добавить = new System.Windows.Forms.ToolStripButton();
            this.Удалить = new System.Windows.Forms.ToolStripButton();
            this.Панель_для_сохраненных_вкладок = new System.Windows.Forms.Panel();
            this.Сохраненные_вкладки = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox_для_сохр = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox_для_вкладок = new System.Windows.Forms.ListBox();
            this.webControl = new Awesomium.Windows.Forms.WebControl(this.components);
            this.Сохранить_вкладку = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Меню.SuspendLayout();
            this.Панель_для_сохраненных_вкладок.SuspendLayout();
            this.Сохраненные_вкладки.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Сохранить_вкладку.SuspendLayout();
            this.SuspendLayout();
            // 
            // Меню
            // 
            this.Меню.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Назад,
            this.Вперед,
            this.Обновить,
            this.Строка,
            this.Найти,
            this.Добавить,
            this.Удалить});
            this.Меню.Location = new System.Drawing.Point(0, 0);
            this.Меню.Name = "Меню";
            this.Меню.Size = new System.Drawing.Size(910, 27);
            this.Меню.TabIndex = 0;
            this.Меню.Text = "toolStrip1";
            // 
            // Назад
            // 
            this.Назад.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Назад.Image = ((System.Drawing.Image)(resources.GetObject("Назад.Image")));
            this.Назад.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(29, 24);
            this.Назад.Text = "toolStripButton1";
            this.Назад.Click += new System.EventHandler(this.Назад_Click_1);
            // 
            // Вперед
            // 
            this.Вперед.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Вперед.Image = ((System.Drawing.Image)(resources.GetObject("Вперед.Image")));
            this.Вперед.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Вперед.Name = "Вперед";
            this.Вперед.Size = new System.Drawing.Size(29, 24);
            this.Вперед.Text = "toolStripButton2";
            this.Вперед.Click += new System.EventHandler(this.Вперед_Click);
            // 
            // Обновить
            // 
            this.Обновить.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Обновить.Image = ((System.Drawing.Image)(resources.GetObject("Обновить.Image")));
            this.Обновить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Обновить.Name = "Обновить";
            this.Обновить.Size = new System.Drawing.Size(29, 24);
            this.Обновить.Text = "toolStripButton1";
            this.Обновить.Click += new System.EventHandler(this.Обновить_Click);
            // 
            // Строка
            // 
            this.Строка.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Строка.Name = "Строка";
            this.Строка.Size = new System.Drawing.Size(600, 27);
            // 
            // Найти
            // 
            this.Найти.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Найти.Image = ((System.Drawing.Image)(resources.GetObject("Найти.Image")));
            this.Найти.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Найти.Name = "Найти";
            this.Найти.Size = new System.Drawing.Size(29, 24);
            this.Найти.Text = "toolStripButton1";
            this.Найти.Click += new System.EventHandler(this.Найти_Click);
            // 
            // Добавить
            // 
            this.Добавить.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Добавить.Image = ((System.Drawing.Image)(resources.GetObject("Добавить.Image")));
            this.Добавить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(29, 24);
            this.Добавить.Text = "toolStripButton2";
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // Удалить
            // 
            this.Удалить.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Удалить.Image = ((System.Drawing.Image)(resources.GetObject("Удалить.Image")));
            this.Удалить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(29, 24);
            this.Удалить.Text = "toolStripButton1";
            // 
            // Панель_для_сохраненных_вкладок
            // 
            this.Панель_для_сохраненных_вкладок.Controls.Add(this.Сохраненные_вкладки);
            this.Панель_для_сохраненных_вкладок.Dock = System.Windows.Forms.DockStyle.Left;
            this.Панель_для_сохраненных_вкладок.Location = new System.Drawing.Point(0, 27);
            this.Панель_для_сохраненных_вкладок.Name = "Панель_для_сохраненных_вкладок";
            this.Панель_для_сохраненных_вкладок.Size = new System.Drawing.Size(207, 487);
            this.Панель_для_сохраненных_вкладок.TabIndex = 3;
            // 
            // Сохраненные_вкладки
            // 
            this.Сохраненные_вкладки.Controls.Add(this.tabPage1);
            this.Сохраненные_вкладки.Controls.Add(this.tabPage2);
            this.Сохраненные_вкладки.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Сохраненные_вкладки.Location = new System.Drawing.Point(0, 0);
            this.Сохраненные_вкладки.Name = "Сохраненные_вкладки";
            this.Сохраненные_вкладки.SelectedIndex = 0;
            this.Сохраненные_вкладки.Size = new System.Drawing.Size(207, 487);
            this.Сохраненные_вкладки.TabIndex = 0;
            this.Сохраненные_вкладки.SelectedIndexChanged += new System.EventHandler(this.Сохраненные_вкладки_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox_для_сохр);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(199, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сохраненные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox_для_сохр
            // 
            this.listBox_для_сохр.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_для_сохр.FormattingEnabled = true;
            this.listBox_для_сохр.ItemHeight = 16;
            this.listBox_для_сохр.Location = new System.Drawing.Point(3, 3);
            this.listBox_для_сохр.Name = "listBox_для_сохр";
            this.listBox_для_сохр.Size = new System.Drawing.Size(193, 452);
            this.listBox_для_сохр.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox_для_вкладок);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(199, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Действующие";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox_для_вкладок
            // 
            this.listBox_для_вкладок.ContextMenuStrip = this.Сохранить_вкладку;
            this.listBox_для_вкладок.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_для_вкладок.FormattingEnabled = true;
            this.listBox_для_вкладок.ItemHeight = 16;
            this.listBox_для_вкладок.Location = new System.Drawing.Point(3, 3);
            this.listBox_для_вкладок.Name = "listBox_для_вкладок";
            this.listBox_для_вкладок.Size = new System.Drawing.Size(193, 452);
            this.listBox_для_вкладок.TabIndex = 0;
            // 
            // webControl
            // 
            this.webControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl.Location = new System.Drawing.Point(207, 27);
            this.webControl.Size = new System.Drawing.Size(703, 487);
            this.webControl.TabIndex = 5;
            // 
            // Сохранить_вкладку
            // 
            this.Сохранить_вкладку.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Сохранить_вкладку.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВкладкуToolStripMenuItem});
            this.Сохранить_вкладку.Name = "contextMenuStrip1";
            this.Сохранить_вкладку.Size = new System.Drawing.Size(211, 56);
            // 
            // сохранитьВкладкуToolStripMenuItem
            // 
            this.сохранитьВкладкуToolStripMenuItem.Name = "сохранитьВкладкуToolStripMenuItem";
            this.сохранитьВкладкуToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.сохранитьВкладкуToolStripMenuItem.Text = "Сохранить вкладку";
            this.сохранитьВкладкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВкладкуToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 514);
            this.Controls.Add(this.webControl);
            this.Controls.Add(this.Панель_для_сохраненных_вкладок);
            this.Controls.Add(this.Меню);
            this.Name = "MainForm";
            this.Text = "Dinowser";
            this.Меню.ResumeLayout(false);
            this.Меню.PerformLayout();
            this.Панель_для_сохраненных_вкладок.ResumeLayout(false);
            this.Сохраненные_вкладки.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.Сохранить_вкладку.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Меню;
        private System.Windows.Forms.ToolStripButton Назад;
        private System.Windows.Forms.ToolStripButton Вперед;
        private System.Windows.Forms.ToolStripButton Обновить;
        private System.Windows.Forms.ToolStripTextBox Строка;
        private System.Windows.Forms.ToolStripButton Найти;
        private System.Windows.Forms.ToolStripButton Добавить;
        private System.Windows.Forms.ToolStripButton Удалить;
        private System.Windows.Forms.Panel Панель_для_сохраненных_вкладок;
        private System.Windows.Forms.TabControl Сохраненные_вкладки;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox_для_сохр;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox_для_вкладок;
        private Awesomium.Windows.Forms.WebControl webControl;
        private System.Windows.Forms.ContextMenuStrip Сохранить_вкладку;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВкладкуToolStripMenuItem;
    }
}

