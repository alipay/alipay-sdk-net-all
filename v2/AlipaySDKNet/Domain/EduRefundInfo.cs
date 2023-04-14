using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduRefundInfo : AopObject
    {
        /// <summary>
        /// 本次退款是否发生了资金变化。 Y-是 N-否
        /// </summary>
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// isv系统的订单号
        /// </summary>
        [XmlElement("isv_order_no")]
        public string IsvOrderNo { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如部分退款，则此参数必传
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 支付宝返回的退款资金渠道，json格式字符串
        /// </summary>
        [XmlElement("refund_detail_item_list")]
        public string RefundDetailItemList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }
    }
}
