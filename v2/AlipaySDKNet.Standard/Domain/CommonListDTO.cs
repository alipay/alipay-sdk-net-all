using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CommonListDTO : AopObject
    {
        /// <summary>
        /// 中文描述
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 值的编码。非可度量参数。不是错误码。
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
