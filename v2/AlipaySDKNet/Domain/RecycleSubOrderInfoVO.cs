using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSubOrderInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSubOrderInfoVO : AopObject
    {
        /// <summary>
        /// 回收子单号
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 回收的订单状态
        /// </summary>
        [XmlElement("sub_order_status")]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 商家的子单号
        /// </summary>
        [XmlElement("sub_out_order_id")]
        public string SubOutOrderId { get; set; }
    }
}
