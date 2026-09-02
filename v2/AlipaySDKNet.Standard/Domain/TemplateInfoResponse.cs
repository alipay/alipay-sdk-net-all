using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateInfoResponse : AopObject
    {
        /// <summary>
        /// 适用场景
        /// </summary>
        [XmlElement("scenario_description")]
        public string ScenarioDescription { get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模版名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
