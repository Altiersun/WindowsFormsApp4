namespace WindowsFormsApp4
{
    partial class FormBudget
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel panelInput;

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMonth;

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbMonth;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvBudget;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.panelInput = new System.Windows.Forms.Panel();

            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();

            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.dgvBudget = new System.Windows.Forms.DataGridView();

            this.panelTop.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).BeginInit();
            this.SuspendLayout();

            // ========= 상단 패널 =========
            this.panelTop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 55;

            this.lblTitle.Text = "💰 예산 관리";
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);

            // ========= 입력 영역 =========
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Height = 140;
            this.panelInput.Padding = new System.Windows.Forms.Padding(20);

            this.lblCategory.Text = "카테고리";
            this.lblCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblCategory.Location = new System.Drawing.Point(20, 20);

            this.lblAmount.Text = "예산 금액";
            this.lblAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblAmount.Location = new System.Drawing.Point(20, 60);

            this.lblMonth.Text = "월 선택";
            this.lblMonth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblMonth.Location = new System.Drawing.Point(300, 20);

            this.cmbCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[]
            {
                "식비", "교통비", "주거비", "교육", "의료", "취미", "기타"
            });
            this.cmbCategory.Location = new System.Drawing.Point(110, 17);
            this.cmbCategory.Width = 150;

            this.txtAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtAmount.Location = new System.Drawing.Point(110, 57);
            this.txtAmount.Width = 150;

            this.cmbMonth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Items.AddRange(new object[]
            {
                "1월","2월","3월","4월","5월","6월",
                "7월","8월","9월","10월","11월","12월"
            });
            this.cmbMonth.Location = new System.Drawing.Point(370, 17);
            this.cmbMonth.Width = 100;

            // ========= 버튼 =========
            this.btnAdd.Text = "추가";
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(520, 12);
            this.btnAdd.Size = new System.Drawing.Size(90, 35);

            this.btnUpdate.Text = "수정";
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(520, 52);
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);

            this.btnDelete.Text = "삭제";
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(520, 92);
            this.btnDelete.Size = new System.Drawing.Size(90, 35);

            // 입력 패널에 컨트롤 추가
            this.panelInput.Controls.Add(this.lblCategory);
            this.panelInput.Controls.Add(this.lblAmount);
            this.panelInput.Controls.Add(this.lblMonth);

            this.panelInput.Controls.Add(this.cmbCategory);
            this.panelInput.Controls.Add(this.txtAmount);
            this.panelInput.Controls.Add(this.cmbMonth);

            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.btnUpdate);
            this.panelInput.Controls.Add(this.btnDelete);

            // ========= DataGridView =========
            this.dgvBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBudget.BackgroundColor = System.Drawing.Color.White;
            this.dgvBudget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudget.ColumnHeadersHeight = 36;
            this.dgvBudget.EnableHeadersVisualStyles = false;
            this.dgvBudget.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvBudget.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            // ========= FormBudget =========
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvBudget);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "FormBudget";

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
