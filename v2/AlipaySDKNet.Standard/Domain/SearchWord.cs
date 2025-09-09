using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchWord Data Structure.
    /// </summary>
    [Serializable]
    public class SearchWord : AopObject
    {
        /// <summary>
        /// 词文本
        /// </summary>
        [XmlElement("bidword")]
        public string Bidword { get; set; }

        /// <summary>
        /// 词匹配规则，如果未传则默认为宽泛匹配BROAD_MATCH
        /// </summary>
        [XmlElement("match_type")]
        public string MatchType { get; set; }

        /// <summary>
        /// 词出价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
