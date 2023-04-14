using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzPageCond Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzPageCond : AopObject
    {
        /// <summary>
        /// 分页查询数量，可以理解成 SQL 里的 limit
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 分页查询偏移量，可以理解成 SQL 里的 offset
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }
    }
}
