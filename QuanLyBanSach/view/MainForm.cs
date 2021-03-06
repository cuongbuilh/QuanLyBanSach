using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanSach.report;

namespace QuanLyBanSach.view
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnu_NguoiDung_Click(object sender, EventArgs e)
        {
            new FrmNguoiDung().Show();
        }

        private void mnu_PhanQuyen_Click(object sender, EventArgs e)
        {
            new FrmQuyen().Show();
        }

        private void mnu_Sach_Click(object sender, EventArgs e)
        {
            new FrmSach().Show();
        }

        private void mnu_NXB_Click(object sender, EventArgs e)
        {
            new FrmNhaXuatBan().Show();
        }

        private void mnu_TacGia_Click(object sender, EventArgs e)
        {
            new FrmTacGia().Show();
        }

        private void mnu_TheLoai_Click(object sender, EventArgs e)
        {
            new FrmTheLoai().Show();
        }

        private void mnu_TaoDonHang_Click(object sender, EventArgs e)
        {
            new FrmTaoDonHang().Show();
        }

        private void mnu_DangKy_Click(object sender, EventArgs e)
        {
            new FrmDangKy().Show();
        }

        private void mnu_DangNhap_Click(object sender, EventArgs e)
        {
            new FrmDangNhap().Show();
            this.Hide();
        }

        private void mnu_DangXuat_Click(object sender, EventArgs e)
        {
            LOGIN_USER.TENNGUOIDUNG = "";
            LOGIN_USER.MANGUOIDUNG = 0;
            new FrmDangNhap().Show();
            this.Hide();
        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnu_BaoCao_DoanhThu_Click(object sender, EventArgs e)
        {
            Frm_BaoCao_DoanhThu frmBaoCaoDoanhThu = new Frm_BaoCao_DoanhThu();
            frmBaoCaoDoanhThu.Show();
        }
    }
}
