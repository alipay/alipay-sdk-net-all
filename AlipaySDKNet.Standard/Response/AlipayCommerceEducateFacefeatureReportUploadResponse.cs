using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureReportUploadResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureReportUploadResponse : AopResponse
    {
        /// <summary>
        /// 上报成功失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
