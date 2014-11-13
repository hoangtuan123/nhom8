using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class PhieuNhap
    {
        private int phieunhap_id;
        [DataMember]
        public int PhieuNhap_ID
        {
            get { return phieunhap_id; }
            set { phieunhap_id = value; }
        }

        private string maphieunhap;
        [DataMember]
        public string MaPhieuNhap
        {
            get { return maphieunhap; }
            set { maphieunhap = value; }
        }


        private int nhasx_id;
        [DataMember]
        public int NhaSX_ID
        {
            get { return nhasx_id; }
            set { nhasx_id = value; }
        }

        private DateTime ngaynhap;
        [DataMember]
        public DateTime NgayNhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }

        private string tennsx;
        [DataMember]
        public string TenNhaSX
        {
            get { return tennsx; }
            set { tennsx = value; }
        }

        private float tongtien;
        [DataMember]
        public float TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        
    }
}
