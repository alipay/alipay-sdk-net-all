using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageCond Data Structure.
    /// </summary>
    [Serializable]
    public class PageCond : AopObject
    {
        /// <summary>
        /// 分页查询数量
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 分页查询偏移量
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }
    }
}
