using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INguoiDungService" in both code and config file together.
    [ServiceContract]
    public interface INguoiDungService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        void Them(NguoiDung ng);
        [OperationContract]
        Boolean DangNhap(string tendangnhap, string matkhau);
        [OperationContract]
        DataSet ThongTinNguoiDung(string tenDangNhap, string matKhau);
        [OperationContract]
        DataSet ThongTinNguoiDung_ID(int ID);
        [OperationContract]
        bool CapNhatThongTin(NguoiDung ng,int ID);
        [OperationContract]
        bool DoiMatKhau(string MatKhau, int ID);
        [OperationContract]
        bool KT_MatKhau(string MatKhau,int ID);
        [OperationContract]
        bool IsEmail(string Email);
        [OperationContract]
        bool IsTenDangNhap(string TenDangNhap);


    }
}
