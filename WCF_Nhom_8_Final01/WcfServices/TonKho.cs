using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class TonKho
    {
        private int sp_id;
        [DataMember]
        public int SP_ID
        {
            get { return sp_id; }
            set { sp_id = value; }
        }

        private DateTime thoigian;
        [DataMember]
        public DateTime ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private int soluongton;
        [DataMember]
        public int SoLuongTon
        {
            get { return soluongton; }
            set { soluongton = value; }
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
