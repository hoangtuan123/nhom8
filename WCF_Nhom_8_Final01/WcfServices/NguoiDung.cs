using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [DataContract]
    public class NguoiDung
    {
        private int id;
        private string ten;
        private string tenDangNhap;
        private string matKhau;
        private string email;
        private int quyen;
        private string diaChi;
        private string soDienThoai;
        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        [DataMember]
        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        [DataMember]
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
        [DataMember]
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        [DataMember]
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        
    }
}
