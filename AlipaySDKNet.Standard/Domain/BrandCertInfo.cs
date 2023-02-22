using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandCertInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandCertInfo : AopObject
    {
        /// <summary>
        /// 是否完成品牌认证
        /// </summary>
        [XmlElement("brand_cert")]
        public bool BrandCert { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌中文名
        /// </summary>
        [XmlElement("brand_name_cn")]
        public string BrandNameCn { get; set; }

        /// <summary>
        /// 品牌英文名
        /// </summary>
        [XmlElement("brand_name_en")]
        public string BrandNameEn { get; set; }
    }
}
