using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandResult Data Structure.
    /// </summary>
    [Serializable]
    public class BrandResult : AopObject
    {
        /// <summary>
        /// 已有的品牌的id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 已有品牌的名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
