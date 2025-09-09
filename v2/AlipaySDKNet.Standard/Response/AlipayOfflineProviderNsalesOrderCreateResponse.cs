using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNsalesOrderCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderNsalesOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 绝对过期时间
        /// </summary>
        [XmlElement("express_timeout")]
        public string ExpressTimeout { get; set; }

        /// <summary>
        /// 用户扫码下单链接
        /// </summary>
        [XmlElement("order_url")]
        public string OrderUrl { get; set; }

        /// <summary>
        /// 卖进订单id
        /// </summary>
        [XmlElement("sales_entry_order_id")]
        public string SalesEntryOrderId { get; set; }

        /// <summary>
        /// 卖进预订单id
        /// </summary>
        [XmlElement("sales_entry_pre_order_id")]
        public string SalesEntryPreOrderId { get; set; }
    }
}
