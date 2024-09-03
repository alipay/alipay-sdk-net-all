using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleInMerchantLicense Data Structure.
    /// </summary>
    [Serializable]
    public class SettleInMerchantLicense : AopObject
    {
        /// <summary>
        /// 商户简称。用于芝麻信用服务开通。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
