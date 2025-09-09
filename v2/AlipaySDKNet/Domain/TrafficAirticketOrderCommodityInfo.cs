using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderCommodityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderCommodityInfo : AopObject
    {
        /// <summary>
        /// 商品唯一编号，建议按照如下规则： 1. 机票类：传入机票票号 2. 其他辅营类：商家自定义的uuid
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称，如： 1. 机票类：「飞猪机票」 2. 其他辅营类（商户自定义，或提前跟支付宝约定）：「接送机服务服务」、「航班延误险」
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量，单位：个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品状态，默认无需传入，如需使用请与支付宝约定
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品状态描述，默认无需传入，如需使用请与支付宝约定
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 商品总价，币种：人民币，单位：元
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 商品单价，币种：人民币，单位：元
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
