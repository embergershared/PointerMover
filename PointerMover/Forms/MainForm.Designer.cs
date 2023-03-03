using System.Windows.Forms;

namespace CursorMover
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            QuitButton = new Button();
            StopButton = new Button();
            StartButton = new Button();
            SuspendLayout();
            // 
            // QuitButton
            // 
            resources.ApplyResources(QuitButton, "QuitButton");
            QuitButton.Name = "QuitButton";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += OKButton_Click;
            // 
            // StopButton
            // 
            resources.ApplyResources(StopButton, "StopButton");
            StopButton.Name = "StopButton";
            StopButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            resources.ApplyResources(StartButton, "StartButton");
            StartButton.Name = "StartButton";
            StartButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(QuitButton);
            Name = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button QuitButton;
        private Button StopButton;
        private Button StartButton;
    }
}