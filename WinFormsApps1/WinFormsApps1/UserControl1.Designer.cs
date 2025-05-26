namespace WinFormsApps1
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCEvents = new Button();
            SuspendLayout();
            // 
            // btnCEvents
            // 
            btnCEvents.AutoSize = true;
            btnCEvents.BackColor = SystemColors.InactiveBorder;
            btnCEvents.FlatStyle = FlatStyle.Flat;
            btnCEvents.Location = new Point(0, 3);
            btnCEvents.Name = "btnCEvents";
            btnCEvents.Size = new Size(195, 57);
            btnCEvents.TabIndex = 0;
            btnCEvents.Text = "button1";
            btnCEvents.TextAlign = ContentAlignment.TopLeft;
            btnCEvents.UseVisualStyleBackColor = false;
            btnCEvents.Click += btnCEvents_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCEvents);
            Name = "UserControl1";
            Size = new Size(199, 72);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCEvents;
    }
}
