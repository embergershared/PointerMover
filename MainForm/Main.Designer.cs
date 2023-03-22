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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            button_Quit = new Button();
            button_Stop = new Button();
            button_Start = new Button();
            label_Language = new Label();
            comboBox_Language = new ComboBox();
            timer_RunningTime = new Timer(components);
            textBox_TimeElapsed = new TextBox();
            label_Elapsed = new Label();
            numericUpDown_Interval = new NumericUpDown();
            label_MoveInterval = new Label();
            label_Seconds = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Interval).BeginInit();
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
            button_Stop.Click += Button_Stop_Click;
            // 
            // button_Start
            // 
            resources.ApplyResources(button_Start, "button_Start");
            button_Start.Name = "button_Start";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += Button_Start_Click;
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
            // timer_RunningTime
            // 
            timer_RunningTime.Interval = 1000;
            timer_RunningTime.Tick += Timer_RunningTime_Ticks;
            // 
            // textBox_TimeElapsed
            // 
            resources.ApplyResources(textBox_TimeElapsed, "textBox_TimeElapsed");
            textBox_TimeElapsed.Name = "textBox_TimeElapsed";
            textBox_TimeElapsed.ReadOnly = true;
            textBox_TimeElapsed.TabStop = false;
            // 
            // label_Elapsed
            // 
            resources.ApplyResources(label_Elapsed, "label_Elapsed");
            label_Elapsed.Name = "label_Elapsed";
            // 
            // numericUpDown_Interval
            // 
            numericUpDown_Interval.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            resources.ApplyResources(numericUpDown_Interval, "numericUpDown_Interval");
            numericUpDown_Interval.Maximum = new decimal(new int[] { 1800, 0, 0, 0 });
            numericUpDown_Interval.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown_Interval.Name = "numericUpDown_Interval";
            numericUpDown_Interval.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // label_MoveInterval
            // 
            resources.ApplyResources(label_MoveInterval, "label_MoveInterval");
            label_MoveInterval.Name = "label_MoveInterval";
            // 
            // label_Seconds
            // 
            resources.ApplyResources(label_Seconds, "label_Seconds");
            label_Seconds.Name = "label_Seconds";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_Seconds);
            Controls.Add(label_MoveInterval);
            Controls.Add(numericUpDown_Interval);
            Controls.Add(label_Elapsed);
            Controls.Add(textBox_TimeElapsed);
            Controls.Add(comboBox_Language);
            Controls.Add(label_Language);
            Controls.Add(button_Start);
            Controls.Add(button_Stop);
            Controls.Add(button_Quit);
            Name = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Interval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Quit;
        private Button button_Stop;
        private Button button_Start;
        private Label label_Language;
        private ComboBox comboBox_Language;
        private Timer timer_RunningTime;
        private TextBox textBox_TimeElapsed;
        private Label label_Elapsed;
        private NumericUpDown numericUpDown_Interval;
        private Label label_MoveInterval;
        private Label label_Seconds;
    }
}