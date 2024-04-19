using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionOrderCreateResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionOrderCreateResponse : AopResponse
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
        /// 冻资单订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 请求参数中的外部商户订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
