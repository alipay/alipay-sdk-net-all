using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCashlessticketTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessticketTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 票模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
