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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SanPhamService" in both code and config file together.
    public class SanPhamService : ISanPhamService
    {
        //Hàm tự viết
        //Lấy id sản phẩm mới nhât
        public DataSet LaySP_ID()
        {
            string sql = "select top 1 SP_ID from SanPham order by SP_ID desc";
            return SqlDataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text);
        }
        //Hàm tự viết
        //Hiển thị tấc cả sản phẩm
        public List<SanPham> HienThiSanPhamFull()
        {
            List<SanPham> data = new List<SanPham>();
            string sql = "select * from SanPham";
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString(),
                    };
                    data.Add(sp);
                }
            }
            return data;
        }
        //Hàm tự viết
        //Hiển thị 5 sản phẩm mới nhất
        public List<SanPham> HienThiSanPhamMoi()
        {
            List<SanPham> data = new List<SanPham>();
            string sql = "select top 5 * from SanPham order by SP_ID desc";
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString()
                    };
                    data.Add(sp);
                }
            }
            return data;
        }
        //Hàm tự viết
        //Hiển thị các sản phẩm cùng loại với sp hiện tại
        public List<SanPham> HienThiSanPhamCungLoai(SanPham sp)
        {
            List<SanPham> data = new List<SanPham>();
            string sql = "select * from SanPham where NhaSX_ID=@NhaSX_ID except select * from SanPham where SP_ID=@SP_ID";
            SqlParameter sp_id = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlParameter nhasx_id = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, sp_id, nhasx_id);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString()
                    };
                    data.Add(sp);
                }
            }
            return data;
        }
        //Hàm tự viết
        //Hiển thị  sản phẩm theo nhà sản xuất
        public List<SanPham> HienThiSanPhamNhaSX(SanPham sp)
        {
            List<SanPham> data = new List<SanPham>();
            string sql = "select * from SanPham where NhaSX_ID=@NhaSX_ID";
            SqlParameter nhasx_id = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, nhasx_id);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString()
                    };
                    data.Add(sp);
                }
            }
            return data;
        }
        //Hàm tự viết
        //Tìm kiếm sản phẩm theo tên, nhà sản xuất, khoảng giá
        public List<SanPham> TimKiemSanPham(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden)
        {
            List<SanPham> data = new List<SanPham>();
            string sql;
            if (tensp != "")
            {
                sql = string.Format("select * from SanPham where TenSP like '%{0}%'", tensp);
            }
            else
            {
                sql = string.Format("select * from SanPham where NhaSX_ID={0} and (DonGia between {1} and {2})", nhasxid, dongiatu, dongiaden);
            }
            SqlDataReader rd = SqlDataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString()
                    };
                    data.Add(sp);
                }
            }
            return data;
        }
        //Hàm tự viết
        //Hiển thị chi tiết sản phẩm
        public DataSet ChiTietSanPham(SanPham sp)
        {
            string sql;
            TonKho tonkho = new TonKho();
            TonKhoService dal_tonkho = new TonKhoService();

            tonkho.SP_ID = sp.SP_ID;
            List<TonKho> list = dal_tonkho.TimKiemTonKho_SPID(tonkho);
            if (list.Count > 0)
            {
                sql = "select sp.SP_ID,TenSP,sp.NhaSX_ID,TenNhaSX,CPU,RAM,HDD,BaoHanh,Hinh,DonGia,MoTa,SoLuongTon,ThoiGian"
                            + " from SanPham sp, NhaSX nsx, (select top 1 * from TonKho where SP_ID=@SP_ID order by ThoiGian desc) as tk"
                            + " where sp.NhaSX_ID = nsx.NhaSX_ID and sp.SP_ID=tk.SP_ID";
            }
            else
            {
                sql = "select sp.SP_ID,TenSP,sp.NhaSX_ID,TenNhaSX,CPU,RAM,HDD,BaoHanh,Hinh,DonGia,MoTa,SoLuongTon=0"
                            + " from SanPham sp, NhaSX nsx"
                            + " where sp.NhaSX_ID = nsx.NhaSX_ID and SP_ID=@SP_ID";
            }
            SqlParameter sp_id = new SqlParameter("@SP_ID", sp.SP_ID);
            DataSet ds = SqlDataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, sp_id);
            return ds;
        }
        //Hàm tự viết
        //nhập sản phẩm
        public DataSet ThongTinNhapSP(PhieuNhap pn)
        {
            CtPhieuNhapService dal = new CtPhieuNhapService();
            string mapn = pn.MaPhieuNhap.ToString();
            string sql = "";
            bool kt = dal.KiemTraMaPhieuNhap(mapn);
            if (kt == true)
            {
                sql = string.Format("select SP_ID,TenSP,NhaSX_ID from SanPham where NhaSX_ID=@NhaSX_ID"
                        + " and SP_ID not in"
                            + " (select ct_pn.SP_ID from SanPham sp, PhieuNhap pn, CT_PhieuNhap ct_pn"
                            + " where pn.MaPhieuNhap=ct_pn.MaPhieuNhap and ct_pn.SP_ID=sp.SP_ID"
                            + " and ct_pn.MaPhieuNhap='{0}')", mapn);
            }
            else
            {
                sql = "select SP_ID,TenSP,NhaSX_ID from SanPham where NhaSX_ID=@NhaSX_ID";
            }
            SqlParameter nhasxid = new SqlParameter("@NhaSX_ID", pn.NhaSX_ID);
            return SqlDataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, nhasxid);
        }
        //Hàm tự viết
        //Thêm sản phẩm mới
        public void Them(SanPham sp)
        {
            string sql = "insert into SanPham values(@TenSP,@NhaSX_ID,@CPU,@RAM,@HDD,@BaoHanh,@DonGia,@Hinh,@MoTa)";
            SqlParameter tensp = new SqlParameter("@TenSP", sp.TenSP);
            SqlParameter nhasxid = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlParameter cpu = new SqlParameter("@CPU", sp.CPU);
            SqlParameter ram = new SqlParameter("@RAM", sp.RAM);
            SqlParameter hdd = new SqlParameter("@HDD", sp.HDD);
            SqlParameter baohanh = new SqlParameter("@BaoHanh", sp.BaoHanh);
            SqlParameter dongia = new SqlParameter("@DonGia", sp.DonGia);
            SqlParameter hinh = new SqlParameter("@Hinh", sp.Hinh);
            SqlParameter mota = new SqlParameter("@MoTa", sp.MoTa);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, tensp, nhasxid, cpu, ram, hdd, baohanh, dongia, hinh, mota);    
        }
        //Hàm tự viết
        //Sửa sản phẩm
        public void Sua(SanPham sp)
        {
            string sql = "update SanPham set TenSP=@TenSP,NhaSX_ID=@NhaSX_ID,CPU=@CPU,RAM=@RAM,HDD=@HDD,BaoHanh=@BaoHanh,DonGia=@DonGia,Hinh=@Hinh,MoTa=@MoTa where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlParameter tensp = new SqlParameter("@TenSP", sp.TenSP);
            SqlParameter nhasxid = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlParameter cpu = new SqlParameter("@CPU", sp.CPU);
            SqlParameter ram = new SqlParameter("@RAM", sp.RAM);
            SqlParameter hdd = new SqlParameter("@HDD", sp.HDD);
            SqlParameter baohanh = new SqlParameter("@BaoHanh", sp.BaoHanh);
            SqlParameter dongia = new SqlParameter("@DonGia", sp.DonGia);
            SqlParameter hinh = new SqlParameter("@Hinh", sp.Hinh);
            SqlParameter mota = new SqlParameter("@MoTa", sp.MoTa);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, spid, tensp, nhasxid, cpu, ram, hdd, baohanh, dongia, hinh, mota);
        }
        //Hàm tự viết
        //Sửa đơn giá sản phẩm
        public void Sua_DonGia(SanPham sp)
        {
            string sql = "update SanPham set DonGia=@DonGia where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlParameter dongia = new SqlParameter("@DonGia", sp.DonGia);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, spid, dongia);
        }
        //Hàm tự viết
        //Xóa sản phẩm
        public void Xoa(SanPham sp)
        {
            string sql = "delete SanPham where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlDataProvider.ExecuteNonQuery(sql, CommandType.Text, spid);
        }       
    }
}
