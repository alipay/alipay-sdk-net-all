using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceReceiptSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceReceiptSyncModel : AopObject
    {
        /// <summary>
        /// 订单信息,最大限制10条
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("receipt_simple_order_d_t_o")]
        public List<ReceiptSimpleOrderDTO> OrderList { get; set; }
    }
}
