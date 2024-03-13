using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 冻资单地址
        /// </summary>
        [XmlElement("alipay_order_detail_url")]
        public string AlipayOrderDetailUrl { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单金额，整数，单位分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 默认CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 冻资单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部请求下单时传入订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 外部商户订单
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 已缴金额，整数，单位分
        /// </summary>
        [XmlElement("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// 待缴金额 整数，(单位：分)
        /// </summary>
        [XmlElement("unpaid_amount")]
        public string UnpaidAmount { get; set; }
    }
}
