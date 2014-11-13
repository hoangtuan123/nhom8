using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICtDonDHService" in both code and config file together.
    [ServiceContract]
    public interface ICtDonDHService
    {
        [OperationContract]
        List<CtDonDH> HienThiCtDonDH(CtDonDH ct);
        [OperationContract]
        void Them(CtDonDH ct);
        [OperationContract]
        void Xoa(CtDonDH ct);
    }
}
