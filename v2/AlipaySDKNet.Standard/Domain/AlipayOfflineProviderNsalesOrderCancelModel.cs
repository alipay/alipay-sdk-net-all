using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesOrderCancelModel : AopObject
    {
        /// <summary>
        /// 卖进订单id
        /// </summary>
        [XmlElement("sales_entry_order_id")]
        public string SalesEntryOrderId { get; set; }
    }
}
