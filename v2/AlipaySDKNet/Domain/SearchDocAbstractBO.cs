using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchDocAbstractBO Data Structure.
    /// </summary>
    [Serializable]
    public class SearchDocAbstractBO : AopObject
    {
        /// <summary>
        /// 离线摘要
        /// </summary>
        [XmlElement("abstract_offline")]
        public string AbstractOffline { get; set; }

        /// <summary>
        /// 在线摘要
        /// </summary>
        [XmlElement("abstract_online")]
        public string AbstractOnline { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [XmlElement("snippet")]
        public string Snippet { get; set; }
    }
}
