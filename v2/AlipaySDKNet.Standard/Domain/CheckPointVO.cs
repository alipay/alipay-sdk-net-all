using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckPointVO Data Structure.
    /// </summary>
    [Serializable]
    public class CheckPointVO : AopObject
    {
        /// <summary>
        /// 检查点是否通过
        /// </summary>
        [XmlElement("is_pass")]
        public bool IsPass { get; set; }

        /// <summary>
        /// 检查点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
