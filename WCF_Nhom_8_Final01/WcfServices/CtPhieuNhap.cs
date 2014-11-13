using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class CtPhieuNhap
    {
        private string maphieunhap;
        [DataMember]
        public string MaPhieuNhap
        {
            get { return maphieunhap; }
            set { maphieunhap = value; }
        }

        private int sp_id;
        [DataMember]
        public int SP_ID
        {
            get { return sp_id; }
            set { sp_id = value; }
        }

        private int soluongnhap;
        [DataMember]
        public int SoLuongNhap
        {
            get { return soluongnhap; }
            set { soluongnhap = value; }
        }

        private float dongianhap;
        [DataMember]
        public float DonGiaNhap
        {
            get { return dongianhap; }
            set { dongianhap = value; }
        }

        private string tensp;
        [DataMember]
        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; }
        }
    }
}
