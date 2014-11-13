using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class NhaSX
    {
        private int nhasx_id;
        [DataMember]
        public int NhaSX_ID
        {
            get { return nhasx_id; }
            set { nhasx_id = value; }
        }

        private string tennhasx;
        [DataMember]
        public string TenNhaSX
        {
            get { return tennhasx; }
            set { tennhasx = value; }
        }
    }
}
