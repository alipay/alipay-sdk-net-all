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
        /// 商户名称
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
