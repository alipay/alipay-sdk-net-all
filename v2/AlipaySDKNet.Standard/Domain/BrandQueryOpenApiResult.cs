using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandQueryOpenApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class BrandQueryOpenApiResult : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_no")]
        public string BrandNo { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 品牌方
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }
    }
}
