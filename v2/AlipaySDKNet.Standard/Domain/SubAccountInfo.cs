using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountInfo : AopObject
    {
        /// <summary>
        /// 来源于不同平台的商户号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 子商户号类型
        /// </summary>
        [XmlElement("sub_merchant_type")]
        public string SubMerchantType { get; set; }
    }
}
