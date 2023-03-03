using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using PointerMoverNETFramework.Classes;

namespace PointerMoverNETFramework
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadLanguageComboBox("en-US");
            ChangeLanguage("pt-BR");
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
        private void LoadLanguageComboBox(string lang)
        {
            var languages = new[]
            {
                new Language(0, "English", "en-US"),
                new Language(1, "Francais", "fr-FR"),
                new Language(2, "Brasileiro", "pt-BR")
            };

            comboBox1.DataSource = languages;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Code";
            var index = Array.Find(languages, element => element.Code == lang).Index;
            comboBox1.SelectedIndex = index;
        }
        
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.SelectedValue.ToString()))
            {
                ChangeLanguage(comboBox1.SelectedValue.ToString());
            }
            else
            {
                ChangeLanguage("en-US");
            }
        }

        private void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            this.Controls.Clear();
            this.InitializeComponent();
            LoadLanguageComboBox(lang);
        }
    }
}
