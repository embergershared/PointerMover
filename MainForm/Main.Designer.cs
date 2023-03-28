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
            label_X = new Label();
            label_Y = new Label();
            label_Command = new Label();
            label_Action = new Label();
            timer_DisplayDebugAction = new Timer(components);
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
            resources.ApplyResources(comboBox_Language, "comboBox_Language");
            comboBox_Language.FormattingEnabled = true;
            comboBox_Language.Name = "comboBox_Language";
            comboBox_Language.SelectionChangeCommitted += ComboBox_Language_SelectionChangeCommitted;
            // 
            // timer_RunningTime
            // 
            timer_RunningTime.Interval = 1000;
            timer_RunningTime.Tick += Timer_RunningTime_Tick;
            // 
            // textBox_TimeElapsed
            // 
            resources.ApplyResources(textBox_TimeElapsed, "textBox_TimeElapsed");
            textBox_TimeElapsed.BorderStyle = BorderStyle.None;
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
            resources.ApplyResources(numericUpDown_Interval, "numericUpDown_Interval");
            numericUpDown_Interval.Increment = new decimal(new int[] { 5, 0, 0, 0 });
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
            // label_X
            // 
            resources.ApplyResources(label_X, "label_X");
            label_X.Name = "label_X";
            // 
            // label_Y
            // 
            resources.ApplyResources(label_Y, "label_Y");
            label_Y.Name = "label_Y";
            // 
            // label_Command
            // 
            resources.ApplyResources(label_Command, "label_Command");
            label_Command.Name = "label_Command";
            // 
            // label_Action
            // 
            resources.ApplyResources(label_Action, "label_Action");
            label_Action.Name = "label_Action";
            label_Action.TextChanged += Label_Action_TextChanged;
            // 
            // timer_DisplayDebugAction
            // 
            timer_DisplayDebugAction.Interval = 1000;
            timer_DisplayDebugAction.Tick += Timer_DisplayDebugAction_Tick;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_Action);
            Controls.Add(label_Command);
            Controls.Add(label_Y);
            Controls.Add(label_X);
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
            MaximizeBox = false;
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
        private Label label_X;
        private Label label_Y;
        private Label label_Command;
        private Label label_Action;
        private Timer timer_DisplayDebugAction;
    }
}