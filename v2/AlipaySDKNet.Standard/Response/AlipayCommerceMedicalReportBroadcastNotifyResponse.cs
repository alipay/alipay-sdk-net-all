using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalReportBroadcastNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalReportBroadcastNotifyResponse : AopResponse
    {
        /// <summary>
        /// 通知
        /// </summary>
        [XmlElement("notify")]
        public string Notify { get; set; }
    }
}
