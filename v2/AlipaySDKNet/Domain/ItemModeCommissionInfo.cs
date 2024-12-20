using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemModeCommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemModeCommissionInfo : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 抽佣比例，无单位。如0.0400表示4%的抽佣比例。
        /// </summary>
        [XmlElement("item_rate")]
        public string ItemRate { get; set; }
    }
}
