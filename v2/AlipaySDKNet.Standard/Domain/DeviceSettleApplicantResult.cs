using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceSettleApplicantResult Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceSettleApplicantResult : AopObject
    {
        /// <summary>
        /// 是需要设备厂商录入的sn号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
