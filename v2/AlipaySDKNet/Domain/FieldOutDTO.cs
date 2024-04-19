using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FieldOutDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FieldOutDTO : AopObject
    {
        /// <summary>
        /// 字段编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 字段属性
        /// </summary>
        [XmlElement("props")]
        public PropertyOutDTO Props { get; set; }
    }
}
