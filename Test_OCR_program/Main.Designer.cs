
namespace Test_OCR_program
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_min_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_min_word_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_min_word_high_auto = new System.Windows.Forms.CheckBox();
            this.cb_max_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_max_word_width_auto = new System.Windows.Forms.CheckBox();
            this.CB_OCR_type = new System.Windows.Forms.ComboBox();
            this.cb_max_word_high_auto = new System.Windows.Forms.CheckBox();
            this.Tb_min_word_high = new System.Windows.Forms.MaskedTextBox();
            this.Tb_min_width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_min_word_width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_max_word_high = new System.Windows.Forms.MaskedTextBox();
            this.Tb_max_width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_max_word_width = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_build_OCR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HSWC = new HalconDotNet.HSmartWindowControl();
            this.lbl_Comparison_Words = new System.Windows.Forms.Label();
            this.txt_Comparison_Words = new System.Windows.Forms.TextBox();
            this.gBx_Result = new System.Windows.Forms.GroupBox();
            this.lbl_plan_B_Yield = new System.Windows.Forms.Label();
            this.lbl_plan_B_NG = new System.Windows.Forms.Label();
            this.lbl_plan_B_OK = new System.Windows.Forms.Label();
            this.lbl_plan_A_Yield = new System.Windows.Forms.Label();
            this.lbl_plan_A_NG = new System.Windows.Forms.Label();
            this.lbl_plan_A_OK = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_program2 = new System.Windows.Forms.Label();
            this.lbl_program1 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Trigger = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.bgW_Run = new System.ComponentModel.BackgroundWorker();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gBx_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFile.Location = new System.Drawing.Point(12, 3);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(92, 40);
            this.btn_LoadFile.TabIndex = 0;
            this.btn_LoadFile.Text = "Load";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // txt_file_path
            // 
            this.txt_file_path.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file_path.Location = new System.Drawing.Point(112, 9);
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.Size = new System.Drawing.Size(354, 34);
            this.txt_file_path.TabIndex = 1;
            this.txt_file_path.Text = "C:\\Users\\LouisDing\\Desktop\\Work\\TSMC\\20220629_修改過的訓練檔 _字母B\\L4V1B8.L6_2228\\Station" +
    "A\\Lot6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cb_min_width_auto);
            this.groupBox1.Controls.Add(this.cb_min_word_width_auto);
            this.groupBox1.Controls.Add(this.cb_min_word_high_auto);
            this.groupBox1.Controls.Add(this.cb_max_width_auto);
            this.groupBox1.Controls.Add(this.cb_max_word_width_auto);
            this.groupBox1.Controls.Add(this.CB_OCR_type);
            this.groupBox1.Controls.Add(this.cb_max_word_high_auto);
            this.groupBox1.Controls.Add(this.Tb_min_word_high);
            this.groupBox1.Controls.Add(this.Tb_min_width);
            this.groupBox1.Controls.Add(this.Tb_min_word_width);
            this.groupBox1.Controls.Add(this.Tb_max_word_high);
            this.groupBox1.Controls.Add(this.Tb_max_width);
            this.groupBox1.Controls.Add(this.Tb_max_word_width);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_build_OCR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(464, 159);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OCR設定";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(276, 126);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 15);
            this.label26.TabIndex = 55;
            this.label26.Text = "Min";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(276, 96);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 15);
            this.label25.TabIndex = 54;
            this.label25.Text = "Min";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(276, 64);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 15);
            this.label24.TabIndex = 53;
            this.label24.Text = "Min";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(139, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 50;
            this.label17.Text = "字元擋 : ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(92, 126);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 15);
            this.label23.TabIndex = 52;
            this.label23.Text = "Max";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(92, 96);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 15);
            this.label22.TabIndex = 51;
            this.label22.Text = "Max";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(92, 64);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 15);
            this.label21.TabIndex = 50;
            this.label21.Text = "Max";
            // 
            // cb_min_width_auto
            // 
            this.cb_min_width_auto.AutoSize = true;
            this.cb_min_width_auto.Checked = true;
            this.cb_min_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_min_width_auto.Location = new System.Drawing.Point(383, 125);
            this.cb_min_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_min_width_auto.Name = "cb_min_width_auto";
            this.cb_min_width_auto.Size = new System.Drawing.Size(57, 19);
            this.cb_min_width_auto.TabIndex = 49;
            this.cb_min_width_auto.Text = "Auto";
            this.cb_min_width_auto.UseVisualStyleBackColor = true;
            this.cb_min_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // cb_min_word_width_auto
            // 
            this.cb_min_word_width_auto.AutoSize = true;
            this.cb_min_word_width_auto.Checked = true;
            this.cb_min_word_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_min_word_width_auto.Location = new System.Drawing.Point(383, 94);
            this.cb_min_word_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_min_word_width_auto.Name = "cb_min_word_width_auto";
            this.cb_min_word_width_auto.Size = new System.Drawing.Size(57, 19);
            this.cb_min_word_width_auto.TabIndex = 48;
            this.cb_min_word_width_auto.Text = "Auto";
            this.cb_min_word_width_auto.UseVisualStyleBackColor = true;
            this.cb_min_word_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // cb_min_word_high_auto
            // 
            this.cb_min_word_high_auto.AutoSize = true;
            this.cb_min_word_high_auto.Checked = true;
            this.cb_min_word_high_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_min_word_high_auto.Location = new System.Drawing.Point(383, 61);
            this.cb_min_word_high_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_min_word_high_auto.Name = "cb_min_word_high_auto";
            this.cb_min_word_high_auto.Size = new System.Drawing.Size(57, 19);
            this.cb_min_word_high_auto.TabIndex = 47;
            this.cb_min_word_high_auto.Text = "Auto";
            this.cb_min_word_high_auto.UseVisualStyleBackColor = true;
            this.cb_min_word_high_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // cb_max_width_auto
            // 
            this.cb_max_width_auto.AutoSize = true;
            this.cb_max_width_auto.Checked = true;
            this.cb_max_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_max_width_auto.Location = new System.Drawing.Point(199, 125);
            this.cb_max_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_max_width_auto.Name = "cb_max_width_auto";
            this.cb_max_width_auto.Size = new System.Drawing.Size(57, 19);
            this.cb_max_width_auto.TabIndex = 46;
            this.cb_max_width_auto.Text = "Auto";
            this.cb_max_width_auto.UseVisualStyleBackColor = true;
            this.cb_max_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // cb_max_word_width_auto
            // 
            this.cb_max_word_width_auto.AutoSize = true;
            this.cb_max_word_width_auto.Checked = true;
            this.cb_max_word_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_max_word_width_auto.Location = new System.Drawing.Point(199, 94);
            this.cb_max_word_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_max_word_width_auto.Name = "cb_max_word_width_auto";
            this.cb_max_word_width_auto.Size = new System.Drawing.Size(57, 19);
            this.cb_max_word_width_auto.TabIndex = 45;
            this.cb_max_word_width_auto.Text = "Auto";
            this.cb_max_word_width_auto.UseVisualStyleBackColor = true;
            this.cb_max_word_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // CB_OCR_type
            // 
            this.CB_OCR_type.FormattingEnabled = true;
            this.CB_OCR_type.Items.AddRange(new object[] {
            "Universal_0-9A-Z_NoRej.occ",
            "Industrial_0-9A-Z_NoRej.omc",
            "SFCompactText-RegularG2_0-9A-Z.omc"});
            this.CB_OCR_type.Location = new System.Drawing.Point(227, 28);
            this.CB_OCR_type.Margin = new System.Windows.Forms.Padding(4);
            this.CB_OCR_type.Name = "CB_OCR_type";
            this.CB_OCR_type.Size = new System.Drawing.Size(228, 23);
            this.CB_OCR_type.TabIndex = 35;
            // 
            // cb_max_word_high_auto
            // 
            this.cb_max_word_high_auto.AutoSize = true;
            this.cb_max_word_high_auto.Checked = true;
            this.cb_max_word_high_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_max_word_high_auto.Location = new System.Drawing.Point(199, 61);
            this.cb_max_word_high_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_max_word_high_auto.Name = "cb_max_word_high_auto";
            this.cb_max_word_high_auto.Size = new System.Drawing.Size(57, 19);
            this.cb_max_word_high_auto.TabIndex = 44;
            this.cb_max_word_high_auto.Text = "Auto";
            this.cb_max_word_high_auto.UseVisualStyleBackColor = true;
            this.cb_max_word_high_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // Tb_min_word_high
            // 
            this.Tb_min_word_high.Enabled = false;
            this.Tb_min_word_high.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_min_word_high.Location = new System.Drawing.Point(325, 58);
            this.Tb_min_word_high.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_min_word_high.Mask = "999";
            this.Tb_min_word_high.Name = "Tb_min_word_high";
            this.Tb_min_word_high.PromptChar = ' ';
            this.Tb_min_word_high.Size = new System.Drawing.Size(48, 25);
            this.Tb_min_word_high.TabIndex = 17;
            this.Tb_min_word_high.Text = "0";
            // 
            // Tb_min_width
            // 
            this.Tb_min_width.Enabled = false;
            this.Tb_min_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_min_width.Location = new System.Drawing.Point(325, 121);
            this.Tb_min_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_min_width.Mask = "999";
            this.Tb_min_width.Name = "Tb_min_width";
            this.Tb_min_width.PromptChar = ' ';
            this.Tb_min_width.Size = new System.Drawing.Size(48, 25);
            this.Tb_min_width.TabIndex = 18;
            this.Tb_min_width.Text = "0";
            // 
            // Tb_min_word_width
            // 
            this.Tb_min_word_width.Enabled = false;
            this.Tb_min_word_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_min_word_width.Location = new System.Drawing.Point(325, 90);
            this.Tb_min_word_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_min_word_width.Mask = "999";
            this.Tb_min_word_width.Name = "Tb_min_word_width";
            this.Tb_min_word_width.PromptChar = ' ';
            this.Tb_min_word_width.Size = new System.Drawing.Size(48, 25);
            this.Tb_min_word_width.TabIndex = 16;
            this.Tb_min_word_width.Text = "0";
            // 
            // Tb_max_word_high
            // 
            this.Tb_max_word_high.Enabled = false;
            this.Tb_max_word_high.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_max_word_high.Location = new System.Drawing.Point(140, 58);
            this.Tb_max_word_high.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_max_word_high.Mask = "999";
            this.Tb_max_word_high.Name = "Tb_max_word_high";
            this.Tb_max_word_high.PromptChar = ' ';
            this.Tb_max_word_high.Size = new System.Drawing.Size(48, 25);
            this.Tb_max_word_high.TabIndex = 14;
            this.Tb_max_word_high.Text = "0";
            // 
            // Tb_max_width
            // 
            this.Tb_max_width.Enabled = false;
            this.Tb_max_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_max_width.Location = new System.Drawing.Point(140, 121);
            this.Tb_max_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_max_width.Mask = "999";
            this.Tb_max_width.Name = "Tb_max_width";
            this.Tb_max_width.PromptChar = ' ';
            this.Tb_max_width.Size = new System.Drawing.Size(48, 25);
            this.Tb_max_width.TabIndex = 15;
            this.Tb_max_width.Text = "0";
            // 
            // Tb_max_word_width
            // 
            this.Tb_max_word_width.Enabled = false;
            this.Tb_max_word_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_max_word_width.Location = new System.Drawing.Point(140, 90);
            this.Tb_max_word_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_max_word_width.Mask = "999";
            this.Tb_max_word_width.Name = "Tb_max_word_width";
            this.Tb_max_word_width.PromptChar = ' ';
            this.Tb_max_word_width.Size = new System.Drawing.Size(48, 25);
            this.Tb_max_word_width.TabIndex = 13;
            this.Tb_max_word_width.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "字高 ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "筆畫寬度：";
            // 
            // Btn_build_OCR
            // 
            this.Btn_build_OCR.Location = new System.Drawing.Point(8, 26);
            this.Btn_build_OCR.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_build_OCR.Name = "Btn_build_OCR";
            this.Btn_build_OCR.Size = new System.Drawing.Size(100, 29);
            this.Btn_build_OCR.TabIndex = 25;
            this.Btn_build_OCR.Text = "建立OCR";
            this.Btn_build_OCR.UseVisualStyleBackColor = true;
            this.Btn_build_OCR.Click += new System.EventHandler(this.btn_Create_OCR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "字寬：　";
            // 
            // HSWC
            // 
            this.HSWC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HSWC.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.HSWC.HDoubleClickToFitContent = true;
            this.HSWC.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.HSWC.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.HSWC.HKeepAspectRatio = true;
            this.HSWC.HMoveContent = true;
            this.HSWC.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.HSWC.Location = new System.Drawing.Point(486, 59);
            this.HSWC.Margin = new System.Windows.Forms.Padding(0);
            this.HSWC.Name = "HSWC";
            this.HSWC.Size = new System.Drawing.Size(512, 159);
            this.HSWC.TabIndex = 29;
            this.HSWC.WindowSize = new System.Drawing.Size(512, 159);
            // 
            // lbl_Comparison_Words
            // 
            this.lbl_Comparison_Words.AutoSize = true;
            this.lbl_Comparison_Words.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comparison_Words.Location = new System.Drawing.Point(19, 230);
            this.lbl_Comparison_Words.Name = "lbl_Comparison_Words";
            this.lbl_Comparison_Words.Size = new System.Drawing.Size(108, 27);
            this.lbl_Comparison_Words.TabIndex = 30;
            this.lbl_Comparison_Words.Text = "比對字元";
            // 
            // txt_Comparison_Words
            // 
            this.txt_Comparison_Words.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comparison_Words.Location = new System.Drawing.Point(133, 225);
            this.txt_Comparison_Words.Name = "txt_Comparison_Words";
            this.txt_Comparison_Words.Size = new System.Drawing.Size(253, 34);
            this.txt_Comparison_Words.TabIndex = 31;
            this.txt_Comparison_Words.Text = "L4V1B8.L6";
            // 
            // gBx_Result
            // 
            this.gBx_Result.Controls.Add(this.lbl_plan_B_Yield);
            this.gBx_Result.Controls.Add(this.lbl_plan_B_NG);
            this.gBx_Result.Controls.Add(this.lbl_plan_B_OK);
            this.gBx_Result.Controls.Add(this.lbl_plan_A_Yield);
            this.gBx_Result.Controls.Add(this.lbl_plan_A_NG);
            this.gBx_Result.Controls.Add(this.lbl_plan_A_OK);
            this.gBx_Result.Controls.Add(this.label7);
            this.gBx_Result.Controls.Add(this.label8);
            this.gBx_Result.Controls.Add(this.label9);
            this.gBx_Result.Controls.Add(this.label6);
            this.gBx_Result.Controls.Add(this.label5);
            this.gBx_Result.Controls.Add(this.label4);
            this.gBx_Result.Controls.Add(this.lbl_program2);
            this.gBx_Result.Controls.Add(this.lbl_program1);
            this.gBx_Result.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBx_Result.Location = new System.Drawing.Point(21, 275);
            this.gBx_Result.Name = "gBx_Result";
            this.gBx_Result.Size = new System.Drawing.Size(665, 294);
            this.gBx_Result.TabIndex = 32;
            this.gBx_Result.TabStop = false;
            this.gBx_Result.Text = "比對結果 :";
            // 
            // lbl_plan_B_Yield
            // 
            this.lbl_plan_B_Yield.AutoSize = true;
            this.lbl_plan_B_Yield.Location = new System.Drawing.Point(472, 219);
            this.lbl_plan_B_Yield.Name = "lbl_plan_B_Yield";
            this.lbl_plan_B_Yield.Size = new System.Drawing.Size(24, 29);
            this.lbl_plan_B_Yield.TabIndex = 13;
            this.lbl_plan_B_Yield.Text = "0";
            // 
            // lbl_plan_B_NG
            // 
            this.lbl_plan_B_NG.AutoSize = true;
            this.lbl_plan_B_NG.Location = new System.Drawing.Point(286, 219);
            this.lbl_plan_B_NG.Name = "lbl_plan_B_NG";
            this.lbl_plan_B_NG.Size = new System.Drawing.Size(24, 29);
            this.lbl_plan_B_NG.TabIndex = 12;
            this.lbl_plan_B_NG.Text = "0";
            // 
            // lbl_plan_B_OK
            // 
            this.lbl_plan_B_OK.AutoSize = true;
            this.lbl_plan_B_OK.Location = new System.Drawing.Point(124, 219);
            this.lbl_plan_B_OK.Name = "lbl_plan_B_OK";
            this.lbl_plan_B_OK.Size = new System.Drawing.Size(24, 29);
            this.lbl_plan_B_OK.TabIndex = 11;
            this.lbl_plan_B_OK.Text = "0";
            // 
            // lbl_plan_A_Yield
            // 
            this.lbl_plan_A_Yield.AutoSize = true;
            this.lbl_plan_A_Yield.Location = new System.Drawing.Point(472, 100);
            this.lbl_plan_A_Yield.Name = "lbl_plan_A_Yield";
            this.lbl_plan_A_Yield.Size = new System.Drawing.Size(24, 29);
            this.lbl_plan_A_Yield.TabIndex = 10;
            this.lbl_plan_A_Yield.Text = "0";
            // 
            // lbl_plan_A_NG
            // 
            this.lbl_plan_A_NG.AutoSize = true;
            this.lbl_plan_A_NG.Location = new System.Drawing.Point(286, 100);
            this.lbl_plan_A_NG.Name = "lbl_plan_A_NG";
            this.lbl_plan_A_NG.Size = new System.Drawing.Size(24, 29);
            this.lbl_plan_A_NG.TabIndex = 9;
            this.lbl_plan_A_NG.Text = "0";
            // 
            // lbl_plan_A_OK
            // 
            this.lbl_plan_A_OK.AutoSize = true;
            this.lbl_plan_A_OK.Location = new System.Drawing.Point(124, 100);
            this.lbl_plan_A_OK.Name = "lbl_plan_A_OK";
            this.lbl_plan_A_OK.Size = new System.Drawing.Size(24, 29);
            this.lbl_plan_A_OK.TabIndex = 8;
            this.lbl_plan_A_OK.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ratio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "NG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "OK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ratio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "NG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "OK";
            // 
            // lbl_program2
            // 
            this.lbl_program2.AutoSize = true;
            this.lbl_program2.Location = new System.Drawing.Point(15, 155);
            this.lbl_program2.Name = "lbl_program2";
            this.lbl_program2.Size = new System.Drawing.Size(401, 29);
            this.lbl_program2.TabIndex = 1;
            this.lbl_program2.Text = "方案二 (第5個字元不出現8_指定位置)";
            // 
            // lbl_program1
            // 
            this.lbl_program1.AutoSize = true;
            this.lbl_program1.Location = new System.Drawing.Point(15, 46);
            this.lbl_program1.Name = "lbl_program1";
            this.lbl_program1.Size = new System.Drawing.Size(224, 29);
            this.lbl_program1.TabIndex = 0;
            this.lbl_program1.Text = "方案一 (不指定位置)";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(484, 6);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(125, 40);
            this.btn_Connect.TabIndex = 33;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Trigger
            // 
            this.btn_Trigger.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trigger.Location = new System.Drawing.Point(703, 6);
            this.btn_Trigger.Name = "btn_Trigger";
            this.btn_Trigger.Size = new System.Drawing.Size(81, 40);
            this.btn_Trigger.TabIndex = 34;
            this.btn_Trigger.Text = "Trig";
            this.btn_Trigger.UseVisualStyleBackColor = true;
            this.btn_Trigger.Click += new System.EventHandler(this.btn_Trigger_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(616, 6);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(81, 40);
            this.btn_Run.TabIndex = 35;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // bgW_Run
            // 
            this.bgW_Run.WorkerReportsProgress = true;
            this.bgW_Run.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_Run_DoWork);
            this.bgW_Run.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgW_Run_ProgressChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(790, 6);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(81, 40);
            this.btn_Reset.TabIndex = 36;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 614);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Trigger);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.gBx_Result);
            this.Controls.Add(this.txt_Comparison_Words);
            this.Controls.Add(this.lbl_Comparison_Words);
            this.Controls.Add(this.HSWC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_file_path);
            this.Controls.Add(this.btn_LoadFile);
            this.Name = "Main";
            this.Text = "Main";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBx_Result.ResumeLayout(false);
            this.gBx_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cb_min_width_auto;
        private System.Windows.Forms.CheckBox cb_min_word_width_auto;
        private System.Windows.Forms.CheckBox cb_min_word_high_auto;
        private System.Windows.Forms.CheckBox cb_max_width_auto;
        private System.Windows.Forms.CheckBox cb_max_word_width_auto;
        private System.Windows.Forms.ComboBox CB_OCR_type;
        private System.Windows.Forms.CheckBox cb_max_word_high_auto;
        private System.Windows.Forms.MaskedTextBox Tb_min_word_high;
        private System.Windows.Forms.MaskedTextBox Tb_min_width;
        private System.Windows.Forms.MaskedTextBox Tb_min_word_width;
        private System.Windows.Forms.MaskedTextBox Tb_max_word_high;
        private System.Windows.Forms.MaskedTextBox Tb_max_width;
        private System.Windows.Forms.MaskedTextBox Tb_max_word_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_build_OCR;
        private System.Windows.Forms.Label label2;
        private HalconDotNet.HSmartWindowControl HSWC;
        private System.Windows.Forms.Label lbl_Comparison_Words;
        private System.Windows.Forms.TextBox txt_Comparison_Words;
        private System.Windows.Forms.GroupBox gBx_Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_program2;
        private System.Windows.Forms.Label lbl_program1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Trigger;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lbl_plan_B_Yield;
        private System.Windows.Forms.Label lbl_plan_B_NG;
        private System.Windows.Forms.Label lbl_plan_B_OK;
        private System.Windows.Forms.Label lbl_plan_A_Yield;
        private System.Windows.Forms.Label lbl_plan_A_NG;
        private System.Windows.Forms.Label lbl_plan_A_OK;
        private System.ComponentModel.BackgroundWorker bgW_Run;
        private System.Windows.Forms.Button btn_Reset;
    }
}

