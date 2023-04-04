namespace CuteKeypadUI.resources.forms
{
    partial class FormLights
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
            components = new System.ComponentModel.Container();
            PanelLeftLights = new Panel();
            LLModifier = new Panel();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            LLColorPickerBLabel = new Label();
            LLColorPickerGLabel = new Label();
            LLColorPickerRLabel = new Label();
            trackBar3 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            LLColorPicked = new Panel();
            LLTitle = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            colorDialogToolStripMenuItem = new ToolStripMenuItem();
            copyHTMLToolStripMenuItem = new ToolStripMenuItem();
            copyRGBToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            panel2 = new Panel();
            checkBox2 = new CheckBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            trackBar4 = new TrackBar();
            trackBar5 = new TrackBar();
            trackBar6 = new TrackBar();
            panel3 = new Panel();
            label4 = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            colorDialogToolStripMenuItem1 = new ToolStripMenuItem();
            copyHexadecimalToolStripMenuItem = new ToolStripMenuItem();
            copyRGBToolStripMenuItem1 = new ToolStripMenuItem();
            PanelLeftLights.SuspendLayout();
            LLModifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLeftLights
            // 
            PanelLeftLights.Controls.Add(LLModifier);
            PanelLeftLights.Controls.Add(LLTitle);
            PanelLeftLights.Dock = DockStyle.Left;
            PanelLeftLights.Location = new Point(0, 0);
            PanelLeftLights.Name = "PanelLeftLights";
            PanelLeftLights.Size = new Size(360, 476);
            PanelLeftLights.TabIndex = 0;
            // 
            // LLModifier
            // 
            LLModifier.BackColor = Color.FromArgb(28, 28, 28);
            LLModifier.Controls.Add(checkBox1);
            LLModifier.Controls.Add(textBox3);
            LLModifier.Controls.Add(textBox2);
            LLModifier.Controls.Add(textBox1);
            LLModifier.Controls.Add(LLColorPickerBLabel);
            LLModifier.Controls.Add(LLColorPickerGLabel);
            LLModifier.Controls.Add(LLColorPickerRLabel);
            LLModifier.Controls.Add(trackBar3);
            LLModifier.Controls.Add(trackBar2);
            LLModifier.Controls.Add(trackBar1);
            LLModifier.Controls.Add(LLColorPicked);
            LLModifier.Location = new Point(36, 73);
            LLModifier.Margin = new Padding(36, 3, 36, 36);
            LLModifier.Name = "LLModifier";
            LLModifier.Size = new Size(288, 358);
            LLModifier.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(3, 336);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Rainbow Effect";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(192, 192, 255);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(250, 271);
            textBox3.Margin = new Padding(3, 3, 12, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(26, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "0";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(250, 220);
            textBox2.Margin = new Padding(3, 3, 12, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(26, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "0";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 192);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(250, 169);
            textBox1.Margin = new Padding(3, 3, 12, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(26, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "255";
            // 
            // LLColorPickerBLabel
            // 
            LLColorPickerBLabel.AutoSize = true;
            LLColorPickerBLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LLColorPickerBLabel.ForeColor = Color.White;
            LLColorPickerBLabel.Location = new Point(17, 273);
            LLColorPickerBLabel.Name = "LLColorPickerBLabel";
            LLColorPickerBLabel.Size = new Size(19, 21);
            LLColorPickerBLabel.TabIndex = 2;
            LLColorPickerBLabel.Text = "B";
            // 
            // LLColorPickerGLabel
            // 
            LLColorPickerGLabel.AutoSize = true;
            LLColorPickerGLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LLColorPickerGLabel.ForeColor = Color.White;
            LLColorPickerGLabel.Location = new Point(17, 222);
            LLColorPickerGLabel.Name = "LLColorPickerGLabel";
            LLColorPickerGLabel.Size = new Size(21, 21);
            LLColorPickerGLabel.TabIndex = 2;
            LLColorPickerGLabel.Text = "G";
            // 
            // LLColorPickerRLabel
            // 
            LLColorPickerRLabel.AutoSize = true;
            LLColorPickerRLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LLColorPickerRLabel.ForeColor = Color.White;
            LLColorPickerRLabel.Location = new Point(18, 171);
            LLColorPickerRLabel.Name = "LLColorPickerRLabel";
            LLColorPickerRLabel.Size = new Size(20, 21);
            LLColorPickerRLabel.TabIndex = 2;
            LLColorPickerRLabel.Text = "R";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(44, 222);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(200, 45);
            trackBar3.TabIndex = 1;
            trackBar3.TickStyle = TickStyle.None;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(44, 273);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(200, 45);
            trackBar2.TabIndex = 1;
            trackBar2.TickStyle = TickStyle.None;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(44, 171);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(200, 45);
            trackBar1.TabIndex = 1;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 255;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // LLColorPicked
            // 
            LLColorPicked.BackColor = Color.Red;
            LLColorPicked.Dock = DockStyle.Top;
            LLColorPicked.Location = new Point(0, 0);
            LLColorPicked.Name = "LLColorPicked";
            LLColorPicked.Size = new Size(288, 144);
            LLColorPicked.TabIndex = 0;
            // 
            // LLTitle
            // 
            LLTitle.AutoSize = true;
            LLTitle.BackColor = Color.Transparent;
            LLTitle.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LLTitle.ForeColor = Color.White;
            LLTitle.Location = new Point(0, 0);
            LLTitle.Name = "LLTitle";
            LLTitle.Size = new Size(159, 45);
            LLTitle.TabIndex = 0;
            LLTitle.Text = "Left Lights";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { colorDialogToolStripMenuItem, copyHTMLToolStripMenuItem, copyRGBToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(175, 70);
            // 
            // colorDialogToolStripMenuItem
            // 
            colorDialogToolStripMenuItem.Name = "colorDialogToolStripMenuItem";
            colorDialogToolStripMenuItem.Size = new Size(174, 22);
            colorDialogToolStripMenuItem.Text = "Color Dialog";
            colorDialogToolStripMenuItem.Click += colorDialogToolStripMenuItem_Click;
            // 
            // copyHTMLToolStripMenuItem
            // 
            copyHTMLToolStripMenuItem.Name = "copyHTMLToolStripMenuItem";
            copyHTMLToolStripMenuItem.Size = new Size(174, 22);
            copyHTMLToolStripMenuItem.Text = "Copy Hexadecimal";
            copyHTMLToolStripMenuItem.Click += copyHTMLToolStripMenuItem_Click;
            // 
            // copyRGBToolStripMenuItem
            // 
            copyRGBToolStripMenuItem.Name = "copyRGBToolStripMenuItem";
            copyRGBToolStripMenuItem.Size = new Size(174, 22);
            copyRGBToolStripMenuItem.Text = "Copy RGB";
            copyRGBToolStripMenuItem.Click += copyRGBToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(360, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 476);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 28, 28);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(trackBar4);
            panel2.Controls.Add(trackBar5);
            panel2.Controls.Add(trackBar6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(36, 73);
            panel2.Margin = new Padding(36, 3, 36, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 358);
            panel2.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(3, 336);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Rainbow Effect";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 192, 255);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(250, 271);
            textBox4.Margin = new Padding(3, 3, 12, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(26, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "0";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(192, 255, 192);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(250, 220);
            textBox5.Margin = new Padding(3, 3, 12, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(26, 23);
            textBox5.TabIndex = 3;
            textBox5.Text = "0";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(255, 192, 192);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(250, 169);
            textBox6.Margin = new Padding(3, 3, 12, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(26, 23);
            textBox6.TabIndex = 3;
            textBox6.Text = "255";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 273);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 2;
            label1.Text = "B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 222);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 2;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 171);
            label3.Name = "label3";
            label3.Size = new Size(20, 21);
            label3.TabIndex = 2;
            label3.Text = "R";
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(44, 222);
            trackBar4.Maximum = 255;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(200, 45);
            trackBar4.TabIndex = 1;
            trackBar4.TickStyle = TickStyle.None;
            trackBar4.Scroll += trackBar3_Scroll_1;
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(44, 273);
            trackBar5.Maximum = 255;
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(200, 45);
            trackBar5.TabIndex = 1;
            trackBar5.TickStyle = TickStyle.None;
            trackBar5.Scroll += trackBar2_Scroll_1;
            // 
            // trackBar6
            // 
            trackBar6.Location = new Point(44, 171);
            trackBar6.Maximum = 255;
            trackBar6.Name = "trackBar6";
            trackBar6.Size = new Size(200, 45);
            trackBar6.TabIndex = 1;
            trackBar6.TickStyle = TickStyle.None;
            trackBar6.Value = 255;
            trackBar6.Scroll += trackBar1_Scroll_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 144);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 45);
            label4.TabIndex = 0;
            label4.Text = "Right Lights";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { colorDialogToolStripMenuItem1, copyHexadecimalToolStripMenuItem, copyRGBToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(175, 70);
            // 
            // colorDialogToolStripMenuItem1
            // 
            colorDialogToolStripMenuItem1.Name = "colorDialogToolStripMenuItem1";
            colorDialogToolStripMenuItem1.Size = new Size(174, 22);
            colorDialogToolStripMenuItem1.Text = "Color Dialog";
            colorDialogToolStripMenuItem1.Click += colorDialogToolStripMenuItem1_Click;
            // 
            // copyHexadecimalToolStripMenuItem
            // 
            copyHexadecimalToolStripMenuItem.Name = "copyHexadecimalToolStripMenuItem";
            copyHexadecimalToolStripMenuItem.Size = new Size(174, 22);
            copyHexadecimalToolStripMenuItem.Text = "Copy Hexadecimal";
            // 
            // copyRGBToolStripMenuItem1
            // 
            copyRGBToolStripMenuItem1.Name = "copyRGBToolStripMenuItem1";
            copyRGBToolStripMenuItem1.Size = new Size(174, 22);
            copyRGBToolStripMenuItem1.Text = "Copy RGB";
            // 
            // FormLights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(720, 476);
            Controls.Add(panel1);
            Controls.Add(PanelLeftLights);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLights";
            Text = "Lights";
            Load += FormLights_Load;
            PanelLeftLights.ResumeLayout(false);
            PanelLeftLights.PerformLayout();
            LLModifier.ResumeLayout(false);
            LLModifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLeftLights;
        private Panel LLModifier;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label LLColorPickerBLabel;
        private Label LLColorPickerGLabel;
        private Label LLColorPickerRLabel;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Panel LLColorPicked;
        private Label LLTitle;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem colorDialogToolStripMenuItem;
        private ToolStripMenuItem copyHTMLToolStripMenuItem;
        private ToolStripMenuItem copyRGBToolStripMenuItem;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private Panel panel2;
        private CheckBox checkBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar trackBar4;
        private TrackBar trackBar5;
        private TrackBar trackBar6;
        private Panel panel3;
        private Label label4;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem colorDialogToolStripMenuItem1;
        private ToolStripMenuItem copyHexadecimalToolStripMenuItem;
        private ToolStripMenuItem copyRGBToolStripMenuItem1;
    }
}