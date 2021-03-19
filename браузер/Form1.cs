using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace браузер
{
    public partial class MainForm : Form
    {
        private int kolPages = 0;
        public MainForm()
        {
            InitializeComponent();
            listBox_для_сохр.Items.AddRange(File.ReadAllLines("save-pages.txt"));
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            listBox_для_вкладок.Items.Add("Новая вкладка");
            /*WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;
            Вкладки.TabPages.Add("Новая вкладка");
            Вкладки.SelectTab(kolPages);
            kolPages++;*/
        }
        /*void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Вкладки.SelectedTab.Text = ((WebBrowser)Вкладки.SelectedTab.Controls[0]).DocumentTitle;
        }*/

        private void Найти_Click(object sender, EventArgs e)
        {
            kolPages = listBox_для_вкладок.SelectedIndex;
            string namesite = Строка.Text;
            try
            {
                Uri uri = new Uri(namesite);
                webControl.Source = uri;
                listBox_для_вкладок.Items[listBox_для_вкладок.SelectedIndex] = namesite;
            }
            catch (Exception)
            {
                Uri uri = new Uri("https://google.com");
                webControl.Source = uri;
                MessageBox.Show("Ошибка");
            }
        }


        /*private void MainForm_Load(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;
            Вкладки.TabPages.Add("Новая вкладка");
            Вкладки.SelectTab(kolPages);
            Вкладки.SelectedTab.Controls.Add(browser);
            kolPages++;
        }*/

        /*private void Удалить_Click(object sender, EventArgs e)
        {
            if (Вкладки.TabPages.Count > 1)
            {
                Вкладки.TabPages.RemoveAt(Вкладки.SelectedIndex);
                Вкладки.SelectTab(Вкладки.TabPages.Count - 1);
                kolPages--;
            }
            else
            {
                Application.Exit();
            }
        }*/

        /*private void Строка_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)Вкладки.SelectedTab.Controls[0]).Navigate(Строка.Text);
            }
        }*/

        private void Сохраненные_вкладки_SelectedIndexChanged(object sender, EventArgs e)
        {
            kolPages = listBox_для_вкладок.SelectedIndex;
            try
            {
                Uri uri = new Uri(listBox_для_вкладок.Items[kolPages].ToString());
                webControl.Source = uri;
            }
            catch (Exception)
            {
                Uri uri = new Uri("https://google.com");
                webControl.Source = uri;
            }
        }

        private void Назад_Click_1(object sender, EventArgs e)
        {
            webControl.GoBack();
        }

        private void Обновить_Click(object sender, EventArgs e)
        {
            webControl.Refresh();
        }

        private void Вперед_Click(object sender, EventArgs e)
        {
            webControl.GoForward();
        }

        private void сохранитьВкладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.AppendAllText("save-pages.txt", listBox_для_вкладок.Items[listBox_для_вкладок.SelectedIndex].ToString());
            listBox_для_сохр.Items.Add(listBox_для_вкладок.Items[listBox_для_вкладок.SelectedIndex].ToString());
        }
    }
}
