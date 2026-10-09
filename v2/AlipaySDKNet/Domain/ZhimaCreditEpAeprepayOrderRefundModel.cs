using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAeprepayOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAeprepayOrderRefundModel : AopObject
    {
        /// <summary>
        /// 退款垫付金额。币种最小单位，如人民币：分
        /// </summary>
        [XmlElement("advance_amount")]
        public string AdvanceAmount { get; set; }

        /// <summary>
        /// 退款垫付币种
        /// </summary>
        [XmlElement("advance_currency")]
        public string AdvanceCurrency { get; set; }

        /// <summary>
        /// 扩展预留
        /// </summary>
        [XmlElement("ext_param")]
        public ZmEpAePrepayExtParam ExtParam { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 审核单创建时间戳
        /// </summary>
        [XmlElement("order_time_millis")]
        public string OrderTimeMillis { get; set; }

        /// <summary>
        /// 退款金额。币种最小单位，如人民币：分
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 卖家余额退款金额。币种最小单位，如人民币：分
        /// </summary>
        [XmlElement("refund_balance_amount")]
        public string RefundBalanceAmount { get; set; }

        /// <summary>
        /// 退款币种
        /// </summary>
        [XmlElement("refund_currency")]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 商家登陆id
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 子订单id
        /// </summary>
        [XmlElement("son_order_id")]
        public string SonOrderId { get; set; }

        /// <summary>
        /// 退款的结算单id
        /// </summary>
        [XmlElement("sub_out_order_id")]
        public string SubOutOrderId { get; set; }
    }
}
