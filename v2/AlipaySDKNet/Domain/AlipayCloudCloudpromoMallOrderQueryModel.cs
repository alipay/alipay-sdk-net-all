using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallOrderQueryModel : AopObject
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
