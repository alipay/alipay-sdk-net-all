using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPassTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPassTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
