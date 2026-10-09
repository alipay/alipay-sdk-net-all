using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUpdateByIdSuccessDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUpdateByIdSuccessDTO : AopObject
    {
        /// <summary>
        /// 支付宝内部商品编码ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
