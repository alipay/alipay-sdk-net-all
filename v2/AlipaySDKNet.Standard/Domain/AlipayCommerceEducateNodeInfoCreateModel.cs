using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateNodeInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateNodeInfoCreateModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 组织节点图片URL地址
        /// </summary>
        [XmlElement("node_logo")]
        public string NodeLogo { get; set; }

        /// <summary>
        /// 组织节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
