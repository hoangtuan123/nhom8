
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CtDonDHService" in both code and config file together.
    public class CtDonDHService : ICtDonDHService
    {
        // Hàm tự viết
        // Hiển thị CT_đơn hàng trong frm đơn hàng phần winform
        public List<CtDonDH> HienThiCtDonDH(CtDonDH ct)
        {
            List<CtDonDH> data = new List<CtDonDH>();
            string sql = "select MaDonDH,sp.SP_ID,sp.TenSP,DonGiaDat,SoLuongDat from CT_DonDH ct, SanPham sp where ct.SP_ID=sp.SP_ID and MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ct.MaDonDH);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, madondh);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    ct = new CtDonDH()
                    {
                        MaDonDH = rd[0].ToString(),
                        SP_ID = int.Parse(rd[1].ToString()),
                        DonGiaDat = float.Parse(rd[3].ToString()),
                        SoLuongDat = int.Parse(rd[4].ToString()),
                        TenSP = rd[2].ToString()
                    };
                    data.Add(ct);
                }
            }
            return data;
        }
        // Hàm tự viết
        // Thêm chi tiết đơn hàng vào csdl trong phần webform đặt hàng
        public void Them(CtDonDH ct)
        {
            string sql = "insert into CT_DonDH values(@MaDonDH,@SP_ID,@DonGiaDat,@SoLuongDat)";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ct.MaDonDH);
            SqlParameter spid = new SqlParameter("@SP_ID", ct.SP_ID);
            SqlParameter dongiadat = new SqlParameter("@DonGiaDat", ct.DonGiaDat);
            SqlParameter soluongdat = new SqlParameter("@SoLuongDat", ct.SoLuongDat);

            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, madondh, spid, dongiadat, soluongdat);
        }
        // Hàm tự viết
        // Xóa chi tiết đơn hàng
        public void Xoa(CtDonDH ct)
        {
            string sql = "Delete CT_DonDH where MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ct.MaDonDH);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, madondh);
        }
    }
}
