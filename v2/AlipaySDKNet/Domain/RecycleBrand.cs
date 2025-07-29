using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleBrand Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleBrand : AopObject
    {
        /// <summary>
        /// 品牌code
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌logo链接
        /// </summary>
        [XmlElement("brand_url")]
        public string BrandUrl { get; set; }
    }
}
