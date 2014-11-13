using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class CtDonDH
    {
        private string madondh;
        [DataMember]
        public string MaDonDH
        {
            get { return madondh; }
            set { madondh = value; }
        }

        private int sp_id;
        [DataMember]
        public int SP_ID
        {
            get { return sp_id; }
            set { sp_id = value; }
        }

        private float dongiadat;
        [DataMember]
        public float DonGiaDat
        {
            get { return dongiadat; }
            set { dongiadat = value; }
        }

        private int soluongdat;
        [DataMember]
        public int SoLuongDat
        {
            get { return soluongdat; }
            set { soluongdat = value; }
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
