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
