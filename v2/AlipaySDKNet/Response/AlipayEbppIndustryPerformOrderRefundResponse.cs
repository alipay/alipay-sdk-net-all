using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderRefundResponse.
    /// </summary>
    public class AlipayEbppIndustryPerformOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 账单金额(订单原价，单位元)
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 行业业务受理平台分配的机构编码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 用户实际支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 行业业务受理平台分配的业务服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
