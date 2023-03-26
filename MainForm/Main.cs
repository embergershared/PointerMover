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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MainForm.Interfaces;
using Microsoft.Extensions.Configuration;
using MainForm.Models;
// ReSharper disable once RedundantUsingDirective
using MainForm.Classes;
// ReSharper disable once RedundantUsingDirective
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using Microsoft.Extensions.Localization;

namespace MainForm
{
    public partial class Main : Form
    {
        #region Members

        // UI Languages
        private readonly Dictionary<string, Lang[]> _languages;

        // Dependencies Injection
        private readonly IStringLocalizer<Main> _localizer;
        private readonly IConfigurationRoot _configurationRoot;
        private readonly IPointerMover _pointerMover;

        // Variables
        private int _elapsedSeconds;
        private int _moveInterval;
        private int _movePixels;
        private readonly bool _debugIsEnabled;

        #endregion

        #region Constructor

        public Main(
            ILanguagesCollections languagesCollections,
            IConfigurationRoot configurationRoot,
            IPointerMover pointerMover,
            IStringLocalizer<Main> localizer
            )
        {
            _configurationRoot = configurationRoot;
            _languages = languagesCollections.LanguagesCollections;
            _pointerMover = pointerMover;
            _localizer = localizer;

            InitializeComponent();

            _debugIsEnabled = Convert.ToBoolean(_configurationRoot["EnableDebug"]);
        }

        #endregion

        #region GUI events

        private void Button_Start_Click(object sender, EventArgs e)
        {
            _elapsedSeconds = 0;
            DisplayElapsedTime(_elapsedSeconds);

            SetPointerMoverPixelsMove();
            ClearCodingTexts();

            button_Stop.Enabled = true;
            button_Start.Enabled = false;
            numericUpDown_Interval.Enabled = false;
            _moveInterval = (int)numericUpDown_Interval.Value;

            if (_debugIsEnabled)
            {
                label_Command.Text = string.Format(_localizer["Moving of {0} pixels, every {1} seconds."], _movePixels, _moveInterval);
                ShowDebugComponents();
            }

            timer_RunningTime.Start();
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = true;
            button_Stop.Enabled = false;
            numericUpDown_Interval.Enabled = true;

            HideDebugComponents();
            label_Command.Text = "";

            timer_RunningTime.Stop();
        }

        private void Button_Quit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void SetPointerMoverPixelsMove()
        {
            _ = int.TryParse(_configurationRoot["DefaultPixelsMove"], out _movePixels);
            _pointerMover.Initialize(_movePixels);
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
            ClearCodingTexts();
        }

        private void Label_Action_TextChanged(object sender, EventArgs e)
        {
            timer_DisplayDebugAction.Start();
        }

        private void Timer_DisplayDebugAction_Tick(object sender, EventArgs e)
        {
            label_Action.Text = "";
            timer_DisplayDebugAction.Stop();
        }

        private void Timer_RunningTime_Tick(object sender, EventArgs e)
        {
            // Timer ticks each second and we do 3 things:
            // 1. Add 1 second to the elapsedSeconds
            _elapsedSeconds += 1;

            // 2. Update running time text box
            DisplayElapsedTime(_elapsedSeconds);

            // 3. Check if we move the pointer
            if (_elapsedSeconds % _moveInterval != 0) return;
            // Move the pointer
            _pointerMover.MovePointer();
        }

        #endregion

        #region Private methods

        private void Main_Load(object sender, EventArgs e)
        {
            var requestedStartLanguage = _configurationRoot["StartLanguage"];
            var startLanguage = requestedStartLanguage != null && _languages.ContainsKey(requestedStartLanguage)
                ? requestedStartLanguage
                : _languages.First().Key;
            SetFormUiLanguage(startLanguage);

            ClearCodingTexts();

            _pointerMover.ShareDebugInfos(label_Action, label_X, label_Y);

            numericUpDown_Interval.Value = (decimal.Parse(_configurationRoot["DefaultInterval"]));

            if (!_debugIsEnabled) return;
            ShowDebugComponents();
        }

        private void ClearCodingTexts()
        {
            label_Action.Text = "";
            label_Command.Text = "";
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

        private void DisplayElapsedTime(int i)
        {
            var timespan = TimeSpan.FromSeconds(i);
            var display = $"{timespan.ToString("hh")}h {timespan.ToString("mm")}m {timespan.ToString("ss")}s";
            textBox_TimeElapsed.Text = display;
        }

        private void ShowDebugComponents()
        {
            label_Debug.Show();
            label_X.Show();
            label_Y.Show();
            label_Action.Show();
            label_Command.Show();
        }

        private void HideDebugComponents()
        {
            label_Debug.Hide();
            label_X.Hide();
            label_Y.Hide();
            label_Action.Hide();
            label_Command.Hide();
        }

        #endregion
    }
}