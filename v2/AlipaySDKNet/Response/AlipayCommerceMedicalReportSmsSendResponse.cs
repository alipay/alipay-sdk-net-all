using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalReportSmsSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalReportSmsSendResponse : AopResponse
    {
        /// <summary>
        /// 短信是否发送
        /// </summary>
        [XmlElement("sms_sent")]
        public bool SmsSent { get; set; }
    }
}
