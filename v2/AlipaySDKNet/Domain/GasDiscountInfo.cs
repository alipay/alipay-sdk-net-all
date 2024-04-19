using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GasDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GasDiscountInfo : AopObject
    {
        /// <summary>
        /// 优惠金额 （单位：元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商家优惠id
        /// </summary>
        [XmlElement("discount_id")]
        public string DiscountId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext")]
        public ExtensionMap Ext { get; set; }

        /// <summary>
        /// 优惠名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
