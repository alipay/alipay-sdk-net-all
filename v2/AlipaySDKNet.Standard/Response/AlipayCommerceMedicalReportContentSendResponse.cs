using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalReportContentSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalReportContentSendResponse : AopResponse
    {
        /// <summary>
        /// 返回的数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
