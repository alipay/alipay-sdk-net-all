using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReverseOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReverseOrderInfo : AopObject
    {
        /// <summary>
        /// 渠道逆向订单ID
        /// </summary>
        [XmlElement("channel_reverse_order_no")]
        public string ChannelReverseOrderNo { get; set; }

        /// <summary>
        /// 逆向订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("return_item_list")]
        [XmlArrayItem("item_third_party_info")]
        public List<ItemThirdPartyInfo> ReturnItemList { get; set; }
    }
}
