using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace Test_OCR_program
{
    public partial class Main : Form
    {
        private string compare_string;
        private string[] detect_words = new string[2];
        private int file_count;
        private string Folder_Path;
        private List<string> ocr_detect_world = new List<string>();
        private List<int> ocr_result = new List<int>();
        private int plan_A_OK, plan_B_OK, plan_A_NG, plan_B_NG;
        private double plan_A_Yield_Ratio, plan_B_Yield_Ratio;
        private string report_path = @"OCR_Report\";

        #region Halcon 建構

        public static HObject Empty_Ncc_result;
        public static HObject ho_OriImage = new HObject();
        public static HTuple hv_AcqHandle = new HTuple();

        private HObject ho_Symbols_OCR_01_0 = new HObject();
        private HTuple hv_Confidences_OCR_01_0 = new HTuple();
        private HTuple hv_Scores_OCR_01_0 = new HTuple();
        private HTuple hv_TmpCtrl_LineIndex = new HTuple(), hv_SymbolNames_OCR_01_0 = new HTuple();
        private HTuple hv_TmpCtrl_NumLines = new HTuple();

        //private HTuple OCR_models[i] = new HTuple();
        private HTuple[] OCR_Expressions = new HTuple[2];

        private HTuple OCR_handel = new HTuple();
        private HTuple[] OCR_models = new HTuple[2];

        //
        private HTuple Words, Confidence;

        #endregion Halcon 建構

        public Main()
        {
            InitializeComponent();
            HOperatorSet.GenImageConst(out Empty_Ncc_result, "byte", 512, 512);
            HOperatorSet.SetSystem("clip_region", "false");
        }

        private void bgW_Run_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < file_count; i++)
            {
                HOperatorSet.GrabImage(out ho_OriImage, hv_AcqHandle);
                Thread.Sleep(50);
                bgW_Run.ReportProgress(1); //讀取圖片
                Test_OCR();
                bgW_Run.ReportProgress(2); //刷新結果
                Write_Report();
                ocr_detect_world.Clear();
                ocr_result.Clear();
                Thread.Sleep(50);
            }
        }

        private void bgW_Run_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    Show_Current_Image();
                    break;

                case 2:
                    Refresh_Result();
                    break;

                default:
                    break;
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Folder_Path = txt_file_path.Text;
            if (Directory.Exists(Folder_Path))
            {
                hv_AcqHandle.Dispose();
                HOperatorSet.OpenFramegrabber("File", 1, 1, 0, 0, 0, 0, "default", -1, "default", -1, "false", Folder_Path, "default", 1, -1, out hv_AcqHandle);
            }

            DirectoryInfo di = new DirectoryInfo(Folder_Path);
            FileInfo[] files = di.GetFiles("*.tiff"); //篩選副檔名為xls的 //取得所有的excel檔 會存入陣列裡面
            file_count = files.Length; //取得個數
        }

        private void btn_Create_OCR_Click(object sender, EventArgs e)
        {
            int Word_max_Width, Word_max_High, Stroke_max_Width;
            int Word_min_Width, Word_min_High, Stroke_min_Width;
            bool Word_max_Width_auto, Word_max_High_auto, Stroke_max_Width_auto;
            bool Word_min_Width_auto, Word_min_High_auto, Stroke_min_Width_auto;
            try
            {
                //輸入OCR建立參數
                Word_min_Width = Convert.ToInt32(Tb_min_word_width.Text);
                Word_min_High = Convert.ToInt32(Tb_min_word_high.Text);
                Stroke_min_Width = Convert.ToInt32(Tb_min_width.Text);
                Word_max_Width = Convert.ToInt32(Tb_max_word_width.Text);
                Word_max_High = Convert.ToInt32(Tb_max_word_high.Text);
                Stroke_max_Width = Convert.ToInt32(Tb_max_width.Text);

                //auto 功能確認
                Word_min_Width_auto = cb_min_width_auto.Checked;
                Word_min_High_auto = cb_min_word_high_auto.Checked;
                Stroke_min_Width_auto = cb_min_width_auto.Checked;
                Word_max_High_auto = cb_max_word_high_auto.Checked;
                Word_max_Width_auto = cb_max_word_width_auto.Checked;
                Stroke_max_Width_auto = cb_max_width_auto.Checked;
            }
            catch
            {
                MessageBox.Show("OCR參數有誤!!");
                return;
            }

            #region 建立字元條件 2022/01/14

            OCR_handel.Dispose();
            switch (CB_OCR_type.SelectedIndex)
            {
                case 0:
                    HOperatorSet.ReadOcrClassCnn("Universal_0-9A-Z_NoRej.occ", out OCR_handel);
                    break;

                case 1:
                    HOperatorSet.ReadOcrClassMlp("Industrial_0-9A-Z_NoRej.omc", out OCR_handel);
                    break;

                case 2:
                    HOperatorSet.ReadOcrClassMlp("SFCompactText-RegularG2_0-9A-Z.omc", out OCR_handel);
                    break;
            }

            //OCR_models[i].Dispose();
            for (int i = 0; i < OCR_models.Length; i++)
            {
                HOperatorSet.CreateTextModelReader("auto", OCR_handel, out OCR_models[i]);
                HOperatorSet.SetTextModelParam(OCR_models[i], "dot_print", "true");
                HOperatorSet.SetTextModelParam(OCR_models[i], "min_contrast", 4);
                HOperatorSet.SetTextModelParam(OCR_models[i], "polarity", "dark_on_light");
                HOperatorSet.SetTextModelParam(OCR_models[i], "eliminate_border_blobs", "false");
                HOperatorSet.SetTextModelParam(OCR_models[i], "add_fragments", "false");

                if (Word_min_Width_auto)
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "min_char_width", "auto");
                }
                else
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "min_char_width", Word_min_Width);
                }

                if (Word_min_High_auto)
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "min_char_height", "auto");
                }
                else
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "min_char_height", Word_min_High);
                }

                if (Word_max_Width_auto)
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "max_char_width", "auto");
                }
                else
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "max_char_width", Word_max_Width);
                }

                if (Word_max_High_auto)
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "max_char_height", "auto");
                }
                else
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "max_char_height", Word_max_High);
                }

                if (Stroke_min_Width_auto)
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "min_stroke_width", "auto");
                }
                else
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "min_stroke_width", Stroke_min_Width);
                }

                if (Stroke_max_Width_auto)
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "max_stroke_width", "auto");
                }
                else
                {
                    HOperatorSet.SetTextModelParam(OCR_models[i], "max_stroke_width", Stroke_max_Width);
                }

                HOperatorSet.SetTextModelParam(OCR_models[i], "return_punctuation", "false");
                HOperatorSet.SetTextModelParam(OCR_models[i], "num_classes", 3);
            }

            #endregion 建立字元條件 2022/01/14

            //建立比對資訊
            if (txt_Comparison_Words.Text != string.Empty)
            {
                compare_string = txt_Comparison_Words.Text.Substring(0, 6);
            }
            else
            {
                MessageBox.Show("未輸入比對資訊!");
                return;
            }
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != txt_Comparison_Words.Text)
                {
                    txt_file_path.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_plan_A_OK.Text = $"0";
            lbl_plan_A_NG.Text = $"0";
            lbl_plan_A_Yield.Text = $"0";
            lbl_plan_B_OK.Text = $"0";
            lbl_plan_B_NG.Text = $"0";
            lbl_plan_B_Yield.Text = $"0";
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < file_count; i++)
            //{
            //    HOperatorSet.GrabImage(out ho_OriImage, hv_AcqHandle);
            //    Thread.Sleep(100);
            //    Show_Current_Image();
            //    Test_OCR();
            //    Refresh_Result();
            //    Write_Report();
            //    ocr_detect_world.Clear();
            //    ocr_result.Clear();
            //    Thread.Sleep(50);
            //}
            bgW_Run.RunWorkerAsync();
        }

        private void btn_Trigger_Click(object sender, EventArgs e)
        {
            HOperatorSet.GrabImage(out ho_OriImage, hv_AcqHandle);
            Show_Current_Image();
            Test_OCR();
            Refresh_Result();
            ocr_detect_world.Clear();
            ocr_result.Clear();
        }

        private void cb_OCR_Setting_CheckedChanged(object sender, EventArgs e)
        {
            string cb_name = ((CheckBox)sender).Name;
            bool cb_state = ((CheckBox)sender).Checked;
            switch (cb_name)
            {
                case "cb_max_word_high_auto":
                    if (cb_state)
                    {
                        Tb_max_word_high.Enabled = false;
                        Tb_max_word_high.Text = "0";
                    }
                    else
                    {
                        Tb_max_word_high.Enabled = true;
                    }
                    break;

                case "cb_min_word_high_auto":
                    if (cb_state)
                    {
                        Tb_min_word_high.Enabled = false;
                        Tb_min_word_high.Text = "0";
                    }
                    else
                    {
                        Tb_min_word_high.Enabled = true;
                    }
                    break;

                case "cb_max_word_width_auto":
                    if (cb_state)
                    {
                        Tb_max_word_width.Enabled = false;
                        Tb_max_word_width.Text = "0";
                    }
                    else
                    {
                        Tb_max_word_width.Enabled = true;
                    }
                    break;

                case "cb_min_word_width_auto":
                    if (cb_state)
                    {
                        Tb_min_word_width.Enabled = false;
                        Tb_min_word_width.Text = "0";
                    }
                    else
                    {
                        Tb_min_word_width.Enabled = true;
                    }
                    break;

                case "cb_max_width_auto":
                    if (cb_state)
                    {
                        Tb_max_width.Enabled = false;
                        Tb_max_width.Text = "0";
                    }
                    else
                    {
                        Tb_max_width.Enabled = true;
                    }
                    break;

                case "cb_min_width_auto":
                    if (cb_state)
                    {
                        Tb_min_width.Enabled = false;
                        Tb_min_width.Text = "0";
                    }
                    else
                    {
                        Tb_min_width.Enabled = true;
                    }
                    break;
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            OCR_Expressions[0] = "^[^IO]*$";
            OCR_Expressions[1] = "^[^IOB][^IOB][^IOB][^IOB][^IO8][^IOB]*$"; //建立固定位置，只出現B
        }

        private void Refresh_Result()
        {
            lbl_plan_A_OK.Text = plan_A_OK.ToString();
            lbl_plan_A_NG.Text = plan_A_NG.ToString();
            lbl_plan_A_Yield.Text = Math.Round(plan_A_Yield_Ratio, 2).ToString();
            lbl_plan_B_OK.Text = plan_B_OK.ToString();
            lbl_plan_B_NG.Text = plan_B_NG.ToString();
            lbl_plan_B_Yield.Text = Math.Round(plan_B_Yield_Ratio, 2).ToString();
        }

        private void Show_Current_Image()
        {
            HOperatorSet.GetImageSize(ho_OriImage, out HTuple W, out HTuple H);
            HOperatorSet.SetPart(HSWC.HalconWindow, 0, 0, H - 1, W - 1);

            HOperatorSet.DispObj(ho_OriImage, HSWC.HalconWindow);
            HOperatorSet.GetImageSize(ho_OriImage, out HTuple w, out HTuple h);
        }

        private void Test_OCR()
        {
            for (int i = 0; i < OCR_models.Length; i++)
            {
                HOperatorSet.FindText(ho_OriImage, OCR_models[i], out HTuple textResultID);
                hv_TmpCtrl_NumLines.Dispose();
                HOperatorSet.GetTextResult(textResultID, "num_lines", out hv_TmpCtrl_NumLines);

                HTuple end_val90 = hv_TmpCtrl_NumLines - 1;
                HTuple step_val90 = 1;
                for (hv_TmpCtrl_LineIndex = 0; hv_TmpCtrl_LineIndex.Continue(end_val90, step_val90); hv_TmpCtrl_LineIndex = hv_TmpCtrl_LineIndex.TupleAdd(step_val90))
                {
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        ho_Symbols_OCR_01_0.Dispose();
                        HOperatorSet.GetTextObject(out ho_Symbols_OCR_01_0, textResultID, (new HTuple("line")).TupleConcat(hv_TmpCtrl_LineIndex));
                    }
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        hv_SymbolNames_OCR_01_0.Dispose(); hv_Confidences_OCR_01_0.Dispose(); hv_Scores_OCR_01_0.Dispose();
                        HOperatorSet.DoOcrWordMlp(ho_Symbols_OCR_01_0, ho_OriImage, OCR_handel, OCR_Expressions[i], 5, 5, out hv_SymbolNames_OCR_01_0, out Confidence, out Words, out hv_Scores_OCR_01_0);
                    }
                }
                detect_words[i] = Words.S;
                Words.Dispose();
                //判定條件
                bool condition_1 = detect_words[i].Substring(0, 6).Equals(compare_string);
                bool condition_2 = detect_words[i].Length.Equals(10);

                if (i.Equals(0))
                {
                    if (condition_1 && condition_2)
                    {
                        //true
                        plan_A_OK++;
                        ocr_result.Add(1);
                    }
                    else
                    {
                        //false
                        plan_A_NG++;
                        ocr_result.Add(0);
                        HOperatorSet.WriteImage(ho_OriImage, "tiff", 0, @"OCR_Image\Plan_A\" + $"Index_{plan_A_OK + plan_A_NG}_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
                    }
                    plan_A_Yield_Ratio = Convert.ToDouble(plan_A_OK) / Convert.ToDouble(file_count) * 100;
                    plan_A_Yield_Ratio = Convert.ToDouble(plan_A_OK) / Convert.ToDouble(plan_A_OK + plan_A_NG) * 100;
                }
                else
                {
                    if (condition_1 && condition_2)
                    {
                        //true
                        plan_B_OK++;
                        ocr_result.Add(1);
                    }
                    else
                    {
                        //false
                        plan_B_NG++;
                        ocr_result.Add(0);
                        HOperatorSet.WriteImage(ho_OriImage, "tiff", 0, @"OCR_Image\Plan_B\" + $"Index_{plan_B_OK + plan_B_NG}_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
                    }
                    //plan_B_Yield_Ratio = Convert.ToDouble(plan_B_OK) / Convert.ToDouble(file_count) * 100;
                    plan_B_Yield_Ratio = Convert.ToDouble(plan_B_OK) / Convert.ToDouble(plan_B_OK + plan_B_NG) * 100;
                }
                //ocr_detect_world.AddRange(detect_words.ToList());
                ocr_detect_world.Add(detect_words[i]);
            }
        }

        private void Write_Report()
        {
            //資料夾不存在，建立資料夾
            if (!Directory.Exists(report_path))
            {
                Directory.CreateDirectory(report_path);
            }
            string report_file_name = report_path + "\\" + "OCR_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            if (!File.Exists(report_file_name))
            {
                FileStream fs = new FileStream(report_file_name, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine($"比對字串, {txt_Comparison_Words.Text}");
                sw.WriteLine($"方案一辨識內容,方案二辨識內容,方案一結果,方案二結果");
                sw.Close();
                fs.Close();
            }
            using (StreamWriter sw = new StreamWriter(report_file_name, true, Encoding.Default))
            {
                sw.WriteLineAsync($"{ocr_detect_world[0]},{ocr_detect_world[1]},{ocr_result[0]},{ocr_result[1]}");
                sw.Close();
                sw.Dispose();
            }
        }
    }
}