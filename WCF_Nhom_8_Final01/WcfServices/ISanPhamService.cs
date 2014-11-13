using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;


namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISanPhamService" in both code and config file together.
    [ServiceContract]
    public interface ISanPhamService
    {             
        [OperationContract]
        DataSet LaySP_ID();
        [OperationContract]
        List<SanPham> HienThiSanPhamFull();
        [OperationContract]
        List<SanPham> HienThiSanPhamMoi();
        [OperationContract]
        List<SanPham> HienThiSanPhamCungLoai(SanPham sp);
        [OperationContract]
        List<SanPham> HienThiSanPhamNhaSX(SanPham sp);
        [OperationContract]
        List<SanPham> TimKiemSanPham(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden);
        [OperationContract]
        DataSet ChiTietSanPham(SanPham sp);
        [OperationContract]
        DataSet ThongTinNhapSP(PhieuNhap pn);
        [OperationContract]
        void Them(SanPham sp);
        [OperationContract]
        void Sua(SanPham sp);
        [OperationContract]
        void Sua_DonGia(SanPham sp);
        [OperationContract]
        void Xoa(SanPham sp);
    }
}
