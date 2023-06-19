using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskImagePlusQueryOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RiskImagePlusQueryOrderInfo : AopObject
    {
        /// <summary>
        /// 订单商品名称
        /// </summary>
        [XmlElement("order_items_name")]
        public string OrderItemsName { get; set; }

        /// <summary>
        /// 订单商品价格，单位：元
        /// </summary>
        [XmlElement("order_items_price")]
        public string OrderItemsPrice { get; set; }

        /// <summary>
        /// 订单商品数量
        /// </summary>
        [XmlElement("order_items_quantity")]
        public string OrderItemsQuantity { get; set; }
    }
}
