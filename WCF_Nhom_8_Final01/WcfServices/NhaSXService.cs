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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NhaSXService" in both code and config file together.
    public class NhaSXService : INhaSXService
    {
        //Hàm tự viết
        //Hiển thị tấc cả nhà sản xuất
        public List<NhaSX> HienThiNhaSX()
        {
            List<NhaSX> data = new List<NhaSX>();
            string sql = "select * from NhaSX";
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    NhaSX nsx = new NhaSX()
                    {
                        NhaSX_ID = int.Parse(rd[0].ToString()),
                        TenNhaSX = rd[1].ToString()
                    };
                    data.Add(nsx);
                }

            }
            return data;
        }
        //Hàm tự viết
        //Thêm nhà sản xuất
        public void Them(NhaSX nsx)
        {
            string sql = "insert into NhaSX values(@TenNhaSX)";
            SqlParameter tennsx = new SqlParameter("@TenNhaSX", nsx.TenNhaSX);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, tennsx);
        }
        //Hàm tự viết
        //Sửa nhà sản xuất
        public void Sua(NhaSX nsx)
        {
            string sql = "update NhaSX set TenNhaSX=@TenNhaSX where NhaSX_ID=@NhaSX_ID";
            SqlParameter nsxid = new SqlParameter("@NhaSX_ID", nsx.NhaSX_ID);
            SqlParameter tennsx = new SqlParameter("@TenNhaSX", nsx.TenNhaSX);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, nsxid, tennsx);
        }
        //Hàm tự viết
        //Xóa nhà sản xuất
        public void Xoa(NhaSX nsx)
        {
            string sql = "delete NhaSX where NhaSX_ID=@NhaSX_ID";
            SqlParameter nsxid = new SqlParameter("@NhaSX_ID", nsx.NhaSX_ID);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, nsxid);
        }
    }
}
