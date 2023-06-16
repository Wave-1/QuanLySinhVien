using System.Data;
using Newtonsoft.Json;
namespace WinFormsApp_SV
{
    public partial class Form1 : Form
    {
        SinhVien? svChon = new SinhVien();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public async void LoadData()
        {
            try
            {
                QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
                string kq = await quanLySinhVien.Get();
                DataTable? dt = new DataTable();
                dt = JsonConvert.DeserializeObject<DataTable>(kq);
                dgvDanhSachSV.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SinhVien getForm()
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.Id = tbId.Text;
            sinhVien.Ten = tbTen.Text;
            sinhVien.GioiTinh = cbGioiTinh.Text;
            sinhVien.Tuoi = int.Parse(tbTuoi.Text);
            sinhVien.DiemToan = Double.Parse(tbDiemToan.Text);
            sinhVien.DiemVan = Double.Parse(tbDiemVan.Text);
            sinhVien.DiemAnh = Double.Parse(tbDiemAnh.Text);
            sinhVien.DiemTB = Double.Parse(tbDiemTB.Text);
            sinhVien.HocLuc = cbHocLuc.Text;
            return sinhVien;
        }

        public void setForm(SinhVien sinhVien)
        {
            if (sinhVien != null)
            {
                tbId.Text = sinhVien.Id;
                tbTen.Text = sinhVien.Ten;
                cbGioiTinh.Text = sinhVien.GioiTinh;
                tbTuoi.Text = sinhVien.Tuoi.ToString();
                tbDiemToan.Text = sinhVien.DiemToan.ToString();
                tbDiemVan.Text = sinhVien.DiemVan.ToString();
                tbDiemAnh.Text = sinhVien.DiemAnh.ToString();
                tbDiemTB.Text = sinhVien.DiemTB.ToString();
                cbHocLuc.Text = sinhVien.HocLuc;
            }
            else
            {
                tbId.Text = "";
                tbTen.Text = "";
                cbGioiTinh.Text = "";
                tbTuoi.Text = "";
                tbDiemToan.Text = "";
                tbDiemVan.Text = "";
                tbDiemAnh.Text = "";
                tbDiemTB.Text = "";
                cbHocLuc.Text = "";
            }
        }

        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                svChon.Id = dgvDanhSachSV.Rows[index].Cells[0].Value.ToString();
                svChon.Ten = dgvDanhSachSV.Rows[index].Cells[1].Value.ToString();
                svChon.GioiTinh = dgvDanhSachSV.Rows[index].Cells[2].Value.ToString();
                svChon.Tuoi = Convert.ToInt32(dgvDanhSachSV.Rows[index].Cells[3].Value.ToString());
                svChon.DiemToan = Convert.ToDouble(dgvDanhSachSV.Rows[index].Cells[4].Value.ToString());
                svChon.DiemVan = Convert.ToDouble(dgvDanhSachSV.Rows[index].Cells[5].Value.ToString());
                svChon.DiemAnh = Convert.ToDouble(dgvDanhSachSV.Rows[index].Cells[6].Value.ToString());
                svChon.DiemTB = Convert.ToDouble(dgvDanhSachSV.Rows[index].Cells[7].Value.ToString());
                svChon.HocLuc = dgvDanhSachSV.Rows[index].Cells[8].Value.ToString();
                setForm(svChon);
            }
        }

        private void tbDiemToan_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTrungBinh();
        }

        private void tbDiemVan_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTrungBinh();
        }

        private void tbDiemAnh_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTrungBinh();
        }
        private void TinhDiemTrungBinh()
        {
            double diemToan, diemVan, diemAnh;
            if (double.TryParse(tbDiemToan.Text, out diemToan) &&
                double.TryParse(tbDiemVan.Text, out diemVan) &&
                double.TryParse(tbDiemAnh.Text, out diemAnh))
            {
                double diemTrungBinh = (diemToan + diemVan + diemAnh) / 3;
                double lamTron = Math.Round(diemTrungBinh, 1);
                tbDiemTB.Text = lamTron.ToString();
            }
            else
            {
                tbDiemTB.Text = "Không hợp lệ";
            }
        }

        private void tbDiemToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (tbDiemToan.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            double diemToan;
            if (double.TryParse(tbDiemToan.Text + e.KeyChar, out diemToan))
            {
                if (diemToan < 0 || diemToan > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbDiemVan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (tbDiemVan.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            double diemVan;
            if (double.TryParse(tbDiemVan.Text + e.KeyChar, out diemVan))
            {
                if (diemVan < 0 || diemVan > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbDiemAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (tbDiemAnh.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            double diemAnh;
            if (double.TryParse(tbDiemAnh.Text + e.KeyChar, out diemAnh))
            {
                if (diemAnh < 0 || diemAnh > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            double tuoi;
            if (double.TryParse(tbTuoi.Text + e.KeyChar, out tuoi))
            {
                if (tuoi < 0 || tuoi > 100)
                {
                    e.Handled = true;
                }
            }
        }

        private void HienHocLuc()
        {
            double diemTB;
            if (double.TryParse(tbDiemTB.Text, out diemTB))
            {
                if (diemTB >= 8.0)
                {
                    cbHocLuc.SelectedIndex = 0;
                }
                else if (diemTB >= 6.5)
                {
                    cbHocLuc.SelectedIndex = 1;
                }
                else if (diemTB >= 5)
                {
                    cbHocLuc.SelectedIndex = 2;
                }
                else
                {
                    cbHocLuc.SelectedIndex = 3;
                }
            }
        }

        private void cbHocLuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienHocLuc();
        }

        private void cbHocLuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void tbDiemTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = getForm();
                QuanLySinhVien qlsv = new QuanLySinhVien();
                var kq = await qlsv.Create(sv);
                if (kq > 0)
                {
                    LoadData();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    QuanLySinhVien qlsv = new QuanLySinhVien();
                    var kq = await qlsv.Delete(svChon.Id);
                    if (kq > 0)
                    {
                        LoadData();
                        MessageBox.Show("Xóa thành công");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = getForm();
                QuanLySinhVien qlsv = new QuanLySinhVien();
                var kq = await qlsv.Update(sv);
                if (kq > 0)
                {
                    LoadData();
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBox1.Text;
                string path = $"https://localhost:7217/id?ten={searchText}";
                QuanLySinhVien qlsv = new QuanLySinhVien();
                string kq = await qlsv.Search(path);

                if (!string.IsNullOrEmpty(kq))
                {
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(kq);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        SinhVien sv = new SinhVien
                        {
                            Id = row["ID"].ToString(),
                            Ten = row["Ten"].ToString(),
                            GioiTinh = row["GioiTinh"].ToString(),
                            Tuoi = Convert.ToInt32(row["Tuoi"]),
                            DiemToan = Convert.ToDouble(row["DiemToan"]),
                            DiemVan = Convert.ToDouble(row["DiemVan"]),
                            DiemAnh = Convert.ToDouble(row["DiemAnh"]),
                            DiemTB = Convert.ToDouble(row["DiemTB"]),
                            HocLuc = row["HocLuc"].ToString()
                        };
                        setForm(sv);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm sinh viên !!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}