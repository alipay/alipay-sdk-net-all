using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegePromotionPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegePromotionPlanInfo : AopObject
    {
        /// <summary>
        /// 充享惠方案权益金部分，最小为0
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 充享惠方案的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 商户创建充享惠方案时指定的外部唯一编号，用于幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 充享惠方案有偿券部分
        /// </summary>
        [XmlArray("paid_voucher_list")]
        [XmlArrayItem("pay_for_privilege_paid_voucher_config")]
        public List<PayForPrivilegePaidVoucherConfig> PaidVoucherList { get; set; }

        /// <summary>
        /// 充享惠方案本金部分，单位元，必须大于0
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 充享惠方案ID
        /// </summary>
        [XmlElement("promotion_plan_id")]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 充享惠方案开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 充享惠方案的状态，ENABLED(启用), DISABLED(停用)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
