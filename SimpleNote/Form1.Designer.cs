namespace SimpleNote
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.디자인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버전정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.불러오기ToolStripMenuItem,
            this.디자인ToolStripMenuItem,
            this.환경설정ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.불러오기ToolStripMenuItem1,
            this.저장ToolStripMenuItem1,
            this.다른이름으로저장ToolStripMenuItem,
            this.인쇄ToolStripMenuItem});
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            resources.ApplyResources(this.불러오기ToolStripMenuItem, "불러오기ToolStripMenuItem");
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            this.불러오기ToolStripMenuItem.MouseLeave += new System.EventHandler(this.불러오기ToolStripMenuItem_MouseLeave);
            this.불러오기ToolStripMenuItem.MouseHover += new System.EventHandler(this.불러오기ToolStripMenuItem_MouseHover);
            // 
            // 불러오기ToolStripMenuItem1
            // 
            this.불러오기ToolStripMenuItem1.Name = "불러오기ToolStripMenuItem1";
            resources.ApplyResources(this.불러오기ToolStripMenuItem1, "불러오기ToolStripMenuItem1");
            this.불러오기ToolStripMenuItem1.Click += new System.EventHandler(this.불러오기ToolStripMenuItem1_Click);
            // 
            // 저장ToolStripMenuItem1
            // 
            this.저장ToolStripMenuItem1.Name = "저장ToolStripMenuItem1";
            resources.ApplyResources(this.저장ToolStripMenuItem1, "저장ToolStripMenuItem1");
            this.저장ToolStripMenuItem1.Click += new System.EventHandler(this.저장ToolStripMenuItem1_Click);
            this.저장ToolStripMenuItem1.MouseLeave += new System.EventHandler(this.저장ToolStripMenuItem1_MouseLeave);
            this.저장ToolStripMenuItem1.MouseHover += new System.EventHandler(this.저장ToolStripMenuItem1_MouseHover);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            resources.ApplyResources(this.다른이름으로저장ToolStripMenuItem, "다른이름으로저장ToolStripMenuItem");
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ToolStripMenuItem_Click);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            resources.ApplyResources(this.인쇄ToolStripMenuItem, "인쇄ToolStripMenuItem");
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.인쇄ToolStripMenuItem_Click);
            // 
            // 디자인ToolStripMenuItem
            // 
            this.디자인ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴바꾸기ToolStripMenuItem,
            this.색상바꾸기ToolStripMenuItem});
            this.디자인ToolStripMenuItem.Name = "디자인ToolStripMenuItem";
            resources.ApplyResources(this.디자인ToolStripMenuItem, "디자인ToolStripMenuItem");
            // 
            // 글꼴바꾸기ToolStripMenuItem
            // 
            this.글꼴바꾸기ToolStripMenuItem.Name = "글꼴바꾸기ToolStripMenuItem";
            resources.ApplyResources(this.글꼴바꾸기ToolStripMenuItem, "글꼴바꾸기ToolStripMenuItem");
            this.글꼴바꾸기ToolStripMenuItem.Click += new System.EventHandler(this.글꼴바꾸기ToolStripMenuItem_Click);
            // 
            // 색상바꾸기ToolStripMenuItem
            // 
            this.색상바꾸기ToolStripMenuItem.Name = "색상바꾸기ToolStripMenuItem";
            resources.ApplyResources(this.색상바꾸기ToolStripMenuItem, "색상바꾸기ToolStripMenuItem");
            this.색상바꾸기ToolStripMenuItem.Click += new System.EventHandler(this.색상바꾸기ToolStripMenuItem_Click);
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.버전정보ToolStripMenuItem,
            this.환경설정ToolStripMenuItem1});
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            resources.ApplyResources(this.환경설정ToolStripMenuItem, "환경설정ToolStripMenuItem");
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            this.환경설정ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.환경설정ToolStripMenuItem_MouseDown);
            this.환경설정ToolStripMenuItem.MouseEnter += new System.EventHandler(this.환경설정ToolStripMenuItem_MouseEnter);
            this.환경설정ToolStripMenuItem.MouseLeave += new System.EventHandler(this.환경설정ToolStripMenuItem_MouseLeave);
            this.환경설정ToolStripMenuItem.MouseHover += new System.EventHandler(this.환경설정ToolStripMenuItem_MouseHover);
            this.환경설정ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.환경설정ToolStripMenuItem_MouseMove);
            this.환경설정ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.환경설정ToolStripMenuItem_MouseUp);
            // 
            // 버전정보ToolStripMenuItem
            // 
            this.버전정보ToolStripMenuItem.Name = "버전정보ToolStripMenuItem";
            resources.ApplyResources(this.버전정보ToolStripMenuItem, "버전정보ToolStripMenuItem");
            this.버전정보ToolStripMenuItem.Click += new System.EventHandler(this.버전정보ToolStripMenuItem_Click);
            // 
            // 환경설정ToolStripMenuItem1
            // 
            this.환경설정ToolStripMenuItem1.Name = "환경설정ToolStripMenuItem1";
            resources.ApplyResources(this.환경설정ToolStripMenuItem1, "환경설정ToolStripMenuItem1");
            this.환경설정ToolStripMenuItem1.Click += new System.EventHandler(this.환경설정ToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleNote.Properties.Resources._315166_text_note_icon;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Simple Note Printer";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 버전정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 디자인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴바꾸기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상바꾸기ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
    }
}

