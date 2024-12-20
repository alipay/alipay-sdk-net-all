using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditGoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreditGoInfo : AopObject
    {
        /// <summary>
        /// 芝麻任务权益信息
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 芝麻任务信息
        /// </summary>
        [XmlElement("task")]
        public string Task { get; set; }

        /// <summary>
        /// 芝麻任务模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
