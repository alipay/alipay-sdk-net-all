using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDiscountPhonePayResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDiscountPhonePayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝业务订单号
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 客服信息
        /// </summary>
        [XmlElement("customer_service_info")]
        public ToBDiscountCustomerServiceInfo CustomerServiceInfo { get; set; }
    }
}
