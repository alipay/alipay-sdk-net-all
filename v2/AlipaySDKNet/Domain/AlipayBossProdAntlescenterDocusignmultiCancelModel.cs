using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignmultiCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterDocusignmultiCancelModel : AopObject
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 操作方工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 取消签署原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 签署id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
