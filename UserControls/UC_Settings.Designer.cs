namespace Mater_Audio_Terminal.UserControls
{
    partial class UC_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Settings));
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            this.parrotSlider1 = new ReaLTaiizor.Controls.ParrotSlider();
            this.linearGauge1 = new CodeArtEng.Gauge.LinearGauge();
            this.SuspendLayout();
            // 
            // parrotSlider1
            // 
            this.parrotSlider1.BarThickness = 4;
            this.parrotSlider1.BigStepIncrement = 10;
            this.parrotSlider1.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("parrotSlider1.Colors")));
            this.parrotSlider1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotSlider1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.parrotSlider1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotSlider1.KnobColor = System.Drawing.Color.Gray;
            this.parrotSlider1.KnobImage = null;
            this.parrotSlider1.Location = new System.Drawing.Point(99, 77);
            this.parrotSlider1.Max = 100;
            this.parrotSlider1.Name = "parrotSlider1";
            this.parrotSlider1.Percentage = 50;
            this.parrotSlider1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotSlider1.Positions = ((System.Collections.Generic.List<float>)(resources.GetObject("parrotSlider1.Positions")));
            this.parrotSlider1.QuickHopping = false;
            this.parrotSlider1.Size = new System.Drawing.Size(250, 20);
            this.parrotSlider1.SliderStyle = ReaLTaiizor.Controls.ParrotSlider.Style.Windows10;
            this.parrotSlider1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotSlider1.TabIndex = 1;
            this.parrotSlider1.Text = "parrotSlider1";
            this.parrotSlider1.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // linearGauge1
            // 
            this.linearGauge1.BottomBarHeight = 5;
            this.linearGauge1.Demo = true;
            this.linearGauge1.Location = new System.Drawing.Point(400, 72);
            this.linearGauge1.Maximum = 100D;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.ResetValue = 0D;
            this.linearGauge1.ScaleFactor = 1D;
            this.linearGauge1.SegmentGap = 1;
            this.linearGauge1.Size = new System.Drawing.Size(200, 30);
            this.linearGauge1.TabIndex = 2;
            this.linearGauge1.Title = "";
            this.linearGauge1.Unit = "%";
            this.linearGauge1.UserDefinedColors.Base = themeColors1;
            this.linearGauge1.UserDefinedColors.Error = themeColors2;
            this.linearGauge1.UserDefinedColors.Warning = themeColors3;
            // 
            // UC_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.linearGauge1);
            this.Controls.Add(this.parrotSlider1);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(782, 563);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotSlider parrotSlider1;
        private CodeArtEng.Gauge.LinearGauge linearGauge1;
    }
}
