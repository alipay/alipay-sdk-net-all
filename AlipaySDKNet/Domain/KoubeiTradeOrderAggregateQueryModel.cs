using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiTradeOrderAggregateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeOrderAggregateQueryModel : AopObject
    {
        /// <summary>
        /// 口碑订单号； 注：外部订单号和订单号必须填写一个
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号;  注：外部订单号和订单号必须填写一个
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
