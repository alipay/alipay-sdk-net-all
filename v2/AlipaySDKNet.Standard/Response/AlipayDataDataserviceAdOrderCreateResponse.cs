using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOrderCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 广告投放平台生成的订单ID
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部订单ID
        /// </summary>
        [XmlElement("order_outer_id")]
        public string OrderOuterId { get; set; }
    }
}
