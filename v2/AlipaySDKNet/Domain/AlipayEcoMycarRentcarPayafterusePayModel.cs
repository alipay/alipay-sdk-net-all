using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarPayafterusePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarPayafterusePayModel : AopObject
    {
        /// <summary>
        /// 扣款金额，单位分
        /// </summary>
        [XmlElement("deduct_amount")]
        public long DeductAmount { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号，注意先享后付扣款只能发起一次。车生活侧通过此字段保证幂等
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 此次扣款的商户侧交易号，通过此字段进行扣款请求幂等控制
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
