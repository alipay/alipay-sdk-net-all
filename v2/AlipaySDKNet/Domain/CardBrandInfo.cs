using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardBrandInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardBrandInfo : AopObject
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 首字母
        /// </summary>
        [XmlElement("firstletter")]
        public string Firstletter { get; set; }

        /// <summary>
        /// 品牌logo图片链接
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
