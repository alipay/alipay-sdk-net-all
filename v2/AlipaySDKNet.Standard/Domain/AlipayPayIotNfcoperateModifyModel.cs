using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayIotNfcoperateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayIotNfcoperateModifyModel : AopObject
    {
        /// <summary>
        /// 活动投放结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 表示计划是否下线
        /// </summary>
        [XmlElement("offline")]
        public bool Offline { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 用于编辑的计划信息
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 活动投放开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
