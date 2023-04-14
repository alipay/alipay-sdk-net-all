using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeInformation Data Structure.
    /// </summary>
    [Serializable]
    public class TradeInformation : AopObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 是否LC订单，Y - 是 /  N - 否，不传默认为N
        /// </summary>
        [XmlElement("is_l_c_order")]
        public string IsLCOrder { get; set; }

        /// <summary>
        /// 一达通是否收到信用证正本，是否LC订单，Y - 是 / N - 否
        /// </summary>
        [XmlElement("is_l_c_received_by_one_touch")]
        public string IsLCReceivedByOneTouch { get; set; }

        /// <summary>
        /// 订单金额，币种最小单位，如果是CNY，则单位分
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
