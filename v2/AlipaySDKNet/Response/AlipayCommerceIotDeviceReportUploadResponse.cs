using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceReportUploadResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceReportUploadResponse : AopResponse
    {
        /// <summary>
        /// 是否上传成功
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
