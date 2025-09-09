using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WithholdTradeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WithholdTradeDTO : AopObject
    {
        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 当前交易所扣款的金额
        /// </summary>
        [XmlElement("deduct")]
        public string Deduct { get; set; }

        /// <summary>
        /// 扣款金额，单位为分 当前字段已废弃(字段类型变更，不再使用Number)
        /// </summary>
        [XmlElement("deduct_amount")]
        public long DeductAmount { get; set; }

        /// <summary>
        /// 扣款成功时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
