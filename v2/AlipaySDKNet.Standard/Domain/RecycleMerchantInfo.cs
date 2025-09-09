using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户logo链接
        /// </summary>
        [XmlElement("merchant_logo_url")]
        public string MerchantLogoUrl { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
    }
}
