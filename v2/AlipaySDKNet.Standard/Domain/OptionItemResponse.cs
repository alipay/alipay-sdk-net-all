using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OptionItemResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OptionItemResponse : AopObject
    {
        /// <summary>
        /// 问题编号
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 问题可选项内容
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
