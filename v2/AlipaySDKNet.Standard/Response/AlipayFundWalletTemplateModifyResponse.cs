using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletTemplateModifyResponse.
    /// </summary>
    public class AlipayFundWalletTemplateModifyResponse : AopResponse
    {
        /// <summary>
        /// 钱包模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 钱包模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
