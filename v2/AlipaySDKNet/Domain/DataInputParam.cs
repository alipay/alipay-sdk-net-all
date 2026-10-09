using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataInputParam Data Structure.
    /// </summary>
    [Serializable]
    public class DataInputParam : AopObject
    {
        /// <summary>
        /// 字段属性值
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 由蚂蚁定义颁发的字段属性字段
        /// </summary>
        [XmlElement("property")]
        public string Property { get; set; }
    }
}
