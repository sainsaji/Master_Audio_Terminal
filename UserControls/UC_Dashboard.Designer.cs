namespace Mater_Audio_Terminal.UserControls
{
    partial class UC_Dashboard
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
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            this.lblDashboard = new ReaLTaiizor.Controls.MetroLabel();
            this.circularGauge1 = new CodeArtEng.Gauge.CircularGauge();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDashboard.IsDerivedStyle = true;
            this.lblDashboard.Location = new System.Drawing.Point(326, 256);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(100, 23);
            this.lblDashboard.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblDashboard.StyleManager = null;
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.ThemeAuthor = "Taiizor";
            this.lblDashboard.ThemeName = "MetroLight";
            // 
            // circularGauge1
            // 
            this.circularGauge1.Demo = true;
            this.circularGauge1.ErrorLimit = 100D;
            this.circularGauge1.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.MouseClick;
            this.circularGauge1.Location = new System.Drawing.Point(76, 57);
            this.circularGauge1.Maximum = 100D;
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.PointerPaintMode = CodeArtEng.Gauge.PointerPaintMode.SimpleGradient;
            this.circularGauge1.ResetValue = 0D;
            this.circularGauge1.ScaleFactor = 1D;
            this.circularGauge1.Size = new System.Drawing.Size(191, 176);
            this.circularGauge1.TabIndex = 2;
            this.circularGauge1.Theme = CodeArtEng.Gauge.GaugeTheme.DarkBlue;
            this.circularGauge1.Title = "Master Audio";
            this.circularGauge1.Unit = "%";
            this.circularGauge1.UserDefinedColors.Base = themeColors1;
            this.circularGauge1.UserDefinedColors.Error = themeColors2;
            this.circularGauge1.UserDefinedColors.Warning = themeColors3;
            this.circularGauge1.Value = 100D;
            this.circularGauge1.WarningLimit = 80D;
            // 
            // UC_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.circularGauge1);
            this.Controls.Add(this.lblDashboard);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(782, 563);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroLabel lblDashboard;
        private CodeArtEng.Gauge.CircularGauge circularGauge1;
    }
}
