using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandInfos Data Structure.
    /// </summary>
    [Serializable]
    public class BrandInfos : AopObject
    {
        /// <summary>
        /// 品牌对应的品牌box信息
        /// </summary>
        [XmlElement("box_exclusive_info")]
        public SearchBrandBoxInfo BoxExclusiveInfo { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
