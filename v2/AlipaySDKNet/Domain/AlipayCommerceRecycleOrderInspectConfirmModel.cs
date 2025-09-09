using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderInspectConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderInspectConfirmModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 回收订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单的质检金额，币种：人民币，单位：元
        /// </summary>
        [XmlElement("order_inspect_price")]
        public string OrderInspectPrice { get; set; }

        /// <summary>
        /// 商家的订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 子单质检确认列表
        /// </summary>
        [XmlArray("sub_order_inspect_confirm_list")]
        [XmlArrayItem("recycle_sub_order_inspect_confirm_v_o")]
        public List<RecycleSubOrderInspectConfirmVO> SubOrderInspectConfirmList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
