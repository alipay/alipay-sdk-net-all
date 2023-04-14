using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlanInfo : AopObject
    {
        /// <summary>
        /// 出资方图片logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 招商方案id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商活动名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 券模版信息列表
        /// </summary>
        [XmlArray("voucher_template_list")]
        [XmlArrayItem("yun_task_voucher_template_info")]
        public List<YunTaskVoucherTemplateInfo> VoucherTemplateList { get; set; }
    }
}
