using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalesData Data Structure.
    /// </summary>
    [Serializable]
    public class SalesData : AopObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 当日销售订单数
        /// </summary>
        [XmlElement("order_count")]
        public string OrderCount { get; set; }

        /// <summary>
        /// 当日退款订单数
        /// </summary>
        [XmlElement("refund_order_count")]
        public string RefundOrderCount { get; set; }

        /// <summary>
        /// 当日退款金额
        /// </summary>
        [XmlElement("refund_sales_amount")]
        public string RefundSalesAmount { get; set; }

        /// <summary>
        /// 当日销售额
        /// </summary>
        [XmlElement("sales_amount")]
        public string SalesAmount { get; set; }
    }
}
