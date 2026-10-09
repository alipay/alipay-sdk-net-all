using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSiteInfo : AopObject
    {
        /// <summary>
        /// 二级商户网站名称
        /// </summary>
        [XmlElement("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 二级商户网站类型
        /// </summary>
        [XmlElement("site_type")]
        public string SiteType { get; set; }

        /// <summary>
        /// 二级商户网址URL
        /// </summary>
        [XmlElement("site_url")]
        public string SiteUrl { get; set; }
    }
}
