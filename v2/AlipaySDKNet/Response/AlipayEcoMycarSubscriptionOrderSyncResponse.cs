using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarSubscriptionOrderSyncResponse.
    /// </summary>
    public class AlipayEcoMycarSubscriptionOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 车生活订单号，在首次同步订单时生成并返回
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
