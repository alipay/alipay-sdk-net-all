using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBrandBoxRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBrandBoxRequest : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌box工单id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
