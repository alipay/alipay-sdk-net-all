using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageTemplateModifyResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageTemplateModifyResponse : AopResponse
    {
        /// <summary>
        /// 短信模板Code。
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
