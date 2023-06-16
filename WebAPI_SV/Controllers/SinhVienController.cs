using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace WebAPI_SV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SinhVienController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            Provider p = new Provider();
            DataTable dt = p.Select(CommandType.Text, "SELECT * FROM SINHVIEN");
            string JSONString = JsonConvert.SerializeObject(dt);
            return JSONString;
        }

        [HttpPost]
        public void Post([FromBody] SinhVien sv)
        {
            Provider p = new Provider();
            string strSql = "INSERT INTO SINHVIEN VALUES(@ID, @TEN, @GIOITINH, @TUOI," +
                " @DIEMTOAN, @DIEMVAN, @DIEMANH, @DIEMTB, @HOCLUC)";
            p.ExecuteNonQuery(CommandType.Text, strSql,
                new SqlParameter { ParameterName = "@ID", Value =  sv.Id},
                new SqlParameter { ParameterName = "@TEN", Value = sv.Ten },
                new SqlParameter { ParameterName = "@GIOITINH", Value = sv.GioiTinh },
                new SqlParameter { ParameterName = "@TUOI", Value = sv.Tuoi },
                new SqlParameter { ParameterName = "@DIEMTOAN", Value = sv.DiemToan },
                new SqlParameter { ParameterName = "@DIEMVAN", Value = sv.DiemVan },
                new SqlParameter { ParameterName = "@DIEMANH", Value = sv.DiemAnh },
                new SqlParameter { ParameterName = "@DIEMTB", Value = sv.DiemTB },
                new SqlParameter { ParameterName = "@HOCLUC", Value = sv.HocLuc }
                );
        }

        [HttpPut]
        public void Put(string id, [FromBody] SinhVien sv)
        {
            Provider p = new Provider();
            string strSql = "UPDATE SINHVIEN" +
                            " SET TEN = @TEN, GIOITINH = @GIOITINH, TUOI = @TUOI," +
                            " DIEMTOAN = @DIEMTOAN, DIEMVAN =  @DIEMVAN, DIEMANH = @DIEMANH, DIEMTB = @DIEMTB, HOCLUC = @HOCLUC" +
                            " WHERE ID=@ID";
            p.ExecuteNonQuery(CommandType.Text, strSql,
                new SqlParameter { ParameterName= "@ID", Value = sv.Id },
                new SqlParameter { ParameterName = "@TEN", Value = sv.Ten },
                new SqlParameter { ParameterName = "@GIOITINH", Value = sv.GioiTinh },
                new SqlParameter { ParameterName = "@TUOI", Value = sv.Tuoi },
                new SqlParameter { ParameterName = "@DIEMTOAN", Value = sv.DiemToan },
                new SqlParameter { ParameterName = "@DIEMVAN", Value = sv.DiemVan },
                new SqlParameter { ParameterName = "@DIEMANH", Value = sv.DiemAnh },
                new SqlParameter { ParameterName = "@DIEMTB", Value = sv.DiemTB },
                new SqlParameter { ParameterName = "@HOCLUC", Value = sv.HocLuc }
                );
        }
        [HttpDelete]
        public void Delete(string id)
        {
            Provider p = new Provider();
            string strSql = "DELETE SINHVIEN WHERE ID = @ID";
            p.ExecuteNonQuery(CommandType.Text, strSql,
                new SqlParameter { ParameterName = "@ID", Value = id });
        }

        [HttpGet("/id")]
        public IActionResult Search(string ten)
        {
            Provider p = new Provider();
            string strSql = "SELECT * FROM SINHVIEN WHERE TEN LIKE '%' + @ten + '%'";
            DataTable dt = p.Select(CommandType.Text, strSql,
                new SqlParameter { ParameterName = "@ten", Value = ten }
            );

            var customData = ConvertDataTableToCustomClass(dt);

            return new JsonResult(customData);
        }

        private List<SinhVien> ConvertDataTableToCustomClass(DataTable dt)
        {
            var customData = new List<SinhVien>();

            foreach (DataRow row in dt.Rows)
            {
                var item = new SinhVien
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
                customData.Add(item);
            }
            return customData;
        }
    }
}