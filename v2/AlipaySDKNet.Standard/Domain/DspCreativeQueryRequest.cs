using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DspCreativeQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class DspCreativeQueryRequest : AopObject
    {
        /// <summary>
        /// 创意id
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 模版id，和样式关联
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
