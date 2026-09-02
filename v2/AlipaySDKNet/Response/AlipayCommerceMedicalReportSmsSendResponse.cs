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
        /// 分发统一业务号。未传时自动生成。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 短信是否发送
        /// </summary>
        [XmlElement("sms_sent")]
        public bool SmsSent { get; set; }
    }
}
