using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DarwinParameter Data Structure.
    /// </summary>
    [Serializable]
    public class DarwinParameter : AopObject
    {
        /// <summary>
        /// 达尔文实验参数
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 达尔文实验参数值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
