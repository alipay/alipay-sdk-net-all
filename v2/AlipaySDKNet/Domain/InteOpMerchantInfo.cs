using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 商户联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }
    }
}
