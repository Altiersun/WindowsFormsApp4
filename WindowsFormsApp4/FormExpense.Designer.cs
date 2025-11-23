namespace WindowsFormsApp4
{
    partial class FormExpense
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel panelInput;

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMemo;

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMemo;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvExpense;

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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();

            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.dgvExpense = new System.Windows.Forms.DataGridView();

            this.panelTop.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            this.SuspendLayout();

            // ================= TOP PANEL =====================
            this.panelTop.BackColor = System.Drawing.Color.IndianRed;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 55;

            this.lblTitle.Text = "💸 지출 내역 관리";
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);

            // ================= INPUT PANEL =====================
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Height = 170;
            this.panelInput.Padding = new System.Windows.Forms.Padding(20);

            this.lblDate.Text = "날짜";
            this.lblDate.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblDate.Location = new System.Drawing.Point(20, 20);

            this.lblCategory.Text = "카테고리";
            this.lblCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblCategory.Location = new System.Drawing.Point(20, 60);

            this.lblAmount.Text = "금액";
            this.lblAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblAmount.Location = new System.Drawing.Point(20, 100);

            this.lblMemo.Text = "메모";
            this.lblMemo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblMemo.Location = new System.Drawing.Point(350, 20);

            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dtpDate.Location = new System.Drawing.Point(110, 17);
            this.dtpDate.Width = 200;

            this.cmbCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[]
            {
                "식비","교통비","주거비","교육","취미","의료","쇼핑","기타"
            });
            this.cmbCategory.Location = new System.Drawing.Point(110, 57);
            this.cmbCategory.Width = 200;

            this.txtAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtAmount.Location = new System.Drawing.Point(110, 97);
            this.txtAmount.Width = 200;

            this.txtMemo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtMemo.Location = new System.Drawing.Point(350, 50);
            this.txtMemo.Multiline = true;
            this.txtMemo.Size = new System.Drawing.Size(300, 80);

            // 버튼
            this.btnAdd.Text = "추가";
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(680, 20);
            this.btnAdd.Size = new System.Drawing.Size(90, 35);

            this.btnUpdate.Text = "수정";
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(680, 65);
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);

            this.btnDelete.Text = "삭제";
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(680, 110);
            this.btnDelete.Size = new System.Drawing.Size(90, 35);

            // 입력 패널에 컨트롤 추가
            this.panelInput.Controls.Add(this.lblDate);
            this.panelInput.Controls.Add(this.lblCategory);
            this.panelInput.Controls.Add(this.lblAmount);
            this.panelInput.Controls.Add(this.lblMemo);

            this.panelInput.Controls.Add(this.dtpDate);
            this.panelInput.Controls.Add(this.cmbCategory);
            this.panelInput.Controls.Add(this.txtAmount);
            this.panelInput.Controls.Add(this.txtMemo);

            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.btnUpdate);
            this.panelInput.Controls.Add(this.btnDelete);

            // ================= GRID =====================
            this.dgvExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpense.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpense.RowTemplate.Height = 28;
            this.dgvExpense.ColumnHeadersHeight = 36;
            this.dgvExpense.EnableHeadersVisualStyles = false;
            this.dgvExpense.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
            this.dgvExpense.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;


            // ================= FORM =====================
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvExpense);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "FormExpense";

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
