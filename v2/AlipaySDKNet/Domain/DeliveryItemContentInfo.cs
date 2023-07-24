using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryItemContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryItemContentInfo : AopObject
    {
        /// <summary>
        /// 支付宝侧商品id。 注意事项：支持状态为“出售中”的商品
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品模版类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
