namespace Shutdown_Timer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            H1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            H1.Location = new Point(39, 22);
            H1.Name = "H1";
            H1.Size = new Size(164, 21);
            H1.TabIndex = 0;
            H1.Text = "Shutdown Timer";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(15, 15, 15);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(34, 97);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "2";
            textBox1.Size = new Size(175, 19);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(68, 132);
            button1.Name = "button1";
            button1.Size = new Size(104, 28);
            button1.TabIndex = 3;
            button1.Text = "Set Timer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(68, 166);
            button2.Name = "button2";
            button2.Size = new Size(104, 28);
            button2.TabIndex = 4;
            button2.Text = "Cancel Timer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 80);
            label1.Name = "label1";
            label1.Size = new Size(95, 12);
            label1.TabIndex = 2;
            label1.Text = "Zeit in Stunden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 6F);
            label2.Location = new Point(72, 242);
            label2.Name = "label2";
            label2.Size = new Size(96, 8);
            label2.TabIndex = 5;
            label2.Text = "Shutdown Timer by Lefty";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(68, 200);
            button3.Name = "button3";
            button3.Size = new Size(104, 28);
            button3.TabIndex = 6;
            button3.Text = "No Win Update";
            toolTip1.SetToolTip(button3, "Shutdown PC immediately without Windows Updates");
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = SystemColors.InactiveCaptionText;
            toolTip1.ForeColor = SystemColors.InactiveBorder;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Force Shutdown";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(249, 257);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(H1);
            Cursor = Cursors.Hand;
            Font = new Font("MS Gothic", 9F);
            ForeColor = SystemColors.InactiveBorder;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lefty Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label H1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
        private ToolTip toolTip1;
    }
}
