namespace Tutor_C_3_Buoi1
{
    partial class FormTutor1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutor1));
            label1 = new Label();
            tb_1 = new TextBox();
            button1 = new Button();
            cb_1 = new ComboBox();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            timer = new System.Windows.Forms.Timer(components);
            ptb_avt = new PictureBox();
            btn_avt = new Button();
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openNewFileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ptb_avt).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(181, 26);
            label1.Name = "label1";
            label1.Size = new Size(102, 50);
            label1.TabIndex = 0;
            label1.Text = "Bài 1";
            // 
            // tb_1
            // 
            tb_1.Location = new Point(36, 79);
            tb_1.Name = "tb_1";
            tb_1.Size = new Size(392, 23);
            tb_1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(36, 127);
            button1.Name = "button1";
            button1.Size = new Size(392, 52);
            button1.TabIndex = 2;
            button1.Text = "Nút bấm vui vui";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_1
            // 
            cb_1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_1.FormattingEnabled = true;
            cb_1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cb_1.Location = new Point(36, 204);
            cb_1.Name = "cb_1";
            cb_1.Size = new Size(392, 23);
            cb_1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(36, 245);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(171, 246);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(36, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // ptb_avt
            // 
            ptb_avt.Image = (Image)resources.GetObject("ptb_avt.Image");
            ptb_avt.Location = new Point(532, 79);
            ptb_avt.Name = "ptb_avt";
            ptb_avt.Size = new Size(187, 225);
            ptb_avt.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_avt.TabIndex = 7;
            ptb_avt.TabStop = false;
            // 
            // btn_avt
            // 
            btn_avt.Location = new Point(532, 321);
            btn_avt.Name = "btn_avt";
            btn_avt.Size = new Size(187, 23);
            btn_avt.TabIndex = 8;
            btn_avt.Text = "Đổi ảnh đại diện";
            btn_avt.UseVisualStyleBackColor = true;
            btn_avt.Click += btn_avt_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipShown += notifyIcon1_BalloonTipShown;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openNewFileToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openNewFileToolStripMenuItem
            // 
            openNewFileToolStripMenuItem.Name = "openNewFileToolStripMenuItem";
            openNewFileToolStripMenuItem.Size = new Size(180, 22);
            openNewFileToolStripMenuItem.Text = "Open new file";
            openNewFileToolStripMenuItem.Click += openNewFileToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // FormTutor1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_avt);
            Controls.Add(ptb_avt);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(cb_1);
            Controls.Add(button1);
            Controls.Add(tb_1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTutor1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormTutor1_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_avt).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_1;
        private Button button1;
        private ComboBox cb_1;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer;
        private PictureBox ptb_avt;
        private Button btn_avt;
        private NotifyIcon notifyIcon1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openNewFileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}