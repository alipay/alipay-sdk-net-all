using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsDeviceTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsDeviceTransferModel : AopObject
    {
        /// <summary>
        /// 设备要转入的isv的pid
        /// </summary>
        [XmlElement("new_owner_pid")]
        public string NewOwnerPid { get; set; }

        /// <summary>
        /// 需要转移设备的sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
