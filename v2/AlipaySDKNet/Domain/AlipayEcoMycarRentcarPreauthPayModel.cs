using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarPreauthPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarPreauthPayModel : AopObject
    {
        /// <summary>
        /// 扣款金额，单位分
        /// </summary>
        [XmlElement("deduct_amount")]
        public long DeductAmount { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

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
        /// 扣款的外部交易号，车生活侧通过此字段进行幂等控制，同一笔预授权的多次扣款要使用不同的交易号
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
