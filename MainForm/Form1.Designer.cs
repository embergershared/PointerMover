namespace MainForm
{
    partial class Form1
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
            button_Quit = new Button();
            button_Stop = new Button();
            button_Start = new Button();
            label_Language = new Label();
            comboBox_Language = new ComboBox();
            SuspendLayout();
            // 
            // button_Quit
            // 
            button_Quit.Location = new Point(578, 252);
            button_Quit.Name = "button_Quit";
            button_Quit.Size = new Size(110, 47);
            button_Quit.TabIndex = 0;
            button_Quit.Text = "Quit";
            button_Quit.UseVisualStyleBackColor = true;
            button_Quit.Click += button1_Click;
            // 
            // button_Stop
            // 
            button_Stop.Location = new Point(398, 252);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(110, 47);
            button_Stop.TabIndex = 1;
            button_Stop.Text = "Stop";
            button_Stop.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            button_Start.Location = new Point(282, 252);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(110, 47);
            button_Start.TabIndex = 2;
            button_Start.Text = "Start";
            button_Start.UseVisualStyleBackColor = true;
            // 
            // label_Language
            // 
            label_Language.AutoSize = true;
            label_Language.Location = new Point(12, 265);
            label_Language.Name = "label_Language";
            label_Language.Size = new Size(74, 20);
            label_Language.TabIndex = 3;
            label_Language.Text = "Language";
            // 
            // comboBox_Language
            // 
            comboBox_Language.FormattingEnabled = true;
            comboBox_Language.Location = new Point(92, 262);
            comboBox_Language.Name = "comboBox_Language";
            comboBox_Language.Size = new Size(151, 28);
            comboBox_Language.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 311);
            Controls.Add(comboBox_Language);
            Controls.Add(label_Language);
            Controls.Add(button_Start);
            Controls.Add(button_Stop);
            Controls.Add(button_Quit);
            Name = "Form1";
            Text = "Pointer mover";
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