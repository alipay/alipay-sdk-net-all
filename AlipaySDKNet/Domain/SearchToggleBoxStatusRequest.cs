using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchToggleBoxStatusRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchToggleBoxStatusRequest : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 需切换的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
