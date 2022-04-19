using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeRecItem Data Structure.
    /// </summary>
    [Serializable]
    public class ApeRecItem : AopObject
    {
        /// <summary>
        /// 物品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// item的打分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
