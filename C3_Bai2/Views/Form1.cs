using C3_Bai2.Controller.Services;
using C3_Bai2.Model.DomainClass;
using Microsoft.EntityFrameworkCore.Metadata;

namespace C3_Bai2
{
    public partial class Form1 : Form
    {
        SachService _service = new();
        Guid _id;
        List<Guid> _idNXB = new List<Guid>(); 
        public Form1()
        {
            InitializeComponent();
            LoadGrid(null);
            LoadNXB();
        }
        public void LoadNXB()
        {
            foreach (var item in _service.GetNxbs(null))
            {
                _idNXB.Add(item.Id);
                cmbxNXB.Items.Add(item.Ten);
            }
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            dtgSach.ColumnCount = 5;
            dtgSach.Columns[0].Name = "STT";
            dtgSach.Columns[1].Name = "ID";
            dtgSach.Columns[2].Name = "Mã sách";
            dtgSach.Columns[3].Name = "Tên sách";
            dtgSach.Columns[4].Name = "Nhà xuất bản";
            dtgSach.Rows.Clear();
            foreach (var item in _service.GetSaches(input))
            {
                var nxb = _service.GetNxbs(null).FirstOrDefault(x => x.Id == item.IdNxb);
                if (nxb == null)
                {
                    dtgSach.Rows.Add(stt++, item.Id, item.Ma, item.Ten, "Không có thông tin");
                }
                else
                {
                    dtgSach.Rows.Add(stt++, item.Id, item.Ma, item.Ten, nxb.Ten);
                }
            }
        }

        private void dtgSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _id = Guid.Parse(dtgSach.Rows[rowIndex].Cells[1].Value.ToString());
                var obj = _service.GetSaches(null).FirstOrDefault(x => x.Id == _id);
                txtTen.Text = obj.Ten;
                txtMa.Text = obj.Ma;
                if (obj.TrangThai == 1)
                {
                    rbtnConHang.Checked = true;
                }
                else
                {
                    rbtnHetHang.Checked = true;
                }
                int iNXB = _service.GetNxbs(null).FindIndex(x => x.Id == obj.IdNxb);
                cmbxNXB.SelectedIndex = iNXB;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadGrid(null);
        }
        public bool CheckTextBox()
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Các trường ko được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
            {
                return;
            }
            Sach sach = new Sach();
            sach.Ma = txtMa.Text;
            sach.Ten = txtTen.Text;
            if (rbtnConHang.Checked)
            {
                sach.TrangThai = 1;
            }
            else
            {
                sach.TrangThai = 0;
            }
            sach.IdNxb = _idNXB[cmbxNXB.SelectedIndex]; 
            _service.ThemSach(sach);
            LoadGrid(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = new Sach();
            obj.Ma = txtMa.Text;
            obj.Ten = txtTen.Text;
            if (rbtnConHang.Checked)
            {
                obj.TrangThai = 1;
            }
            else
            {
                obj.TrangThai = 0;
                obj.Id = _id;
                obj.IdNxb = _idNXB[cmbxNXB.SelectedIndex];
                _service.SuaSach(obj);
                LoadGrid(null);
            }
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}