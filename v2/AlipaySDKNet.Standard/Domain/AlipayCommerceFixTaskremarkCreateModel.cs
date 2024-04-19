using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFixTaskremarkCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFixTaskremarkCreateModel : AopObject
    {
        /// <summary>
        /// 针对工单的补充备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 添加备注的工单id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
