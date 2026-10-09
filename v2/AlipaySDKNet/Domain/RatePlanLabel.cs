using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RatePlanLabel Data Structure.
    /// </summary>
    [Serializable]
    public class RatePlanLabel : AopObject
    {
        /// <summary>
        /// 标签类别
        /// </summary>
        [XmlElement("label_category")]
        public string LabelCategory { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [XmlElement("label_desc")]
        public string LabelDesc { get; set; }

        /// <summary>
        /// 标签id
        /// </summary>
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }
    }
}
