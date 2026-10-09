using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskAgreementSignResponse.
    /// </summary>
    public class AlipayCommerceYuntaskAgreementSignResponse : AopResponse
    {
        /// <summary>
        /// 响应为表单格式，可嵌入页面，具体以返回的结果为准
        /// </summary>
        [XmlElement("form_data")]
        public string FormData { get; set; }
    }
}
