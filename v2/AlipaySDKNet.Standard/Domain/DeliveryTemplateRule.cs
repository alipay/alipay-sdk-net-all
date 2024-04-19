using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryTemplateRule Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryTemplateRule : AopObject
    {
        /// <summary>
        /// 指定商家消息区域
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
