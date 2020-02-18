using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingExchangevoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingExchangevoucherTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
