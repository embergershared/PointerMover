using System.Windows.Forms;
using System.Drawing;

namespace MainForm
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            button_Quit = new Button();
            button_Stop = new Button();
            button_Start = new Button();
            label_Language = new Label();
            comboBox_Language = new ComboBox();
            SuspendLayout();
            // 
            // button_Quit
            // 
            resources.ApplyResources(button_Quit, "button_Quit");
            button_Quit.Name = "button_Quit";
            button_Quit.UseVisualStyleBackColor = true;
            button_Quit.Click += Button_Quit_Click;
            // 
            // button_Stop
            // 
            resources.ApplyResources(button_Stop, "button_Stop");
            button_Stop.Name = "button_Stop";
            button_Stop.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            resources.ApplyResources(button_Start, "button_Start");
            button_Start.Name = "button_Start";
            button_Start.UseVisualStyleBackColor = true;
            // 
            // label_Language
            // 
            resources.ApplyResources(label_Language, "label_Language");
            label_Language.Name = "label_Language";
            // 
            // comboBox_Language
            // 
            comboBox_Language.FormattingEnabled = true;
            resources.ApplyResources(comboBox_Language, "comboBox_Language");
            comboBox_Language.Name = "comboBox_Language";
            comboBox_Language.SelectionChangeCommitted += ComboBox_Language_SelectionChangeCommitted;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox_Language);
            Controls.Add(label_Language);
            Controls.Add(button_Start);
            Controls.Add(button_Stop);
            Controls.Add(button_Quit);
            Name = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Quit;
        private Button button_Stop;
        private Button button_Start;
        private Label label_Language;
        private ComboBox comboBox_Language;
    }
}