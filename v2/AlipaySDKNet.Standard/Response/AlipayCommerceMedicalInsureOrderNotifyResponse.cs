using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsureOrderNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsureOrderNotifyResponse : AopResponse
    {
        /// <summary>
        /// 通知描述
        /// </summary>
        [XmlElement("notify_result")]
        public string NotifyResult { get; set; }
    }
}
