using MainForm.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainForm
{
    public partial class Main : Form
    {
        private IDictionary<string, Lang[]> _languages;

        public Main()
        {
            InitializeComponent();
            GetLanguagesCollections();
        }

        private void GetLanguagesCollections()
        {
            // These are hard-coded here,
            // Could be pulled from any settings source.
            _languages = new Dictionary<string, Lang[]>
            {
                {
                    "en-US",
                    new[]
                    {
                        new Lang(0, "English", "en-US"),
                        new Lang(1, "French", "fr-FR"),
                        new Lang(2, "Brazilian", "pt-BR"),
                    }
                },
                {
                    "fr-FR",
                    new[]
                    {
                        new Lang(0, "Anglais", "en-US"),
                        new Lang(1, "Français", "fr-FR"),
                        new Lang(2, "Brésilien", "pt-BR"),
                    }
                },
                {
                    "pt-BR",
                    new[]
                    {
                        new Lang(0, "Inglês", "en-US"),
                        new Lang(1, "Francês", "fr-FR"),
                        new Lang(2, "Brasileiro", "pt-BR"),
                    }
                }

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetFormUiLanguage(_languages.First().Key);
        }

        private void comboBox_Language_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_Language.SelectedValue.ToString()))
            {
                SetFormUiLanguage(comboBox_Language.SelectedValue.ToString());
            }
            else
            {
                SetFormUiLanguage("en-US");
            }
        }


        private void SetFormUiLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            this.Controls.Clear();
            this.InitializeComponent();
            SetComboBoxItemsLanguage(lang);
        }

        private void SetComboBoxItemsLanguage(string lang)
        {
            comboBox_Language.DataSource = _languages[lang];
            comboBox_Language.DisplayMember = "Name";
            comboBox_Language.ValueMember = "Code";
            var index = Array.Find(_languages[lang], element => element.Code == lang).Index;
            comboBox_Language.SelectedIndex = index;
        }
    }
}