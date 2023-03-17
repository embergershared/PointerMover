/*
 * Copyright (c) 2023 Emmanuel Bergerat
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using MainForm.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using MainForm.Interfaces;
using Microsoft.Extensions.Configuration;

namespace MainForm
{
    public partial class Main : Form
    {
        //
        // Constants
        //
        #region Constants


        #endregion

        //
        // Members
        //
        #region Members

        // UI Languages
        private readonly Dictionary<string, Lang[]> _languages;
        // Dependencies
        private readonly IConfigurationRoot _configurationRoot;

        #endregion

        //
        // Constructor
        //
        #region Constructor

        public Main(
            ILanguagesCollections languagesCollections,
            IConfigurationRoot configurationRoot
            )
        {
            _configurationRoot = configurationRoot;
            _languages = languagesCollections.LanguagesCollections;
            InitializeComponent();
        }

        #endregion

        //
        // GUI events
        //
        #region GUI events

        private void Button_Quit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ComboBox_Language_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_Language.SelectedValue != null && !string.IsNullOrEmpty(comboBox_Language.SelectedValue.ToString()))
            {
                SetFormUiLanguage(comboBox_Language.SelectedValue.ToString());
            }
            else
            {
                SetFormUiLanguage("en-US");
            }
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods

        private void Main_Load(object sender, EventArgs e)
        {
            var requestedStartLanguage = _configurationRoot["StartLanguage"];
            var startLanguage = requestedStartLanguage != null && _languages.ContainsKey(requestedStartLanguage)
                ? requestedStartLanguage
                : _languages.First().Key;
            SetFormUiLanguage(startLanguage);
        }

        private void SetFormUiLanguage(string? lang)
        {
            if (lang == null) return;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            this.Controls.Clear();
            this.InitializeComponent();
            SetComboBoxItemsLanguage(lang);
        }

        private void SetComboBoxItemsLanguage(string? lang)
        {
            if (lang == null) return;
            comboBox_Language.DataSource = _languages[lang];
            comboBox_Language.DisplayMember = "Name";
            comboBox_Language.ValueMember = "Code";
            var index = Array.Find(_languages[lang], element => element.Code == lang)!.Index;
            comboBox_Language.SelectedIndex = index;
        }

        #endregion

    }
}