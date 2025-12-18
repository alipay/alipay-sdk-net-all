using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandChainContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandChainContactInfo : AopObject
    {
        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }
    }
}
