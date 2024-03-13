using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageTemplateApplyResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageTemplateApplyResponse : AopResponse
    {
        /// <summary>
        /// 短信模板Code。人工审核通过后，该模板才能用于发送短信。
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
