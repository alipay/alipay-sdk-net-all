using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransTrusteeshipAccountCreateResponse.
    /// </summary>
    public class AlipayFundTransTrusteeshipAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 开设的支付宝账号user_id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 场景余额模式外标卡信息
        /// </summary>
        [XmlElement("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
