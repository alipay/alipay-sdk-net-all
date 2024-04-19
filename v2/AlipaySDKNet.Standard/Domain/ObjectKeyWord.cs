using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjectKeyWord Data Structure.
    /// </summary>
    [Serializable]
    public class ObjectKeyWord : AopObject
    {
        /// <summary>
        /// 大类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 物体标签
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 置信度
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
