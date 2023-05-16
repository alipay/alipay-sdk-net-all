using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcCardapplyNotifyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcCardapplyNotifyResponse : AopResponse
    {
        /// <summary>
        /// 通知结果，返回支付宝是否接收成功
        /// </summary>
        [XmlElement("notify_result")]
        public bool NotifyResult { get; set; }
    }
}
