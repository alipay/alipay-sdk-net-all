using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOObligationConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOObligationConfig : AopObject
    {
        /// <summary>
        /// 芝麻GO管理页做任务按钮对应链接
        /// </summary>
        [XmlElement("benefit_url")]
        public string BenefitUrl { get; set; }

        /// <summary>
        /// 完成任务所需的最少额度，当obligation_template取值为：OBTL002时必传
        /// </summary>
        [XmlElement("obligation_amount")]
        public string ObligationAmount { get; set; }

        /// <summary>
        /// 承诺模式下，义务的类型，包含次数类型和金额类型：     OBTL001("OBTL001", "在x时间内完成n次"),     OBTL002("OBTL002", "在x时间内达到n元金额")
        /// </summary>
        [XmlElement("obligation_template")]
        public string ObligationTemplate { get; set; }

        /// <summary>
        /// 完成任务所需的最少次数，当obligation_template取值为：OBTL001时必填
        /// </summary>
        [XmlElement("obligation_times")]
        public string ObligationTimes { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("promise_type_desc")]
        public string PromiseTypeDesc { get; set; }

        /// <summary>
        /// 芝麻GO管理页任务进度重定向链接
        /// </summary>
        [XmlElement("task_progress_redirect_schema")]
        public string TaskProgressRedirectSchema { get; set; }
    }
}
