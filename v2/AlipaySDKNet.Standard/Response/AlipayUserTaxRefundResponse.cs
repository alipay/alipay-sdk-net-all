using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserTaxRefundResponse.
    /// </summary>
    public class AlipayUserTaxRefundResponse : AopResponse
    {
        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
