using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemIdStatusSuccessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemIdStatusSuccessInfo : AopObject
    {
        /// <summary>
        /// 平台方商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
