using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzQueryContext Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzQueryContext : AopObject
    {
        /// <summary>
        /// 查询策略，可选经过缓存 CACHED，或不经过缓存 DIRECT
        /// </summary>
        [XmlElement("query_strategy")]
        public string QueryStrategy { get; set; }

        /// <summary>
        /// 用于区分访问者身份
        /// </summary>
        [XmlElement("query_token")]
        public string QueryToken { get; set; }
    }
}
