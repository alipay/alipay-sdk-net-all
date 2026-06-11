using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmartphoneVendorsUserIdentity Data Structure.
    /// </summary>
    [Serializable]
    public class SmartphoneVendorsUserIdentity : AopObject
    {
        /// <summary>
        /// 手机厂商用户标识
        /// </summary>
        [XmlElement("user_identification")]
        public string UserIdentification { get; set; }

        /// <summary>
        /// 用于区分传入用户身份标识类型
        /// </summary>
        [XmlElement("vendor_id_type")]
        public string VendorIdType { get; set; }
    }
}
