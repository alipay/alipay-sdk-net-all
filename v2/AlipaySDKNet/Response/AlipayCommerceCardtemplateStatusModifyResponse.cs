using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCardtemplateStatusModifyResponse.
    /// </summary>
    public class AlipayCommerceCardtemplateStatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 卡模版ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }
    }
}
