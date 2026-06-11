using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrdervoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrdervoucherQueryModel : AopObject
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
