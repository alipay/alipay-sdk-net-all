using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehOpenBrandDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VehOpenBrandDTO : AopObject
    {
        /// <summary>
        /// 品牌成立年份
        /// </summary>
        [XmlElement("brand_established_year")]
        public string BrandEstablishedYear { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌logo图片URL
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌英文名称
        /// </summary>
        [XmlElement("brand_name_en")]
        public string BrandNameEn { get; set; }

        /// <summary>
        /// 品牌国别
        /// </summary>
        [XmlElement("brand_origin")]
        public string BrandOrigin { get; set; }

        /// <summary>
        /// 品牌名称首字母
        /// </summary>
        [XmlElement("initial")]
        public string Initial { get; set; }
    }
}
