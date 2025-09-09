using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceRelationPair Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceRelationPair : AopObject
    {
        /// <summary>
        /// 设备绑定的SMID或PID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 绑定的商户类型,标识merchant_id给的pid还是smid
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 设备的sn号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
