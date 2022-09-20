using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServeParamInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServeParamInfo : AopObject
    {
        /// <summary>
        /// 参数描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 参数名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 对应参数的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
