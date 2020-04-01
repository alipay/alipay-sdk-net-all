using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoDoctemplateSettingurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoDoctemplateSettingurlQueryModel : AopObject
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
