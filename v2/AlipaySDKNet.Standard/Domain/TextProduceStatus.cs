using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextProduceStatus Data Structure.
    /// </summary>
    [Serializable]
    public class TextProduceStatus : AopObject
    {
        /// <summary>
        /// 物品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 是否已经产出 已经产出为true，否则为false
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
