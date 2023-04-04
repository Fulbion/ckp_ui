namespace CuteKeypadUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.PanelNav = new System.Windows.Forms.Panel();
            this.ButtonActivation = new System.Windows.Forms.Button();
            this.ButtonDistance = new System.Windows.Forms.Button();
            this.ButtonLights = new System.Windows.Forms.Button();
            this.ButtonBindings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.ButtonQuit);
            this.panel1.Controls.Add(this.PanelNav);
            this.panel1.Controls.Add(this.ButtonActivation);
            this.panel1.Controls.Add(this.ButtonDistance);
            this.panel1.Controls.Add(this.ButtonLights);
            this.panel1.Controls.Add(this.ButtonBindings);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 540);
            this.panel1.TabIndex = 0;
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.FlatAppearance.BorderSize = 0;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonQuit.ForeColor = System.Drawing.Color.OrangeRed;
            this.ButtonQuit.Image = global::CuteKeypadUI.Properties.Resources.quit;
            this.ButtonQuit.Location = new System.Drawing.Point(0, 496);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(240, 44);
            this.ButtonQuit.TabIndex = 2;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // PanelNav
            // 
            this.PanelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelNav.Location = new System.Drawing.Point(0, 128);
            this.PanelNav.Name = "PanelNav";
            this.PanelNav.Size = new System.Drawing.Size(3, 100);
            this.PanelNav.TabIndex = 2;
            this.PanelNav.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNav_Paint);
            // 
            // ButtonActivation
            // 
            this.ButtonActivation.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonActivation.FlatAppearance.BorderSize = 0;
            this.ButtonActivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonActivation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonActivation.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonActivation.Image = global::CuteKeypadUI.Properties.Resources.activation;
            this.ButtonActivation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonActivation.Location = new System.Drawing.Point(0, 218);
            this.ButtonActivation.Name = "ButtonActivation";
            this.ButtonActivation.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.ButtonActivation.Size = new System.Drawing.Size(240, 44);
            this.ButtonActivation.TabIndex = 1;
            this.ButtonActivation.Text = "Activation";
            this.ButtonActivation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonActivation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonActivation.UseVisualStyleBackColor = true;
            this.ButtonActivation.Click += new System.EventHandler(this.ButtonActivation_Click);
            this.ButtonActivation.Leave += new System.EventHandler(this.ButtonActivation_Leave);
            // 
            // ButtonDistance
            // 
            this.ButtonDistance.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDistance.FlatAppearance.BorderSize = 0;
            this.ButtonDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDistance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDistance.ForeColor = System.Drawing.Color.Gold;
            this.ButtonDistance.Image = global::CuteKeypadUI.Properties.Resources.distance;
            this.ButtonDistance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDistance.Location = new System.Drawing.Point(0, 174);
            this.ButtonDistance.Name = "ButtonDistance";
            this.ButtonDistance.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.ButtonDistance.Size = new System.Drawing.Size(240, 44);
            this.ButtonDistance.TabIndex = 1;
            this.ButtonDistance.Text = "Distance";
            this.ButtonDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDistance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonDistance.UseVisualStyleBackColor = true;
            this.ButtonDistance.Click += new System.EventHandler(this.ButtonDistance_Click);
            this.ButtonDistance.Leave += new System.EventHandler(this.ButtonDistance_Leave);
            // 
            // ButtonLights
            // 
            this.ButtonLights.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLights.FlatAppearance.BorderSize = 0;
            this.ButtonLights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLights.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonLights.ForeColor = System.Drawing.Color.Orange;
            this.ButtonLights.Image = global::CuteKeypadUI.Properties.Resources.lights;
            this.ButtonLights.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonLights.Location = new System.Drawing.Point(0, 130);
            this.ButtonLights.Name = "ButtonLights";
            this.ButtonLights.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.ButtonLights.Size = new System.Drawing.Size(240, 44);
            this.ButtonLights.TabIndex = 1;
            this.ButtonLights.Text = "Lights";
            this.ButtonLights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLights.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonLights.UseVisualStyleBackColor = true;
            this.ButtonLights.Click += new System.EventHandler(this.ButtonLights_Click);
            this.ButtonLights.Leave += new System.EventHandler(this.ButtonLights_Leave);
            // 
            // ButtonBindings
            // 
            this.ButtonBindings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonBindings.FlatAppearance.BorderSize = 0;
            this.ButtonBindings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBindings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonBindings.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonBindings.Image = global::CuteKeypadUI.Properties.Resources.bindings;
            this.ButtonBindings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonBindings.Location = new System.Drawing.Point(0, 86);
            this.ButtonBindings.Name = "ButtonBindings";
            this.ButtonBindings.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.ButtonBindings.Size = new System.Drawing.Size(240, 44);
            this.ButtonBindings.TabIndex = 1;
            this.ButtonBindings.Text = "Bindings";
            this.ButtonBindings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBindings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonBindings.UseVisualStyleBackColor = true;
            this.ButtonBindings.Click += new System.EventHandler(this.ButtonBindings_Click);
            this.ButtonBindings.Enter += new System.EventHandler(this.ButtonBindings_Click);
            this.ButtonBindings.Leave += new System.EventHandler(this.ButtonBindings_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 86);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cute Config";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::CuteKeypadUI.Properties.Resources.icon;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(63, 63);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quit.ForeColor = System.Drawing.Color.LightGray;
            this.Quit.Location = new System.Drawing.Point(688, 0);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(32, 28);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.ButtonQuit_Click);
            this.Quit.MouseHover += new System.EventHandler(this.Quit_MouseHover);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelTitle.Controls.Add(this.label3);
            this.PanelTitle.Controls.Add(this.button1);
            this.PanelTitle.Controls.Add(this.label2);
            this.PanelTitle.Controls.Add(this.Quit);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(240, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(720, 64);
            this.PanelTitle.TabIndex = 2;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(167, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "(CM-MKP-2K)";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(662, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(14, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cute Keypad 2-keys";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(240, 64);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(720, 476);
            this.PanelDesktop.TabIndex = 3;
            this.PanelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktop_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cute Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox Logo;
        private Label label1;
        private Button ButtonBindings;
        private Button ButtonActivation;
        private Button ButtonDistance;
        private Panel PanelNav;
        private Button ButtonLights;
        private Button ButtonQuit;
        private Button Quit;
        private Panel PanelTitle;
        private Panel PanelDesktop;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}