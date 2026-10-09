using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceQueryByConditionRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceQueryByConditionRequest : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }
    }
}
