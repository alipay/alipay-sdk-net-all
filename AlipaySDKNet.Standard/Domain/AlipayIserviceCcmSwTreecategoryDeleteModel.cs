using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwTreecategoryDeleteModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
