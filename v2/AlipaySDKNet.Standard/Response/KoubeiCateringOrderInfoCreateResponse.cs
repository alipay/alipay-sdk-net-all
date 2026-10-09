using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoCreateResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 口碑的订单号（唯一主键），和pos本地订单号一一对应
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否需要重试，true-需要重试，false-不需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
