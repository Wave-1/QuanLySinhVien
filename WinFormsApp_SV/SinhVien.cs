namespace WinFormsApp_SV
{
    public class SinhVien
    {
        private string? _id;
        private string? _ten;
        private string? _gioiTinh;
        private int _tuoi;
        private double _diemToan;
        private double _diemVan;
        private double _diemAnh;
        private double _diemTB;
        private string? _hocLuc;

        public string? Id { get => _id; set => _id = value; }
        public string? Ten { get => _ten; set => _ten = value; }
        public string? GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public int Tuoi { get => _tuoi; set => _tuoi = value; }
        public double DiemToan { get => _diemToan; set => _diemToan = value; }
        public double DiemVan { get => _diemVan; set => _diemVan = value; }
        public double DiemAnh { get => _diemAnh; set => _diemAnh = value; }
        public double DiemTB { get => _diemTB; set => _diemTB = value; }
        public string? HocLuc { get => _hocLuc; set => _hocLuc = value; }
    }
}