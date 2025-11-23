namespace WindowsFormsApp4
{
    partial class FormStats
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;

        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.Label lblIncomeTotal;
        private System.Windows.Forms.Label lblExpenseTotal;
        private System.Windows.Forms.Label lblBudgetTotal;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();

            this.lblIncomeTotal = new System.Windows.Forms.Label();
            this.lblExpenseTotal = new System.Windows.Forms.Label();
            this.lblBudgetTotal = new System.Windows.Forms.Label();

            this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            this.SuspendLayout();

            // ============ TOP BAR ============
            this.panelTop.BackColor = System.Drawing.Color.Peru;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 55;

            this.lblTitle.Text = "📊 자료 통계";
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);

            // ============ FILTER PANEL ============
            this.panelFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Height = 110;
            this.panelFilter.Padding = new System.Windows.Forms.Padding(20);

            this.lblMonth.Text = "월 선택";
            this.lblMonth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblMonth.Location = new System.Drawing.Point(20, 20);

            this.cmbMonth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cmbMonth.Location = new System.Drawing.Point(100, 18);
            this.cmbMonth.Width = 150;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Items.AddRange(new object[]
            {
                "1월","2월","3월","4월","5월","6월","7월","8월","9월","10월","11월","12월"
            });

            this.btnLoad.Text = "통계 불러오기";
            this.btnLoad.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.BackColor = System.Drawing.Color.Peru;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(270, 15);
            this.btnLoad.Size = new System.Drawing.Size(120, 33);

            // Label 영역
            this.lblIncomeTotal.Location = new System.Drawing.Point(20, 60);
            this.lblIncomeTotal.AutoSize = true;
            this.lblIncomeTotal.Font = new System.Drawing.Font("맑은 고딕", 10F);

            this.lblExpenseTotal.Location = new System.Drawing.Point(200, 60);
            this.lblExpenseTotal.AutoSize = true;
            this.lblExpenseTotal.Font = new System.Drawing.Font("맑은 고딕", 10F);

            this.lblBudgetTotal.Location = new System.Drawing.Point(380, 60);
            this.lblBudgetTotal.AutoSize = true;
            this.lblBudgetTotal.Font = new System.Drawing.Font("맑은 고딕", 10F);

            this.panelFilter.Controls.Add(this.lblMonth);
            this.panelFilter.Controls.Add(this.cmbMonth);
            this.panelFilter.Controls.Add(this.btnLoad);
            this.panelFilter.Controls.Add(this.lblIncomeTotal);
            this.panelFilter.Controls.Add(this.lblExpenseTotal);
            this.panelFilter.Controls.Add(this.lblBudgetTotal);


            // ============ CHART ============
            this.chartStats.Dock = System.Windows.Forms.DockStyle.Fill;

            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("ChartArea1");
            this.chartStats.ChartAreas.Add(chartArea);

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Series1");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chartStats.Series.Add(series);

            // ============ FORM ============
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.chartStats);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "FormStats";

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
