using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCardTemplateModifyResponse.
    /// </summary>
    public class AlipayCommerceCardTemplateModifyResponse : AopResponse
    {
        /// <summary>
        /// 卡模版ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
