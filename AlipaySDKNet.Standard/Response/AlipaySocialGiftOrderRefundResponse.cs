using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialGiftOrderRefundResponse.
    /// </summary>
    public class AlipaySocialGiftOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 本次操作的订单id，与该接口入参order_id一致
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
