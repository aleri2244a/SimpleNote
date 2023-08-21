using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using System.Diagnostics;
using System.Windows.Input;

namespace SimpleNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(345, 506);
            this.MaximumSize = new Size(345, 506);
            toolStripStatusLabel1.Text = "Ready!";
            textBox1.Text = Properties.Settings.Default.myPath;
            fontDialog1.Font = Properties.Settings.Default.myFont;
            colorDialog1.Color = Properties.Settings.Default.myFColor;

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 환경설정ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "[Setting/환경설정]";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 저장ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "[Save/저장]";
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 저장ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.myPath = textBox1.Text;
            Properties.Settings.Default.myFont = fontDialog1.Font;
            Properties.Settings.Default.myFColor = colorDialog1.Color;
            Properties.Settings.Default.Save();
            MessageBox.Show("작성된 내용을 저장했습니다.\r作成された内容を保存しました。\rYour entries have been saved successfully.\r\r[확인]버튼을 눌러주세요.\r[確認] ボタンを押してください。\rPress the [OK] button.\r", "*.*", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 불러오기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "db";
            openFileDlg.Filter = "Text File(*.txt;*.tx)|*.txt;*.tx";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    this.textBox1.Text = File.ReadAllText(openFileDlg.FileName);
                    MessageBox.Show("파일을 성공적으로 불러 왔습니다.\rファイルの読み込みに成功しました。\rSuccessfully loaded file!", "*.*", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 저장ToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {


        }

        private void 저장ToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            statusStrip1.Text = "Ready!";
        }

        private void 불러오기ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusStrip1.Text = "[File]";
        }

        private void 불러오기ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            statusStrip1.Text = "Status";
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog1.FilterIndex = 1;

            // 대화상자를 닫기 전에 디렉토리를 이전에 선택한 디렉토리로
            // 복원한지의 여부를 나타납니다.
            saveFileDialog1.RestoreDirectory = true;

            // 확장명을 입력하지 않을 때, 자동으로 확장자를 추가할 수 있습니다.
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "txt";

            // 파일이 이미 존재하면 덮어쓰기 할지를 묻는 대화상자를 표시합니다.
            // 기본값: true
            saveFileDialog1.OverwritePrompt = true;

            // 저장할 위치의 초기 디렉토리를 설정합니다.
            // Environment.CurrentDirectory: 현재 디렉토리를 나타냅니다.
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(textBox1.Text);
                }
            }
        }

        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://versioninfo.s1mplen0te.kro.kr/");


        }

        private void 환경설정ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            statusStrip1.Text = "Ready!";
        }

        private void 환경설정ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            statusStrip1.Text = "Ready!";
        }

        private void 환경설정ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            statusStrip1.Text = "Ready!";
        }

        private void 환경설정ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            statusStrip1.Text = "Ready!";
        }

        private void 환경설정ToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            statusStrip1.Text = "Ready!";
        }

        private void 영어ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
        }

        private void 한국어ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ko-KR");

        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kokr한국어ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ko-KR");
        }

        private void enus영어ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
        }

        private void 환경설정ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 영어ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
        }

        private void 한국어ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ko");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ko");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja");
                    break;
                 case 3:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh");
                    break;

            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void 글꼴바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }

        }

        private void 색상바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Thread.Sleep(2500);
            e.Graphics.DrawString(textBox1.Text, new Font("에스코어 드림 4 Regular", 10, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                Properties.Settings.Default.myPath = textBox1.Text;
            Properties.Settings.Default.myFont = fontDialog1.Font;
            Properties.Settings.Default.myFColor = colorDialog1.Color;
            Properties.Settings.Default.Save();
          
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
