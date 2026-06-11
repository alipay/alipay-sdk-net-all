using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOrderTagInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOrderTagInfoVO : AopObject
    {
        /// <summary>
        /// 标签编码
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        [XmlElement("tag_type")]
        public string TagType { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
