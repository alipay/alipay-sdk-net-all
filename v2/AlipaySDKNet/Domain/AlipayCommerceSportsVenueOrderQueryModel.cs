using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVenueOrderQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }
    }
}
