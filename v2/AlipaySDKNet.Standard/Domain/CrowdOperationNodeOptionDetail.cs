using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdOperationNodeOptionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdOperationNodeOptionDetail : AopObject
    {
        /// <summary>
        /// 选项值展示描述文案
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 选项值ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 父节点值ID
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 父节点选项值
        /// </summary>
        [XmlElement("parent_value")]
        public string ParentValue { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 选项值展示文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 选项值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
