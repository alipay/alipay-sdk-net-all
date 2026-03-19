using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderSettleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderSettleInfoDTO : AopObject
    {
        /// <summary>
        /// 租赁订单支付外部请求号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 结算账号，仅采购结算有
        /// </summary>
        [XmlElement("settle_target")]
        public RentOrderSettleTargetDTO SettleTarget { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
