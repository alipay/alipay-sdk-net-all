using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrderRefundResponse.
    /// </summary>
    public class AlipayMarketingActivityOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 购买商家兑换券的营销订单号。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
