using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupBuyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupBuyInfo : AopObject
    {
        /// <summary>
        /// 团ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 拼团状态
        /// </summary>
        [XmlElement("group_status")]
        public string GroupStatus { get; set; }
    }
}
