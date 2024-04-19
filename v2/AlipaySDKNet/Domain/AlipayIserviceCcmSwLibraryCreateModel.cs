using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwLibraryCreateModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库对应的类目树名称，与treeId不可同时为空
        /// </summary>
        [XmlElement("instance_code")]
        public string InstanceCode { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 知识库对应的类目树Id，与instanceCode不可同时为空
        /// </summary>
        [XmlElement("tree_id")]
        public long TreeId { get; set; }
    }
}
