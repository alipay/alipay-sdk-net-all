using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class CommonKeyword : AopObject
    {
        /// <summary>
        /// 回传的值对应的参数名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 回传值对应的参数值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
