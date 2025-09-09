using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderCloseModel : AopObject
    {
        /// <summary>
        /// 关闭的原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 回收的订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家的订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 子单关闭信息
        /// </summary>
        [XmlArray("sub_order_close_list")]
        [XmlArrayItem("recycle_sub_order_close_v_o")]
        public List<RecycleSubOrderCloseVO> SubOrderCloseList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
