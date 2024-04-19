using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessOrderCreateResponse.
    /// </summary>
    public class AlipayBusinessOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 订单创建确认营销信息。订单有营销信息时返回该参数。注：promotion_list包含商户券信息与平台营销信息如阿里红包等；use_mode与入参selected_marketing中的use_mode值相同
        /// </summary>
        [XmlElement("confirmed_marketing")]
        public MarketingInfo ConfirmedMarketing { get; set; }

        /// <summary>
        /// 商户外部订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
