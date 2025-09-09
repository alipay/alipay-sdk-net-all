using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TagInfo : AopObject
    {
        /// <summary>
        /// 计算条件表达式
        /// </summary>
        [XmlElement("pre_identity")]
        public string PreIdentity { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("tag_key")]
        public string TagKey { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
