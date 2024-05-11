using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarMerchantOrderSyncResponse.
    /// </summary>
    public class AlipayEcoMycarMerchantOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 车生活订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
