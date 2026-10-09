using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleCompensationInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleCompensationInfoVO : AopObject
    {
        /// <summary>
        /// 赔付支付外部请求号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝服务器主动通知商户服务器里指定的页面http/https路径
        /// </summary>
        [XmlElement("pay_notify_url")]
        public string PayNotifyUrl { get; set; }
    }
}
