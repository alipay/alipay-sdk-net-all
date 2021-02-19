using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwTreeGetModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
