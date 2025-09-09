using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemIdStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemIdStatusInfo : AopObject
    {
        /// <summary>
        /// 商品app方编码, 用于标识门店内唯一一个商品
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 操作类型, 0上架, -1下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
