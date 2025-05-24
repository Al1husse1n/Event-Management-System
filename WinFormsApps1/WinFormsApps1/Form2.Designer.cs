namespace WinFormsApps1
{
    partial class CustomerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            llProfile = new LinkLabel();
            llHome = new LinkLabel();
            llCLogout = new LinkLabel();
            panelWelcomeCustomer = new Panel();
            lblUpcoming = new Label();
            button1 = new Button();
            txtCSearchEvent = new TextBox();
            lblCWelcome = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            panelWelcomeCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(llProfile);
            groupBox1.Controls.Add(llHome);
            groupBox1.Controls.Add(llCLogout);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(126, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // llProfile
            // 
            llProfile.AutoSize = true;
            llProfile.LinkColor = Color.Black;
            llProfile.Location = new Point(6, 124);
            llProfile.Name = "llProfile";
            llProfile.Size = new Size(106, 38);
            llProfile.TabIndex = 3;
            llProfile.TabStop = true;
            llProfile.Text = "Profile";
            // 
            // llHome
            // 
            llHome.AutoSize = true;
            llHome.LinkColor = Color.Black;
            llHome.Location = new Point(6, 41);
            llHome.Name = "llHome";
            llHome.Size = new Size(95, 38);
            llHome.TabIndex = 2;
            llHome.TabStop = true;
            llHome.Text = "Home";
            // 
            // llCLogout
            // 
            llCLogout.AutoSize = true;
            llCLogout.LinkColor = Color.Black;
            llCLogout.Location = new Point(4, 205);
            llCLogout.Name = "llCLogout";
            llCLogout.Size = new Size(108, 38);
            llCLogout.TabIndex = 1;
            llCLogout.TabStop = true;
            llCLogout.Text = "Logout";
            // 
            // panelWelcomeCustomer
            // 
            panelWelcomeCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelWelcomeCustomer.BackColor = SystemColors.ScrollBar;
            panelWelcomeCustomer.Controls.Add(lblUpcoming);
            panelWelcomeCustomer.Controls.Add(button1);
            panelWelcomeCustomer.Controls.Add(txtCSearchEvent);
            panelWelcomeCustomer.Controls.Add(lblCWelcome);
            panelWelcomeCustomer.Location = new Point(124, 0);
            panelWelcomeCustomer.Name = "panelWelcomeCustomer";
            panelWelcomeCustomer.Size = new Size(758, 172);
            panelWelcomeCustomer.TabIndex = 2;
            // 
            // lblUpcoming
            // 
            lblUpcoming.AutoSize = true;
            lblUpcoming.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpcoming.Location = new Point(-5, 104);
            lblUpcoming.Name = "lblUpcoming";
            lblUpcoming.Size = new Size(239, 38);
            lblUpcoming.TabIndex = 3;
            lblUpcoming.Text = "Upcoming Events";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(665, 48);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCSearchEvent
            // 
            txtCSearchEvent.Anchor = AnchorStyles.Right;
            txtCSearchEvent.BackColor = SystemColors.Window;
            txtCSearchEvent.Location = new Point(453, 48);
            txtCSearchEvent.Name = "txtCSearchEvent";
            txtCSearchEvent.Size = new Size(206, 31);
            txtCSearchEvent.TabIndex = 1;
            txtCSearchEvent.TextChanged += txtCSearchEvent_TextChanged;
            // 
            // lblCWelcome
            // 
            lblCWelcome.AutoSize = true;
            lblCWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCWelcome.Location = new Point(59, 38);
            lblCWelcome.Name = "lblCWelcome";
            lblCWelcome.Size = new Size(175, 48);
            lblCWelcome.TabIndex = 0;
            lblCWelcome.Text = "Welcome";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ScrollBar;
            flowLayoutPanel1.CausesValidation = false;
            flowLayoutPanel1.Location = new Point(119, 171);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(763, 301);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelWelcomeCustomer);
            Controls.Add(groupBox1);
            Name = "CustomerForm";
            Text = "Customer";
            Load += CustomerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelWelcomeCustomer.ResumeLayout(false);
            panelWelcomeCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel llCLogout;
        private LinkLabel llHome;
        private Panel panelWelcomeCustomer;
        private LinkLabel llProfile;
        private Label lblCWelcome;
        private Button button1;
        private TextBox txtCSearchEvent;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUpcoming;
    }
}