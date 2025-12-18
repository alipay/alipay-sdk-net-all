using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderVoucherConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderVoucherConsultModel : AopObject
    {
        /// <summary>
        /// 回收交易订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
