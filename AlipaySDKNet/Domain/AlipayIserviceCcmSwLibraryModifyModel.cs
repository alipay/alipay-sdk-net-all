using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwLibraryModifyModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库Id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
