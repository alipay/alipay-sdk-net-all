using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwTreecategoryCreateModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        [XmlElement("father_id")]
        public long FatherId { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签。KNOWLEDGE（知识库）；PLATFORM（公有云工作台）；HELP（公有云帮助中心）
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }
    }
}
