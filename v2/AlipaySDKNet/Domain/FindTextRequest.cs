using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FindTextRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FindTextRequest : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("key_list")]
        [XmlArrayItem("string")]
        public List<string> KeyList { get; set; }

        /// <summary>
        /// 语言代码
        /// </summary>
        [XmlElement("language")]
        public string Language { get; set; }
    }
}
