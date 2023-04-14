using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YunTaskRecruitEnrolledInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskRecruitEnrolledInfo : AopObject
    {
        /// <summary>
        /// 出资方LOGO
        /// </summary>
        [XmlElement("investor_logo")]
        public string InvestorLogo { get; set; }

        /// <summary>
        /// 任务激励出资方pid
        /// </summary>
        [XmlElement("investor_pid")]
        public string InvestorPid { get; set; }

        /// <summary>
        /// 招商计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商方案名
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [XmlArray("voucher_templates")]
        [XmlArrayItem("yun_task_voucher_template_info")]
        public List<YunTaskVoucherTemplateInfo> VoucherTemplates { get; set; }
    }
}
