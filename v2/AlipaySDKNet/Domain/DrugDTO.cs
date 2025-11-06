using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrugDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DrugDTO : AopObject
    {
        /// <summary>
        /// 药品数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 药品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
