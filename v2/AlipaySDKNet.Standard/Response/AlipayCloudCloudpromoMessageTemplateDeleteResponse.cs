using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageTemplateDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageTemplateDeleteResponse : AopResponse
    {
        /// <summary>
        /// 短信模板Code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
