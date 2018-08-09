namespace Image_Editor
{
    partial class ImageEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditor));
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightnessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.RotateRightButton = new System.Windows.Forms.Button();
            this.RotateLeftButton = new System.Windows.Forms.Button();
            this.RotateHorizantalButton = new System.Windows.Forms.Button();
            this.RotateVerticalButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CropButton = new System.Windows.Forms.Button();
            this.GrayScaleButton = new System.Windows.Forms.Button();
            this.BlurButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.InvertButton = new System.Windows.Forms.Button();
            this.GammaButton = new System.Windows.Forms.Button();
            this.GammaTrackBar = new System.Windows.Forms.TrackBar();
            this.Contrast = new System.Windows.Forms.Button();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.GammaLabel = new System.Windows.Forms.Label();
            this.MirrorButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OriginalPicLabel = new System.Windows.Forms.Label();
            this.MirrorLabel = new System.Windows.Forms.Label();
            this.RedBlueGreen = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.RedEffectlabel = new System.Windows.Forms.Label();
            this.BlueEffectlabel = new System.Windows.Forms.Label();
            this.GreenEffectlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CreateTextButton = new System.Windows.Forms.Button();
            this.CropImageButton = new System.Windows.Forms.Button();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.TextButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.FontButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ZoomInButton = new System.Windows.Forms.Button();
            this.ZoomOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog1";
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BrightnessTrackBar.LargeChange = 100;
            this.BrightnessTrackBar.Location = new System.Drawing.Point(160, 97);
            this.BrightnessTrackBar.Maximum = 100;
            this.BrightnessTrackBar.Minimum = -100;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(173, 45);
            this.BrightnessTrackBar.SmallChange = 5;
            this.BrightnessTrackBar.TabIndex = 6;
            this.BrightnessTrackBar.TickFrequency = 5;
            this.BrightnessTrackBar.Visible = false;
            this.BrightnessTrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // BrightnessButton
            // 
            this.BrightnessButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.BrightnessButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrightnessButton.BackgroundImage")));
            this.BrightnessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrightnessButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrightnessButton.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightnessButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrightnessButton.Location = new System.Drawing.Point(11, 98);
            this.BrightnessButton.Name = "BrightnessButton";
            this.BrightnessButton.Size = new System.Drawing.Size(124, 45);
            this.BrightnessButton.TabIndex = 8;
            this.BrightnessButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrightnessButton.UseVisualStyleBackColor = false;
            this.BrightnessButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Browsebutton
            // 
            this.Browsebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Browsebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Browsebutton.BackgroundImage")));
            this.Browsebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Browsebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Browsebutton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebutton.Location = new System.Drawing.Point(11, 37);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(124, 45);
            this.Browsebutton.TabIndex = 11;
            this.Browsebutton.UseVisualStyleBackColor = false;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click_1);
            this.Browsebutton.MouseHover += new System.EventHandler(this.Browsebutton_MouseHover);
            this.Browsebutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Browsebutton_MouseMove);
            // 
            // RotateButton
            // 
            this.RotateButton.BackColor = System.Drawing.Color.Black;
            this.RotateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateButton.BackgroundImage")));
            this.RotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotateButton.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RotateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RotateButton.Location = new System.Drawing.Point(15, 274);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(96, 45);
            this.RotateButton.TabIndex = 12;
            this.RotateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RotateButton.UseVisualStyleBackColor = false;
            this.RotateButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // RotateRightButton
            // 
            this.RotateRightButton.BackColor = System.Drawing.Color.Black;
            this.RotateRightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateRightButton.BackgroundImage")));
            this.RotateRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RotateRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotateRightButton.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateRightButton.Location = new System.Drawing.Point(273, 278);
            this.RotateRightButton.Name = "RotateRightButton";
            this.RotateRightButton.Size = new System.Drawing.Size(132, 40);
            this.RotateRightButton.TabIndex = 13;
            this.RotateRightButton.UseVisualStyleBackColor = false;
            this.RotateRightButton.Visible = false;
            this.RotateRightButton.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // RotateLeftButton
            // 
            this.RotateLeftButton.BackColor = System.Drawing.Color.Black;
            this.RotateLeftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateLeftButton.BackgroundImage")));
            this.RotateLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RotateLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotateLeftButton.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateLeftButton.Location = new System.Drawing.Point(135, 278);
            this.RotateLeftButton.Name = "RotateLeftButton";
            this.RotateLeftButton.Size = new System.Drawing.Size(122, 41);
            this.RotateLeftButton.TabIndex = 14;
            this.RotateLeftButton.UseVisualStyleBackColor = false;
            this.RotateLeftButton.Visible = false;
            this.RotateLeftButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // RotateHorizantalButton
            // 
            this.RotateHorizantalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RotateHorizantalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateHorizantalButton.BackgroundImage")));
            this.RotateHorizantalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RotateHorizantalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotateHorizantalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateHorizantalButton.Location = new System.Drawing.Point(134, 334);
            this.RotateHorizantalButton.Name = "RotateHorizantalButton";
            this.RotateHorizantalButton.Size = new System.Drawing.Size(122, 35);
            this.RotateHorizantalButton.TabIndex = 15;
            this.RotateHorizantalButton.UseVisualStyleBackColor = false;
            this.RotateHorizantalButton.Visible = false;
            this.RotateHorizantalButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // RotateVerticalButton
            // 
            this.RotateVerticalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RotateVerticalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateVerticalButton.BackgroundImage")));
            this.RotateVerticalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RotateVerticalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotateVerticalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateVerticalButton.Location = new System.Drawing.Point(276, 334);
            this.RotateVerticalButton.Name = "RotateVerticalButton";
            this.RotateVerticalButton.Size = new System.Drawing.Size(119, 35);
            this.RotateVerticalButton.TabIndex = 16;
            this.RotateVerticalButton.UseVisualStyleBackColor = false;
            this.RotateVerticalButton.Visible = false;
            this.RotateVerticalButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Black;
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SaveButton.Location = new System.Drawing.Point(160, 37);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 45);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CropButton
            // 
            this.CropButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CropButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CropButton.BackgroundImage")));
            this.CropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CropButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CropButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CropButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CropButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CropButton.Location = new System.Drawing.Point(16, 386);
            this.CropButton.Name = "CropButton";
            this.CropButton.Size = new System.Drawing.Size(83, 40);
            this.CropButton.TabIndex = 18;
            this.CropButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CropButton.UseVisualStyleBackColor = false;
            this.CropButton.Click += new System.EventHandler(this.CropButton_Click);
            // 
            // GrayScaleButton
            // 
            this.GrayScaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GrayScaleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GrayScaleButton.BackgroundImage")));
            this.GrayScaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrayScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrayScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayScaleButton.Location = new System.Drawing.Point(132, 432);
            this.GrayScaleButton.Name = "GrayScaleButton";
            this.GrayScaleButton.Size = new System.Drawing.Size(107, 39);
            this.GrayScaleButton.TabIndex = 19;
            this.GrayScaleButton.UseVisualStyleBackColor = false;
            this.GrayScaleButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // BlurButton
            // 
            this.BlurButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BlurButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlurButton.BackgroundImage")));
            this.BlurButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlurButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurButton.Location = new System.Drawing.Point(11, 435);
            this.BlurButton.Name = "BlurButton";
            this.BlurButton.Size = new System.Drawing.Size(94, 36);
            this.BlurButton.TabIndex = 20;
            this.BlurButton.UseVisualStyleBackColor = false;
            this.BlurButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(826, 598);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.PictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseHover += new System.EventHandler(this.PictureBox1_MouseHover);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove_1);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(288, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // InvertButton
            // 
            this.InvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InvertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InvertButton.BackgroundImage")));
            this.InvertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvertButton.Location = new System.Drawing.Point(276, 435);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(102, 36);
            this.InvertButton.TabIndex = 27;
            this.InvertButton.UseVisualStyleBackColor = false;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // GammaButton
            // 
            this.GammaButton.BackColor = System.Drawing.Color.Black;
            this.GammaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GammaButton.BackgroundImage")));
            this.GammaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GammaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GammaButton.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GammaButton.Location = new System.Drawing.Point(13, 159);
            this.GammaButton.Name = "GammaButton";
            this.GammaButton.Size = new System.Drawing.Size(124, 45);
            this.GammaButton.TabIndex = 29;
            this.GammaButton.UseVisualStyleBackColor = false;
            this.GammaButton.Click += new System.EventHandler(this.GammaButton_Click);
            // 
            // GammaTrackBar
            // 
            this.GammaTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GammaTrackBar.Location = new System.Drawing.Point(160, 157);
            this.GammaTrackBar.Maximum = 100;
            this.GammaTrackBar.Minimum = 1;
            this.GammaTrackBar.Name = "GammaTrackBar";
            this.GammaTrackBar.Size = new System.Drawing.Size(173, 45);
            this.GammaTrackBar.TabIndex = 6;
            this.GammaTrackBar.TickFrequency = 5;
            this.GammaTrackBar.Value = 1;
            this.GammaTrackBar.Visible = false;
            this.GammaTrackBar.Scroll += new System.EventHandler(this.GammaTrackBar_Scroll);
            // 
            // Contrast
            // 
            this.Contrast.BackColor = System.Drawing.SystemColors.ControlText;
            this.Contrast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Contrast.BackgroundImage")));
            this.Contrast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Contrast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Contrast.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrast.Location = new System.Drawing.Point(12, 220);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(124, 45);
            this.Contrast.TabIndex = 32;
            this.Contrast.UseVisualStyleBackColor = false;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ContrastTrackBar.Location = new System.Drawing.Point(160, 219);
            this.ContrastTrackBar.Maximum = 100;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(173, 45);
            this.ContrastTrackBar.SmallChange = 5;
            this.ContrastTrackBar.TabIndex = 6;
            this.ContrastTrackBar.TickFrequency = 5;
            this.ContrastTrackBar.Visible = false;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.BackColor = System.Drawing.Color.Lime;
            this.ContrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastLabel.Location = new System.Drawing.Point(339, 230);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(16, 16);
            this.ContrastLabel.TabIndex = 33;
            this.ContrastLabel.Text = "0";
            this.ContrastLabel.Visible = false;
            this.ContrastLabel.Click += new System.EventHandler(this.ContrastLabel_Click);
            // 
            // GammaLabel
            // 
            this.GammaLabel.AutoSize = true;
            this.GammaLabel.BackColor = System.Drawing.Color.Lime;
            this.GammaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GammaLabel.Location = new System.Drawing.Point(339, 172);
            this.GammaLabel.Name = "GammaLabel";
            this.GammaLabel.Size = new System.Drawing.Size(16, 16);
            this.GammaLabel.TabIndex = 35;
            this.GammaLabel.Text = "0";
            this.GammaLabel.Visible = false;
            // 
            // MirrorButton
            // 
            this.MirrorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MirrorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MirrorButton.BackgroundImage")));
            this.MirrorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MirrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MirrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MirrorButton.Location = new System.Drawing.Point(15, 538);
            this.MirrorButton.Name = "MirrorButton";
            this.MirrorButton.Size = new System.Drawing.Size(104, 35);
            this.MirrorButton.TabIndex = 36;
            this.MirrorButton.UseVisualStyleBackColor = false;
            this.MirrorButton.Click += new System.EventHandler(this.MirrorButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(421, 377);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // OriginalPicLabel
            // 
            this.OriginalPicLabel.AutoSize = true;
            this.OriginalPicLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OriginalPicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPicLabel.Location = new System.Drawing.Point(435, 28);
            this.OriginalPicLabel.Name = "OriginalPicLabel";
            this.OriginalPicLabel.Size = new System.Drawing.Size(114, 16);
            this.OriginalPicLabel.TabIndex = 38;
            this.OriginalPicLabel.Text = "Original Picture";
            this.OriginalPicLabel.Visible = false;
            // 
            // MirrorLabel
            // 
            this.MirrorLabel.AutoSize = true;
            this.MirrorLabel.BackColor = System.Drawing.Color.White;
            this.MirrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MirrorLabel.Location = new System.Drawing.Point(435, 358);
            this.MirrorLabel.Name = "MirrorLabel";
            this.MirrorLabel.Size = new System.Drawing.Size(100, 16);
            this.MirrorLabel.TabIndex = 39;
            this.MirrorLabel.Text = "Mirror Picture";
            this.MirrorLabel.Visible = false;
            this.MirrorLabel.Click += new System.EventHandler(this.MirrorLabel_Click);
            // 
            // RedBlueGreen
            // 
            this.RedBlueGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RedBlueGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RedBlueGreen.BackgroundImage")));
            this.RedBlueGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedBlueGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedBlueGreen.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedBlueGreen.Location = new System.Drawing.Point(12, 485);
            this.RedBlueGreen.Name = "RedBlueGreen";
            this.RedBlueGreen.Size = new System.Drawing.Size(109, 41);
            this.RedBlueGreen.TabIndex = 40;
            this.RedBlueGreen.UseVisualStyleBackColor = false;
            this.RedBlueGreen.Click += new System.EventHandler(this.RedBlueGreen_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RedButton.BackgroundImage")));
            this.RedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedButton.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedButton.Location = new System.Drawing.Point(144, 487);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(69, 35);
            this.RedButton.TabIndex = 41;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Visible = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BlueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlueButton.BackgroundImage")));
            this.BlueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlueButton.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueButton.Location = new System.Drawing.Point(233, 487);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(70, 35);
            this.BlueButton.TabIndex = 42;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Visible = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GreenButton.BackgroundImage")));
            this.GreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GreenButton.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenButton.Location = new System.Drawing.Point(320, 487);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(75, 35);
            this.GreenButton.TabIndex = 43;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Visible = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // RedEffectlabel
            // 
            this.RedEffectlabel.AutoSize = true;
            this.RedEffectlabel.BackColor = System.Drawing.Color.White;
            this.RedEffectlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedEffectlabel.Location = new System.Drawing.Point(435, 358);
            this.RedEffectlabel.Name = "RedEffectlabel";
            this.RedEffectlabel.Size = new System.Drawing.Size(80, 16);
            this.RedEffectlabel.TabIndex = 44;
            this.RedEffectlabel.Text = "Red Effect";
            this.RedEffectlabel.Visible = false;
            // 
            // BlueEffectlabel
            // 
            this.BlueEffectlabel.AutoSize = true;
            this.BlueEffectlabel.BackColor = System.Drawing.Color.White;
            this.BlueEffectlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueEffectlabel.Location = new System.Drawing.Point(435, 358);
            this.BlueEffectlabel.Name = "BlueEffectlabel";
            this.BlueEffectlabel.Size = new System.Drawing.Size(82, 16);
            this.BlueEffectlabel.TabIndex = 45;
            this.BlueEffectlabel.Text = "Blue Effect";
            this.BlueEffectlabel.Visible = false;
            // 
            // GreenEffectlabel
            // 
            this.GreenEffectlabel.AutoSize = true;
            this.GreenEffectlabel.BackColor = System.Drawing.Color.White;
            this.GreenEffectlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenEffectlabel.Location = new System.Drawing.Point(435, 356);
            this.GreenEffectlabel.Name = "GreenEffectlabel";
            this.GreenEffectlabel.Size = new System.Drawing.Size(93, 16);
            this.GreenEffectlabel.TabIndex = 46;
            this.GreenEffectlabel.Text = "Green Effect";
            this.GreenEffectlabel.Visible = false;
            this.GreenEffectlabel.Click += new System.EventHandler(this.GreenEffectlabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(421, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 598);
            this.panel1.TabIndex = 48;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Size = new System.Drawing.Size(856, 598);
            this.splitContainer1.SplitterDistance = 821;
            this.splitContainer1.TabIndex = 0;
            // 
            // CreateTextButton
            // 
            this.CreateTextButton.Location = new System.Drawing.Point(7, 19);
            this.CreateTextButton.Name = "CreateTextButton";
            this.CreateTextButton.Size = new System.Drawing.Size(96, 29);
            this.CreateTextButton.TabIndex = 0;
            this.CreateTextButton.Text = "CreateText";
            this.CreateTextButton.UseVisualStyleBackColor = true;
            this.CreateTextButton.Click += new System.EventHandler(this.CreateTextButton_Click);
            // 
            // CropImageButton
            // 
            this.CropImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CropImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CropImageButton.BackgroundImage")));
            this.CropImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CropImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CropImageButton.Location = new System.Drawing.Point(273, 388);
            this.CropImageButton.Name = "CropImageButton";
            this.CropImageButton.Size = new System.Drawing.Size(95, 35);
            this.CropImageButton.TabIndex = 24;
            this.CropImageButton.UseVisualStyleBackColor = false;
            this.CropImageButton.Visible = false;
            this.CropImageButton.Click += new System.EventHandler(this.CropImageButton_Click);
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectImageButton.BackgroundImage")));
            this.SelectImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectImageButton.Location = new System.Drawing.Point(132, 387);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(112, 35);
            this.SelectImageButton.TabIndex = 23;
            this.SelectImageButton.UseVisualStyleBackColor = false;
            this.SelectImageButton.Visible = false;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextButton.BackgroundImage")));
            this.TextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextButton.Location = new System.Drawing.Point(300, 589);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(98, 39);
            this.TextButton.TabIndex = 49;
            this.TextButton.UseVisualStyleBackColor = false;
            this.TextButton.Visible = false;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(108, 595);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 50;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FontButton
            // 
            this.FontButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FontButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FontButton.BackgroundImage")));
            this.FontButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FontButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontButton.Location = new System.Drawing.Point(7, 634);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(111, 43);
            this.FontButton.TabIndex = 51;
            this.FontButton.UseVisualStyleBackColor = false;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Write Text : ";
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZoomInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZoomInButton.BackgroundImage")));
            this.ZoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZoomInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomInButton.Location = new System.Drawing.Point(156, 538);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(100, 37);
            this.ZoomInButton.TabIndex = 53;
            this.ZoomInButton.UseVisualStyleBackColor = false;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZoomOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZoomOutButton.BackgroundImage")));
            this.ZoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZoomOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZoomOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomOutButton.Location = new System.Drawing.Point(283, 538);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(95, 35);
            this.ZoomOutButton.TabIndex = 54;
            this.ZoomOutButton.UseVisualStyleBackColor = false;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click_1);
            // 
            // ImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 736);
            this.Controls.Add(this.ZoomOutButton);
            this.Controls.Add(this.ZoomInButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.CropImageButton);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GreenEffectlabel);
            this.Controls.Add(this.BlueEffectlabel);
            this.Controls.Add(this.RedEffectlabel);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.RedBlueGreen);
            this.Controls.Add(this.MirrorLabel);
            this.Controls.Add(this.OriginalPicLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MirrorButton);
            this.Controls.Add(this.GammaLabel);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.ContrastTrackBar);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.GammaTrackBar);
            this.Controls.Add(this.GammaButton);
            this.Controls.Add(this.InvertButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BlurButton);
            this.Controls.Add(this.GrayScaleButton);
            this.Controls.Add(this.CropButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RotateVerticalButton);
            this.Controls.Add(this.RotateHorizantalButton);
            this.Controls.Add(this.RotateLeftButton);
            this.Controls.Add(this.RotateRightButton);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.Browsebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrightnessButton);
            this.Controls.Add(this.BrightnessTrackBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1300, 736);
            this.Name = "ImageEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Photo Sharp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.ImageEditor_Click);
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button RotateRightButton;
        private System.Windows.Forms.Button RotateLeftButton;
        private System.Windows.Forms.Button RotateHorizantalButton;
        private System.Windows.Forms.Button RotateVerticalButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CropButton;
        private System.Windows.Forms.Button GrayScaleButton;
        private System.Windows.Forms.Button BlurButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.Button GammaButton;
        private System.Windows.Forms.TrackBar GammaTrackBar;
        private System.Windows.Forms.Button Contrast;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label GammaLabel;
        private System.Windows.Forms.Button MirrorButton;
        public System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label OriginalPicLabel;
        private System.Windows.Forms.Label MirrorLabel;
        private System.Windows.Forms.Button RedBlueGreen;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Label RedEffectlabel;
        private System.Windows.Forms.Label BlueEffectlabel;
        private System.Windows.Forms.Label GreenEffectlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CreateTextButton;
        private System.Windows.Forms.Button CropImageButton;
        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ZoomInButton;
        private System.Windows.Forms.Button ZoomOutButton;
        private System.Windows.Forms.Button BrightnessButton;
        public System.Windows.Forms.Button SelectImageButton;
    }
}

