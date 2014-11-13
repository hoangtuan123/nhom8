using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CtPhieuNhapService" in both code and config file together.
    public class CtPhieuNhapService : ICtPhieuNhapService
    {
        // Hàm tự viết
        // Hiển thị chi tiết phiếu nhập
        public List<CtPhieuNhap> HienThiCtPhieuNhap(CtPhieuNhap ct)
        {
            List<CtPhieuNhap> data = new List<CtPhieuNhap>();
            string sql = "select MaPhieuNhap,sp.SP_ID,sp.TenSP,DonGiaNhap,SoLuongNhap from CT_PhieuNhap ct, SanPham sp where ct.SP_ID=sp.SP_ID and MaPhieuNhap=@MaPhieuNhap";
            SqlParameter maphieunhap = new SqlParameter("@MaPhieuNhap", ct.MaPhieuNhap);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, maphieunhap);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    ct = new CtPhieuNhap()
                    {
                        MaPhieuNhap = rd[0].ToString(),
                        SP_ID = int.Parse(rd[1].ToString()),
                        TenSP = rd[2].ToString(),
                        DonGiaNhap = float.Parse(rd[3].ToString()),
                        SoLuongNhap = int.Parse(rd[4].ToString()),

                    };
                    data.Add(ct);
                }
            }
            return data;
        }

        // Hàm tự viết
        // Kiểm tra mã phiếu nhậpp
        public bool KiemTraMaPhieuNhap(string ma)
        {
            List<CtPhieuNhap> data = new List<CtPhieuNhap>();
            string sql = "select MaPhieuNhap from CT_PhieuNhap where MaPhieuNhap=@MaPhieuNhap";
            SqlParameter maphieunhap = new SqlParameter("@MaPhieuNhap", ma);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, maphieunhap);
            if (rd.HasRows)
                return true;
            else
                return false;
        }

        // Hàm tự viết
        // Thêm phiếu nhập
        public void Them(CtPhieuNhap ct)
        {
            string sql = "insert into CT_PhieuNhap values(@MaPhieuNhap,@SP_ID,@SoLuongNhap,@DonGiaNhap)";
            SqlParameter maphieunhap = new SqlParameter("@MaPhieuNhap", ct.MaPhieuNhap);
            SqlParameter spid = new SqlParameter("@SP_ID", ct.SP_ID);
            SqlParameter dongianhap = new SqlParameter("@DonGiaNhap", ct.DonGiaNhap);
            SqlParameter soluongnhap = new SqlParameter("@SoLuongNhap", ct.SoLuongNhap);

            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, maphieunhap, spid, dongianhap, soluongnhap);
        }
    }
}
