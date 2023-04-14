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
        /// 开通的托管子户账号
        /// </summary>
        [XmlElement("alipay_account_no")]
        public string AlipayAccountNo { get; set; }

        /// <summary>
        /// 开设的支付宝账号open_id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

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
