using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentOrderCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryRentOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 租房平台请求支付时的预创单编号
        /// </summary>
        [XmlElement("biz_seq")]
        public string BizSeq { get; set; }

        /// <summary>
        /// 当前租房支付单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 租房平台跳转支付宝做组合支付的跳转地址
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }
    }
}
