using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduPlanInstanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduPlanInstanceInfo : AopObject
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("plan_instance_no")]
        public string PlanInstanceNo { get; set; }

        /// <summary>
        /// 任务状态：0-初始化；1-待打款；2-打款成功；4-待退款；5-退款成功
        /// </summary>
        [XmlElement("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        /// 任务序号
        /// </summary>
        [XmlElement("serial")]
        public long Serial { get; set; }
    }
}
