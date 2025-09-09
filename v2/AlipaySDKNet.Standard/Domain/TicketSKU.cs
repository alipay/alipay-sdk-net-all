using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketSKU Data Structure.
    /// </summary>
    [Serializable]
    public class TicketSKU : AopObject
    {
        /// <summary>
        /// 票种的唯一ID用于下单
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 票种的类型由客户方针对自己的商品类型进行传递，不进行枚举管控，在页面上透传展示
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 09:00-10:00 这种属于按照天+分时控制余票，DATE是按照天控制余票
        /// </summary>
        [XmlElement("stock_type")]
        public string StockType { get; set; }

        /// <summary>
        /// 用户票种的一些描述信息
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 票种的单价，非必填如果有会显示在票种旁
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
