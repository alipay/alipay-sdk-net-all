using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderDiscountInfo : AopObject
    {
        /// <summary>
        /// 优惠项目价格，币种：人民币，单位：元
        /// </summary>
        [XmlElement("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 优惠项目描述
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 优惠项目id，商户侧定义的唯一标识
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 优惠项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
