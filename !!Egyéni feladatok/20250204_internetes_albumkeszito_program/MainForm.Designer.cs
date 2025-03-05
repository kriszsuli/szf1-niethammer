using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace src
{
    partial class MainForm
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
            tabControl = new TabControl();
            kepekTab = new TabPage();
            splitContainer1 = new SplitContainer();
            selectedImgsLabel = new Label();
            pictureBox1 = new PictureBox();
            fileNameLabel = new Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            listView1 = new System.Windows.Forms.ListView();
            imageList1 = new ImageList(components);
            directoryLabel = new Label();
            button1 = new System.Windows.Forms.Button();
            leirasTab = new TabPage();
            splitContainer2 = new SplitContainer();
            webBrowser = new WebBrowser();
            monthCalendar1 = new MonthCalendar();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            label3 = new Label();
            writerTextBox = new System.Windows.Forms.TextBox();
            label2 = new Label();
            titleTextBox = new System.Windows.Forms.TextBox();
            label1 = new Label();
            photographerTextBox = new System.Windows.Forms.TextBox();
            konvertalasTab = new TabPage();
            splitContainer3 = new SplitContainer();
            richTextBox2 = new RichTextBox();
            convertButton = new System.Windows.Forms.Button();
            watermarkTextbox = new System.Windows.Forms.TextBox();
            label6 = new Label();
            label5 = new Label();
            thumbnailWidth = new NumericUpDown();
            largeImgWidth = new NumericUpDown();
            label4 = new Label();
            tabControl.SuspendLayout();
            kepekTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            leirasTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            konvertalasTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thumbnailWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)largeImgWidth).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(kepekTab);
            tabControl.Controls.Add(leirasTab);
            tabControl.Controls.Add(konvertalasTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(780, 430);
            tabControl.TabIndex = 0;
            // 
            // kepekTab
            // 
            kepekTab.Controls.Add(splitContainer1);
            kepekTab.Location = new Point(4, 24);
            kepekTab.Name = "kepekTab";
            kepekTab.Padding = new Padding(3);
            kepekTab.Size = new Size(772, 402);
            kepekTab.TabIndex = 0;
            kepekTab.Text = "Képek";
            kepekTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(selectedImgsLabel);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(fileNameLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(progressBar);
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Panel2.Controls.Add(directoryLabel);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(766, 396);
            splitContainer1.SplitterDistance = 398;
            splitContainer1.TabIndex = 0;
            // 
            // selectedImgsLabel
            // 
            selectedImgsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            selectedImgsLabel.AutoSize = true;
            selectedImgsLabel.Location = new Point(-4, 378);
            selectedImgsLabel.Name = "selectedImgsLabel";
            selectedImgsLabel.Size = new Size(125, 15);
            selectedImgsLabel.TabIndex = 2;
            selectedImgsLabel.Text = "Kijelölt képek száma: 0";
            selectedImgsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.Location = new Point(0, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // fileNameLabel
            // 
            fileNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fileNameLabel.AutoSize = true;
            fileNameLabel.FlatStyle = FlatStyle.Flat;
            fileNameLabel.Location = new Point(3, 10);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(0, 15);
            fileNameLabel.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(0, 373);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(364, 23);
            progressBar.TabIndex = 6;
            progressBar.Visible = false;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.CheckBoxes = true;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(0, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(364, 364);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemCheck += listView1_ItemCheck;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(100, 100);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // directoryLabel
            // 
            directoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            directoryLabel.AutoSize = true;
            directoryLabel.FlatStyle = FlatStyle.Flat;
            directoryLabel.Location = new Point(2, 10);
            directoryLabel.Name = "directoryLabel";
            directoryLabel.Size = new Size(0, 15);
            directoryLabel.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(244, 3);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(123, 28);
            button1.TabIndex = 2;
            button1.Text = "Mappa választása...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // leirasTab
            // 
            leirasTab.Controls.Add(splitContainer2);
            leirasTab.Location = new Point(4, 24);
            leirasTab.Name = "leirasTab";
            leirasTab.Padding = new Padding(3);
            leirasTab.Size = new Size(772, 402);
            leirasTab.TabIndex = 1;
            leirasTab.Text = "Leírás";
            leirasTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.White;
            splitContainer2.Panel1.Controls.Add(webBrowser);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(monthCalendar1);
            splitContainer2.Panel2.Controls.Add(richTextBox1);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(766, 396);
            splitContainer2.SplitterDistance = 205;
            splitContainer2.TabIndex = 0;
            // 
            // webBrowser
            // 
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Location = new Point(0, 0);
            webBrowser.Name = "webBrowser";
            webBrowser.Size = new Size(205, 396);
            webBrowser.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(1, 2);
            monthCalendar1.Dock = DockStyle.Right;
            monthCalendar1.Location = new Point(330, 0);
            monthCalendar1.MaximumSize = new Size(227, 162);
            monthCalendar1.MinimumSize = new Size(227, 162);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(3, 183);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(551, 210);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Leírás";
            richTextBox1.TextChanged += TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(writerTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(titleTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(photographerTextBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 396);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(7, 108);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Szöveget írta:";
            // 
            // writerTextBox
            // 
            writerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            writerTextBox.Location = new Point(90, 105);
            writerTextBox.Name = "writerTextBox";
            writerTextBox.Size = new Size(223, 23);
            writerTextBox.TabIndex = 4;
            writerTextBox.Text = "Szövegíró Péter";
            writerTextBox.TextChanged += TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(9, 79);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 6;
            label2.Text = "Fényképezte:";
            // 
            // titleTextBox
            // 
            titleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleTextBox.Location = new Point(90, 47);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(223, 23);
            titleTextBox.TabIndex = 2;
            titleTextBox.Text = "Cím";
            titleTextBox.TextChanged += TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(9, 50);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 5;
            label1.Text = "Album címe:";
            // 
            // photographerTextBox
            // 
            photographerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            photographerTextBox.Location = new Point(90, 76);
            photographerTextBox.Name = "photographerTextBox";
            photographerTextBox.Size = new Size(223, 23);
            photographerTextBox.TabIndex = 3;
            photographerTextBox.Text = "Fényképező János";
            photographerTextBox.TextChanged += TextChanged;
            // 
            // konvertalasTab
            // 
            konvertalasTab.Controls.Add(splitContainer3);
            konvertalasTab.Location = new Point(4, 24);
            konvertalasTab.Name = "konvertalasTab";
            konvertalasTab.Size = new Size(772, 402);
            konvertalasTab.TabIndex = 2;
            konvertalasTab.Text = "Konvertálás";
            konvertalasTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(richTextBox2);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(convertButton);
            splitContainer3.Panel2.Controls.Add(watermarkTextbox);
            splitContainer3.Panel2.Controls.Add(label6);
            splitContainer3.Panel2.Controls.Add(label5);
            splitContainer3.Panel2.Controls.Add(thumbnailWidth);
            splitContainer3.Panel2.Controls.Add(largeImgWidth);
            splitContainer3.Panel2.Controls.Add(label4);
            splitContainer3.Size = new Size(772, 402);
            splitContainer3.SplitterDistance = 572;
            splitContainer3.TabIndex = 0;
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(0, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox2.Size = new Size(572, 402);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // convertButton
            // 
            convertButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            convertButton.Location = new Point(12, 141);
            convertButton.MaximumSize = new Size(112, 45);
            convertButton.MinimumSize = new Size(112, 45);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(112, 45);
            convertButton.TabIndex = 6;
            convertButton.Text = "Konvertálás";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // watermarkTextbox
            // 
            watermarkTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            watermarkTextbox.Location = new Point(12, 112);
            watermarkTextbox.Name = "watermarkTextbox";
            watermarkTextbox.Size = new Size(112, 23);
            watermarkTextbox.TabIndex = 5;
            watermarkTextbox.Text = "pollak.hu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 94);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 4;
            label6.Text = "Vízjel:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(12, 50);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 3;
            label5.Text = "Kis képek mérete:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // thumbnailWidth
            // 
            thumbnailWidth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            thumbnailWidth.Location = new Point(12, 68);
            thumbnailWidth.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            thumbnailWidth.Name = "thumbnailWidth";
            thumbnailWidth.Size = new Size(55, 23);
            thumbnailWidth.TabIndex = 2;
            thumbnailWidth.Value = new decimal(new int[] { 256, 0, 0, 0 });
            // 
            // largeImgWidth
            // 
            largeImgWidth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            largeImgWidth.Location = new Point(12, 24);
            largeImgWidth.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            largeImgWidth.Name = "largeImgWidth";
            largeImgWidth.Size = new Size(55, 23);
            largeImgWidth.TabIndex = 1;
            largeImgWidth.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(12, 6);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 0;
            label4.Text = "Nagy képek mérete:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            Padding = new Padding(10);
            Text = "Internetes albumkészítő program     Chlebik Krisztofer (susu@liba.lol)";
            tabControl.ResumeLayout(false);
            kepekTab.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            leirasTab.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            konvertalasTab.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)thumbnailWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)largeImgWidth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage leirasTab;
        private TabPage konvertalasTab;
        private TabPage kepekTab;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label fileNameLabel;
        private System.Windows.Forms.Button button1;
        private Label directoryLabel;
        private Label selectedImgsLabel;
        private System.Windows.Forms.ListView listView1;
        private ImageList imageList1;
        private SplitContainer splitContainer2;
        private MonthCalendar monthCalendar1;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Label label3;
        private System.Windows.Forms.TextBox writerTextBox;
        private Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private Label label1;
        private System.Windows.Forms.TextBox photographerTextBox;
        private SplitContainer splitContainer3;
        private RichTextBox richTextBox2;
        private NumericUpDown largeImgWidth;
        private Label label4;
        private Label label5;
        private NumericUpDown thumbnailWidth;
        private System.Windows.Forms.TextBox watermarkTextbox;
        private Label label6;
        private System.Windows.Forms.Button convertButton;
        private WebBrowser webBrowser;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}