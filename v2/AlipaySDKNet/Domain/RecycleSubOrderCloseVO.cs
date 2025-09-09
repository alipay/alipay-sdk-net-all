using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSubOrderCloseVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSubOrderCloseVO : AopObject
    {
        /// <summary>
        /// 关闭订单的原因描述
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 回收的子订单号
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 商家的子订单号
        /// </summary>
        [XmlElement("sub_out_order_id")]
        public string SubOutOrderId { get; set; }
    }
}
