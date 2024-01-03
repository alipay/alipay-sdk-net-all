using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarPreauthpayCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarPreauthpayCloseModel : AopObject
    {
        /// <summary>
        /// 扣款时的外部交易号
        /// </summary>
        [XmlElement("deduct_out_trade_no")]
        public string DeductOutTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 2088000000000000
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
