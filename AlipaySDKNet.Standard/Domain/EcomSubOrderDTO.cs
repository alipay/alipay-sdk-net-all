using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomSubOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomSubOrderDTO : AopObject
    {
        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("buy_amount")]
        public long BuyAmount { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_fee")]
        public long OrderFee { get; set; }

        /// <summary>
        /// 订单id，必填
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [XmlElement("trade_end_time")]
        public string TradeEndTime { get; set; }
    }
}
