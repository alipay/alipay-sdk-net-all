using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwTreeModifyModel : AopObject
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

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
