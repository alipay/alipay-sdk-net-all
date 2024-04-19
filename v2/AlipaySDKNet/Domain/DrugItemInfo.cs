using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrugItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DrugItemInfo : AopObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 机构药品码
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
