using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NguoiDungService" in both code and config file together.
    public class NguoiDungService : INguoiDungService
    {
        public void DoWork()
        {
        }

        // Hàm tự viết
        // Thêm người dùng (đăng ký)
        public void Them(NguoiDung ng)
        {
            string sql_1;
            sql_1 = "select ID from NguoiDung ORDER BY ID DESC";
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql_1, CommandType.Text);
            if (ds.Tables[0].Rows.Count>0)
            {
                string id_1 = ds.Tables[0].Rows[0]["ID"].ToString();
                ng.ID = int.Parse(id_1) + 1;
            }
            else {
                ng.ID = 0;
            }
               
            string sql = "insert into NguoiDung values(@ID,@Ten,@TenDangNhap,@MatKhau,@Email,@Quyen,@DiaChi,@SoDienThoai)";
            SqlParameter id = new SqlParameter("@ID", ng.ID);
            SqlParameter ten = new SqlParameter("@Ten", ng.Ten);
            SqlParameter tendangnhap = new SqlParameter("@TenDangNhap", ng.TenDangNhap);
            SqlParameter matkhau = new SqlParameter("@MatKhau", ng.MatKhau);
            SqlParameter email = new SqlParameter("@Email", ng.Email);
            SqlParameter quyen = new SqlParameter("@Quyen", ng.Quyen);
            SqlParameter diachi = new SqlParameter("@DiaChi", ng.DiaChi);
            SqlParameter sodienthoai = new SqlParameter("@SoDienThoai", ng.SoDienThoai);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, id, ten, tendangnhap, matkhau, email, quyen, diachi, sodienthoai);
        }
        // Hàm tự viết
        // Kiểm tra thông tin đăng nhập
        public bool DangNhap(string tendangnhap, string matkhau)
        {
            NguoiDung ng = new NguoiDung();
            string sql;
            sql = "select *"
                            + " from NguoiDung"
                            + " where TenDangNhap = @TenDangNhap and MatKhau=@MatKhau";
            SqlParameter tendangnhap_1 = new SqlParameter("@TenDangNhap", tendangnhap);
            SqlParameter matkhau_1 = new SqlParameter("@MatKhau", matkhau);
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, tendangnhap_1, matkhau_1);
            if (ds!=null)
            {
                return true;
            }
            return false;
        }
        // Hàm tự viết
        // lấy thông tin người dùng theo tên đăng nhập và mật khẩu
        public DataSet ThongTinNguoiDung(string tenDangNhap,string matKhau)
        {
            string sql;
            sql = "select *"
                            + " from NguoiDung"
                            + " where TenDangNhap = @TenDangNhap and MatKhau=@MatKhau";
            SqlParameter tendangnhap = new SqlParameter("@TenDangNhap", tenDangNhap);
            SqlParameter matkhau = new SqlParameter("@MatKhau", matKhau);
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, tendangnhap, matkhau);

            return ds;
        }

        // Hàm tự viết
        // lấy thông tin người dùng theo ID
        public DataSet ThongTinNguoiDung_ID(int ID)
        {
            string sql;
            sql = "select *"
                            + " from NguoiDung"
                            + " where ID=@ID";
            SqlParameter id = new SqlParameter("@ID", ID);
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, id);
            return ds;
        }

        // Hàm tự viết
        // Cập nhật lại thông tin người dùng
        public bool CapNhatThongTin(NguoiDung ng,int ID)
        {
            bool flag = true;
            try
            {
                string sql = "update NguoiDung set Ten=@Ten,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,Email=@Email where ID=@ID";
                SqlParameter id = new SqlParameter("@ID", ID);
                SqlParameter hoten = new SqlParameter("@Ten", ng.Ten);
                SqlParameter diachi = new SqlParameter("@DiaChi", ng.DiaChi);
                SqlParameter sodienthoai = new SqlParameter("@SoDienThoai", ng.SoDienThoai);
                SqlParameter email = new SqlParameter("@Email", ng.Email);
                SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, hoten, diachi, sodienthoai, email, id);
                flag = true;
            }
            catch {
                flag = false;
            }
            return flag;
        }

        // Hàm tự viết
        // Cập nhật lại mật khẩu cho người dùng
        public bool DoiMatKhau(string MatKhau, int ID)
        {
            bool flag = true;
            try
            {
                string sql = "update NguoiDung set MatKhau=@MatKhau where ID=@ID";
                SqlParameter id = new SqlParameter("@ID", ID);
                SqlParameter matkhau = new SqlParameter("@MatKhau", MatKhau);
                SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, id, matkhau);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        // Hàm tự viết
        // Kiểm tra mật khẩu thuộc một ID người dùng 
        public bool KT_MatKhau(string MatKhau, int ID)
        {
            string sql;
            sql = "select *"
                            + " from NguoiDung"
                            + " where ID = @ID and MatKhau=@MatKhau";
            SqlParameter matkhau = new SqlParameter("@MatKhau", MatKhau);
            SqlParameter id = new SqlParameter("@ID", ID);
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, id,matkhau);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        // Hàm tự viết
        // Kiểm tra Email có tồn tại không
        public bool IsEmail(string Email)
        {
            bool flag;
            string sql_1 = "select ID from NguoiDung Where Email=@Email";
            SqlParameter email = new SqlParameter("@Email", Email);
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql_1, CommandType.Text, email);
            if (ds.Tables[0].Rows.Count > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        // Hàm tự viết
        // Kiểm tra tên đăng nhập có tồn tại chưa
        public bool IsTenDangNhap(string TenDangNhap)
        {
            bool flag;
            string sql_1 = "select ID from NguoiDung Where TenDangNhap=@TenDangNhap";
            SqlParameter tendangnhap = new SqlParameter("@TenDangNhap", TenDangNhap);
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql_1, CommandType.Text, tendangnhap);
            if (ds.Tables[0].Rows.Count > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
