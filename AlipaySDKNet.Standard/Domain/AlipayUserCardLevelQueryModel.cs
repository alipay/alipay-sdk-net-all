using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCardLevelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCardLevelQueryModel : AopObject
    {
        /// <summary>
        /// template_id：卡模版id，为alipay.user.card.template.create接口返回的模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
