using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class DonDH
    {
        private int dondh_id;
        [DataMember]
        public int DonDH_ID
        {
            get { return dondh_id; }
            set { dondh_id = value; }
        }

        private string madondh;
        [DataMember]
        public string MaDonDH
        {
            get { return madondh; }
            set { madondh = value; }
        }


        private string hotenkh;
        [DataMember]
        public string HoTenKH
        {
            get { return hotenkh; }
            set { hotenkh = value; }
        }

        private string diachi;
        [DataMember]
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string dienthoai;
        [DataMember]
        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }

        private string email;
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime ngaydat;
        [DataMember]
        public DateTime NgayDat
        {
            get { return ngaydat; }
            set { ngaydat = value; }
        }

        private DateTime ngaygiao;
        [DataMember]
        public DateTime NgayGiao
        {
            get { return ngaygiao; }
            set { ngaygiao = value; }
        }

        private string ghichu;
        [DataMember]
        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        private string tinhtrang;
        [DataMember]
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

        private float tongtien;
        [DataMember]
        public float TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        private int iD_NguoiDung;
        [DataMember]
        public int ID_NguoiDung
        {
            get { return iD_NguoiDung; }
            set { iD_NguoiDung = value; }
        }
        
    }
}
