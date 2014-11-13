using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class SanPham
    {
        private int sp_id;
        [DataMember]
        public int SP_ID
        {
            get { return sp_id; }
            set { sp_id = value; }
        }

        private string tensp;
        [DataMember]
        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; }
        }

        private int nhasx_id;
        [DataMember]
        public int NhaSX_ID
        {
            get { return nhasx_id; }
            set { nhasx_id = value; }
        }

        private string cpu;
        [DataMember]
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }

        private string ram;
        [DataMember]
        public string RAM
        {
            get { return ram; }
            set { ram = value; }
        }

        private string hdd;
        [DataMember]
        public string HDD
        {
            get { return hdd; }
            set { hdd = value; }
        }

        private string baohanh;
        [DataMember]
        public string BaoHanh
        {
            get { return baohanh; }
            set { baohanh = value; }
        }

        private float dongia;
        [DataMember]
        public float DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        private string hinh;
        [DataMember]
        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }

        private string mota;
        [DataMember]
        public string MoTa
        {
            get { return mota; }
            set { mota = value; }
        }

    }
}
