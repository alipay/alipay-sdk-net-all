using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlbumExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlbumExtInfo : AopObject
    {
        /// <summary>
        /// 该字段为拓展信息中的key值，例如需传入 key=value，该字段放入key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 该字段为拓展信息中的value值，例如有 key=value，该字段放入value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
